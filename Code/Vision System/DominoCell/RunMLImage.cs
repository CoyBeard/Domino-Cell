using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.Util;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace DominoCell
{
    internal class RunMLImage
    {
        private static bool MLPrediction = false;
        private static int MLPredictionProgress = 0;

        public static (int PredictedID, string PredictedLabel, double Confidence, Bitmap image) PredictImage(Mat InpImg, int attempts = 9)
        {
            //return (1, "good", 1.0, InpImg.ToBitmap());//TMP

            MLPrediction = false;
            Console.WriteLine("Running PredictImage");

            List<int> FoundIDs = new List<int>();

            List<double> Confidences = new List<double>();

            int Rotate = 0;
            double Brightness = 1;
            //RotateAndAdjustBrightness
            //FindMostCommon
            for (int i = 0; i < attempts; i++)
            {
                MLPredictionProgress = (int)Math.Round((double)((double)i / (double)attempts) * 100);

                Console.WriteLine($"Rotate = {Rotate}, Brightness = {((double)Brightness) / 10}");

                Bitmap AlteredImage = RotateAndAdjustBrightness(InpImg.ToBitmap(), (float)Rotate, (float)Brightness);

                byte[] ImpImg = ImageToByte(AlteredImage);
                MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
                {
                    ImageSource = ImpImg,
                };

                //Load model and predict output
                //Task.Run(() => YourSynchronousMethod()).Wait();
                var MLModelResult = MLModel1.Predict(sampleData);

                Console.WriteLine($"result {i}: Label = {MLModelResult.PredictedLabel}");

                foreach (var Score in MLModelResult.Score)
                {
                    Console.WriteLine($"Confidence = {Score}");
                    Confidences.Add(Score);
                }

                if (MLModelResult.PredictedLabel == "Good")
                {
                    FoundIDs.Add(1);
                }
                else
                {
                    FoundIDs.Add(0);
                }

                Random random = new Random();
                Rotate = random.Next(-20, 20);
                //Brightness = random.Next(5, 20);
            }

            Console.WriteLine("Compute Complete");

            MLPredictionProgress = 100;

            int FoundID = FindMostCommon(FoundIDs);

            double Confidence = (float)Confidences.Average() * 100.0;

            string FoundLabel = "NULL";
            if (FoundID == 1)
            {
                FoundLabel = "Good";
            }
            else
            {
                FoundLabel = "Jam";
            }

            MLPredictionProgress = 0;

            Console.WriteLine("result:");
            Console.WriteLine(FoundLabel);
            Console.WriteLine(Confidence + "% Confident");

            MLPrediction = true;
            return (FoundID, FoundLabel, Confidence, InpImg.ToBitmap());
        }

        private static Bitmap RotateAndAdjustBrightness(Bitmap original, float degrees, float brightness)
        {
            // Calculate the new width and height based on the rotation angle
            double radians = degrees * Math.PI / 180;
            int originalWidth = original.Width;
            int originalHeight = original.Height;
            double cos = Math.Abs(Math.Cos(radians));
            double sin = Math.Abs(Math.Sin(radians));
            int newWidth = (int)(originalWidth * cos + originalHeight * sin);
            int newHeight = (int)(originalHeight * cos + originalWidth * sin);

            // Create a new bitmap with the calculated size
            Bitmap rotatedBitmap = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(rotatedBitmap))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.TextRenderingHint = TextRenderingHint.AntiAlias;

                // Set the brightness of the image
                ColorMatrix colorMatrix = new ColorMatrix(new float[][] {
                new float[] { brightness, 0, 0, 0, 0 },
                new float[] { 0, brightness, 0, 0, 0 },
                new float[] { 0, 0, brightness, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { 0, 0, 0, 0, 1 }
            });

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix);

                // Rotate and draw the original image onto the new bitmap
                g.TranslateTransform(newWidth / 2, newHeight / 2);
                g.RotateTransform(degrees);
                g.TranslateTransform(-originalWidth / 2, -originalHeight / 2);
                g.DrawImage(original, new Rectangle(0, 0, originalWidth, originalHeight), 0, 0, originalWidth, originalHeight, GraphicsUnit.Pixel, attributes);
            }

            return rotatedBitmap;
        }
        private static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private static int FindMostCommon(List<int> numbers)
        {
            Random random = new Random();

            Dictionary<int, int> counts = new Dictionary<int, int>();

            // Count the occurrences of each number
            foreach (int number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }

            int maxCount = counts.Max(kvp => kvp.Value);

            // Find all numbers with the maximum count
            List<int> mostCommon = counts.Where(kvp => kvp.Value == maxCount)
                                         .Select(kvp => kvp.Key)
                                         .ToList();

            // If there is a tie, choose randomly
            int randomIndex = random.Next(mostCommon.Count);
            return mostCommon[randomIndex];
        }
    }
}

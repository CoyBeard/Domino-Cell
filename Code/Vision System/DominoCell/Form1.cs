using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
//using DirectShowLib;
using System.IO.Ports;
using Emgu.CV.Util;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
//using Microsoft.ML;
using System.Timers;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Imaging;
using System.Xml.Linq;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Data.SqlClient;
using System.Collections;
using Emgu.CV.Features2D;
using Emgu.CV.Flann;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using DirectShowLib;


namespace DominoCell
{
    public partial class Form1 : Form
    {
        bool EnableIPIOs = false;

        static int OutputKicker1 = 3;
        static int OutputKicker2 = 2;
        static int OutputKicker3 = 1;
        static int OutputRunSystem = 8;

        System.Timers.Timer Kicker1Timer = new System.Timers.Timer();
        System.Timers.Timer Kicker2Timer = new System.Timers.Timer();
        System.Timers.Timer Kicker3Timer = new System.Timers.Timer();
        static int KickerOnTime = 80;//ms
        static int KickerCoolDownTime = 400;//ms
        System.Timers.Timer Kicker1CoolDownTimer = new System.Timers.Timer();
        System.Timers.Timer Kicker2CoolDownTimer = new System.Timers.Timer();
        System.Timers.Timer Kicker3CoolDownTimer = new System.Timers.Timer();
        bool Kicker1InCoolDown = false;
        bool Kicker2InCoolDown = false;
        bool Kicker3InCoolDown = false;

        //Setup Camera Comunications
        VideoCapture capture;
        private List<DsDevice> cameraList;
        //Live Frame
        Mat frame = new Mat();
        Mat Kicker1ROIFrame = new Mat();
        Mat Kicker2ROIFrame = new Mat();
        Mat Kicker3ROIFrame = new Mat();
        bool CameraActive = false;


        //Kicker ROIs
        Rectangle Kicker1ROI = new Rectangle(120, 1000, 450, 600);
        Rectangle Kicker2ROI = new Rectangle(1330, 1030, 450, 600);
        Rectangle Kicker3ROI = new Rectangle(2500, 1050, 450, 600);

        private string ScreenshotDefaultFolderPath = Path.GetFullPath(@"..\..\..\Screenshots\");
        //@"\\192.168.0.201\BasementNAS\Projects\230907 Robotic Card Playing Cell\Programing\PC\Screenshots\";//@"C:\Users\Coy\source\repos\Card Playing Robot Cell - 22\Card Playing Robot Cell\ML Card Images BaW Cropped\9\"
        private string ImgFileType = ".png";


        //ML
        bool RunML = false;
        bool RunDataCollection = false;



        //Timer
        bool CaptureFrame = false;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RunML = checkBoxRunML.Checked;

            //Cnnect to IP IOs
            if (EnableIPIOs)
            {
                IPIO.Initialize();
            }

            // Initialize the list of available cameras
            cameraList = GetAvailableCameras();

            // Populate the combo box with available cameras
            foreach (var camera in cameraList)
            {
                comboBoxCameraSelect.Items.Add(camera.Name);
            }

            // Create a timer with a 10ms interval
            System.Timers.Timer FrameGrabTimer = new System.Timers.Timer(10);
            System.Timers.Timer DataCollectionTimer = new System.Timers.Timer(2000);
            System.Timers.Timer MLModelTimer = new System.Timers.Timer(500);
            Kicker1Timer.Interval = (double)numericUpDownKickerOut1Delay.Value;
            Kicker2Timer.Interval = (double)numericUpDownKickerOut2Delay.Value;
            Kicker3Timer.Interval = (double)numericUpDownKickerOut3Delay.Value;
            Kicker1CoolDownTimer.Interval = (double)KickerCoolDownTime;
            Kicker2CoolDownTimer.Interval = (double)KickerCoolDownTime;
            Kicker3CoolDownTimer.Interval = (double)KickerCoolDownTime;

            FrameGrabTimer.Elapsed += FrameGrabTimerElapsed;
            DataCollectionTimer.Elapsed += DataCollectionTimerElapsed;
            MLModelTimer.Elapsed += MLModelTimerElapsed;
            Kicker1Timer.Elapsed += Kicker1TimerElapsed;
            Kicker2Timer.Elapsed += Kicker2TimerElapsed;
            Kicker3Timer.Elapsed += Kicker3TimerElapsed;
            Kicker1CoolDownTimer.Elapsed += Kicker1CoolDownTimerElapsed;
            Kicker2CoolDownTimer.Elapsed += Kicker2CoolDownTimerElapsed;
            Kicker3CoolDownTimer.Elapsed += Kicker3CoolDownTimerElapsed;

            // Start the timer
            FrameGrabTimer.Start();
            DataCollectionTimer.Start();
            MLModelTimer.Start();

        }

        private void buttonCamStart_Click(object sender, EventArgs e)
        {
            // Update the selected camera
            string selectedCameraIndex = comboBoxCameraSelect.Text;// .SelectedIndex + 1;

            if (selectedCameraIndex != null)
            {
                // Dispose the existing video capture if any
                if (capture != null)
                {
                    capture.Dispose();
                    capture = null;
                }

                // Create a new video capture using the selected camera
                capture = new VideoCapture(comboBoxCameraSelect.FindStringExact(selectedCameraIndex));

                // Set the resolution of the capture
                capture.Set(CapProp.FrameWidth, 3840); // Set width
                capture.Set(CapProp.FrameHeight, 2160); // Set height
                //Console.WriteLine($"Width: {capture.Get(CapProp.FrameWidth)} Height: {capture.Get(CapProp.FrameHeight)}");

                capture.ImageGrabbed += Capture_ImageGrabbed;

                // Start capturing frames from the selected camera
                capture.Start();
                CameraActive = true;
            }
        }

        private async void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            if (CaptureFrame)
            {
                // Retrieve the latest frame from the video capture
                capture.Retrieve(frame);

                Kicker1ROIFrame = new Mat(frame, Kicker1ROI);

                Kicker2ROIFrame = new Mat(frame, Kicker2ROI);

                Kicker3ROIFrame = new Mat(frame, Kicker3ROI);

                pictureBoxKicker1ROI.Image = Kicker1ROIFrame.ToBitmap();

                pictureBoxKicker2ROI.Image = Kicker2ROIFrame.ToBitmap();

                pictureBoxKicker3ROI.Image = Kicker3ROIFrame.ToBitmap();

                //draw Kicker 1 ROI
                CvInvoke.Rectangle(frame, Kicker1ROI, new MCvScalar(0, 0, 255), 2);
                CvInvoke.PutText(frame, "Kicker 1", new Point(Kicker1ROI.X - 80, Kicker1ROI.Y - 70), FontFace.HersheySimplex, 1, new MCvScalar(0, 0, 255), 3);

                //draw Kicker 2 ROI
                CvInvoke.Rectangle(frame, Kicker2ROI, new MCvScalar(0, 0, 255), 2);
                CvInvoke.PutText(frame, "Kicker 2", new Point(Kicker2ROI.X - 80, Kicker2ROI.Y - 70), FontFace.HersheySimplex, 1, new MCvScalar(0, 0, 255), 3);

                //draw Kicker 3 ROI
                CvInvoke.Rectangle(frame, Kicker3ROI, new MCvScalar(0, 0, 255), 2);
                CvInvoke.PutText(frame, "Kicker 3", new Point(Kicker3ROI.X - 80, Kicker3ROI.Y - 70), FontFace.HersheySimplex, 1, new MCvScalar(0, 0, 255), 3);

                pictureBoxLiveView.Image = frame.ToBitmap();


                if (RunML)
                {
                    RunMLModel();
                }

                CaptureFrame = false;
            }
        }

        private void RunMLModel()
        {
            if (!Kicker1InCoolDown)
            {
                //predict Jam
                var Kicker1MLResult = RunMLImage.PredictImage(Kicker1ROIFrame, 1);
                //Update UI
                labelKicker1Result.Invoke(new Action(() =>
                {
                    labelKicker1Result.Text = Kicker1MLResult.PredictedLabel + " " + Kicker1MLResult.Confidence + "% Sure";
                }));
                //Send Output
                if (Kicker1MLResult.PredictedID == 0)
                {
                    Kicker1Timer.Start();
                    Kicker1InCoolDown = true;
                    Kicker1CoolDownTimer.Start();
                }
            }

            if (!Kicker2InCoolDown)
            {
                //predict Jam
                var Kicker2MLResult = RunMLImage.PredictImage(Kicker2ROIFrame, 1);
                //Update UI
                labelKicker2Result.Invoke(new Action(() =>
                {
                    labelKicker2Result.Text = Kicker2MLResult.PredictedLabel + " " + Kicker2MLResult.Confidence + "% Sure";
                }));
                //Send Output
                if (Kicker2MLResult.PredictedID == 0)
                {
                    Kicker2Timer.Start();
                    Kicker2InCoolDown = true;
                    Kicker2CoolDownTimer.Start();
                }
            }

            if (!Kicker3InCoolDown)
            {
                //predict Jam
                var Kicker3MLResult = RunMLImage.PredictImage(Kicker3ROIFrame, 1);
                //Update UI
                labelKicker3Result.Invoke(new Action(() =>
                {
                    labelKicker3Result.Text = Kicker3MLResult.PredictedLabel + " " + Kicker3MLResult.Confidence + "% Sure";
                }));
                //Send Output
                if (Kicker3MLResult.PredictedID == 0)
                {
                    Kicker3Timer.Start();
                    Kicker3InCoolDown = true;
                    Kicker3CoolDownTimer.Start();
                }
            }
            

            RunML = false;
        }

        private List<DsDevice> GetAvailableCameras()
        {
            List<DsDevice> cameras = new List<DsDevice>();

            // Enumerate video input devices using DirectShowLib
            DsDevice[] devices = DsDevice.GetDevicesOfCat(DirectShowLib.FilterCategory.VideoInputDevice);
            foreach (DsDevice device in devices)
            {
                cameras.Add(device);
            }

            return cameras;
        }

        private void FrameGrabTimerElapsed(object sender, ElapsedEventArgs e)
        {
            CaptureFrame = true;
        }

        private void DataCollectionTimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (RunDataCollection)
            {
                TakeScreenshot();
            }
        }

        private void MLModelTimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (checkBoxRunML.Checked)
            {
                RunML = true;
            }
        }

        private void Kicker1TimerElapsed(object sender, ElapsedEventArgs e)
        {
            IPIO.Output(OutputKicker1, true, KickerOnTime);
            Kicker1Timer.Stop();
        }
        private void Kicker2TimerElapsed(object sender, ElapsedEventArgs e)
        {
            IPIO.Output(OutputKicker2, true, KickerOnTime);
            Kicker2Timer.Stop();
        }
        private void Kicker3TimerElapsed(object sender, ElapsedEventArgs e)
        {
            IPIO.Output(OutputKicker3, true, KickerOnTime);
            Kicker3Timer.Stop();
        }
        private void Kicker1CoolDownTimerElapsed(object sender, ElapsedEventArgs e)
        {
            Kicker1InCoolDown = false;
            Kicker1CoolDownTimer.Stop();
        }
        private void Kicker2CoolDownTimerElapsed(object sender, ElapsedEventArgs e)
        {
            Kicker2InCoolDown = false;
            Kicker2CoolDownTimer.Stop();
        }
        private void Kicker3CoolDownTimerElapsed(object sender, ElapsedEventArgs e)
        {
            Kicker3InCoolDown = false;
            Kicker3CoolDownTimer.Stop();
        }

        private void checkBoxRunML_CheckedChanged(object sender, EventArgs e)
        {
            RunML = checkBoxRunML.Checked;
        }

        private void buttonTakePhoto_Click(object sender, EventArgs e)
        {
            TakeScreenshot();
        }

        private void TakeScreenshot()
        {
            // Get the current date and time
            DateTime currentDate = DateTime.Now;

            // Format the date as a string (optional)
            string formattedDate = currentDate.ToString("yyyyMMdd.HHmmssms");

            Bitmap Kicker1Image = new Bitmap(Kicker1ROI.Width, Kicker1ROI.Height);
            Bitmap Kicker2Image = new Bitmap(Kicker2ROI.Width, Kicker2ROI.Height);
            Bitmap Kicker3Image = new Bitmap(Kicker3ROI.Width, Kicker3ROI.Height);

            Graphics.FromImage(Kicker1Image).DrawImage(frame.ToBitmap(), new Rectangle(0, 0, Kicker1ROI.Width, Kicker1ROI.Height), Kicker1ROI, GraphicsUnit.Pixel);
            Graphics.FromImage(Kicker2Image).DrawImage(frame.ToBitmap(), new Rectangle(0, 0, Kicker2ROI.Width, Kicker2ROI.Height), Kicker2ROI, GraphicsUnit.Pixel);
            Graphics.FromImage(Kicker3Image).DrawImage(frame.ToBitmap(), new Rectangle(0, 0, Kicker3ROI.Width, Kicker3ROI.Height), Kicker3ROI, GraphicsUnit.Pixel);

            Kicker1Image.Save(ScreenshotDefaultFolderPath + @"Kicker1" + formattedDate.ToString() + ImgFileType);
            Kicker2Image.Save(ScreenshotDefaultFolderPath + @"Kicker2" + formattedDate.ToString() + ImgFileType);
            Kicker3Image.Save(ScreenshotDefaultFolderPath + @"Kicker3" + formattedDate.ToString() + ImgFileType);
        }

        private void checkBoxRunDataCollection_CheckedChanged(object sender, EventArgs e)
        {
            RunDataCollection = checkBoxRunDataCollection.Checked;
        }

        private void buttonRunML_Click(object sender, EventArgs e)
        {
            if (!RunML)
            {
                RunMLModel();
            }
        }

        private void buttonKicker1_Click(object sender, EventArgs e)
        {
            IPIO.Output(OutputKicker1, true, 500);
        }
        private void checkBoxKicker1_CheckedChanged(object sender, EventArgs e)
        {
            IPIO.Output(OutputKicker1, checkBoxKicker1.Checked);
        }
        private void buttonKicker2_Click(object sender, EventArgs e)
        {
            IPIO.Output(OutputKicker2, true, 500);
        }
        private void checkBoxKicker2_CheckedChanged(object sender, EventArgs e)
        {
            IPIO.Output(OutputKicker2, checkBoxKicker2.Checked);
        }
        private void buttonKicker3_Click(object sender, EventArgs e)
        {
            IPIO.Output(OutputKicker3, true, 500);
        }
        private void checkBoxKicker3_CheckedChanged(object sender, EventArgs e)
        {
            IPIO.Output(OutputKicker3, checkBoxKicker3.Checked);
        }
        private void buttonRunMode_Click(object sender, EventArgs e)
        {
            IPIO.Output(OutputRunSystem, true, 1000);
        }
        private void checkBoxRunMode_CheckedChanged(object sender, EventArgs e)
        {
            IPIO.Output(OutputRunSystem, checkBoxRunMode.Checked);
        }

        private void numericUpDownKickerOut1Delay_ValueChanged(object sender, EventArgs e)
        {
            Kicker1Timer.Interval = (double)numericUpDownKickerOut1Delay.Value;
        }
        private void numericUpDownKickerOut2Delay_ValueChanged(object sender, EventArgs e)
        {
            Kicker2Timer.Interval = (double)numericUpDownKickerOut2Delay.Value;
        }
        private void numericUpDownKickerOut3Delay_ValueChanged(object sender, EventArgs e)
        {
            Kicker3Timer.Interval = (double)numericUpDownKickerOut3Delay.Value;
        }
    }
}

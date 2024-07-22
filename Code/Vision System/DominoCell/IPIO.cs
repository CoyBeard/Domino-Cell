using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using NModbus;

namespace DominoCell
{
    internal class IPIO
    {
        private static bool IPIOInitialized = false;

        // Define the Modbus server's IP address and port
        static string IPIO1IP = "192.168.0.200"; // Replace with your server's IP address
        static int IPIO1Port = 502; // Modbus default port is 4196
        // Create a TCP client socket
        static TcpClient IPIO1;
        // Get the network stream for sending data
        static NetworkStream IPIO1Stream;

        // byte arrays to send
        static List<byte[]> OutCodes = new List<byte[]> {
            new byte[] { 0x01, 0x05, 0x00, 0x00, 0xFF, 0x00, 0x8C, 0x3A },  //snd 0     
            new byte[] { 0x01, 0x05, 0x00, 0x00, 0x00, 0x00, 0xCD, 0xCA },  //snd 1     
            new byte[] { 0x01, 0x05, 0x00, 0x01, 0xFF, 0x00, 0xDD, 0xFA },  //snd 2     
            new byte[] { 0x01, 0x05, 0x00, 0x01, 0x00, 0x00, 0x9C, 0x0A },  //snd 3     
            new byte[] { 0x01, 0x05, 0x00, 0x02, 0xFF, 0x00, 0x2D, 0xFA },  //snd 4     
            new byte[] { 0x01, 0x05, 0x00, 0x02, 0x00, 0x00, 0x6C, 0x0A },  //snd 5     
            new byte[] { 0x01, 0x05, 0x00, 0x03, 0xFF, 0x00, 0x7C, 0x3A },  //snd 6     
            new byte[] { 0x01, 0x05, 0x00, 0x03, 0x00, 0x00, 0x3D, 0xCA },  //snd 7     
            new byte[] { 0x01, 0x05, 0x00, 0x04, 0xFF, 0x00, 0xCD, 0xFB },  //snd 8     
            new byte[] { 0x01, 0x05, 0x00, 0x04, 0x00, 0x00, 0x8C, 0x0B },  //snd 9     
            new byte[] { 0x01, 0x05, 0x00, 0x05, 0xFF, 0x00, 0x9C, 0x3B },  //snd 10    
            new byte[] { 0x01, 0x05, 0x00, 0x05, 0x00, 0x00, 0xDD, 0xCB },  //snd 11      
            new byte[] { 0x01, 0x05, 0x00, 0x06, 0xFF, 0x00, 0x6C, 0x3B },  //snd 12    
            new byte[] { 0x01, 0x05, 0x00, 0x06, 0x00, 0x00, 0x2D, 0xCB },  //snd 13    
            new byte[] { 0x01, 0x05, 0x00, 0x07, 0xFF, 0x00, 0x3D, 0xFB },  //snd 14    
            new byte[] { 0x01, 0x05, 0x00, 0x07, 0x00, 0x00, 0x7C, 0x0B },  //snd 15        
            new byte[] { 0x01, 0x05, 0x00, 0xFF, 0xFF, 0x00, 0xBC, 0x0A },  //snd 32        
            new byte[] { 0x01, 0x05, 0x00, 0xFF, 0x00, 0x00, 0xFD, 0xFA }   //snd 33
        };

        public static void Initialize()
        {
            Console.WriteLine("Initializing IPIO..");

            try
            {
                // Create a TCP client socket
                IPIO1 = new TcpClient(IPIO1IP, IPIO1Port);
                // Get the network stream for sending data
                IPIO1Stream = IPIO1.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Console.WriteLine("Done");

            IPIOInitialized = true;
        }

        public static async void Output(int Coil, bool State, int StateTime = 0) //state time in ms
        {
            if (!IPIOInitialized)
            {
                Initialize();
            }

            Coil = (Coil * 2) - 2;
            if (Coil <= 22)
            {
                // Send the data to the Modbus server
                byte[] cmd = OutCodes[Coil + (State ? 0 : 1)];
                IPIO1Stream.Write(cmd, 0, cmd.Length);
                Console.WriteLine($"Sending data: {string.Join(", ", cmd)}");
                Console.WriteLine($"Coil : {Coil}, = {State}");


                if (StateTime != 0)
                {
                    await Task.Delay(StateTime);

                    // Send the data to the Modbus server
                    cmd = OutCodes[Coil + (State ? 1 : 0)];
                    IPIO1Stream.Write(cmd, 0, cmd.Length);
                    Console.WriteLine($"Sending data: {string.Join(", ", cmd)}");
                    Console.WriteLine($"Coil : {Coil}, = {State}");

                }
            }
        }
    }
}

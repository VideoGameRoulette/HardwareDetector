using System;
using System.Management;

namespace HardwareDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE ConfigManagerErrorCode = 0 and ClassGuid = '{4D36E97E-E325-11CE-BFC1-08002BE10318}'");
                foreach (ManagementObject device in searcher.Get())
                {
                    Console.WriteLine("Device Name: " + device["Name"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}

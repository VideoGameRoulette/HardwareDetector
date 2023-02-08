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
                // Create a ManagementObjectSearcher to query the Win32_PnPEntity class
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE ConfigManagerErrorCode = 0 and ClassGuid = '{4D36E97E-E325-11CE-BFC1-08002BE10318}'");

                // Get all the ManagementObject instances that match the query
                foreach (ManagementObject device in searcher.Get())
                {
                    // Display the device name in the console
                    Console.WriteLine("Device Name: " + device["Name"]);
                }
            }
            catch (Exception ex)
            {
                // Display an error message in the console if an exception is thrown
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            // Wait for a key press to exit the program
            Console.ReadKey();
        }
    }
}

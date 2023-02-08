# Hardware Detector in C#

This code is a simple C# program that uses the Windows Management Instrumentation (WMI) class `Win32_PnPEntity` to detect hardware devices that are plugged into the current computer and specifically located in a PCI slot. The code only displays devices that are functioning properly.

## How to Use

1. Open Visual Studio and create a new Console Application project.
2. Replace the contents of the `Program.cs` file with the code provided in this repository in the `HardwareDetector.cs` file.
3. Build and run the project.

## Explanation of the Code

The code uses the `ManagementObjectSearcher` class to query the `Win32_PnPEntity` WMI class, which represents a Plug and Play device. The query only returns instances of the class where `ConfigManagerErrorCode` is equal to 0, which means the device is functioning properly, and where `ClassGuid` is equal to `{4D36E97E-E325-11CE-BFC1-08002BE10318}`, which represents PCI devices.

The code then uses a `foreach` loop to iterate over all the `ManagementObject` instances returned by the query. For each instance, the device name is displayed in the console.

A `try-catch` block is used to handle exceptions that may be thrown while executing the code. If an exception is thrown, an error message is displayed in the console.

Finally, the `Console.ReadKey()` method is used to wait for a key press before exiting the program.

## Conclusion

This code provides a simple and straightforward way to detect hardware devices that are plugged into the current computer and located in a PCI slot. The code can be easily modified to suit specific needs, such as filtering for other types of devices or displaying additional information about the devices.

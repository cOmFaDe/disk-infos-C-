using System;
using System.IO;

DriveInfo[] mostrarDrivers = DriveInfo.GetDrives();


Console.WriteLine("DISK INFOS");


    DriveInfo drive = new DriveInfo(@"C:\");
    Console.WriteLine("Disk Format: {0}", drive.DriveFormat);
    Console.WriteLine("Disk Size: {0,15}", drive.TotalSize);
    Console.WriteLine("Disk Type: {0}", drive.DriveType);
    Console.WriteLine("Disk Free Space:: {0,15}", drive.AvailableFreeSpace);
    Console.WriteLine("Disk Root Directory: {0} ",drive.RootDirectory);
 Console.ReadKey();



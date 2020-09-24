using System.IO;
using System;

public class Directories
{
    public void CreateDirectories()
    {
        string directoryName = @"D:\FIles0f6thsem\Example\Parent";
        string subDirectoryName = "Subfolder";
        string helloworldprogram = @"using System; 

                                    namespace Assignment_2
                                    {
                                        class Program
                                        {
                                            static void Main(string[] args)
                                            {
                                                Console.WriteLine( ""Hello World!"");
                                            }
                                        }
                                    }  "; //storing hellow world program data as string
        Directory.CreateDirectory(directoryName); //creating parent directory
        for (int i = 1; i <= 10; i++) //creating 10 sub directories
        {
            string tempsubDirectoryName = $"{directoryName}/{subDirectoryName + i}";
            Directory.CreateDirectory(tempsubDirectoryName);
            string fileName = $"{directoryName}/{subDirectoryName + i}/Helloworld.cs";
            // creating helloworld program inside subdirectories
            // Writing code in each program files
            File.WriteAllText(fileName,helloworldprogram); 

        }
        Console.WriteLine("Created folders and files sucessfully");
    }
}
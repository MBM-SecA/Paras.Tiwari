using System.IO;
using System;
public class Directories{
    public void CreateDirectories()
    {
        string directoryName = "Parent";
        string subDirectoryName="Subfolder";
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
                                    }  ";
        
        Directory.CreateDirectory(directoryName); //creating parent directory
        for(int i=1;i<=10;i++) //creating 10 sub directories
        {
            string tempsubDirectoryName=$"{directoryName}/{subDirectoryName+i}";
            Directory.CreateDirectory(tempsubDirectoryName);
        }
          
          for(int i=1;i<=10;i++)// creating helloworld program inside subdirectories
        {
            string fileName = $"{directoryName}/{subDirectoryName+i}/Helloworld.cs";
            File.Create(fileName);
        }

        for(int i=1;i<=10;i++)// Writing code in each program files
        {
            string fileName = $"{directoryName}/{subDirectoryName+i}/Helloworld.cs";
            if(File.Exists(fileName))
            {
                File.WriteAllText(fileName,helloworldprogram);
            }
                
            else
                Console.WriteLine("File not found to write content");
        }
        

        Console.WriteLine("Created folders and files sucessfully");
    }
}
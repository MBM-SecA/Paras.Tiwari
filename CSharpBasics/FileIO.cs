using System;
using System.IO;

public class FileIO
{
    public void LearnFileHandling()
    {
       string fileName ="command.txt";
       if(File.Exists(fileName))
       {
           string fileContent = File.ReadAllText("command.txt");
            Console.WriteLine(fileContent); 
       }
        else
        {
            string fileContent = File.ReadAllText("command.txt");
             fileContent = "command.txt";
                Console.WriteLine(fileContent); 
        }
    }

    public void LearnFileInfo()
    {
        string fileName = "command.txt";
        FileInfo fileInfo = new FileInfo(fileName);
        var size = fileInfo.Length;
        var createdDate =fileInfo.CreationTimeUtc;
        Console.WriteLine(fileName);
        Console.WriteLine($"File Size: {size} bytes");
        Console.WriteLine($"Created:{createdDate}");
    }
    public void LearnDirectories()
    {
        string directoryName="A";
        Directory.CreateDirectory(directoryName); 
    }
     


}
 //Q2: Create a folder "Parent",create ten subfolders in "Parent".
      //Each sub folder should contain  C# file with hello world program.
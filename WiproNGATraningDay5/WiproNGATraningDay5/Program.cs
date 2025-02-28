using System;
using System.IO; // Required for file handling

internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "sample.txt"; // File name

        // 1. Creating and Writing to a File
        WriteToFile(filePath, "Hello, this is a file handling example in C#.\nWelcome to file operations!");

        // 2. Reading from a File
        ReadFromFile(filePath);

        // 3. Appending Text to an Existing File
        AppendToFile(filePath, "\nThis line is appended to the file.");

        // 4. Reading Again after Appending
        ReadFromFile(filePath);

        // 5. Deleting the File
        DeleteFile(filePath);
    }

    // Method to write to a file
    static void WriteToFile(string path, string content)
    {
        File.WriteAllText(path, content);
        Console.WriteLine("File created and written successfully.");
    }

    // Method to read from a file
    static void ReadFromFile(string path)
    {
        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            Console.WriteLine("File Content:\n" + content);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    // Method to append text to a file
    static void AppendToFile(string path, string content)
    {
        File.AppendAllText(path, content);
        Console.WriteLine("Content appended successfully.");
    }

    // Method to delete a file
    static void DeleteFile(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("File deleted successfully.");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}

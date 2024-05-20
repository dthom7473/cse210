using System;
using System.IO;

public class DataLoader
{
    private string _filePath;

    public DataLoader(string filePath)
    {
        _filePath = filePath;
    }

    public void LoadEntries()
    {
        if (File.Exists(_filePath))
        {
            string[] lines = File.ReadAllLines(_filePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("No entries found.");
        }
    }
}
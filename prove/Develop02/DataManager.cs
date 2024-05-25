using System;
using System.IO;

public class DataLoader
{
    private string filePath;

    public DataLoader(string filePath)
    {
        this.filePath = filePath;
    }

    public void LoadEntries()
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
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

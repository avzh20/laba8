using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("Inlet.in");
        string searchChar = lines[0].Split('_')[1];
        char charToSearch = searchChar[0];
        string lastLine = lines[lines.Length - 1];
        string[] words = lastLine.Split(' ');
        string secondLastWord = words[words.Length - 2];
        int count = 0;
        foreach (char c in secondLastWord)
        {
            if (char.ToLower(c) == char.ToLower(charToSearch))
            {
                count++;
            }
        }
        File.WriteAllText("Outlet.out", count.ToString());
        Console.WriteLine("Результат записан в файл Outlet.out.");
    }
}

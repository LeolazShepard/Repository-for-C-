using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Writetextfile
{
    static void Main()
    {
        string[] lines = { "First line", "Second line",
"Third line" };
        System.IO.File.WriteAllLines(@"E:\WriteLines.txt", lines);
        string text = "A class is the most powerful data type in C#. Like structures, " +
        "a class defines the data and behavior of the data type. ";
        System.IO.File.WriteAllText(@"E:\writetext.txt", text);
        using (System.IO.StreamWriter file =
        new System.IO.StreamWriter(@"E:\WriteLines2.txt"))
        {
            foreach (string line in lines)
            {
                if (line.Contains("Second") == false)
                { file.WriteLine(line); }
            }
        }
        using (System.IO.StreamWriter file =
        new System.IO.StreamWriter(@"E:\WriteLines2.txt", true))
        {
            file.WriteLine("четвертий рядок");
        }
    }
}
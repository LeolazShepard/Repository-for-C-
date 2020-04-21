using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Writetextfile {
 static void Main()
 { // приклад#1: запис масиву рядків у файл
 string[] lines = { "First line", "Second line",
"Third line" };
 System.IO.File.WriteAllLines(@"E:\WriteLines.txt", lines);
 // приклад#2: запис одного рядка в файл
 string text = "A class is the most powerful data type
 in C#. Like structures, " +
 "a class defines the data and behavior of the data type. ";
 System.IO.File.WriteAllText(@"E:\writetext.txt", text);
 // приклад#3: запис одного рядків у файл
 using (System.IO.StreamWriter file =
 new System.IO.StreamWriter(@"E:\WriteLines2.txt")) {
 foreach (string line in lines) {
 if (line.Contains("Second") == false)
 { file.WriteLine(line); }
 } }
 // приклад #4: до запис нового тесту в існуючий файл
 using (System.IO.StreamWriter file =
 new System.IO.StreamWriter(@"E:\WriteLines2.txt", true))
 {
 file.WriteLine("четвертий рядок");
 } } }
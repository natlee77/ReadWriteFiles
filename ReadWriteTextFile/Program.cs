using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadWriteTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
           // string fileName = "persons.txt"; //läg direct till f.

            WriteToFile("persons.txt", "Nataliya.Lisjö,49,Degerfors");//
            ReadFromFile("persons.txt");

            //WriteToFile("textfile.txt", "My brothers name is Tommy. ");
        }

        private static void WriteToFile(string filename, string text)// spara info i fil
        {//en Lista
            var lines = new List<string>();      //namn lines
            lines.Add(text);                     // mer dynamisk

           // File.WriteAllLines(@$"C:\Nataliya\.NET\DataLagring\Cataloq_files{filename}", lines); 
           //skriver alla rader som finns i lines.Add(text)och skriver over-ersäter alt och rewrite  info nästa gång ;/

             File.AppendAllLines(@$"C:\Nataliya\.NET\DataLagring\Cataloq_files{filename}", lines);
            //skapa fil +add -med samma info varja gång
           
            
            
            
            {             
               //File.AppendAllText(@$"d:\files\{filename}", content); //class from System.IO
            }
        }

        private static void ReadFromFile(string filename)// läsa from file
        {
            Console.WriteLine("Using array "); //array
            var lines2 = File.ReadAllLines(@$"C:\Nataliya\.NET\DataLagring\Cataloq_files{filename}");
                foreach  (var line in lines2)
                {
                    Console.WriteLine(line);
                }


            Console.WriteLine("Using List ");
            var lines = File.ReadAllLines(@$"C:\Nataliya\.NET\DataLagring\Cataloq_files{filename}").ToList(); //++Using system.linq
               foreach(var line in lines)
               {
                     Console.WriteLine(line);
               }

            
           // var content = File.ReadAllText(@$"d:\files\{filename}");
           // Console.WriteLine(content);
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SharedClassLibrary
{
    public static class CsvService           // flytad  all funktionalitet from programm
    {
        public static void WriteToFile(string filepath, string content)  // spara info i fil
        {
            var lines = new List<string>() { content };   //en Lista 
            File.AppendAllLines(filepath,lines);  //skapa fil +add en rad-med samma info varja gång
            // lines.Add(text);
            // File.WriteAllLines(@$"D:\Nataliya\.NET\DataLagring\Cataloq_files\{filename}", lines);  //skriver alla rader som finns i lines.Add(text)och skriver over-ersäter alt och rewrite info nästa gång 

        }


        public static IEnumerable<Person> ReadFromFile(string filepath, char delimeter = ',') // läsa from file- hämta  & skriver lista och retunera !void-IEnumerable<Person> 
        {
                                       //filepath -väg till var filen med namn
           var lines = File.ReadAllLines(filepath).ToList();  //++Using system.linq
           var persons = new List<Person>();

            foreach (var line in lines)
            {
                var data = line.Split(delimeter);      //splita med , i [] -separera
                               
                //-läga in info //skapa new lista <Person> med ctor
                persons.Add(new Person(data[0], data[1], Convert.ToInt32(data[2]), data[3]));  // matta in Person //kan spara det på separat eller till object i lista
             
                return persons;  //hela f. retuner tillbacka lista
            }
        }
    }
}

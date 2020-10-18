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

           // WriteToFile("persons.txt", "Nataliya,Lisjö, 49, Degerfors");//
            WriteToFile2("uppgift1.txt", "För godkänt ska du göra följande:Du ska skapa en UWP applikation.I applikationen ska du kunna öppna upp en fil och läsa dess innehåll genom att använda en -filepicker funktionalitet.Du ska kunna läsa formatet Json.Sedan ska informationen i filen kunna läsas ut och visas i applikationen i form av en lista.Det ska även vara möjligt att göra samma sak  som nämns ovan med en.csv och en.xml fil.");
            // ReadFromFile("persons.txt");
            ReadFromFile2("uppgift1.txt");
            //WriteToFile("textfile.txt", "My brothers name is Tommy. ");
        }


        private static void WriteToFile2(string filename, string content)
        {
            
            File.WriteAllText(@$"D:\Nataliya\.NET\DataLagring\Cataloq_files\{filename}", content);  //stor text gör 
        }


        private static void ReadFromFile2(string filename)
        {

            var content = File.ReadAllText(@$"D:\Nataliya\.NET\DataLagring\Cataloq_files\{filename}");
            Console.WriteLine(content);
        }


        private static void WriteToFile(string filename, string text)  // spara info i fil
        {//en Lista
            var lines = new List<string>();      //namn lines
            lines.Add(text);                     // mer dynamisk

            // File.WriteAllLines(@$"C:\Nataliya\.NET\DataLagring\Cataloq_files{filename}", lines); 
            //skriver alla rader som finns i lines.Add(text)och skriver over-ersäter alt och rewrite  info nästa gång ;/

            File.AppendAllLines(@$"D:\Nataliya\.NET\DataLagring\Cataloq_files\{filename}", lines);
            //skapa fil +add -med samma info varja gång




            {
                //File.AppendAllText(@$"d:\files\{filename}", content); //class from System.IO
            }
        }

        private static void ReadFromFile(string filename)// läsa from file
        {

            Console.WriteLine("Using List ");           //list
            var lines = File.ReadAllLines(@$"D:\Nataliya\.NET\DataLagring\Cataloq_files\{filename}").ToList(); //++Using system.linq
            var persons = new List<Person>();          //lag in new lista

            foreach (var line in lines)
            {
                //göra nån speciel :
                var data = line.Split(',');      //splita med , i []

                //var.1 -läga in info //skapa new lista <Person> med ctor

                persons.Add(new Person(data[0], data[1], Convert.ToInt32(data[2]), data[3]));  // matta in Person //kan spara det på separat eller till object
                Console.WriteLine($"{data[0]} {data[1]} is {data[2]} year old and lives in {data[3]}"); //kan bara skriva ut -- om jag ska inte spara det på separat eller till object

                //var2. -läga till utan ctor : //då + tomt cor i Person class 
                //eller :
                //var person = new Person();
                //{
                //    person.FirstName = data[0];
                //}


                //persons.Add(new Person { FirstName = data[0], LastName = data[1], Age = Convert.ToInt32(data[2]), City = data[3] });

            }

            foreach (var person in persons)
            {  //loppa genom lista som jag ska skriva ut
                Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} year old and lives in {person.City}");
            }


            //    Console.WriteLine("Using array "); //array variant
            //var lines2 = File.ReadAllLines(@$"C:\Users\46735\Desktop\mama.lnk{filename}");
            //foreach (var line in lines2)//foreach skriver varja rad
            //{
            //    Console.WriteLine(line);
            //}



            //hämta ut specefik greer i List -massa olicka saker att sortera med ; som finns inte in array
            // lines.OrderBy(p=> p.)--exemple

            //splita ut--- razdelit' på olicka delar ++ class Person (ctor)

        }

    }
}

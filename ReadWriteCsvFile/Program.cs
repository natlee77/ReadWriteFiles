using SharedClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;

namespace ReadWriteCsvFile
{
    class Program
    {
        private  static List<Person> persons = new List<Person>(); //decklarera List -for att alla metoden har access till den

        static void Main(string[] args)
        {
           
                         CsvService.WriteToFile(@"D:\Nataliya\.NET\DataLagring\Cataloq_files\persons.csv", "Nataliya; Lisjö; 49; Degerfors");
            var persons=CsvService.ReadFromFile(@"D:\Nataliya\.NET\DataLagring\Cataloq_files\persons.csv"); // retunera nån tilbacka /+ var person =
            
                        
            foreach (var person in persons)  //skriva ut nånt :
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old and lives in {person.City}.");
            }
           
        }


        //private static void WriteToFile(string filename, string content)  // spara info i fil
        //{
        //    var lines = new List<string>() { content };   //en Lista 
        //    File.AppendAllLines(@$"D:\Nataliya\.NET\DataLagring\Cataloq_files\{filename}", lines);  //skapa fil +add en rad-med samma info varja gång
        //    // lines.Add(text);
        //    // File.WriteAllLines(@$"D:\Nataliya\.NET\DataLagring\Cataloq_files\{filename}", lines);  //skriver alla rader som finns i lines.Add(text)och skriver over-ersäter alt och rewrite info nästa gång 

        //}


        //private static void ReadFromFile(string filename)// läsa from file- hämta  & skriver lista
        //{

        //   // Console.WriteLine("Using List ");           //list
        //    var lines = File.ReadAllLines(@$"D:\Nataliya\.NET\DataLagring\Cataloq_files\{filename}").ToList(); //++Using system.linq

        //    foreach (var line in lines)
        //    {
        //        //göra nån speciel :
        //        var data = line.Split(',');      //splita med , i [] -separera
        //        //var.1 -läga in info //skapa new lista <Person> med ctor
        //        persons.Add(new Person(data[0], data[1], Convert.ToInt32(data[2]), data[3]));  // matta in Person //kan spara det på separat eller till object i lista


        //       // Console.WriteLine($"{data[0]} {data[1]} is {data[2]} year old and lives in {data[3]}"); //kan bara skriva ut -- om jag ska inte spara det på separat eller till object
        //       //flytad den i main- en f. göra en sak
                




               

                //var2. -läga till utan ctor : //då + tomt cor i Person class 
                //eller :
                //var person = new Person();
                //{
                //    person.FirstName = data[0];
                //}


                //            //persons.Add(new Person { FirstName = data[0], LastName = data[1], Age = Convert.ToInt32(data[2]), City = data[3] });

                //        }

                //        foreach (var person in persons)
                //        {  //loppa genom lista som jag ska skriva ut
                //            Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} year old and lives in {person.City}");
                //        }


                //        //    Console.WriteLine("Using array "); //array variant
                //        //var lines2 = File.ReadAllLines(@$"C:\Users\46735\Desktop\mama.lnk{filename}");
                //        //foreach (var line in lines2)//foreach skriver varja rad
                //        //{
                //        //    Console.WriteLine(line);
                //        //}



                //        //hämta ut specefik greer i List -massa olicka saker att sortera med ; som finns inte in array
                //        // lines.OrderBy(p=> p.)--exemple

                //        //splita ut--- razdelit' på olicka delar ++ class Person (ctor)


    }
}

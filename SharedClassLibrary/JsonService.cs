using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SharedClassLibrary
{
    public static class JsonService
    {
        public static void WriteToFile(string filepath, Person person)
        {
            var json = JsonConvert.SerializeObject(person);// person object skicka til json 

            using StreamWriter writer = new StreamWriter(filepath);//from system.IO
            writer.WriteLine(json);

            //writer.Write(json); //skriver over info --! tilläga //samma som Writeline/ har ! append variant

        }



        public static void ReadFromFile(string filepath)
        {
            using StreamReader reader = new StreamReader(filepath);

            var json = reader.ReadToEnd();//läsa hela text
            Console.WriteLine(json);
        }


        public static void WriteToFileCorrect(string filepath, Person person)//list--  nån fel hear --skapade inte list i filen

        {

            //problematisk att updarera på den set - det inte vanlig som vi skriver in adta in json fil
            
            try //om det likas att läsa 
            {
               using StreamReader reader = new StreamReader(filepath);   // hämta info  som finns i filen
               var json = reader.ReadToEnd();        //och spara i json//fil inte tomt, när den hämta /sträng -tomt , men ! 0
               reader.Close();//stäng strim delläsa

              
                
               if (json != string.Empty) //if fil finns då vill göra nån
                {
                   
                    var list = JsonConvert.DeserializeObject<List<Person>>(json); //  1. packa up lista med persons
                    list.Add(person);        //+ i list


                    var json2 = JsonConvert.SerializeObject(list);
                   // Console.WriteLine(json2);

                    using StreamWriter writer = new StreamWriter(@"D:\Nataliya\.NET\DataLagring\Cataloq_files\persons.json");//kan skriva
                    
                    writer.WriteLine(json2);//skriver over
                    writer.Close();//stänga


                    //hämta ut och läsa -- kontrol 
                    //foreach (var item in list)
                    //{
                    //    Console.WriteLine(item.FirstName);
                    //}                    
                }
            }


            catch  //om  finns inga filen 
            {
                using StreamWriter writer = new StreamWriter(filepath);  // då skapa vi fil
                var list = new List<Person>() { person };   //+ person direct i Lista
                //list.Add(person);//flera person
                var json = JsonConvert.SerializeObject(list);   //den list göra om till json
                //Console.WriteLine(json);// jag har fel --skriver inte i console
                writer.Write(json);//



                //foreach (var item in list)       // skriva ut den då --fel
                //{
                //    Console.WriteLine(item.FirstName);
                //}

          
                //            writer.Close();
            }
        }
    }
}

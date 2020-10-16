using SharedClassLibrary;
using System;

namespace ReadWriteJsonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //JsonService.WriteToFile(@"d:\files\persons.json", new Person("Hans", "Mattin-Lassei", 36, "Farsta"));
            //JsonService.ReadFromFile(@"d:\files\persons.json");
            JsonService.WriteToFileCorrect(@"d:\files\persons.json", new Person("Hans", "Mattin-Lassei", 36, "Farsta"));
        }
    }
}

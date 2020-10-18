using SharedClassLibrary;
using System;

namespace ReadWriteJsonFile
{
    class Program
    {
        static void Main(string[] args)
        {
           //JsonService.WriteToFile(@"D:\Nataliya\.NET\DataLagring\Cataloq_files\persons.json", new Person("Nataliya", "Lisjo", 19, "Degefors"));
           //JsonService.ReadFromFile(@"D:\Nataliya\.NET\DataLagring\Cataloq_files\persons.json");
          JsonService.WriteToFileCorrect(@"D:\Nataliya\.NET\DataLagring\Cataloq_files\persons.json", new Person("Nataliya", "Lisjo", 19, "Degefors"));
        }
    }
}

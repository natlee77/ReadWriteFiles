using SharedClassLibrary;
using System;

namespace ReadWriteXmlFile
{
    class Program
    {
        static void Main(string[] args)
        {
             XmlService.WriteToFile(@"D:\Nataliya\.NET\DataLagring\Cataloq_files\books.xml");
            XmlService.ReadFromFile(@"D:\Nataliya\.NET\DataLagring\Cataloq_files\books.xml");
        }
    }
}

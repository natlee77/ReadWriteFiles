using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SharedClassLibrary
{
    public static class XmlService
    {
        public static void WriteToFile(string filepath)
        {
            XmlWriterSettings settings = new XmlWriterSettings() //della all text i rader-formatera
            {
                Indent = true,      
                IndentChars = ("  "),
                CloseOutput = true
            };

            using XmlWriter xml = XmlWriter.Create(filepath, settings);//from system .XML

            xml.WriteStartElement("books");//start
            xml.WriteStartElement("book"); //start
            xml.WriteAttributeString("author", "Nataliya Lisjö");//atribyt lättare att söka än text /XmlNodeType.Element
            xml.WriteElementString("title", "This is Data XML");// text/XmlNodeType.Text)
            xml.WriteEndElement();//slut
            xml.WriteEndElement();//slut
            xml.WriteStartElement("books");//start
            xml.WriteStartElement("book"); //start
            xml.WriteAttributeString("author", "Nataliya Lisjö");
            xml.WriteElementString("title", "This is Data XML");
            xml.WriteEndElement();//slut
            xml.WriteEndElement();//slut


            xml.Flush();//

            /*ex.
             <books>
             * <book>
             *    <title> bokenstitel
             *    <author ......
             * </book>
             * <book>
             *    <title> bokenstitel
             *    <author ......
             * </book>*/
        }

        public static void ReadFromFile(string filepath)//läsa info
        {
            using XmlTextReader xml = new XmlTextReader(filepath);
            xml.Read();              //utskrift . det läsa ut file

            while(xml.Read())      //loppa genom
            {
               //  Console.WriteLine(xml.LocalName);// book , title
               // Console.WriteLine(xml.Name); // samma som local name
               // Console.WriteLine(xml.NodeType); //whitespace , element, endelement
               // Console.WriteLine(xml.Value); // namn av book

               
                XmlNodeType ntype = xml.NodeType;//

                if (ntype == XmlNodeType.Element)//läsa ut name , value,attribyt
                {
                    if (xml.Name == "book")
                    {
                        Console.WriteLine(xml.Name);
                        Console.WriteLine("Author:" + xml.GetAttribute("author"));//skriva ut author namn
                        
                    }
                }

                //if (ntype == XmlNodeType.Text)// valua element-- text
                //{
                //    Console.WriteLine(xml.Value);
                //}
            }
        }
    }
}

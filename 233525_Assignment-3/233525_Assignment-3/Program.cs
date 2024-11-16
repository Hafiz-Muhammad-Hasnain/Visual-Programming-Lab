using System;
using System.Xml;

namespace XMLWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            CreateXMLFile();
            ReadXMLFile();
        }

        static void CreateXMLFile()
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t",
                Encoding = System.Text.Encoding.UTF8
            };

            using (XmlWriter writer = XmlWriter.Create("GPS.xml", settings))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("GPS_Log");

                writer.WriteStartElement("Position");
                writer.WriteAttributeString("DateTime", DateTime.Now.ToString());
                writer.WriteElementString("x", "65.8973342");
                writer.WriteElementString("y", "72.3452346");

                writer.WriteStartElement("SatteliteInfo");
                writer.WriteElementString("Speed", "40");
                writer.WriteElementString("NoSatt", "7");
                writer.WriteEndElement();

                writer.WriteEndElement(); 

               
                writer.WriteStartElement("Image");
                writer.WriteAttributeString("Resolution", "1024x800");
                writer.WriteElementString("Path", @"\images\1.jpg");
                writer.WriteEndElement(); 

                writer.WriteEndElement(); 

                writer.WriteEndDocument();
            }

            Console.WriteLine("XML file 'GPS.xml' created successfully!");
        }

        static void ReadXMLFile()
        {
            Console.WriteLine("\nReading and displaying contents of 'GPS.xml':");

            using (XmlReader reader = XmlReader.Create("GPS.xml"))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Console.Write($"<{reader.Name}");
                            if (reader.HasAttributes)
                            {
                                while (reader.MoveToNextAttribute())
                                {
                                    Console.Write($" {reader.Name}=\"{reader.Value}\"");
                                }
                                reader.MoveToElement(); 
                            }
                            Console.WriteLine(">");
                            break;

                        case XmlNodeType.Text:
                            Console.WriteLine(reader.Value);
                            break;

                        case XmlNodeType.EndElement:
                            Console.WriteLine($"</{reader.Name}>");
                            break;
                    }
                }
            }
        }
    }
}
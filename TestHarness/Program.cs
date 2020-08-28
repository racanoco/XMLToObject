using System;
using System.IO;

// https://www.codeproject.com/Articles/1163664/Convert-XML-to-Csharp-Object#:~:text=In%20this%20example%20we%20will,into%20a%20C%23%20object%20instance.&text=The%20following%20code%20snippet%20reads,passing%20it%20a%20customer%20type.&text=The%20Serialize%20method%20converts%20a%20customer%20object%20to%20XML.

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            Serializer ser = new Serializer();            
            string xmlOutputData = string.Empty;

            //EXAMPLE 1
            string path = Directory.GetCurrentDirectory() + @"\Customer.xml";
            string xmlInputData = File.ReadAllText(path);

            Customer customer = ser.Deserialize<Customer>(xmlInputData);
            xmlOutputData = ser.Serialize<Customer>(customer);

            // EXAMPLE 2
            path = Directory.GetCurrentDirectory() + @"\CustOrders.xml";
            xmlInputData = File.ReadAllText(path);

            Customer customer2 = ser.Deserialize<Customer>(xmlInputData);
            xmlOutputData = ser.Serialize<Customer>(customer2);

            // https://docs.microsoft.com/es-es/troubleshoot/dotnet/csharp/serialize-object-xml
            // Serializar objeto c# en XML.

            Person person = new Person
            {
                FirstName = "Jeff",
                MI = "A",
                LastName = "Price"
            };

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(person.GetType());
            x.Serialize(Console.Out, person);

            Console.WriteLine();
            Console.ReadLine();
            // End Serializar objeto c# en XML.


            Console.ReadKey();

        }

    }

}

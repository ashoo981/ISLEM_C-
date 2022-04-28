using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;


namespace Islem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int topla = MathsProcess.Topla(1, 3);
            Console.WriteLine(topla);
            


            int cikarma = MathsProcess.Cikarma(20,16);
            Console.WriteLine(cikarma);
           

            for (int i = cikarma; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            

            try
            {
                string[] araba = {"volvo", "renault", "ferrari" };
                Console.WriteLine(araba[10]);

            }
            catch (Exception e)
            {

                Console.WriteLine("hata mevcut kontrol edin:" + e.Message);
            }

            try
            {
                string ws = File.ReadAllText("WORKSPACE.XML");
                XmlDocument wsx = new XmlDocument();

                wsx.LoadXml(ws);

                XmlElement root = wsx.DocumentElement;
                XmlNodeList table = root.GetElementsByTagName("TableName");


                for (int i = 0; i < table.Count; i++)


                {

                    string tbl;
                    tbl = table[i].InnerXml.ToString();
                    Console.WriteLine(tbl);
                    File.WriteAllText("filename.txt", tbl);
                    

                }
               
            }
            catch (Exception wse)
            {

                Console.WriteLine(wse.Message);
            }

           

            Console.ReadLine();






        }
    }
}

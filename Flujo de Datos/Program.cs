
using System;
using System.IO;

namespace Flujo_de_Datos
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (FileStream  fs= new FileStream("Prueba.txt",FileMode.Create,FileAccess.ReadWrite))
            //{
            //    using (StreamWriter sw = new StreamWriter(fs))
            //    {
            //        sw.WriteLine("Hey bro,Nice Dick");
            //        sw.Write("IP:105.03.236");
            //        sw.Write("Diegp es Gay");
            //    }
            //    //using (StreamReader sr = new StreamReader(fs))
            //    //{
            //    //    sr.ReadToEnd();
            //    //}
            //}
            using (FileStream fs = new FileStream("Prueba.txt", FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
        }
    }
}

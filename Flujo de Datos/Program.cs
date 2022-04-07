
using Domain;
using System;
using System.IO;


namespace Flujo_de_Datos
{
    class Program
    {
        static void Main(string[] args)
        {
                Persona[] GrupoPersona = Persona.GetPersonas();
            //using (FileStream fs = new FileStream("Prueba.txt", FileMode.Create, FileAccess.ReadWrite))
            //{
            //    using (StreamWriter sw = new StreamWriter(fs))
            //    {
            //        foreach (Persona perona in GrupoPersona)
            //        {
            //            sw.Write(perona.Nombre);
            //            sw.Write(perona.Apellido);
            //            sw.Write(perona.Edad);
            //            sw.Write(perona.Cedula);
            //        }
            //        //sw.WriteLine("Hey bro,Nice Dick");
            //        //sw.Write("IP:105.03.236");
            //        //sw.Write("Diegp es Gay");
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
                    string linea;
                    int num;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (linea.Contains("a"))
                        {

                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}

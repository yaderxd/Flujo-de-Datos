
using System;
using System.IO;

namespace Flujo_de_Datos
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream  fs= new FileStream("Prueba.txt",FileMode.Create,FileAccess.ReadWrite))
            {

            } 
        }
    }
}

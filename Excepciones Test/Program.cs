using System;

namespace Excepciones_Ej
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Remo barca = new Remo { nombre = "Titanic", Numdekilometrosqueseremo = 0 };
                barca.Numdekilometrosqueseremo = 5;
                if (barca.Numdekilometrosqueseremo >= 3)
                {
                    throw new Exception("Calambre en los brazos");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("El bote llego al puerto");
            }
        }

        public class Remo
        {
            public string nombre { get; set; }
            public int Numdekilometrosqueseremo { get; set; }

        }

    }
}





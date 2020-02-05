using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace EjercicioFechas
{
    class Program
    {
        static void Main(string[] args)
        {
            string cRuta = @"C:\Users\carlos.hoil\Desktop\ejercicio.txt";
            try {
                ProcesadorEvento procesador = new ProcesadorEvento();
                procesador.ProcesaEvento(cRuta);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}

//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            int n = 10000000;
            for (int i = 0; i <= n; i++)
            {
                string tren = i.ToString();
                var train = new Train(tren);
            }
            
            Console.WriteLine(Train.Count);

            var tren1 = new Train("Last Train To London");
            var tren2 = new Train("Last Train To London");
            var tren3 = new Train("Runaway Train");
            Console.WriteLine(tren1==tren2);
            Console.WriteLine(tren2==tren3);
        }
    }
}
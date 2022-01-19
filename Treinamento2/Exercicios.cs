using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Data;

namespace Treinamento2
{
    class Exercicios
    {
        static void Main(string[] args)
        {
            //Formatação de data
            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("15/06/2000 13:04:23", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}

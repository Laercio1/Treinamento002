using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento2
{
    class Exercicio_SintaxeAlternativa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para Y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int maior = (x > y) ? x * 10 : y * 10;

            Console.WriteLine(maior);

            //Funções interessantes para string 
            string original = "abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper(); //SERVE PARA DEIXAR TODAS AS LETRAS MAÍUSCULAS
            string s2 = original.ToLower(); //SERVE PARA DEIXAR TODAS AS LETRAS MENUSCULAS
            string s3 = original.Trim();//SERVE PARA TIRAR OS ESPAÇOS
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -"+ original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc): "+ n1);
            Console.WriteLine("LastIndexOf('bc'): "+ n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

        }
    }
}

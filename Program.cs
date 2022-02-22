using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados separados por vírgula");
            string opus = Console.ReadLine();
            List<string> vsem = new List<string>();

            //string[] sem = opus.Split(',');
            string[] opuss;
            opuss = new[] { opus };
            Calcula.TiraVirgula(opuss, vsem);    // Faz as vezes do Split
            int soma = Calcula.Resultado(vsem);

            Console.Write("Soma = " + soma);
            Console.Read();
        }
    }
}

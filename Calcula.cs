using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{

    public class Calcula
    {

        public static int Resultado(List<string> ops)
        {

            List<int> vs = new List<int>();

            int tam = ops.Count;
 
            for (int i = 0; i < tam; i++)
            {
                switch (ops[i])
                {
                    case "D":
                        vs.Add(vs.Last() * 2);
                        break;
                    case "C":
                        vs.RemoveAt(vs.Count - 1);      
                        break;
                    case "+":
                        vs.Add(vs.Last() + vs[vs.Count - 2]);
                        break;
                    default:
                        vs.Add(int.Parse(ops[i]));
                        break;
                }
            }
            int conta = vs.Count;
            int resulta = 0;
            for (int i = 0; i < conta; i++)
            {
                resulta += vs[i];
            }
            ops[0] = Convert.ToString(resulta);
            return int.Parse(ops[0]);
        }


        public static void TiraVirgula(string[] strs,List <string> vosem)
        {
            //string[] strs = New strs[];
            string str = string.Join("", strs);
            int tamanho = str.Length;
            bool sinal = false;

            for (int i = 0; i < tamanho; i++)
            {
                if (str.Substring(i, 1) != ",")
                {
                    if (sinal == true)
                    {
                        sinal = false;
                        vosem.Add(str.Substring(i - 1, 1) + str.Substring(i , 1));
                    }
                    else
                    {
                        if (str.Substring(i, 1) == "-")
                        {
                            sinal = true;
                        }
                        else
                        {
                            vosem.Add(str.Substring(i, 1));
                        }
                    }
                }              
            }
        }
    }
}

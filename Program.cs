using System;
using System.Collections.Generic;

namespace idz1_zad4_mulyava
{
    class Program
    {
        public static List<string> Concatination(List<string> L1, List<string> L2)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < L1.Count; i++)
            {
                for (int j = 0; j < L2.Count; j++)
                {
                    result.Add(L1[i] + L2[j] + " ");
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<string> L1 = new List<string> { "aaaa", "ochen" };
            List<string> L2 = new List<string> { "mnogo", "strok" };

            List<string> result = Concatination(L1, L2);
            foreach (string s in result)
            {
                Console.Write(s + " ");
            }
        }
    }
}


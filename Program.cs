using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача__1
{
    class Program
    {
        static void Main(String[] args)
        {
            int i, n;
            Console.WriteLine("Введите выражение:");
            string text = Console.ReadLine();
            Char[] a = text.ToArray();
            n = a.Length;
            String[] m = new String[n];
            for (i = 0; i < n; i++)
            {
                m[i] = Convert.ToString(a[i]);
            }
            int b = 0;
            int slagaemoe;
            int sum = 0;
            String plus = "+";            
            if (m[0]!=(plus))
            {            
                slagaemoe = Convert.ToInt32(m[0]);
                sum += slagaemoe;
            }
            for (i = b; i < n; i++)
            {
                if (m[i].Equals(plus))
                {
                    slagaemoe = Convert.ToInt32(m[i + 1]);
                    sum += slagaemoe;
                }                              
            }
            Console.Write("Ответ: " + sum);
            Console.ReadLine();
        }
    }
}

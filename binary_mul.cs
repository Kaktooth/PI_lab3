using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {  
            string b1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("x");
            string b2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("__________________________");
            char[] a = b1.ToCharArray();
            char[] b = b2.ToCharArray();
            int i= 0;
            int l = 0;
            int size = a.Length;
            int e = size;
            string mul = "";
            string res = "";
            string[] k = new string[size];
            string d = "";
            while (i!=size)    //multiply
            {
                if (b[i] == '0')
                {
                    string s = d.PadLeft(size, '0');
                    string g = s.PadLeft(e, ' ');
                    k[i] = s;
                    Console.WriteLine(g);
                    e++;
                }
                else if (b[i] == '1')
                {
                    k[i] = b1;
                    string c = b1.PadLeft(e, ' ');
                    Console.WriteLine(c);
                    mul = k[i].Insert(l, k[i]);
                    res = mul.Remove(mul.Length - 1);
                    e++;
                }
                i++;
                l++;
            }
            Console.WriteLine("__________________________");
            Console.WriteLine("{0}", res);
            Console.ReadLine();
        } 
    }
}

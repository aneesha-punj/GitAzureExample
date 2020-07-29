using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    class IntToBinary
    {
        public void Practice()
        {
            int x = 13;
            int r = 0;
            string temp = "", binary = "";
            while (x>1)
            {
                r = x % 2;
                x = x / 2;
                temp = temp + Convert.ToString(r);
            }
            if(x==1)
            {
                temp = temp + 1;
            }
            int len= temp.Length-1;
            while(len>=0)
            {
                binary = binary + temp[len];
                len--;
            }
            
            Console.WriteLine(binary);
            Console.ReadKey();
        }
        public static void Main()
        {
            IntToBinary p = new IntToBinary();
            p.Practice();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class BinaryGap
    {
        public void Gap()
        {
            int x = 9;
            int r = 0;
            string temp = "", binary = "";
            while (x > 1)
            {
                r = x % 2;
                x = x / 2;
                temp = temp + Convert.ToString(r);
            }
            if (x == 1)
            {
                temp = temp + 1;
            }
            int len = temp.Length - 1;
            while (len >= 0)
            {
                binary = binary + temp[len];
                len--;
            }

            int count = 0, maxlen = 0, len1 = 0;
            //bool gapStarted=false;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    if (count > 0)
                    {
                        count++;

                    }
                    else
                    {
                        count = 1;
                    }
                }
                else
                {
                    count = 0;
                }
                if (count > maxlen)
                    maxlen = count;
                if (binary[i] == '1' && maxlen > len1)
                    len1 = maxlen;
            }
            Console.WriteLine(len1);
        }

        public static void Main()
        {
            BinaryGap bg = new BinaryGap();
            bg.Gap();

            Console.ReadKey();
        }
    }
}

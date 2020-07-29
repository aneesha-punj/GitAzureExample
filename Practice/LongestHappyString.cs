using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class LongestHappyString
    {
        public string LongestDiverseString(int a, int b, int c)
        {
            string strResult = "";
            int length = a + b + c;
            int cntA = 0, cntB = 0, cntC = 0;
            for (int i = 0; i < length; i++)
            {
                if ((a >= b && a >= c && cntA != 2) || (a > 0 && (cntB == 2 || cntC == 2)))
                {
                    strResult = strResult + "a";
                    cntA++;
                    cntB = 0;
                    cntC = 0;
                    a--;
                }
                else if ((b >= a && b >= c && cntB != 2) || (b > 0 && (cntA == 2 || cntC == 2)))
                {
                    strResult = strResult + "b";
                    cntB++;
                    cntA = 0;
                    cntC = 0;
                    b--;
                }
                else if ((c >= b && c >= a && cntC != 2) || (c > 0 && (cntB == 2 || cntA == 2)))
                {
                    strResult = strResult + "c";
                    cntC++;
                    cntA = 0;
                    cntB = 0;
                    c--;
                }
            }
            Console.WriteLine(strResult);
            Console.ReadKey();
            return strResult;
        }
        static void Main(string[] args)
        {
            LongestHappyString longest = new LongestHappyString();
            int a = 1, b = 1, c = 7;
            longest.LongestDiverseString(a, b, c);
            
        }
    }
}
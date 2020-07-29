using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class OddOccurence
    {
        public int solution(int[] A)
        {
            int temp = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                temp = temp ^ A[i];
            }
            Console.WriteLine(temp);
            Console.ReadKey();
            return temp;   
        }
        static void Main(string[] args)
        {
            OddOccurence odd = new OddOccurence();
            int[] A = {  1,1,3, 4, 4 };
            odd.solution(A);
        }
           
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            int leftsum = A[0];
            int rightsum = 0;
            int temp , result;
            for (int i = 1; i < A.Length; i++)
            {
                rightsum += A[i];
            }
            result = (int)Math.Abs(rightsum - leftsum);
            for (int i = 1; i < A.Length; i++)
            {
                temp = (int)Math.Abs(rightsum - leftsum);
                if (temp<result)
                {
                    result = temp;
                }
                leftsum += A[i];
                rightsum -= A[i];
            }
            Console.WriteLine(result);
            Console.ReadKey();
            return result;
        }
        static void Main(string[] args)
        {
            TapeEquilibrium te = new TapeEquilibrium();
            int[] A = { 3, 1, 2, 4, 3 };
            te.solution(A);
        }
    }
}

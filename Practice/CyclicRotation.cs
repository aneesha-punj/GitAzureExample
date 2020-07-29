using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            int[] B = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                B[(i + K) % A.Length] = A[i];
            }
            foreach (int i in B)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            return B;
      
        }
        static void Main(string[] args)
        {
            CyclicRotation cr = new CyclicRotation();
            int K = 3;
            int[] A = { 3, 8, 9, 7, 6 };
            cr.solution(A,K);
            Console.ReadLine();
        }

    }
}

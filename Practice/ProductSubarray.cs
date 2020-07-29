using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class ProductSubarray
    {
        int Product(int[] A)
        {
            int res = 1;
            for (int i = 0; i < A.Length; i++)
            {
                int prod = 1;
                for (int j = 0; j < A.Length; j++)
                {
                    prod = prod * A[j];
                    res = res * prod;
                }
            }
            Console.WriteLine(res);
            Console.ReadKey();
            return (res);
        }
        static void Main(string[] args)
        {
            ProductSubarray ps = new ProductSubarray();
            int[] A = { 10, 3, 7 };
            ps.Product(A);
        }
    }
}

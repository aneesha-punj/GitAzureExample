using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class SlidingWindow
    {
        int maxSub(int[] A, int K)
        {
            int max = 0;
            //Outer loop will navigate the array
            for (int i = 0; i < A.Length - K; i++)
            {
                max = A[i];
                //Inner loop with track the maximum element in every k elements (all k windows or all subarrays with size k
                for (int j = 0; j < K; j++)
                {
                    if (A[i + j] > max)
                    {
                        max = A[i + j];
                    }

                }
                Console.WriteLine(max + " ");
                Console.ReadKey();

            }
            return max;
        }
            static void Main(string[] args)
            {
            SlidingWindow sw = new SlidingWindow();
            int[] A = { 2, 3, 4, 5, 2, 6, 1 };
            int K = 3;
            sw.maxSub(A, K);
            }
        }
    }


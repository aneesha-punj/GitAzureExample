using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class FrogLeaves
    {
        public int solution(int X, int[] A)
        {
            int occupiedpositions =0;
            bool[] inposition = new bool[X + 1];
            for (int i = 0; i < A.Length; i++)
            {
                int temp = A[i];
                if(A[i]<=X && !inposition[temp])
                {
                    occupiedpositions++;
                    inposition[temp] = true;
                }
                if (occupiedpositions==X)
                {

                }
            }
        }
}

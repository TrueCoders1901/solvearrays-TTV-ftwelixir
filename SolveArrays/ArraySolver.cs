using System;
using System.Collections.Generic;
using System.Linq;

namespace SolveArrays
{
    public class ArraySolver
    {
        public int Sum(int[] numbers)
        {
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            foreach (int element in numbers)
            {
                if (element % 2 == 0)
                {
                    return numbers.Sum();
                }
            }
            return 0;
        }

        public double AverageEvens(int[] numbers)
        {
            foreach (int element in numbers)
            {
                if (element % 2 == 0)
                {
                    return numbers.Average();
                }
            }
            return 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

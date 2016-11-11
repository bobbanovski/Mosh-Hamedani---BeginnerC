using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class HackerRank
    {
        static void Main(string[] args)
        {

            int[] arr1 = new[] { 1, 2, 3, 0, 4, 3 };
            int[] arr2 = new[] { 2, 3, 4, 0, 2, 1 };
            int[] arr3 = new[] {1, 4, 2, 3, 1, 0};
            int[] arr4 = new[] {5, 2, 5, 1, 4, 0};
            int[,] multiArr = new int[6, 4];
            for (int i = 0; i < arr1.Length; i++)
            {
                multiArr[i, 0] = arr1[i];
                multiArr[i, 1] = arr2[i];
                multiArr[i, 2] = arr3[i];
                multiArr[i, 3] = arr4[i];
            }

            var hourSum = 0;
            var hourTot = 0;

            var dimX = multiArr.GetLength(0);
            var dimY = multiArr.GetLength(1);
            for (int i = 0; i <= (dimY - 3); i++)
                {
                    for (int j = 0; j <= (dimX - 3); j++)
                    {
                        hourSum = multiArr[j, i] + multiArr[j, i + 1] + multiArr[j, i + 2]
                                  + multiArr[j + 1, i + 1]
                                  + multiArr[j + 2, i] + multiArr[j + 2, i + 1] + multiArr[j + 2, i + 2];
                        if (hourSum > hourTot)
                            hourTot = hourSum;
                    }
                }
            Console.WriteLine(hourTot);
        }
    }
}

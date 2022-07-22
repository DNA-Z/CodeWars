using System;
using System.Collections.Generic;

namespace KatasDotnet5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] array =
            {
                new int[] { }
            };

            int[] res = Snail(array);

            Console.WriteLine();
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write($"{res[i]} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public static List<int> resultList = new List<int>();
        public static int[] Snail(int[][] array)
        {
            //return array[0].Length == 0 ? resultList.ToArray() : (array[0].Length == 1 ? resultList.Add(array[0][0]).ToArray() : )

            if (array == null || array[0].Length == 0)
                return resultList.ToArray();

            if (array[0].Length == 1)
            {
                //resultList.Add(array[0][0]);



            }


            int row = array.Length - 1;
            int col;
            int[][] resizeArray = new int[row][];

            for (int i = 0; i < row; i++)
            {
                col = array[i].Length;
                resultList.Add(array[0][i]);
                if (i == row - 1)
                    resultList.Add(array[0][i + 1]);

                resizeArray[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    resizeArray[i][j] = array[i + 1][j];
                }
            }

            row = resizeArray.Length;
            int[][] resizeArray2 = new int[row][];
            for (int i = 0; i < row; i++)
            {
                col = resizeArray[i].Length;
                resultList.Add(resizeArray[i][col - 1]);
                resizeArray2[i] = new int[row];

                for (int j = 0; j < col; j++)
                {
                    if (j == col - 1)
                        continue;
                    resizeArray2[i][j] = resizeArray[i][j];
                }
            }

            row = resizeArray2.Length - 1;
            int[][] resizeArray3 = new int[row][];
            for (int i = row; i >= 0; i--)
            {
                resultList.Add(resizeArray2[row][i]);
            }

            for (int i = 0; i < row; i++)
            {
                col = resizeArray2[i].Length;
                resizeArray3[i] = new int[col];

                for (int j = 0; j < col; j++)
                {
                    resizeArray3[i][j] = resizeArray2[i][j];
                }
            }

            row = resizeArray3.Length;
            int[][] resizeArray4 = new int[row][];
            for (int i = row - 1; i >= 0; i--)
            {
                resultList.Add(resizeArray3[i][0]);
            }

            for (int i = 0; i < row; i++)
            {
                col = resizeArray3[i].Length;
                resizeArray4[i] = new int[row];
                for (int j = 1; j < col; j++)
                {
                    resizeArray4[i][j - 1] = resizeArray3[i][j];
                }
            }

            if (resizeArray4.Length != 0)
            {
                Snail(resizeArray4);
            }

            return resultList.ToArray();
        }
    }
}

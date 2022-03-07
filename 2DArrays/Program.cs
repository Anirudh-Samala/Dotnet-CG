﻿using System;

namespace _2DArrays
{
    class Program
    {
        public static void Main2(string[] args)
        {
            int[,] arr1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 } , { 7, 8, 9 } };
            int[,] arr2 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] arr3 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

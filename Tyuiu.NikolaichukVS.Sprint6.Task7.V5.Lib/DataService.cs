﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.NikolaichukVS.Sprint6.Task7.V5.Lib
{
    public class DataService : ISprint6Task7V5
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int xCol = 9;

            for (int r = 0; r < rows; r++)
            {
                for (int c  = xCol; c <= xCol; c++)
                {
                    if (matrix[r, c] < 2)
                    {
                        matrix[r, c] = 2;
                    }
                }
            }
            return matrix;
        }
    }
}

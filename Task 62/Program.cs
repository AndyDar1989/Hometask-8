/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/


void FillMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];

    for (int k = 0; k <= matrix.Length; k++)
    {int i =0;
    int j = 0;
    for ( ;i < row; i++)
    {
            for (; j < col; j++)
            {
                matrix[i, j] = k;
                Console.Write(matrix[i, j]);
            }
            i++;
            matrix[i, j] = k;
            Console.Write(matrix[i, j]);
            j--;
            for (; j >= 0; j--)
            {
                matrix[i, j] = k;
                Console.Write(matrix[i, j]);
            }
            i++;

        }
    }}

        FillMatrix(4, 4);







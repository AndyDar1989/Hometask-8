/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] CreateMatrixRndInt(int str, int col, int min, int max)
{
    int[,] matrix = new int[str, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(min, max + 1);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],4}");// 4- задает длинну под вывод 
        Console.WriteLine();
    }
}

void SortMatrixRow(int[,] matrix)
{
    int max = 0;
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = k; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max)
            {
            max = matrix[i,j];
            }     
        }
        Console.Write($"{max}");
        k++;
    }
}



int[,] matr = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(matr);
Console.WriteLine();
SortMatrixRow(matr);

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

int[,] SortMatrixRow(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int[,] sortMatrix = new int[row,col];
    for (int i = 0;i<row;i++)
    {   
        for (int k = 0; k<col;k++)
        {
        int max = matrix[i,k];
        for (int j = k+1; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max)
            {int temp = max;
            max = matrix[i,j];
            matrix[i,j] = temp;}
        }
        sortMatrix[i,k] = max;
        }
    }
    return sortMatrix;
}



int[,] matr = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(matr);
Console.WriteLine();
int[,] newMatr = SortMatrixRow(matr);
PrintMatrix(newMatr);
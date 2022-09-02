/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] FillMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    int k = 1;
    int i = 0;
    int j = 0;
    while (k <= matrix.Length)
    {
        matrix[i, j] = k;
        if (i <= j + 1 && i + j < col - 1)
            j++;
        else if (i < j && i + j >= row - 1)
            i++;
        else if (i >= j && i + j > col - 1)
            j--;
        else
            i--;
        k++;
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

int[,] matr = FillMatrix(5, 5);
PrintMatrix(matr);








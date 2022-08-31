/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

void MinSumOfElem(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[] array = new int[size];
    int k = 0;
    for (int i = 0; i < size; i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[k] = sum;
        Console.Write(array[k] + " ");
        k++;
    }
    int min = array[0];
    int m = 0;
    int l = 1;
    while (l < size)
    {
        if (array[l] < min)
        {
            min = array[l];
            m = l;
        }
        l++;
    }
    Console.WriteLine($"row with mimimal summ ({min}) is {m+1}");
}


int[,] matr = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(matr);
MinSumOfElem(matr);
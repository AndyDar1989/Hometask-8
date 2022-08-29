/*Задача 59: Задайтедвумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на 
пересечении которых расположен наименьший элемент 
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7*/

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

int[] FindMinElement(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] array= new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
            min = matrix[i, j];
            array[0]=i;
            array[1]=j;
           }}
    }
   return array; 
}

void DelRowCol(int[,] matrix, int k, int l)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
    {if (i!=k){
        for (int j = 0; j < matrix.GetLength(1); j++)
        {if (j!=l){
             Console.Write($"{matrix[i, j],4}");// 4- задает длинну под вывод 
        Console.Write("");}
        /*else {j++;Console.WriteLine($"{matrix[i, j],4}");}}}*/
    }}}
}

int[,] matr = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(matr);
int[] position  = FindMinElement(matr);
Console.WriteLine();
DelRowCol(matr, position[0],position[1]);




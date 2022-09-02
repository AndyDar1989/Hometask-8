/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
/*void CheckForRepeat(int str,int col, int depth )
{
    for (int l = 0; l < array3D.GetLength(0); l++)
    {
    for (int m = 0; m < array3D.GetLength(0); m++)
    {
    for (int n = 0; n < array3D.GetLength(0); n++)
    {
    for (int i = array3D.GetLength(0)-1; i >= 0; i--)
    {
        for (int j = array3D.GetLength(1)-1; j >=0; j--)
        {
            for (int k = array3D.GetLength(2)-1; k >=0; k--)
            {
               if (array3D[l, m, n]==array3D[i, j, k])
                array3D[i, j, k]+=1;
            }
        }
    }
    }}}   
}*/


int[,,] Create3DArrayRndInt(int str, int col, int depth)
{
    int[,,] array3D = new int[str, col, depth];
    Random rnd = new Random();
    int min = 10;
    int max = 19;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = rnd.Next(min, max + 1);
                min += 10;
                max += 10;
            }
        }
    }
    return array3D;
}

void Print3DArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(1); k++)
                Console.Write($"{array3D[i, j, k],4}({i},{j},{k})");// 4- задает длинну под вывод 
            Console.WriteLine();
        }
    }
}

int[,,] arr3D = Create3DArrayRndInt(2, 2, 2);
Print3DArray(arr3D);

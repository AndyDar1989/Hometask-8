/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

int[,] MultTwoMatrix(int[,] matrix1,int[,] matrix2)
{
int sizeR = 0;
int sizeC = 0;
if (matrix1.GetLength(0)>matrix2.GetLength(0))
sizeR =  matrix2.GetLength(0);
else sizeR =  matrix1.GetLength(0);
if(matrix1.GetLength(1)>matrix2.GetLength(1))
sizeC =  matrix2.GetLength(1);
else sizeC =  matrix1.GetLength(1);
int[,] multMatrix = new int[sizeR,sizeC];
int i = 0;
int j = 0;
        multMatrix[i,j] = matrix1[i,j]*matrix2[i,j]+matrix1[i,j+1]*matrix2[i+1,j];
        multMatrix[i,j+1] = matrix1[i,j]*matrix2[i,j+1]+matrix1[i,j+1]*matrix2[i+1,j+1];
        multMatrix[i+1,j] = matrix1[i+1,j]*matrix2[i,j]+matrix1[i+1,j+1]*matrix2[i+1,j];
        multMatrix[i+1,j+1] = matrix1[i+1,j]*matrix2[i,j+1]+matrix1[i+1,j+1]*matrix2[i+1,j+1];

return multMatrix;
}

int[,] matr1 = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(matr1);
Console.WriteLine();
int[,] matr2 = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(matr2);
Console.WriteLine();
int[,] resMatr = MultTwoMatrix(matr1,matr2);
PrintMatrix(resMatr);


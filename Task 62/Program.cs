/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

/*void PrintImage(int[,] image)
{
for (int i = 0; i < image.GetLength(0); i++)
{
    for (int j = 0; j < image.GetLength(1); j++)
    {
        if (image[i, j] == 0) Console.Write(" ");
        else Console.Write("+");
    }
    Console.WriteLine();
}
}*/

void FillMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    int i = 0;
    int j = 0;
    int size = row*col;
    for (int n = 0;; n++)
    {
        while(j<col)
           {matrix[i, j] = n;
           j++;}
        while(i+1<row)
           {
            matrix[i, j] = n;
            i++;}
        while(j-1>=0)
           {matrix[i, j] = n;
           j--;}
        while(i-1>0)
           {
            matrix[i, j] = n;
            i--;}
        while(j<col-1)
           {matrix[i, j] = n;
           j++;}
        while(i<row-1)
           {
            matrix[i, j] = n;
            i++;}
        while(j>0)
           {matrix[i, j] = n;
           j--;}

      }  }
   
FillMatrix(4,4);
           
           
   


    /*if (pic[row, col]==0)
    {
        pic[row, col]=1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}*/

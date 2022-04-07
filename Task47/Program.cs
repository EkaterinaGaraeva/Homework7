/*
Задача 47: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] Generate2DArray(int higth, int weigth, double delta)
{
    double[,] array2D = new double[higth, weigth];
    for (int i = 0; i < higth; i++)
    {
        for (int j = 0; j < weigth; j++)
        {
            array2D[i, j] = new Random().NextDouble() * (delta - (-delta)) + (-delta);
            array2D[i, j] = Math.Round(array2D[i, j], 1);
        }
    }
    return array2D;
}

void Print2DArray(double[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i,j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите m: ");
int higth = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int weigth = Convert.ToInt32(Console.ReadLine());

double[,] gereratedArray = Generate2DArray(higth, weigth, 10);
Print2DArray(gereratedArray);

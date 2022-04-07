/*
Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] Generate2DArray(int higth, int weigth, int delta)
{
    int[,] array2D = new int[higth, weigth];
    for (int i = 0; i < higth; i++)
    {
        for (int j = 0; j < weigth; j++)
        {
            array2D[i, j] = new Random().Next(delta * -1, delta);
        }
    }
    return array2D;
}

void PrintArray2DArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[] ArrayOfAverages(int[,] array2D)
{
    double[] newArray = new double[array2D.GetLength(0)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            newArray[i] += array2D[i, j];
        }
        newArray[i] /= array2D.GetLength(1);
        newArray[i] = Math.Round(newArray[i], 1);
    }
    return newArray;
}

void PrintArray(double[] arrayOfNumbers)
{
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        Console.Write(arrayOfNumbers[i]);
        if (i != arrayOfNumbers.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine();
}

Console.Write("Введите m: ");
int higth = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int weigth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] generatedArray = Generate2DArray(higth, weigth, 10);
PrintArray2DArray(generatedArray);
Console.WriteLine();

double[] arrayOfAverages = ArrayOfAverages(generatedArray);
PrintArray(arrayOfAverages);

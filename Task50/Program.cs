/*
Задача 50: Напишите программу, которая на вход принимает позицию элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
пример индексов этого массива:
0 1 2 3
4 5 6 7
8 9 10 11
12 13 14 15
*/

int[,] Generate2DArray(int higth, int weigth, int delta)
{
    int[,] _return = new int[higth, weigth];
    for (int i = 0; i < higth; i++)
    {
        for (int j = 0; j < weigth; j++)
        {
            _return[i, j] = new Random().Next(delta * -1, delta);
        }
    }
    return _return;
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

int FindElement(int[,] arrayToFind, int position)
{
    int element = 0;
    if (position <= (arrayToFind.GetLength(0) + 1) * (arrayToFind.GetLength(1) + 1))
    {
        int higth = position / arrayToFind.GetLength(0);
        int weigth = position % arrayToFind.GetLength(1);
        element = arrayToFind[higth, weigth];
        Console.WriteLine($"Элемент на позиции {position} = {element}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет");
    }
    return element;
}

Console.Write("Введите m: ");
int higth = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int weigth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] generatedArray = Generate2DArray(higth, weigth, 10);
PrintArray2DArray(generatedArray);
Console.WriteLine();

Console.Write("Введите позицию элемента: ");
int pos = Convert.ToInt32(Console.ReadLine());
int element = FindElement(generatedArray, pos);

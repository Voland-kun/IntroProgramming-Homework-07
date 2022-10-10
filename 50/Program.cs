// Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
// 5 -> 9

// индексы:
// [0][1][2][3]
// 1 4 7 2
// [4][5][6][7]
// 5 9 2 3
// [8][9][10][11]
// 8 4 2 4


int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] arrayToPrint)
{
    Console.WriteLine();
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void findElementByPosition(int[,] array,int elementPosition)
{
    if (elementPosition > array.Length) 
        Console.WriteLine("Такого числа в массиве нет");
    else
    {
        int row = elementPosition / array.GetLength(1);
        int column = elementPosition % array.GetLength(1);
        Console.WriteLine(array[row, column]);
    }
    
}

Console.WriteLine("Введите количество строк:");
int arrayRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int arrayColumns = Convert.ToInt32(Console.ReadLine());
int[,] generateArray = generate2DArray(arrayRows,arrayColumns,-100,100);
print2DArray(generateArray);
Console.WriteLine("Введите позицию элемента:");
int index = Convert.ToInt32(Console.ReadLine());
findElementByPosition(generateArray,index);
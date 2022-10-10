// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void getAverage(int[,] currentArray)
{
    double average = 0;
    for (int j = 0; j < currentArray.GetLength(1); j++)
    {
        average = 0;
        for (int i = 0; i < currentArray.GetLength(0); i++)
        {
            average += currentArray[i,j];
        }
        printColorData(j + "\t");
        Console.WriteLine(average/currentArray.GetLength(0));
    }
}



Console.WriteLine("Введите количество строк:");
int arrayRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int arrayColumns = Convert.ToInt32(Console.ReadLine());
int[,] generateArray = generate2DArray(arrayRows,arrayColumns,1,10);
print2DArray(generateArray);
Console.WriteLine("Среднее арифметическое столбцов:");
getAverage(generateArray);
/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return result;
}
int[,] get2DDoubleArray(int colLength,
                        int rowLength,
                        int start,
                        int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}
void print2Darray(int[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int[,] ChangeMas(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int k = 0; k < mas.GetLength(1); k++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                if (j + 1 < mas.GetLength(1))
                {
                    if (mas[i, j] < mas[i, j + 1])
                    {
                        int temp = mas[i, j + 1];
                        mas[i, j + 1] = mas[i, j];
                        mas[i, j] = temp;
                    }


                }

            }
        }

    }
    return mas;
}
int n = GetDataFromUser("Введите количество строк");
int m = GetDataFromUser("Введите количество столбцов");
int[,] Array = get2DDoubleArray(n, m, 1, 15);
print2Darray(Array);
Array = ChangeMas(Array);
print2Darray(Array);
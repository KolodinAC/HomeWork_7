// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using static Common.Helper;


Console.WriteLine();
int m = UserInput("Введите желаемое количество строк массива: ");
int n = UserInput("Введите желаемое количество столбцов массива: ");
Console.WriteLine();

int[,] newArray = CreateRandom2DArray(m, n);
Console.WriteLine("Сгенерированный массив: ");
Print2DArray(newArray);
Console.WriteLine();

double[] avgNumbers = GetAvgNumb(newArray);
Console.WriteLine("Среднее арифметическое чисел в столбцах массива: ");
PrintArrayD(avgNumbers);
Console.WriteLine();

double[] GetAvgNumb(int[,] matr)
{
    double[] numArr = new double[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        double result = 0.0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            result += matr[j, i];
        }
        numArr[i] = result / matr.GetLength(0);
    }
    return numArr;
}
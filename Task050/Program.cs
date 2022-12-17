// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using static Common.Helper;

Console.WriteLine();
uint m = UintInput("Введите желаемое количество строк массива: ");
uint n = UintInput("Введите желаемое количество столбцов массива: ");
Console.WriteLine();

float[,] newArray = CreateRandom2DArrayF(m, n);
Console.WriteLine("Ваш сгенерированный массив: ");
Print2DArrayF(newArray);
Console.WriteLine();

uint findM = UintInput("Введите номер строки массива: ");
uint findN = UintInput("Введите номер столбца массива: ");
Console.WriteLine();

if(findM > m || findN > n)
{
    Console.WriteLine("Числа с такими координатами в массиве не существует.");
    return;
}
Console.WriteLine();

float answer = GetElementFromCoord(newArray, findM, findN);
Console.WriteLine("По данным координатам располагается число: " + answer);
Console.WriteLine();


float GetElementFromCoord(float[,] matr, uint rows, uint columns)
{
    float result = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i, j] == matr[rows, columns])
            {
                result = matr[i, j];
            }
        }   
    }
    return result;
}
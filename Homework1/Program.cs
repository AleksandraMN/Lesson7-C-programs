/*Задача 47. Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
using System;
class Program
{
static void FillArray(float[,] matr)
{
	for(int i = 0; i < matr.GetLength(0); i++)  // кол-во строк
	{
		for(int j = 0; j < matr.GetLength(1); j++) // кол-во столбиков
		{
			matr[i, j]= new Random().Next(-7, 11); //
		}
	}
}
static void PrintArray(float[,] matr)
{
		for(int i = 0; i < matr.GetLength(0); i++)  // кол-во строк
	{
			for(int j = 0; j < matr.GetLength(1); j++) // кол-во столбиков
		{
			Console.Write($"{matr[i, j]} ");
		}
		Console.WriteLine();
	}
}

static void Main(string[] args)
{
	Console.Write("Введите количество строк двумерной матрицы: m = ");
	int m = Convert.ToInt32(Console.ReadLine()); 
	Console.Write("Введите количество столбиков двумерной матрицы: n = ");
	int n = Convert.ToInt32(Console.ReadLine());

	float[,] matrix = new float [m, n];

	Console.WriteLine();
	FillArray(matrix);
	PrintArray(matrix);
	Console.WriteLine();
}
}
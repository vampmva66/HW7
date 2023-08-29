// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// System.Console.Write("Введите первую размерность массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите вторую размерность массива: ");
// int colomns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double [rows,colomns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         System.Console.Write(matrix[i,j] + " ");
//     }
//     System.Console.WriteLine();
// }
 



// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет




// System.Console.Write("Введите первую размерность массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите вторую размерность массива: ");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [rows , colomns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 10);
//         System.Console.Write(matrix[i,j] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.Write("Введите позицию первого элемента: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите позицию второго элемента: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > matrix.GetLength(0) || b > matrix.GetLength(1))
// {
//     Console.WriteLine("Такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {a} строки и {b} столбца равно {matrix[a-1,b-1]}");
// }


// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


// System.Console.Write("Введите первую размерность массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите вторую размерность массива: ");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [rows , colomns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 10);
//         System.Console.Write(matrix[i,j] + " ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     double avarage = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         avarage = (avarage + matrix[i,j]);
//     }
//     avarage = avarage/ rows;
//     System.Console.Write("Среднее арифметическое = " + avarage + "; ");
// }

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
// {
//     int[,] array = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(minRnd, maxRnd + 1);
//         }
//     }
//     return array;
// }

// void PrintArrayMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();

// }
// void FiltrRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

//         int[,] myarray = GenerateArray(rows: 3, columns: 3, minRnd: 0, maxRnd: 10);
//         PrintArrayMatrix(myarray);
//         FiltrRows(myarray);
//         System.Console.WriteLine();
//         PrintArrayMatrix(myarray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
// {
//     int[,] array = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(minRnd, maxRnd + 1);
//         }
//     }
//     return array;
// }

// void PrintArrayMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();

// }

// void MinSumRows(int[,] matrix)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//                 minRow += matrix[0, i];
//     }
//  for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         sumRow += matrix[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.WriteLine($"{minSumRow + 1} строка");
// }


// int[,] myarray = GenerateArray(rows: 5, columns: 3, minRnd: 0, maxRnd: 10);
// PrintArrayMatrix(myarray);
// MinSumRows(myarray);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
// {
//     int[,] array = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(minRnd, maxRnd + 1);
//         }
//     }
//     return array;
// }

// void PrintArrayMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();

// }

// void Multiplicator(int[,] matrix, int[,] matrix2)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] *= matrix2[i,j];
//                   System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();

// }

// int[,] firstarray = GenerateArray(rows: 2, columns: 2, minRnd: 1, maxRnd: 3);
// int[,] secondarray = GenerateArray(rows: 2, columns: 2, minRnd: 4, maxRnd: 8);
// PrintArrayMatrix(firstarray);
// PrintArrayMatrix(secondarray);
// Multiplicator(firstarray, secondarray);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// void FillArrayRandomNumber(int[,,] array, int minNumber = 0, int maxNumber = 9)
// {
//     Random rand = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int h = 0; h < array.GetLength(2); h++)
//             {
//                 while (array[i, j, h] == 0)
//                 {
//                     int number = rand.Next(minNumber, maxNumber + 1);

//                     if (IsNumberInArray(array, number) == false)
//                     {
//                         array[i, j, h] = number;
//                     }
//                 }

//             }
//         }
//     }
// }

// bool IsNumberInArray(int[,,] array, int number)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int h = 0; h < array.GetLength(2); h++)
//             {
//                 if (array[i, j, h] == number) return true;
//             }
//         }
//     }

//     return false;
// }

// void PrintArrayWithIdex(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int h = 0; h < array.GetLength(2); h++)
//             {
//                 Console.Write(array[i, j, h]);
//                 Console.Write("({0},{1},{2})\t", i, j, h);
//             }

//             Console.WriteLine();
//         }

//         Console.WriteLine();
//     }
// }

// int arraySizeX = 2;
// int arraySizeY = 2;
// int arraySizeZ = 2;
// int minNumber = 10;
// int maxNumber = 99;
// int[,,] myarray = new int[arraySizeX, arraySizeY, arraySizeZ];
// FillArrayRandomNumber(myarray, minNumber, maxNumber);
// PrintArrayWithIdex(myarray);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] GenerateArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     int t = 1;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = t;
//             t++;
//         }
//     }
//     return array;
// }

// void PrintArrayMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();

// }

// void Spiralarray(int[,] array, int n)
// {
//     int i = 0, j = 0;
//     int value = 1;
//     for (int e = 0; e < n * n; e++)
//     {
//         int k = 0;
//         do { array[i, j++] = value++; } while (++k < n - 1);
//         for (k = 0; k < n - 1; k++) array[i++, j] = value++;
//         for (k = 0; k < n - 1; k++) array[i, j--] = value++;
//         for (k = 0; k < n - 1; k++) array[i--, j] = value++;
//         ++i; ++j;
//         n = n < 2 ? 0 : n - 2;
//     }
// }

// int[,] myarray = GenerateArray(4, 4);
// PrintArrayMatrix(myarray);
// System.Console.WriteLine();
// Spiralarray(myarray, 4);
// PrintArrayMatrix(myarray);

// Все готово
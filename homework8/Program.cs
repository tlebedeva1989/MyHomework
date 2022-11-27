// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {    
//     int[,] array = new int[rows,columns];

//     for(int i = 0; i < rows; i++)
//         for(int j=0; j<columns; j++)
//              array[i,j] = new Random().Next(minValue, maxValue + 1);
        
    
        
    
//     return array;    
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j]   + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//  элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// void ChangeRowsFromMaxToMin(int[,] array)
// {
    
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1)-1; j++)
//         {
            
//             if(array[i,j] < array[i, j + 1])
//             {
                
//                 int temp = array[i,j];
//                 array[i,j] = array[i, j + 1];
//                 array[i, j + 1] = temp;

//             }
            
//         }
//     }
   
// }

// Console.WriteLine("Input number of rows: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(n,m,min,max);
// Show2dArray( myArray);
// ChangeRowsFromMaxToMin(myArray);
// Show2dArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int MinSumRow(int[,] array)
// {
//     int[] sumOfRows = new int[array.GetLength(0)];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for(int j = 0; j < array.GetLength(1); j++)
//         {   
//             sum += array[i,j];
//             sumOfRows[i] = sum;
//         }  
//     }
//     int min = sumOfRows[0];
//     int minIndex = 0;
//     for( int i = 1; i < sumOfRows.Length; i++)
//         if(min > sumOfRows[i]) 
//         {   min = sumOfRows[i];
//             minIndex = i;
//         }

//     return minIndex;
// }

// Console.WriteLine("Input number of rows: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(n,m,min,max);
// Show2dArray( myArray);

// Console.WriteLine($" в {MinSumRow(myArray)} строке массива сумма элементов является наименьшей ");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] MatrixProduct(int[,] array1, int[,] array2)
// {   
//     int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
//     if(array1.GetLength(1) == array2.GetLength(0))
//     {   
//         for( int i = 0; i < array1.GetLength(0); i++)
//             for( int j = 0; j < array1.GetLength(1); j++)
//                 for( int k = 0; k < array2.GetLength(0); k++)
//                     result[i,j] += array1[i,k]*array2[k,j];
//     }  
//     else Console.WriteLine("Невозможно перемножить матрицы.");            
// return result;                    

    
// }

// Console.WriteLine("Input number of rows 1: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns 1: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min possible value 1: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max possible value 1: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input number of rows 2: ");
// int k = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns 2: ");
// int l = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min possible value 2: ");
// int min2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max possible value 2: ");
// int max2 = Convert.ToInt32(Console.ReadLine());



// int[,] matrix1 = CreateRandom2dArray(n,m,min,max);
// Show2dArray( matrix1);

// int[,] matrix2 = CreateRandom2dArray(k,l,min2,max2);
// Show2dArray( matrix2);

// Show2dArray(MatrixProduct(matrix1, matrix2));



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] CreateRandom3dArray(int x, int y, int z, int minValue, int maxValue)
{    
    int[,,] array = new int[x,y,z];

    for(int i = 0; i < x; i++)
        for(int j = 0; j < y; j++)
            for(int k = 0; k < z; k++)
             array[i,j,k] = new Random().Next(minValue, maxValue + 1);
        
    
        
    
    return array;    
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            string n = string.Empty;
            for(int k = 0; k < array.GetLength(2); k++)
            n += ($"{array[i,j,k]} ({i},{j},{k})  ");
        
        Console.WriteLine(n);
        }
    }
    Console.WriteLine();
}

Console.WriteLine("Input number of rows : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of depth : ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value : ");
int min = 10;
int max = 99;

int[,,] myArray = CreateRandom3dArray(n,m,k,min,max);
Show3dArray(myArray);



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


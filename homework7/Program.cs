
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{    
    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j=0; j<columns; j++)
             array[i,j] = new Random().Next(minValue, maxValue + 1);
        
    
        
    
    return array;    
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]   + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}




// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

/* double [,] CreateRandomDouble2dArray(int rows, int columns, double minValue, double maxValue)
{    
    double[,] array = new double[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j=0; j<columns; j++)
             array[i,j] = Math.Round((new Random().NextDouble() + new Random().Next(Convert.ToInt32(minValue), Convert.ToInt32(maxValue))), 2) ;
        
    
        
    
    return array;    
}


void Show2dDoubleArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]   + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
double min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
double max = Convert.ToInt32(Console.ReadLine());

Show2dDoubleArray( CreateRandomDouble2dArray(n,m,min,max)); */



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> числа с такими индексами в массиве нет


/*void ShowArrayElement( int[,] array, int rowPosition, int colPosition)
{
    if(rowPosition < array.GetLength(0) && colPosition < array.GetLength(1))
    
        Console.WriteLine(array[rowPosition, colPosition]);

    else Console.WriteLine("there is no element with added index in this array");    
    
}

Console.WriteLine("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(n, m, min, max);
Show2dArray(myArray);

Console.WriteLine("Input index of row ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input index of column ");
int colIndex = Convert.ToInt32(Console.ReadLine());

ShowArrayElement(myArray, rowIndex, colIndex);*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ShowDoubleArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]   + " ");

    Console.WriteLine(" ");
 
}


double[] ArithmeticalMeanOfColumns(int[,] array)
{
    double[] resultArray = new double[array.GetLength(1)];
    
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sumColumnElements = 0;
        for(int i = 0; i < array.GetLength(0); i++)
 
            sumColumnElements += array[i,j];

        double average = sumColumnElements / array.GetLength(0);
            
        resultArray[j] = Math.Round(average,1) ;
    }    
    
    return resultArray;         
}

Console.WriteLine("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(n,m,min,max);
Show2dArray(myArray );

ShowDoubleArray(ArithmeticalMeanOfColumns(myArray));



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
    
//     return array;    
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i]   + " ");

//     Console.WriteLine(" ");
 
// }

// int HowMuchEvenNumbers(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         count++;
//     }
//     return count;
// }



// int size = 10;
// int min = 100;
// int max = 999;
// int[] array = CreateRandomArray(size, min, max);
// ShowArray(array);
// Console.WriteLine($" There are {HowMuchEvenNumbers(array)} even numbers in array ");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int SumUnevenNumbers(int[] array)
// {
//     int sum = 0;
//     for(int i = 1; i < array.Length; i+=2)
//     sum += array[i];

//     return sum;
// }

// Console.Write("add number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("add min value number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("add max value number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);

// Console.WriteLine($" The sum of uneven elements of array is {SumUnevenNumbers(myArray)}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    
    for(int i = 0; i < size; i++)
            array[i] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);

            return array;    
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]   + " ");

    Console.WriteLine(" ");
 
}

double Max_Min(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 0;  i < array.Length; i++)
    {
        if(max > array[i])  min = array[i];
        else if(min < array[i]) max = array[i]    ;
                    
    }
    double difference = Math.Round(max - min, 2);
    return difference;
}

Console.Write("add number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("add min value number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("add max value number: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
Console.WriteLine($" Difference between max and min numbers in array is {Max_Min(myArray)}");
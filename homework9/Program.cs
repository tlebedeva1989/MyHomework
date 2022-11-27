// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



// void Numbers(int num)
// {
//     Console.Write(num + " ");
//     if(num > 1) Numbers(num-1);
        
// }

// Console.WriteLine("Input a number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Numbers(n);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//  натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int SumOfNumbers(int num1, int num2)
// {
//     if(num1 < num2) return SumOfNumbers(num1+1,num2) +num1;
      
     
//     else if (num1 > num2) return  SumOfNumbers(num1 - 1, num2) + num1;
        
//     else return num1;
    
// }


// Console.WriteLine("Input the first number: ");
// int m = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Input the second number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine (SumOfNumbers(m,n));



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackerman(int num1, int num2)
{
    if(num1 == 0) return num2 + 1;
    else if(num1 > 0 && num2 == 0) return Ackerman(num1 - 1, 1);
    else return Ackerman(num1 - 1, Ackerman(num1, num2 - 1));
}

Console.WriteLine("Input the first natural number: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Input the second natural number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (Ackerman(m,n));
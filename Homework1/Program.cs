/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine ("input the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
   Console.WriteLine($"First Number {firstNumber} is MAX, Second Number {secondNumber} is MIN");
}
else 
{
   Console.WriteLine($"First Number {firstNumber} is MIN, Second Number {secondNumber} is MAX");
}
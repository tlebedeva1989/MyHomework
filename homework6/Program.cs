// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// Console.WriteLine("How many numbers do you want to check? ");
// int m = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for ( int i = 0; i < m; i++)
// {
//     Console.WriteLine("Input a number: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     if(n > 0) count++;
    
// }

// Console.WriteLine($"You add {count} numbers under 0. ");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите угловой коэффициент k для уравнения первой прямой, вида y=k*x + b: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b для уравнения первой прямой, вида y=k*x + b: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициент k для уравнения второй прямой, вида y=k*x + b: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b для уравнения второй прямой, вида y=k*x + b: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double y0;
double x0;
if(k1 != k2 && b1 != b2)
{
    x0 = (b2 - b1) / (k1 - k2);
    y0 = k1 * x0 + b1;
    Console.WriteLine($"Точка пересечения двух прямых, заданных уравнениями y={k1}*x+{b1} и  y={k2}*x+{b2} имеет координаты ({x0}; {y0}) ");
}
else if(k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны.");
else if(k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают.");
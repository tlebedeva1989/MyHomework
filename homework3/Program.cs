// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// bool Palindrom(int num)
// {
//     int firstDigit = num / 10000;
//     int secondDigit = (num / 1000) % 10;
//     int lastDigit = num % 10;
//     int forthDigit = (num % 100) / 10;
//     if ( firstDigit == lastDigit && secondDigit == forthDigit) return true;
//     else return false;
// }

// Console.WriteLine("Input 5-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 10000 && number < 99999) Console.WriteLine($" Is number {number}  palindrom? - {Palindrom(number)}");
// else Console.WriteLine($"{number} is not 5-digit number");



// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// double Distance ( double x1, double x2, double y1, double y2, double z1, double z2)
// {
//     double x = Math.Pow((x2-x1), 2);
//     double y = Math.Pow((y2-y1), 2);
//     double z = Math.Pow((z2-z1), 2);
//     double distance = Math.Sqrt((x + y + z));
//     return distance;
// }

// Console.WriteLine(" Input X- coordinate of the first point: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(" Input Y- coordinate of the first point: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(" Input Z- coordinate of the first point: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(" Input X- coordinate of the second point: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(" Input Y- coordinate of the second point: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(" Input Z- coordinate of the second point: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between two points with coordinates ({x1}, {y1}, {z1}) and ({x2}, {y2}, {z2}) is {Distance(x1, x2, y1, y2,z1, z2)});  ");



// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Cube( int num)
// {
//     int currentNum = 1;
//     int result;
//     while (currentNum <= num)
//     {
//         result = currentNum*currentNum*currentNum;
//         Console.WriteLine(result);
//         currentNum++;
//     }
    
// }

// Console.WriteLine("Input whole number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Cube(number);
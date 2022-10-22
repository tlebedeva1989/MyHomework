// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int ThirdDigit(int tripleDigit)
// {
    
//     if(tripleDigit >=100 && tripleDigit <=999)
//     {
//         int lastDigit;
//         lastDigit = tripleDigit % 10;
//         return lastDigit;
//     }
//     else 
//     return -1;
// }

// Console.WriteLine("Add triple digits: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = ThirdDigit(number);
// if(result == -1) Console.WriteLine("not triple digit");
// else Console.WriteLine($"The third digit of {number} is {result}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int ThirdDigit(int num)
// {
//     if ( num<100) return -1;
//     else
//     {   while (num >999) num = num/10;
         
//     int lastDigit;
//     lastDigit = num % 10;
//     return lastDigit;
//     }    
// }


// Console.WriteLine("Add number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = ThirdDigit(number);
// if(result == -1) Console.WriteLine($"there is no third digit in {number}");
// else Console.WriteLine($"The third digit of {number} is {result}");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// bool DayOfWeek(int day)
// {
//     if ( day >=1 && day<=5) return false;
//     else  return true;
        
     
// }

// Console.WriteLine("Add day of week number from 1 to 7: ");
// int dayNum = Convert.ToInt32(Console.ReadLine());
// if ( dayNum < 1 || dayNum > 7) Console.WriteLine("Wrong day number");
// else
// {
//     Console.Write($"Is Week day number {dayNum} a weekend? " + (DayOfWeek(dayNum)));
// }
    


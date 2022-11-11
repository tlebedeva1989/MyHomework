// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


/* int Pow(int a, int b)
{
    int count = 2;
    int pow = a;
    while (count <= b)
    {
        pow = pow*a;
        count++;
    }
    return pow;
}

Console.WriteLine(" input the first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" input the second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" number {firstNum} to the power {secondNum} is {Pow(firstNum, secondNum)} ");*/




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


/*int DigitSum( int num)
{
    int sum = 0;
    int lastDigit = num % 10;
    int currentNumber = num / 10;
    while ( currentNumber/10 > 1)
    {
        sum +=lastDigit;
        lastDigit = currentNumber % 10; 
        currentNumber =  currentNumber/10;
    }
    sum = sum + lastDigit + currentNumber;
    return sum;
}


Console.WriteLine(" input the a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" Sum of digits in number {number} is {DigitSum(number)}"); */


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

/* int[] CreateArray()
{

    Console.WriteLine( "input array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    int[] array = new int [size];
        while (i < size )
        {
            Console.WriteLine( "input number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            array[i] = num;
            i++;
    
        }
    

    for(int ind = 0; ind < array.Length; ind++)
        Console.Write(array[ind]   + " ");

    Console.WriteLine(" ");

    return array;
}

CreateArray();*/

 



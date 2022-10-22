// 16. Напишите программу, которая 
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 * num1 == num2 || num2 * num2 == num1)
{
    Console.Write("Yes");
}
else Console.Write("No");








//     Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 * number1 == number2 || number2 * number2 == number1)
//     Console.Write("Да");
// else Console.Write("Нет");






// НЕЛЬЗЯ:
// так:

// string str = Console.ReadLine(); // or string str = "32679";
// char res = str[2];

// или так:

// string str = "32679";
// System.Console.WriteLine(str[2]);
//строка это неизменяемый тип данных, строка это не массив.
// Домашнее задание 1

/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Console.Write("Please, enter number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int max2 = ((numA > numB) ? numA: numB); // 2 - в данном случае это номер задачи
int min2 = ((numA < numB) ? numA: numB);

Console.WriteLine($"The bigger number is: {max2}\nThe smaller number is: {min2}");
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
Console.Write("Please, enter number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter number 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max4 = ((num1 > num2) ? num1 : num2);
max4 = ((max4 > num3) ? max4 : num3);

Console.WriteLine("The maximum number is: " + max4);
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
/*
Console.Write("Enter any integer number: ");
int num6 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("This number is " + ((num6 % 2 == 0)? "even": "odd"));
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Please, enter N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i++ < numN)
    Console.Write(i++ + " ");



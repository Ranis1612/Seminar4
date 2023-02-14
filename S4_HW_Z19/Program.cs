﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Clear();
// Console.WriteLine("Введите пятизначное число:  ");
// int num = int.Parse(Console.ReadLine()!);  // num = 12345
// int a1 = num / 10000; // находим первую цифру num / 10000 = 1 (int целое число 1)
// num = num - (a1 * 10000);  //  присваиваем num новое значение, остаток: 12345 - 1*10000 = 2345 или так num = num % 10000 (2345)
// int a2 = num /1000;  // находим вторую цифру  2345 / 1000 = 2  
// num = num - (a2 * 1000);    //num -= a2 * 1000 сокращённая запись //  присваиваем num новое значение, остаток: 2345 - 1*1000 = 345 или так num = num % 1000 (345)
// int a3 = num / 100;   // 345/ 100 = 3 
// num -= a3 * 100;  //  345 - 3 * 100 = 45
// int a4 = num / 10;  //  a4  = 45   
// num -= a4 * 10;    //    45 - 4* 10 = 5
// int a5 = num % 10;   //   a5  =  5   (45 % 10 = 5)
// if(a1 == a5 && a2 == a4) {   Console.Write(" Число является палиндромом");}
// else {  Console.Write(" Число  НЕ является палиндромом");}

//************************************************************************************************************************************

Console.Clear();
Console.WriteLine("Введите пятизначное число:  ");
int num = int.Parse(Console.ReadLine()!);  // num = 12345
int num1 = num; 
int revers = 0;
while(num > 0)    // num = 12345
{
revers = revers * 10 + num % 10;  // revers = 0 * 10 + num % 10(12345 % 10 =5) = 5
num /= 10;   //  num =  num / 10 (12345 / 10) = 1234
}
if(num1 == revers) {   Console.Write(" Число является палиндромом");}
else {  Console.Write(" Число  НЕ является палиндромом");}

//************************************************************************************************************

// !!!!!!!!!!!!!!!    Через метод Revers для больших чисел    !!!!!!!!!!!!!!!!!

// Console.Clear();
// Console.Write("Введите число : ");
// int num = int.Parse(Console.ReadLine()!);int Revers(int num){
// int revers = 0;// 54321
// while (num > 0)
// { // num = 0 > 0 54320
// revers = revers * 10 + num % 10; // revers = 5432 * 10 + num%10(1%10 = 1) = 54321
// num /= 10; // num / 10(1/10)
// }// 12345 == 54321
// return revers;
// }
// if (num == Revers(num))
// {
// Console.Write("Да");
// }
// else
// {
// Console.Write("Нет");
// }
//24 Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A
// a = 5
// sum = 1 + 2 + 3 + 4 + 5

Console.Clear();
Console.WriteLine("Введите число:  ");
int n = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма от 1 до {n} равна {GetSum(n)}");
int GetSum(int limit)                   // int - идентификатор, GetSum - название функции/метода,   int limit - параметр функции 
{   
int sum = 0;                             // int sum - переменная которая используется только для этой функции
  for(int i = 0; i <= limit; i++)
  {
  sum +=i;    
  }
  return sum;
}



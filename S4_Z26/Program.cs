// 26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("Введите число:  ");
int s = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр = {CountNumbers(s)}");

int CountNumbers(int n)   // 123     //  CountNumbers - метод типа "счётчик цифр"
{
  int count = 0;          // переменная для подсчёта количества цифр
    if(n < 0)                               ///   Эти строчки 15, 16 на случай если будет введено отрицательное число,  
      n *= (-1);  // n = n * -1             ///   умножив на -1 мы его сделаем положительным.
    while(n > 0)    // 0 > 0                ///   Далее цикл как в 19 задаче
      {                                     ///   На примере числа 123 
      count++;    // count 3                ///   123 > 0 ? да, значит count +1, 123/10 = 12,  12>0 ? да, значит  count +1, 12 /10 = 1, 
      n /= 10;    // n = n / 10    n = 0    ///    1 > 0 ?  да, значит count +1, 1/10 = 0, 0 не больше 0, значит считаем count, 3 , return возвра-
      }                                     ///   щаем значение count.
  return count;
}



//  Ещё вариант
// Console.Write("Введите число s: ");
// int s = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// Console.Clear();
// while (s > 0)
// {
// s /= 10;
// count++;
// }
// Console.WriteLine($"Количество цифр в числе = {count}");




// Console.Write($"Сумма от 1 до {n} равна {GetSum(n)}");
// int GetSum(int limit)                   // int - идентификатор, GetSum - название функции/метода,   int limit - параметр функции 
// {   
// int sum = 0;                             // int sum - переменная которая используется только для этой функции
//   for(int i = 0; i <= limit; i++)
//   {
//   sum +=i;    
//   }
//   return sum;
// }



//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.
//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5
Console.Clear();
Console.WriteLine("Введите число:  ");
int num = int.Parse(Console.ReadLine()!);
Console.Write($"произведение цифр = {GetMultiply(num)}");   // num для работы в функции мы обозвали n

int GetMultiply(int n)                
{   
int result = 1;                 //    нельзя ставить 0 т.к при умножении (факториал) будет всё превращать в ноль
for(int i = 2; i <= n; i++)
  {
  result *=i;
  }
  return result;
}
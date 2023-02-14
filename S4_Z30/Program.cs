//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
// a = new Random().Next()
// Random r = new Random();
// int a = r.Next(0, 2);
// int a = r.Next(2, 10);
// int a = r.Next(2);
//************************************

// Console.Clear();
// Console.Write("Введите число:  ");
// int num = int.Parse(Console.ReadLine()!);
// int[] array = GetBinArray(num);                 
// Console.Write($"[{String.Join(",", array)}]");   /// в {} пишем переменную, у библиотеки String. есть функция Join, она объединяет массив array
//                                                 /// со строкой "," т.е [0,0,0,1,0], если " -> " тогда [0 -> 0 -> 0 -> 1 -> 0]

// int[] GetBinArray(int size){                   /// int[] - мы будем возвращать массив целых чисел, функция наз - GetBinArray(), 
//                                                /// на вход она принимает - int size- целое число - размер массива
//   int[] result  = new int[size];               ///  создали массив [size] на элементов 
//   for(int i = 0 ;i < size ;i++){               /// и циклом перебрали каждый элемент массива result[i] 
//   result[i] = new Random().Next(2);            ///  new Random() - и вложили рандомное число от 0 до 2 - .Next(2), если первое число не указывается, 
//                                               /// оно автоматически считается с 0 включительно, и до 2х не включая 2
//   }
//   return result;
// }
//***************************************

// Eщё вариант
//
// Console.Clear();
// int[] array = new int[8];
// int[] Array(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(0, 2);
// Console.Write($"{array[i]} ");
// }
// return array;
// }
// Array(array);


//   /// вариант массива через цикл   

Console.Clear();
Console.Write("Введите число:  ");
int num = int.Parse(Console.ReadLine()!);
int[] array = GetBinArray(num);                 
Console.Write($"[{String.Join(",", array)}]");   /// в {} пишем переменную, у библиотеки String. есть функция Join, она объединяет массив array
                                                 /// со строкой "," т.е [0,0,0,1,0], если " -> " тогда [0 -> 0 -> 0 -> 1 -> 0]
Console.Write($"[");                              ////       вариант массива через цикл             
for(int i = 0 ;i < num -1 ;i++){                  ////  
  Console.Write($"{array[i]}, ");                 ////
}Console.Write($"{array[num - 1]}]");              ////


int[] GetBinArray(int size){                   /// int[] - мы будем возвращать массив целых чисел, функция наз - GetBinArray(), 
                                               /// на вход она принимает - int size- целое число - размер массива
  int[] result  = new int[size];               ///  создали массив [size] на элементов 
  for(int i = 0 ;i < size ;i++){               /// и циклом перебрали каждый элемент массива result[i] 
  result[i] = new Random().Next(2);            ///  new Random() - и вложили рандомное число от 0 до 2 - .Next(2), если первое число не указывается, 
                                              /// оно автоматически считается с 0 включительно, и до 2х не включая 2
  }
  return result;
}
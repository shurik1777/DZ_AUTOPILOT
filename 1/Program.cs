//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
//натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16
Console.WriteLine("Введите целое число A и нажмите Enter: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число B и нажмите Enter: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < B; i++)
{
    result *= A;
}

Console.WriteLine("Результат возведения числа {0} в степень {1} равен {2}", A, B, result);

//Задача 27: Напишите программу, которая принимает
//на вход число и выдаёт сумму цифр в числе.

//452 -> 11 ; 82 -> 10 ; 9012 -> 12
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number != 0)
{
  sum += number % 10;
  number /= 10;
}
//Задача 29: Напишите программу, которая задаёт массив
//из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] ; 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Введите целое число A и нажмите Enter: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число B и нажмите Enter: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < B; i++)
{
    result *= A;
}

Console.WriteLine("Результат возведения числа {0} в степень {1} равен {2}", A, B, result);
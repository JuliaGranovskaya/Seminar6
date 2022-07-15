// Перевернуть массив
// int[] GenerateRandomArray(int[] RandomArray)
// {
//     for (int i = 0; i < RandomArray.Length; i++)
//     {
//         RandomArray[i] = new Random().Next(1, 10);
//     }
//     return RandomArray;
// }
// void ReversArray1(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length - i - 1];
//         inArray[inArray.Length - i - 1] = k;
//     }
// }
// int[] ReversArray2(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];
//     }
//     return result;
// }

// Console.Clear();

// int[] myarray = new int[5];
// GenerateRandomArray(myarray);
// Console.WriteLine(String.Join(" ", myarray));

// int[] reversArray=ReversArray2(myarray);
// Console.WriteLine(String.Join(" ", reversArray));

// ReversArray1(myarray);
// Console.WriteLine(String.Join(" ", myarray));

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Console.Write("Введите первое значение: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе значение: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье значение: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a + b > c && b + c > a && a + c > b)
// {
//     Console.WriteLine("Треугольник с такими сторонами может существовать");
// }
// else Console.WriteLine("Треугольник существовать не может");

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (num > 0)
{
    num = num / 2;
    i++;
}
int number = i * 2;
double result = 0;
while (i > 0)
{
    result = result + (number % 2) / Math.Pow(10, i);
    i = i - 1;
}
Console.WriteLine(result);
*/

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Если N = {N} -> ");
// int[] array = new int[N];
// array[0] = 0;
// array[1] = 1;
// Console.Write($"{array[0]} {array[1]} ");
// for (int i = 2; i < N; i++)
// {
//     array[i] = array[i - 2] + array[i - 1];
//     Console.Write($"{array[i]} ");
// }

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
// int[] GenerateRandomArray(int[] RandomArray)
// {
//     for (int i = 0; i < RandomArray.Length; i++)
//     {
//         RandomArray[i] = new Random().Next(1, 10);
//     }
//     return RandomArray;
// }
// void SaveArray(int[] Array)
// {
//     int[] ArrayCopy = new int[Array.Length];
//     for (int i = 0; i < Array.Length; i++)
//     {
//         ArrayCopy[i] = Array[i];
//         Console.Write($"{ArrayCopy[i]} ");
//     }
// }

// int[] myarray = new int[5];
// GenerateRandomArray(myarray);
// SaveArray(myarray);

// Домашнее задание

// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
int i = 0;
if (M <= 0)
{
    Console.Write("Введено некорректное значение");
}
else
{
while (M > 0)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    M = M - 1;
    i++;
}
}
int index = 0;
for (int count = 0; count < array.Length; count++)
{
    if (array[count] > 0)
    {
        index++;
    }
}
Console.WriteLine(index);
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2)
{
    if (b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        Console.WriteLine("Прямые паралленьны друг другу");
    }
}
else
{
    double x = (b2 - b1)/(k1 - k2);
    Console.WriteLine($"x = {x}");
    double y = k1 * x + b1;
    Console.WriteLine($"y = {y}");
}
*/

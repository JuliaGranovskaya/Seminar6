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
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// int[] array;
// while (num > 1)
// {
//     if (num % 2 == 0)
//     {
//         array[i] = 0;
//     }
//     else array[i] = 1;
// i++;
// num = num / 2;
// }
// array[i] = 1;
// int[] ReversArray2(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];
//     }
//     return result;
// }
// ReversArray2(array);

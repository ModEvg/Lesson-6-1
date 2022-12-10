/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write($"Введите количество чисел М =");
int M = int.Parse(Console.ReadLine()!);
int[]massiv = new int[M];
int count=0;
for (int i = 0; i<massiv.Length; i++)
    {   
        Console.Write($"{i+1} число равно ");
        massiv[i] = int.Parse(Console.ReadLine()!); // Задаем числа
    }
for (int i = 0; i<massiv.Length; i++)
{
    if (massiv[i]>0)
    count=count+1;
}
Console.Write($"Количество чисел больше 0 равно {count}");

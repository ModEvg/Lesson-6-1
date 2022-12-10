/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Write($"Введите числа b1, k1, b2, k2 \n");

double b1 = chislo("b1");
double k1 = chislo("k1");
double b2 = chislo("b2");
double k2 = chislo("k2");

Console.Write($"Найдем координаты точки пересечения двух прямых y = {k1}*x+{b1} и y = {k2}*x+{b2} \n");

double x;
double y;

x = Math.Round((b2-b1)/(k1-k2),2);
y = Math.Round(k1*x+b1,2);
Console.Write($"Координаты точки перечения равны ({x},{y})");

double chislo (string vv)
{
    Console.Write($"{vv}=");
    double res = double.Parse(Console.ReadLine()!);
    return res;
}
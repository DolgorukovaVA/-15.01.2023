﻿// ЗАДАНИЕ 3: Задать номер четверти, показать диапазоны для возможных координат
// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Введите номер четверти:");

int quarterNum = Convert.ToInt32(Console.ReadLine());
string range = "";

if (quarterNum == 1) range = "x > 0, y > 0";
else if (quarterNum == 2) range = "x < 0, y > 0";
else if (quarterNum == 3) range = "x < 0, y < 0";
else range = "x > 0, y < 0";

Console.WriteLine($"Для {quarterNum}-й четверти координаты точки должны быть заданы в диапазоне ( {range} )");
Console.WriteLine();
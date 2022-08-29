﻿//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
try{
    Console.Write("Введите координаты x1: "); double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты y1: "); double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты z1: "); double z1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты x2: "); double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты y2: "); double y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты z2: "); double z2 = Convert.ToDouble(Console.ReadLine());

    double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine("{0:0.00}", dist);
}
catch { Console.Write("Введите число!"); }
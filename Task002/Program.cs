﻿// Программа, которая принимает на вход три числа и проверяет, может ли существовать 
// треугольник со сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

void PossibleTriangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} существует");
    else
        Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} НЕ существует");
}

PossibleTriangle(5, 3, 6);
PossibleTriangle(3, 6, 6);
PossibleTriangle(5, 5, 5);
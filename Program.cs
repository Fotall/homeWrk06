﻿Console.Write("\nВведите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

for (int i = 1; i <= N; i++)
{
    Console.Write(+i * i * i + "\t");
}

using System;

class Задание2
{
    static void Main()
    {
        Console.Write("Длина окружности = ");
        Console.WriteLine("Диаметр круга = {0:0.000}",
            double.Parse(Console.ReadLine()) / Math.PI);
    }
}
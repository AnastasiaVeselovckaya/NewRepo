using System;

class Program
{
    static void Main()
    {
        Console.Write("Ведите число килограмм: ");
        int m, b;
        m = Convert.ToInt32(Console.ReadLine());
        b = m / 100;
        Console.WriteLine($"Результат:{b} центнеров");
    }
}
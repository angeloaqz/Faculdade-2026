using System;

class Program
{
    static void Main()
    {
        double valorDouble = 10.75;

        int valorInt = (int)valorDouble;

        Console.WriteLine("Valor double: " + valorDouble);
        Console.WriteLine("Valor int após casting: " + valorInt);
    }
}
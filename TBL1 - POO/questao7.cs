//Tipo de valor: int, double, bool
//Tipo de referência: string, arrays, classes

using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = a;

        b = 20;

        Console.WriteLine(a); // 10
        Console.WriteLine(b); // 20
    }
}

using System;

class Pessoa
{
    public string Nome;
}

class Program
{
    static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Angelo";

        Pessoa p2 = p1;

        p2.Nome = "Carlos";

        Console.WriteLine(p1.Nome); // Carlos
    }
}
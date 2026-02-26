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

        Console.WriteLine("Nome em p1: " + p1.Nome);
        Console.WriteLine("Nome em p2: " + p2.Nome);
    }
}
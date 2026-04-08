// Exercicio 1
public class Pessoa
{
    public string Nome;
    public int Idade;
    public string Cargo;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou {Cargo}.");
    }

    public void ExibirSalario()
    {
        if (Cargo == "Gerente")
        {
            Console.WriteLine($"{Nome} (Gerente) - Salário: R$10.000,00");
        }
        else if (Cargo == "Desenvolvedor")
        {
            Console.WriteLine($"{Nome} (Desenvolvedor) - Salário: R$5.000,00");
        }
        else if (Cargo == "Estagiário")
        {
            Console.WriteLine($"{Nome} (Estagiário) - Salário: R$100,00");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome  = "Carlos";
        p1.Idade = 45;
        p1.Cargo = "Gerente";
        p1.Apresentar();

        Pessoa p2 = new Pessoa();
        p2.Nome  = "Ana";
        p2.Idade = 30;
        p2.Cargo = "Desenvolvedor";
        p2.Apresentar();

        Pessoa p3 = new Pessoa();
        p3.Nome  = "João";
        p3.Idade = 20;
        p3.Cargo = "Estagiário";
        p3.Apresentar();

    }
}

// Exercicio 2
public class Fantasminha
{

    public string Habilidade;
    public string Nick;
    public string Cor;

    public void GerarFantasma()
    {
        Console.WriteLine($"Nick:       {Nick}");
        Console.WriteLine($"Cor:        {Cor}");
        Console.WriteLine($"Habilidade: {Habilidade}");
    }

    public void Mover(string direcao)
    {
        Console.WriteLine($"{Nick} se moveu para \"{direcao}\".");
    }
}

// Exercicio 3
public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;
    public void ExibirDados()
    {
        Console.WriteLine($"Produto:    {Nome}");
        Console.WriteLine($"Preço:      R${Preco:}");
        Console.WriteLine($"Quantidade: {Quantidade} unidades");
    }
    public double CalcularValorTotal()
    {
        return Preco * Quantidade;
    }
}

public class Program
{
    public static void Main()
    {
        Produto p1 = new Produto();
        p1.Nome       = "Notebook";
        p1.Preco      = 3500.00;
        p1.Quantidade = 2;

        Produto p2 = new Produto();
        p2.Nome       = "Mouse";
        p2.Preco      = 89.90;
        p2.Quantidade = 5;

        Produto p3 = new Produto();
        p3.Nome       = "Teclado";
        p3.Preco      = 149.99;
        p3.Quantidade = 3;

        Console.WriteLine("VALOR TOTAL");
        Console.WriteLine($"{p1.Nome}: R${p1.CalcularValorTotal():}");
        Console.WriteLine($"{p2.Nome}: R${p2.CalcularValorTotal():}");
        Console.WriteLine($"{p3.Nome}: R${p3.CalcularValorTotal():}");
    }
}

// Exercicio 4
public class ContaBancaria
{
    public string Titular;
    public string NumeroConta;
    public double Saldo;

    public void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depósito de R${valor} realizado. Novo saldo: R${Saldo}");
    }
    public void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor} realizado. Novo saldo: R${Saldo}");
        }
        else
        {
            Console.WriteLine($"Saque negado! Saldo insuficiente. Saldo atual: R${Saldo}");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Titular:      {Titular}");
        Console.WriteLine($"Nº da Conta:  {NumeroConta}");
        Console.WriteLine($"Saldo atual:  R${Saldo}");
    }
}
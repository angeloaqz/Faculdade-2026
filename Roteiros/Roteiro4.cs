// Exercicio 1 
using System.Collections.Generic;
public class Pagamento
{
    public double Valor;
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine($"Processando pagamento genérico de R${Valor}");
    }
}

public class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine($"Pagamento via Cartão de Crédito");
    }
}
public class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine($"Pagamento via Boleto Bancário");
    }
}
public class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine($"Pagamento via Pix");
    }
}

// Exercicio 2
public abstract class Funcionario
{
    public string Nome;
    public string CPF;
    public abstract double CalcularSalario();
}

public class Gerente : Funcionario
{
    public double SalarioBase;
    public double Bonus;

    public Gerente(string nome, string cpf, double salarioBase, double bonus)
        : base(nome, cpf)
    {
        SalarioBase = salarioBase;
        Bonus       = bonus;
    }

    public override double CalcularSalario()
    {
        return SalarioBase + Bonus;
    }
}

public class Programador : Funcionario
{
    public double ValorPorHora;
    public int HorasTrabalhadas;

    public Programador(string nome, string cpf, double valorPorHora, int horasTrabalhadas)
        : base(nome, cpf)
    {
        ValorPorHora      = valorPorHora;
        HorasTrabalhadas  = horasTrabalhadas;
    }
    public override double CalcularSalario()
    {
        return ValorPorHora * HorasTrabalhadas;
    }
}
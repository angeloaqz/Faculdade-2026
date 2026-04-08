// Exercicio 1
public class Animal
{
    public string Nome;
    public virtual void EmitirSom()
    {
        Console.WriteLine($"{Nome} diz: Som genérico do animal");
    }
}

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

// Exercicio 2
public class Item
{
    public string Nome;
    public double Preco;
    public int Quantidade;
    public double CalcularSubtotal()
    {
        return Preco * Quantidade;
    }

    public void ExibirItem()
    {
        Console.WriteLine($"  Item:       {Nome}");
        Console.WriteLine($"  Preço unit: R${Preco:F2}");
        Console.WriteLine($"  Quantidade: {Quantidade}");
        Console.WriteLine($"  Subtotal:   R${CalcularSubtotal()}");
    }
}
public class Pedido
{
    public int NumeroPedido;
    public string Cliente;

    public Item ItemDoPedido;

    public void ExibirPedido()
    {
        Console.WriteLine($"Pedido Nº:  {NumeroPedido}");
        Console.WriteLine($"Cliente:    {Cliente}");
        Console.WriteLine("Item do Pedido");
        ItemDoPedido.ExibirItem();
        Console.WriteLine($"  TOTAL:    R${ItemDoPedido.CalcularSubtotal()}");
    }
}

// Exercicio 3
public interface IVeiculo
{
    void Mover();
}
public class Carro : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("O carro está se movendo.");
    }
}
public class Bicicleta : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("A bicicleta está se movendo.");
    }
}

// Exercicio 4
public interface IVoar
{
    void Voar();
}
public interface INadar
{
    void Nadar();
}
public class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("Posso voar!");
    }

    public void Nadar()
    {
        Console.WriteLine("Tambem posso nadar! 🦆");
    }
}

public class Aguia : IVoar
{
    public void Voar()
    {
        Console.WriteLine("So posso voar!");
    }
}
public class Peixe : INadar
{
    public void Nadar()
    {
        Console.WriteLine("So posso nadar!");
    }
}

// CLASSE PROGRAM
public class Program
{
    public static void Main()
    {
        Pato  pato  = new Pato();
        Aguia aguia = new Aguia();
        Peixe peixe = new Peixe();

        Console.WriteLine("TESTANDO CADA ANIMAL");
        pato.Voar();
        pato.Nadar();

        Console.WriteLine();
        aguia.Voar();

        Console.WriteLine();
        peixe.Nadar();
    }
}
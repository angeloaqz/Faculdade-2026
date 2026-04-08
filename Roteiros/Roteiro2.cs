//  EXERCÍCIO 01
public class Produto
{
    private string _nome;
    private double _preco;
    public Produto(string nome, decimal preco)
    {
        _nome  = nome;
        _preco = preco;
    }

    public string Nome
    {
        get { return _nome; }
    }

    public double Preco
    {
        get { return _preco; }
        set
        {
            if (value >= 0)
            {
                _preco = value;
            }
            else
            {
                Console.WriteLine($"Erro: preço inválido ({value}). O preço não pode ser negativo!");
            }
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Preço:   R${Preco}");
    }
}

// Exercicio 2
public class Carro
{
    private string _modelo;
    private int _velocidadeAtual;

    public string Modelo
    {
        get { return _modelo; }
    }

    public int VelocidadeAtual
    {
        get { return _velocidadeAtual; }
        set
        {
            if (value >= 0)
            {
                _velocidadeAtual = value;
            }
            else
            {
                _velocidadeAtual = 0;
                Console.WriteLine("Velocidade não pode ser negativa. Mantida em 0.");
            }
        }
    }

    public void Acelerar(int valor)
    {
        VelocidadeAtual += valor;
        Console.WriteLine($"{Modelo} acelerou {valor} km/h. Velocidade: {VelocidadeAtual} km/h");
    }

    public void Frear(int valor)
    {
        VelocidadeAtual -= valor;
        Console.WriteLine($"{Modelo} freou {valor} km/h. Velocidade: {VelocidadeAtual} km/h");
    }
}

// Exercicio 3
public class Elevador
{
    private int _andarAtual;
    private int _totalAndares;
    public int AndarAtual
    {
        get { return _andarAtual; }
        set
        {
            if (value < 0)
            {
                _andarAtual = 0;
                Console.WriteLine("Limite inferior atingido. Elevador mantido no térreo (andar 0).");
            }
            else if (value > _totalAndares)
            {
                _andarAtual = _totalAndares;
                Console.WriteLine($"Limite superior atingido. Elevador mantido no andar {_totalAndares}.");
            }
            else
            {
                _andarAtual = value;
            }
        }
    }

    public int TotalAndares
    {
        get { return _totalAndares; }
    }

    public void Subir()
    {
        AndarAtual += 1;
        Console.WriteLine($"Subindo... Andar atual: {AndarAtual}");
    }

    public void Descer()
    {
        AndarAtual -= 1;
        Console.WriteLine($"Descendo... Andar atual: {AndarAtual}");
    }
}
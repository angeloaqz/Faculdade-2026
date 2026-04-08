// Exercicio 1 
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Parte A: Arredondamentos ===\n");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite o {i}º número decimal: ");
            double numero = double.Parse(Console.ReadLine());

            Console.WriteLine($"  Original:  {numero}");
            Console.WriteLine($"  Round:     {Math.Round(numero)}");
            Console.WriteLine($"  Floor:     {Math.Floor(numero)}");
            Console.WriteLine($"  Ceiling:   {Math.Ceiling(numero)}");
            Console.WriteLine($"  Truncate:  {Math.Truncate(numero)}\n");
        }

        Console.WriteLine("=== Parte B: Calculadora de Investimento ===\n");

        Console.Write("Capital inicial (R$): ");
        double capital = double.Parse(Console.ReadLine());

        Console.Write("Taxa de juros mensal (%): ");
        double taxa = double.Parse(Console.ReadLine()) / 100;

        Console.Write("Número de meses: ");
        int meses = int.Parse(Console.ReadLine());

        Console.Write("Meta de lucro (R$): ");
        double meta = double.Parse(Console.ReadLine());

        double montante = capital * Math.Pow(1 + taxa, meses);
        double lucro = Math.Round(montante - capital, 2);

        Console.WriteLine($"\nMontante final: R${montante:F2}");
        Console.WriteLine($"Lucro:          R${lucro:F2}");

        if (lucro >= meta)
            Console.WriteLine($"Meta de R${meta:F2} ATINGIDA!");
        else
            Console.WriteLine($"Meta de R${meta:F2} NÃO atingida. Faltam R${meta - lucro:F2}.");
    }
}

// Exercicio 2 
public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Parte A: Manipulação de Strings ===\n");

        Console.Write("Digite uma frase com espaços no início/fim e palavras separadas por vírgula: ");
        string frase = Console.ReadLine();

        string fraseAjustada = frase.Trim();
        Console.WriteLine($"\nApós Trim: '{fraseAjustada}'");

        string[] partes = fraseAjustada.Split(',');
        Console.WriteLine("\nPalavras após Split:");
        for (int i = 0; i < partes.Length; i++)
            Console.WriteLine($"  [{i}] {partes[i].Trim()}");

        Console.Write("\nDigite a palavra que deseja substituir: ");
        string palavraAntiga = Console.ReadLine();
        Console.Write("Digite a nova palavra: ");
        string palavraNova = Console.ReadLine();

        string fraseSubstituida = fraseAjustada.Replace(palavraAntiga, palavraNova);
        Console.WriteLine($"Após Replace: '{fraseSubstituida}'");

        Console.Write("\nVerificar se a frase começa com qual palavra? ");
        string inicioPalavra = Console.ReadLine();
        Console.WriteLine($"StartsWith('{inicioPalavra}'): {fraseAjustada.StartsWith(inicioPalavra)}");

        Console.Write("Verificar se a frase termina com qual palavra? ");
        string fimPalavra = Console.ReadLine();
        Console.WriteLine($"EndsWith('{fimPalavra}'): {fraseAjustada.EndsWith(fimPalavra)}");

        Console.WriteLine("\n=== Parte B: Validação de CPF ===\n");

        Console.Write("Digite seu CPF (qualquer formato): ");
        string cpf = Console.ReadLine();

        string cpfLimpo = cpf.Replace(".", "").Replace("-", "").Replace(" ", "").Trim();
        Console.WriteLine($"CPF limpo: {cpfLimpo}");
        Console.WriteLine($"Quantidade de dígitos: {cpfLimpo.Length}");

        if (cpfLimpo.Length == 11)
        {
            Console.WriteLine("Tamanho válido: 11 dígitos ✅");

            string primeiroDigito = cpfLimpo.Substring(0, 1);
            bool digitoValido = primeiroDigito == "1" || primeiroDigito == "2" ||
                                primeiroDigito == "3" || primeiroDigito == "4" ||
                                primeiroDigito == "5" || primeiroDigito == "6" ||
                                primeiroDigito == "7" || primeiroDigito == "8" ||
                                primeiroDigito == "9";

            Console.WriteLine($"Começa com dígito válido ({primeiroDigito}): {(digitoValido ? "✅" : "❌")}");

            string cpfFormatado = cpfLimpo.Substring(0, 3) + "." +
                                  cpfLimpo.Substring(3, 3) + "." +
                                  cpfLimpo.Substring(6, 3) + "-" +
                                  cpfLimpo.Substring(9, 2);
            Console.WriteLine($"CPF formatado: {cpfFormatado}");
        }
        else
        {
            Console.WriteLine("CPF inválido: não tem 11 dígitos ❌");
        }
    }
}

// Exercicio 3
public class Program
{
    public static void Main()
    {
        string[] nomes = new string[3];
        double[] precos = new double[3];
        int[] quantidades = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Nome do produto {i + 1}: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"Preço do produto {i + 1}: ");
            precos[i] = double.Parse(Console.ReadLine());

            Console.Write($"Quantidade do produto {i + 1}: ");
            quantidades[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine($"{"Produto",-15} {"Preço",10} {"Qtd",5} {"Total",12}");
        Console.WriteLine(new string('-', 45));

        double subtotal = 0;

        for (int i = 0; i < 3; i++)
        {
            double total = precos[i] * quantidades[i];
            subtotal += total;
            Console.WriteLine($"{nomes[i],-15} {precos[i],10:F2} {quantidades[i],5} {total,12:N2}");
        }

        double desconto = subtotal * 0.10;
        double totalFinal = subtotal - desconto;

        Console.WriteLine(new string('-', 45));
        Console.WriteLine($"{"Subtotal:",-32} {subtotal,12:N2}");
        Console.WriteLine($"{"Desconto 10%:",-32} {desconto,12:N2}");
        Console.WriteLine($"{"Total Final:",-32} {totalFinal,12:N2}");
    }
}

// Exercicio 4
public class Program
{
    public static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a data e hora do compromisso (dd/MM/yyyy HH:mm): ");
        DateTime compromisso = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);

        DateTime hoje = DateTime.Now;
        int diasFaltando = (compromisso - hoje).Days;

        string diaSemana = compromisso.DayOfWeek switch
        {
            DayOfWeek.Monday    => "segunda-feira",
            DayOfWeek.Tuesday   => "terça-feira",
            DayOfWeek.Wednesday => "quarta-feira",
            DayOfWeek.Thursday  => "quinta-feira",
            DayOfWeek.Friday    => "sexta-feira",
            DayOfWeek.Saturday  => "sábado",
            DayOfWeek.Sunday    => "domingo",
            _ => ""
        };

        string mensagem = string.Format(
            "Olá, {0}!\nSeu compromisso será em {1} dias, na {2}.\nData marcada: {3} às {4}",
            nome,
            diasFaltando,
            diaSemana,
            compromisso.ToString("dd/MM/yyyy"),
            compromisso.ToString("HH:mm")
        );

        Console.WriteLine("\n" + mensagem);
    }
}

// Exercicio 5
public class Program
{
    public static void Main()
    {
        Console.Write("Nome do evento: ");
        string nome = Console.ReadLine();

        Console.Write("Data do evento (dd/MM/yyyy): ");
        DateTime dataEvento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.Write("Valor do ingresso (R$): ");
        double valor = double.Parse(Console.ReadLine());

        Console.Write("Categoria (VIP/Comum): ");
        string categoria = Console.ReadLine().ToUpper().Trim();

        while (!categoria.Contains("VIP") && !categoria.Contains("COMUM"))
        {
            Console.Write("Categoria inválida! Digite VIP ou Comum: ");
            categoria = Console.ReadLine().ToUpper().Trim();
        }

        int diasRestantes = (dataEvento - DateTime.Now).Days;

        double desconto = categoria.Contains("VIP") ? 0.10 : 0.05;
        double valorComDesconto = Math.Round(valor - (valor * desconto), 2);

        Console.WriteLine();
        Console.WriteLine(new string('=', 40));
        Console.WriteLine(string.Format("{0,-20} {1,18}", "INGRESSO", ""));
        Console.WriteLine(new string('=', 40));
        Console.WriteLine(string.Format("{0,-15} {1,24}", "Evento:", nome));
        Console.WriteLine(string.Format("{0,-15} {1,24}", "Data:", dataEvento.ToString("dd/MM/yyyy")));
        Console.WriteLine(string.Format("{0,-15} {1,24}", "Categoria:", categoria));
        Console.WriteLine(string.Format("{0,-15} {1,24:C}", "Valor original:", valor));
        Console.WriteLine(string.Format("{0,-15} {1,24}", "Desconto:", $"{desconto * 100}%"));
        Console.WriteLine(string.Format("{0,-15} {1,24:C}", "Valor final:", valorComDesconto));
        Console.WriteLine(string.Format("{0,-15} {1,24}", "Dias restantes:", diasRestantes));
        Console.WriteLine(new string('=', 40));
    }
}
object obj = "123";

if (int.TryParse(obj.ToString(), out int x))
{
    Console.WriteLine(x);
}
else
{
    Console.WriteLine("Valor inválido");
}
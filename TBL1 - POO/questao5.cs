string s1 = "Olá";
string s2 = "Olá";
string s3 = new string("Olá");

Console.WriteLine(s1 == s2);
Console.WriteLine(s1 == s3);
Console.WriteLine(object.ReferenceEquals(s1, s2));
Console.WriteLine(object.ReferenceEquals(s1, s3));

// Saída esperada:
// True
// True
// False

// True, pois s1 e s2 têm o mesmo conteúdo
// True, pois s1 e s3 têm o mesmo conteúdo
int[] numeros1 = {1, 2, 3};
int[] numeros2 = numeros1;

numeros2[0] = 100;

Console.WriteLine(numeros1[0]);

// Saída esperada:
// 100, pois numeros1 e numeros2 referenciam o mesmo array na memória
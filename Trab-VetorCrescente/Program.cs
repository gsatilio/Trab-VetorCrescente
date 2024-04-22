int[] numeros = new int[5];
int[] numerosantes = new int[5];
int valor, vetor = 5;

while (true)
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Informe o {i + 1}o numero a ser inserido:");
        numeros[i] = int.Parse(Console.ReadLine());
        numerosantes[i] = numeros[i];
    }

    // pega o primeiro indice dos vetores
    for (int i = 0; i < vetor; i++)
    {
        // compara esse indice com os outros indices, precisa comparar 5x cada indice (ou seja, 25 verificacoes no total)
        for (int j = i; j < vetor; j++)
        {
            // se valor do vetor J for menor que do vetor I, realiza a troca de posições
            if (numeros[i] > numeros[j])
            {
                valor = numeros[i];
                numeros[i] = numeros[j];
                numeros[j] = valor;
            }
        }
    }

    Console.WriteLine("Vetor antes de organizar:");
    for (int i = 0; i < 5; i++)
    {
        Console.Write(numerosantes[i] + " ");
    }
    Console.WriteLine("\nVetor após de organizar:");
    for (int i = 0; i < 5; i++)
    {
        Console.Write(numeros[i] + " ");
    }
    Console.ReadKey();
    Console.Clear();
}
//3 4 7 2 1
//3 4 7 2 1

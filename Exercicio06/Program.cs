// 1 - Criar um vetor de valores inteiros.
// 2 - Percorrer o vetor com uma laço .
// 3 - Gerar um valor aleatório em C#. 
// 4 - Ordenar o vetor usando Bubble Sort.
//////////////////////////////////////////////

using System.Collections.Specialized;

int tamanho = 10;
int[] valores = new int[tamanho];


Random ramdom = new Random();
    
for (int i = 0; i < tamanho; i++)
{
    valores[i] = ramdom.Next(10);

    Console.Write(" | " + valores[i]);
}

    Console.Write(" | ");

    bool troca = false;

do
{
    troca = false;
        
    for (int i = 0; i < valores.Length - 1; i++)
    {
        if (valores[i] > valores[i + 1])
        {
            troca = true;
            int aux = valores[i];
            valores[i] = valores[i + 1];
            valores[i + 1] = aux;

        }
    }
} while (troca == true);

Console.Write("\n\n");

    for (int i = 0; i < valores.Length; i++)
    {
        Console.Write(" | " + valores[i]);
    }
    Console.Write(" | ");
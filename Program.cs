// Exercício curso Nélio Alves "Numeros Pares Vetor"
// Criar um vetor de numeros aleatorio, depois mostrar na tela es números pares e a quantidade de numeros pares.

int N = int.Parse(Console.ReadLine());
int [] Num = new int[N];
string[] X = Console.ReadLine().Split(' ');

// Comando para leitura de números na mesma linha;
for (int i = 0; i < N; i++)
{
    Num[i] = int.Parse(X[i]);
}
// Comando para mostrar na tela apenas os números pares;
for (int i = 0; i < N; i ++)
{
    if (Num[i] % 2 == 0)
    Console.Write(Num[i] + " ");
}
// Coamndo para pazer a contagem dos números pares;
int Cont = 0;
for (int i = 0; i < N; i ++)
{
    if (Num[i] % 2 == 0)
    {
        Cont ++;
    }  
}
Console.WriteLine("\n" + Cont);
using System;

class Program
{
    static void Main(string[] args)
    {
        // Array de números (senha)
        int[] listaNumeros = { 5, 6, 4, 13 };

        Console.WriteLine("Digite 4 números separados por espaço:");
        string[] entrada = Console.ReadLine().Split(' ');

        // Verifica se o usuário digitou 4 números
        if (entrada.Length != listaNumeros.Length)
        {
            Console.WriteLine("Você deve digitar exatamente 4 números.");
            return;
        }

        // continação
        // Nome: Miguel Parrado  RM: 554007
        int[] numeros = new int[listaNumeros.Length];

        
        for (int i = 0; i < listaNumeros.Length; i++)
        {
            numeros[i] = int.Parse(entrada[i]);
        }

        
        for (int i = 0; i < listaNumeros.Length; i++)
        {
            if (numeros[i] != listaNumeros[i])
            {
                Console.WriteLine("senha incorreta, tente novamente");
                return;
            }
        }

        Console.WriteLine("senha correta, bem vindo");
    }
}

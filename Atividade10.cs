//Ref. (5 pontos)
//10 - Escreva um programa que leia um número e verifique se ele é par ou ímpar.

public static class Atividade10
{
    public static void Executar()
    { 
        int numero;

        Console.WriteLine("Digite um número: ");
        numero = int.Parse(Console.ReadLine()!);
        Console.Clear(); 

        if (numero%2 == 0)
        {
            Console.WriteLine("Este número é par.");
        }
        else
        {
            Console.WriteLine("Este número é ímpar.");
        }
    }
    
}

//Ref. (5 pontos)
//9 - Escreva um programa que leia um número e verifique se ele é positivo,
//negativo ou zero.
public static class Atividade9
{
    public static void Executar()
    { 

        Console.WriteLine("Digite um número: ");
        double numero = double.Parse(Console.ReadLine()!);

        if (numero > 0)
        {
            Console.WriteLine("Este número é positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("Este número é negativo.");
        }
        else
        {
            Console.WriteLine("Número é igual a zero");
        }
    }
    
}

using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos anos você tem?");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar.");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

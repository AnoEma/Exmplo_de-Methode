using System;

namespace Locura
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();

            Console.WriteLine("Vamos comparar as idade de voces");
            Console.WriteLine();
            Console.Write("Digite seu Nome : ");
            p1.Nome = Console.ReadLine();
            Console.Write("Seu idade : ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.Write("Digite seu Nome : ");
            p2.Nome = Console.ReadLine();
            Console.Write("Seu idade : ");
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade > p2.Idade)
            {
                Console.WriteLine(p1.Nome + " voce é maior de idade");
            }
            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine(p2.Nome + " voce é de menor idade");
            }
        }
    }
}

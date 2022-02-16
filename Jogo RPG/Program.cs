using System;
using Jogo_RPG.src.Entities;

namespace Jogo_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 12, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            // Reflete o polimorfismo, passando o int 3 como parâmetro
            Console.WriteLine(wizard.Attack(8));
        }
    }
}

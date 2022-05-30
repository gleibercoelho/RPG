using System;
using dungeons_dio.src.entities;

namespace dungeons_dio
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Warrior");
            Wizard wizard = new Wizard("Mystic", 24, "Light Wizard");
            Ninja ninja = new Ninja("Kennem", 23, "Dark Ninja");
            Knight knight = new Knight("Gaia", 22, "Knight");

            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(arus.Attack());
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(knight.Attack());
            Console.WriteLine(wizard.Attack(3));
        }
    }
}

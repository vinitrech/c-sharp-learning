using System;

namespace WarriosFightToTheDeath
{
    public class Program
    {
        static void Main(string[] args)
        {
            Warrior askeladd = new Warrior("Askeladd", 100, 9, 9);
            SwiftWarrior thorfinn = new SwiftWarrior("Thorfinn", 70, 8, 8, 50);

            Battle.StartFight(askeladd, thorfinn);
        }
    }
}
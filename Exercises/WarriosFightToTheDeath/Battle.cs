namespace WarriosFightToTheDeath
{
    class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warriorAAttack = warriorA.Attack();
            double warriorBBlock = warriorB.Block();

            double totalDamageToWarriorB = warriorAAttack - warriorBBlock;

            if (totalDamageToWarriorB > 0)
            {
                warriorB.Health -= totalDamageToWarriorB;
                Console.WriteLine("{0} attacks {1} and deals {2} total damage!", warriorA.Name, warriorB.Name, totalDamageToWarriorB);
            }
            else
            {
                totalDamageToWarriorB = 0;
                Console.WriteLine("{0} attacks {1} and {1} blocked!", warriorA.Name, warriorB.Name);
            }

            if (warriorB.Health < 1)
            {
                Console.WriteLine("{0} has died. {1} is victorious!\n", warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else
            {
                Console.WriteLine("{0} has {1} health.\n", warriorB.Name, warriorB.Health);
            }

            return "";
        }
    }
}
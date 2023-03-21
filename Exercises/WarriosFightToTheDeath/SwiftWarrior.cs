namespace WarriosFightToTheDeath
{
    class SwiftWarrior : Warrior
    {
        int dodgeChance = 0;
        CanDodge canDodge = new CanDodge();

        public SwiftWarrior(string name = "Warrior", double health = 0, double attack = 0, double block = 0, int dodgeChance = 0) : base(name, health, attack, block)
        {
            this.dodgeChance = dodgeChance;
        }

        public override double Block()
        {
            Random rand = new Random();
            int randomDodgeChance = rand.Next(1, 100);

            if (randomDodgeChance < this.dodgeChance)
            {
                Console.WriteLine($"{Name} {canDodge.Dodge()}");
                return 10000;
            }
            else
            {
                return base.Block();
            }
        }
    }
}
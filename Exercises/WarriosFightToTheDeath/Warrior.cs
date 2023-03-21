namespace WarriosFightToTheDeath
{

    class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttackMaximum { get; set; }
        public double BlockMaximum { get; set; }

        Random rand = new Random();

        public Warrior(string name = "Warrior", double health = 0, double attack = 0, double blockMaximum = 0)
        {
            this.Name = name;
            this.Health = health;
            this.AttackMaximum = attack;
            this.BlockMaximum = blockMaximum;
        }

        public double Attack()
        {
            return rand.Next(1, (int)AttackMaximum);
        }

        public virtual double Block()
        {
            return rand.Next(1, (int)BlockMaximum);
        }
    }
}
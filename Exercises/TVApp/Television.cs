namespace TVApp
{
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }

        public void Off()
        {
            Console.WriteLine("The TV is off");
        }

        public void On()
        {
            Console.WriteLine("The TV is ON");
        }

        public void VolumeDown()
        {
            if (Volume > 0)
            {
                Volume--;
                Console.WriteLine("The volume is down: {0}", Volume);
            }
            else
            {
                Console.WriteLine("The volume is 0");
            }
        }

        public void VolumeUp()
        {
            if (Volume < 50)
            {
                Volume++;
                Console.WriteLine("The volume is up: {0}", Volume);
            }
            else
            {
                Console.WriteLine("The volume is 50");
            }
        }
    }
}
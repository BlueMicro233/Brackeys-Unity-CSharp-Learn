namespace exercise3
{
    // Xen (environment) character
    class Xen
    {
        // Generic (public) entity
        public string name;
        public int attackSlots;
        public int health;

        // Action definition: Attack
        public void Attack()
        {
            if (attackSlots > 0)
            {
                Console.WriteLine(name + " is attacking");
                attackSlots--;
            }
            else
            {
                Console.WriteLine(name + "cannot attack anymore!");
            }
        }

        // Player
        class Player
        {
            public float playerHealth;
            public int protectiveAttackSlot;
            public string name;

            public void protectiveAttack()
            {
                if (protectiveAttackSlot > 0)
                {
                    Console.WriteLine("PLZ countine your attack! \n");
                }
                else
                {
                    Console.WriteLine("You cannot attack anymore! \n");
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Headcrab
                Xen headcrab = new Xen();
                headcrab.name = "Headcrab";
                headcrab.attackSlots = 5;
                headcrab.health = 5;

                // Me
                Player brownie = new Player();
                brownie.name = "Brownie";
                brownie.playerHealth = 100;
                brownie.protectiveAttackSlot = 2;


                // action

                Console.WriteLine(brownie.name + "! Press Enter to attack!");

                int i = 0;
                for (i = 5; i > 0; i--)
                {
                    Console.ReadKey();
                    brownie.protectiveAttack();
                    headcrab.health--;
                    Console.WriteLine("You caused an effective attack!");
                    Console.WriteLine("\n" + headcrab.name + " has " + headcrab.health + " health left");
                }

                Console.WriteLine("Headcrab has been dead!");
                Console.ReadKey();
            }
        }
    }
}

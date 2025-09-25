namespace exercise3
{
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
    // Xen character
    class Xen
    {
        // Generic (public) entity
        public string name;
        public int attackSlots;
        public float health;

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

        class Program
        {
            static void Main(string[] args)
            {
                // Headcrab
                Xen headcrab = new Xen();
                headcrab.name = "Headcrab";
                headcrab.attackSlots = 5;
                headcrab.health = 30;

                // Me
                Player brownie = new Player();
                brownie.name = "Brownie";
                brownie.playerHealth = 100;
                brownie.protectiveAttackSlot = 2;
                
                Console.WriteLine(brownie.name + "! Press Enter to attack!");
                Console.ReadKey();
                brownie.protectiveAttack();
                Console.WriteLine("You caused an effective attack!");
                
                Console.WriteLine(headcrab.name + " has " + headcrab.health + " health left");

                Console.ReadKey();
            }
        }
    }
}

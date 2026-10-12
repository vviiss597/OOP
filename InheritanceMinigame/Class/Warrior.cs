namespace InheritanceMinigame.Classes
{
    public class Warrior : Character
    {
        public int ShieldBlock {get; set;} =4;
        //:base(...)
        public Warrior(string name) : base(name, 120, 15){}
        //set initial value (120hp, 15 attack)

        //Override :
        public override void PerformAttack(Character target)
        {
            Console.WriteLine($"{Name} swings a heavy grestsword at {target.Name}");
            target.TakeDamage(AttackPower);
        }

        public override void TakeDamage(int damage)
        {
            int finalDamage = Math.Max(1, damage -ShieldBlock);
            Console.WriteLine($"{Name} blocks {ShieldBlock} damage with their shield!");
            base.TakeDamage(finalDamage);
        }
    }
}
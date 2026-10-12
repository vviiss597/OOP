namespace InheritanceMinigame.Classes
{
    public class Character
    {
        //string can =not be null
        public string? Name { get; set; } //auto
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int AttackPower { get; set; }

        public bool IsAlive => Health > 0; //read
        
        //Protected : 
        protected Character(string? name, int health, int attackPower)
        {
            //initialization the method
            Name = name;
            MaxHealth = health;
            Health = health;
            AttackPower = attackPower;
        }

        //Virtual : 
        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            
            if (Health < 0)
                Health = 0;
            
            Console.WriteLine($"{Name} takes {damage} damage! (HP: {Health}/{MaxHealth})");
        }

        public virtual void PerformAttack(Character target) { }
    }
}

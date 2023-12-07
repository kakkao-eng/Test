using System;

namespace Test1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Character[] characters = new Character[]
            {
                new Player("Earth" , 100 , "momo"),
                new Enemy("Banana", 10 , "slide")
            };

            foreach (var character in characters)
            {
                character.Displaylnfo();
                character.PerformAttack();
                character.Attack();
                character.Attack(Character.AttackType.Basic);
                character.Attack(Character.AttackType.Speclal);
                character.Attack(Character.AttackType.Uitimate);
            }
        }
    }
    
    public abstract class Character
    {
        public string Name  { get; set; }
        public int Heath  { get; set; }
        protected string Type;

        public enum AttackType
        {
            Basic,Speclal,Uitimate
        }
        

        public Character(string name , int heath , string type)
        {
            Name = name;
            Heath = heath;
            Type = type;
        }

        public void Displaylnfo()
        {
            Console.WriteLine($"{Name} {Heath} {Type} ");
        }

        public abstract void PerformAttack();

        public void Attack()
        {
                Console.WriteLine($"{Name} performs a Attack");
        }

        public void Attack(AttackType attackType)
        {
            Console.WriteLine($"{attackType}");
            
        }
    }

    public class Player : Character
    {
        public Player(string name, int health, string type) : base(name, health, type)
        {
            Displaylnfo();
            Attack();
            Attack(AttackType.Basic);
        }
        
        
        
        public override void PerformAttack()
        {
            Console.WriteLine($"{Name} attacks with a bow");
        }
    }

    public class Enemy : Character
    {
        
        public Enemy(string name, int health, string type) : base(name, health, type)
        {
            Displaylnfo();
            Attack();
            PerformAttack();
            
        }
        
        
        
        
        public override void PerformAttack()
        {
            Console.WriteLine($"{Name} attacks with a sound");
        }
    }
    
    
    
    
    
    
    
}
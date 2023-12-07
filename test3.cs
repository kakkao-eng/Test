using System;
using System.Xml;

namespace Test3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Character[] characters = new Character[]
            {
                new Player("Earth" , 100 , "momo")
            };

            foreach (var character  in characters)
            {
                character.Displaylnfo();
                character.Attack();
                character.Attack(Character.Attacktype.Basic);
                character.PerformAttack();
            }

        }
    }

    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        protected string Type;

        public enum Attacktype
        {
            Basic,
            Special,
            Ultimate
        }

        public Character(string name, int health, string type)
        {
            Name = name;
            Health = health;
            Type = type;
        }

        public void Displaylnfo()
        {
            Console.WriteLine($"{Name} {Health} {Type}");
        }

        public abstract void PerformAttack();

        public void Attack()
        {
            Console.WriteLine($"{Name} Attack");
        }

        public void Attack(Attacktype attacktype)
        {
            Console.WriteLine($"{attacktype}");
        }
    }

    public class Player : Character
    {
        public Player(string name, int health, string type) : base(name, health, type)
        {
            
        }

        public override void PerformAttack()
        {
            Console.WriteLine($"{Name} Bow");
        }
        
        
    }
    
    
}
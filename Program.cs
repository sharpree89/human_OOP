using System;

namespace ConsoleApplication
{
    public class Human
    {
        public string name;
        public int strength = 3;
        public int intel = 3;
        public int dext = 3;
        public int health = 100;
        public Human(string val)
        {
            name = val;

        }
        public Human(string a, int b, int c, int d, int e)
        {
            name = a;
            strength = b;
            intel = c;
            dext = d;
            health = e;

        }
        public int Attack(Human user)
        {
            Console.WriteLine(name + " is attacking " + user.name);
            int damage = strength * 5;
            user.health -= damage;
            Console.WriteLine(user.name + " receives " + damage + " damage and has " + user.health + " HP left!");
            return (int)health;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Human humanA = new Human("Preeya");
            Console.WriteLine($"My new human is named {humanA.name}");
            Console.WriteLine($"{humanA.name} has {humanA.health} health");
            Human humanB = new Human("Bilbo", 5, 5, 5, 50);
            Console.WriteLine($"My new human is named {humanB.name}");
            Console.WriteLine($"{humanB.name} has {humanB.health} health");
            humanB.Attack(humanA);
        }
    }
}

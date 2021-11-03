using System;

namespace Bees
{
    class Program
    {
        static void Main(string[] args)
        {
            Beehive Hive1 = new Beehive(4);
            Hive1.AddBee(new Bee("John", 3.2F));
            Hive1.AddBee(new Bee("Paul", 2.7F));
            Hive1.AddBee(new Bee("George", 1.1F));
            Hive1.AddBee(new Bee("Ringo", 2.0F));


            Beehive Hive2 = new Beehive(3);
            Hive2.AddBee(new Bee("Kurt", 2.3F));
            Hive2.AddBee(new Bee("Dave", 7.4F));
            Hive2.AddBee(new Bee("Krist", 1.5F));


            Console.WriteLine($"Hive 1 has {Hive1.Bees.Count} bees");
            Console.WriteLine($"Hive 2 has {Hive2.Bees.Count} bees");
            
            Console.WriteLine($"Bees in Hive 1 have {Hive1.CollectHoney(5)} honey from 5 days");
            Console.WriteLine($"Bees in Hive 2 have {Hive1.CollectHoney(9)} honey from 9 days");

        }
    }

}
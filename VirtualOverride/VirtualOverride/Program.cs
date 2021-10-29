using System;

namespace VirtualOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public string[] inventory;

        class Armor : Equipment
        {
            public int defense;
            public override void Equip()
            {
                defense = 15;
            }
        }

        class Weapon : Equipment
        {
            public int attack;
            public override void Equip()
            {
                attack = 15;
            }
        }

        /* class Money : Pickup
        {
            public override void AddToInventory()
            {
                 
            }
        } */

        abstract class Pickup
        {
            public abstract void AddToInventory(string item);
        }

        abstract class Equipment
        {
            public abstract void Equip();
        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {

        private class Enemy
        {
            public int health {get; private set;}
            public Enemy(int _health)
            {
                health = _health;
            }
        }
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy(100);
        }
    }
}

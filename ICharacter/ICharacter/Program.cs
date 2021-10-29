using Interfaces.Smash;
using System;

namespace ICharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class CPUController : ICharacterController
    {
        public void SetCharacter(string ICharacter)
        {

        }

        public void Logic(float frametime)
        {

        }
    }

    class PlayerController : ICharacterController
    {
        public void SetCharacter(string ICharacter)
        {

        }

        public void Logic(float frametime)
        {

        }
    }
}

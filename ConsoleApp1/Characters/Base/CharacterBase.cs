using ConsoleApp1.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Characters
{
    class CharacterBase
    {
        protected string Name;

        public IMovable MovementMode { get; set; }

        private bool _flyingMagic = false;

        public CharacterBase(string name)
        {
            Name = name;    
        }

        public void ApplyFlyingMagic()
        {
            Console.WriteLine("Applying flying magic for " + Name);
            if (MovementMode is WalkingMovement)
            {
                MovementMode = new FlyingMovement();
                _flyingMagic = true;
            }
            Console.WriteLine();
        }

        public void EndFlyingMagic()
        {
            Console.WriteLine("Ending flying magic for " + Name);
            if (_flyingMagic)
            {
                MovementMode = new WalkingMovement();
                _flyingMagic = false;
            }
            Console.WriteLine();
        }

        public void Move()
        {
            Console.WriteLine(Name + ": ");
            MovementMode.Move();
            Console.WriteLine();
        }
    }
}

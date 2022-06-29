using ConsoleApp1.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Characters
{
    class Pegas : CharacterBase
    {
        public Pegas(string name, IMovable movementMode) : base(name)  
        {
            MovementMode = movementMode;
        }

        public void ChangeMovementMode()
        {
            if (MovementMode is WalkingMovement)
            {
                MovementMode = new FlyingMovement();
            }
            else
            {
                MovementMode = new WalkingMovement();
            }
            Console.WriteLine(Name + " changed their movement mode\n");
        }
    }
}

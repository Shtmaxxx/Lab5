using ConsoleApp1.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Characters
{
    class Harpy : CharacterBase
    {
        public Harpy(string name) : base(name)
        {
            MovementMode = new FlyingMovement();
        }
    }
}

using ConsoleApp1.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Characters
{
    class Vampire : CharacterBase
    {
        public Vampire(string name) : base(name)
        {
            MovementMode = new WalkingMovement();
        }
    }
}

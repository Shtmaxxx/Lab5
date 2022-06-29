using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategies
{
    class FlyingMovement : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Performing Flying Movement...");
        }
    }
}

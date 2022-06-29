using ConsoleApp1.Characters;
using ConsoleApp1.Strategies;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ork = new Ork("Ork");
            var troll = new Troll("Troll");
            var pegas = new Pegas("Pegas", new WalkingMovement());
            var vampire = new Vampire("Vampire");
            var harpy = new Harpy("Harpy");

            ork.Move();
            harpy.Move();
            vampire.Move();

            troll.Move();
            troll.ApplyFlyingMagic();
            troll.Move();
            troll.EndFlyingMagic();
            troll.Move();

            pegas.Move();
            pegas.ChangeMovementMode();
            pegas.Move();
            pegas.ChangeMovementMode();
            pegas.Move();
        }
    }
}

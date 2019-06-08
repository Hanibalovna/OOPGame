using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace OOPGame
{
    class ArcanoidGameEngine : GameEngine

    {
        public int FieldWidth { get;}
        public int FieldHeight { get;}
        
        public ArcanoidGameEngine(ConsoleGraphics graphics, int fileWidth, int fieldHeight) : base(graphics)
        {
            FieldWidth = fileWidth;
            FieldHeight = fieldHeight;
            var arcanoid = new Arcanoid(graphics);
            var ball = new Ball(graphics, arcanoid);
            AddObject(arcanoid);
            AddObject(ball);
            AddObject(new Bricks(graphics));
        }
    }
}

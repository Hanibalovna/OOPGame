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
        public int FieldWidth { get; }
        public int FieldHeight { get; }
        private Brick brick;

        public ArcanoidGameEngine(ConsoleGraphics graphics, int fileWidth, int fieldHeight, Brick brick) : base(graphics)
        {
            FieldWidth = fileWidth;
            FieldHeight = fieldHeight;
            this.brick = brick;
            var arcanoid = new Arcanoid(graphics);
            AddObject(arcanoid);
           var bricks = new List<Brick>();
            for (int i = 0; i < brick.brickCount; i++)
            {
                AddObject(new Brick(graphics, 128 + brick.BrickPositionX * i, 0));
                AddObject(new Brick(graphics, 96 + brick.BrickPositionX * (i-1), 36));
            }
            var ball = new Ball(graphics, arcanoid);
            AddObject(ball);
        }
 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace OOPGame
{
    class Brick : IGameObject
    {
        private ConsoleGraphics graphics;
        public ConsoleImage ImgBrick { get; set; }
        private object BrickOne;
        public int BrickPositionX { get; set; }
        public int BrickPositionY { get; set; }
        public int CountBricks;

        public Brick(ConsoleGraphics graphics)
        {
            this.graphics = graphics;
            ImgBrick = graphics.LoadImage("element_blue.png");
        }

        void IGameObject.Render(ConsoleGraphics graphics)
        {
            graphics.DrawImage(ImgBrick, 0, 0);           
        }

        void IGameObject.Update(GameEngine engine)
        {
            
        }
    }
}

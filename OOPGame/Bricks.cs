using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace OOPGame
{
    class Bricks : IGameObject
    {
        private ConsoleImage img;

        public Bricks(ConsoleGraphics graphics)
        {
            img = graphics.LoadImage("element_blue.png");
        //    img = graphics.LoadImage("element_green.png");
        //    img = graphics.LoadImage("element_purple.png");
        //    img = graphics.LoadImage("element_red.png");
        }
        void IGameObject.Render(ConsoleGraphics graphics)
        {
            graphics.DrawImage(img, 100, 0);

        }

        void IGameObject.Update(GameEngine engine)
        {

        }
    }
}

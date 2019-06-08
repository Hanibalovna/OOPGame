using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace OOPGame
{
    class Arcanoid : IGameObject
    {
        private ConsoleGraphics graphics;
        private ConsoleImage img;
        private int speedX, speedY;
        private int x, y;

        public Arcanoid(ConsoleGraphics graphics)
        {
            this.graphics = graphics;
            img = graphics.LoadImage("paddleBlue.png");
            x = graphics.ClientWidth / 2 - img.Width / 2;
            y = graphics.ClientWidth / 2 - img.Height/2;
        }
        void IGameObject.Render(ConsoleGraphics graphics)
        {
            graphics.DrawImage(img, x, y);
        }

        void IGameObject.Update(GameEngine engine)
        {
            var arcanoidGameEngine = (ArcanoidGameEngine)engine;

            if ((Input.IsKeyDown(Keys.RIGHT)) && x < graphics.ClientWidth- img.Width)
                speedX = 15;
            else if ((!Input.IsKeyDown(Keys.RIGHT)) || x > graphics.ClientWidth- img.Width )
                speedX = 0;
            if ((Input.IsKeyDown(Keys.LEFT))&& (x > 0))
                speedX = -15;
            x += speedX;

        }
    }
}

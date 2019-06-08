using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace OOPGame
{
    class Ball : IGameObject
    {
        private ConsoleGraphics graphics;
        private ConsoleImage img;
        private Arcanoid arcanoid;
        private int speedX, speedY;
        private int x, y;

        public Ball(ConsoleGraphics graphics, Arcanoid arcanoid)
        {
            this.graphics = graphics;
            this.arcanoid = arcanoid;
            img = graphics.LoadImage("ballBlue.png");
            x = graphics.ClientWidth / 2 - img.Width / 2;
            y = graphics.ClientWidth / 2 - img.Height*2;
        }
        void IGameObject.Render(ConsoleGraphics graphics)
        {
            graphics.DrawImage(img, x, y);
        }

        void IGameObject.Update(GameEngine engine)
        {
            if (Input.IsKeyDown(Keys.SPACE))
            {
                speedX = 10;
                speedY = -10;
            }
            if (x > graphics.ClientWidth - img.Width )
            {
                speedX = -10;
                speedY = -10;
            }
            else if(y<0)
            {
                speedX = -10;
                speedY = 10;
            }
            else if(x<0)
            {
                speedX = 10;
                speedY = 10;
            }
            x += speedX;
            y += speedY;
            x %= graphics.ClientWidth;
            y %= graphics.ClientHeight;
        }
    }
}

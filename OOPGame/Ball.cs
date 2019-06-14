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
        public int BallPositionX { get; set; }
        public int BallPositionY { get; set; }
        private bool IsGameBegin;

        public Ball(ConsoleGraphics graphics, Arcanoid arcanoid)
        {
            this.graphics = graphics;
            this.arcanoid = arcanoid;
            img = graphics.LoadImage("ballBlue.png");
            BallPositionX = graphics.ClientWidth / 2 - img.Width / 2;
            BallPositionY = graphics.ClientWidth / 2 - img.Height * 2;
        }

        void IGameObject.Render(ConsoleGraphics graphics)
        {
            graphics.DrawImage(img, BallPositionX, BallPositionY);
        }

        void IGameObject.Update(GameEngine engine)
        {
            if (!IsGameBegin && Input.IsKeyDown(Keys.SPACE))
            {
                speedX = 10;
                speedY = -10;
            }
            if (BallPositionX > graphics.ClientWidth - img.Width)
            {
                speedX = -10;
                speedY = -10;
            }
            else if (BallPositionY < 0)
            {
                speedY = 10;
            }
            else if (BallPositionX < 0)
            {
                speedX = 10;
            }
            else if (BallPositionY > graphics.ClientHeight - img.Height)
            {
                speedX = 0;
                speedY = 0;
            }
            if ((BallPositionY > arcanoid.PlatformPositionY - img.Height) && (BallPositionX >= arcanoid.PlatformPositionX) && (BallPositionX <= arcanoid.PlatformPositionX + arcanoid.ImgArcanoid.Width / 2))
            {
                speedX = -10;
                speedY = -10;
            }
            else if ((BallPositionY > arcanoid.PlatformPositionY - img.Height) && (BallPositionX >= arcanoid.PlatformPositionX + arcanoid.ImgArcanoid.Width / 2) && (BallPositionX <= arcanoid.PlatformPositionX + arcanoid.ImgArcanoid.Width))
            {
                speedX = 10;
                speedY = -10;
            }

            BallPositionX += speedX;
            BallPositionY += speedY;

            BallPositionX %= graphics.ClientWidth;
            BallPositionY %= graphics.ClientHeight;
        }
    }
}

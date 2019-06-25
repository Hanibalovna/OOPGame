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
        private ConsoleImage ImgBall;
        private Arcanoid arcanoid;
        private int speedX, speedY;
        public int BallPositionX { get; set; }
        public int BallPositionY { get; set; }
        private bool IsGameBegin;

        public Ball(ConsoleGraphics graphics, Arcanoid arcanoid)
        {
            this.graphics = graphics;
            this.arcanoid = arcanoid;
            ImgBall = graphics.LoadImage("ballBlue.png");
            BallPositionX = graphics.ClientWidth / 2 - ImgBall.Width / 2;
            BallPositionY = graphics.ClientWidth / 2 - ImgBall.Height * 2;
        }
        public void SetSpeed(int speedX, int speedY)
        {

        }
        void IGameObject.Render(ConsoleGraphics graphics)
        {
            graphics.DrawImage(ImgBall, BallPositionX, BallPositionY);
        }

        void IGameObject.Update(GameEngine engine)
        {
            if (!IsGameBegin && Input.IsKeyDown(Keys.SPACE))
            {
                speedX = 10;
                speedY = -10;
            }
            if (BallPositionX > graphics.ClientWidth - ImgBall.Width)
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
            else if (BallPositionY > graphics.ClientHeight - ImgBall.Height)
            {
                speedX = 0;
                speedY = 0;
            }
            arcanoid.ArcanoidTouch(BallPositionX, BallPositionY);
            speedX = -10;
            speedY = -10;

            BallPositionX += speedX;
            BallPositionY += speedY;

            BallPositionX %= graphics.ClientWidth;
            BallPositionY %= graphics.ClientHeight;
        }
    }
}

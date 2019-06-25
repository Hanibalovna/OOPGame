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
        public ConsoleImage ImgArcanoid { get; set; }
        private int speedX, speedY;
        public int PlatformPositionX { get; set; }
        public int PlatformPositionY { get; set; }
        private bool touch;

        public Arcanoid(ConsoleGraphics graphics)
        {
            this.graphics = graphics;
            ImgArcanoid = graphics.LoadImage("paddleBlu.png");
            PlatformPositionX = graphics.ClientWidth / 2 - ImgArcanoid.Width / 2;
            PlatformPositionY = graphics.ClientHeight - ImgArcanoid.Height ;
        }

        void IGameObject.Render(ConsoleGraphics graphics)
        {
            graphics.DrawImage(ImgArcanoid, PlatformPositionX, PlatformPositionY);
        }

        void IGameObject.Update(GameEngine engine)
        {
            var arcanoidGameEngine = (ArcanoidGameEngine)engine;

            if ((Input.IsKeyDown(Keys.RIGHT)) && PlatformPositionX < graphics.ClientWidth - ImgArcanoid.Width)
                speedX = 20;
            else if ((!Input.IsKeyDown(Keys.RIGHT)) || PlatformPositionX > graphics.ClientWidth - ImgArcanoid.Width)
                speedX = 0;
            if ((Input.IsKeyDown(Keys.LEFT)) && (PlatformPositionX > 0))
                speedX = -20;
            PlatformPositionX += speedX;
        }

       public bool ArcanoidTouch(int x, int y)//пересечение платформы и точки
        {
            if (x >= PlatformPositionX + ImgArcanoid.Width || y >= PlatformPositionY + ImgArcanoid.Height)
                return true;
            else
                return false;
        }
    }
}

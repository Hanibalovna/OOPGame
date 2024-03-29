﻿using System;
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
        public int BrickPositionX { get; set; }
        public int BrickPositionY { get; set; }
        public int brickCount;

        public Brick(ConsoleGraphics graphics, int brickPositionX, int brickPositionY)
        {
            this.graphics = graphics;
            ImgBrick = graphics.LoadImage("element_blue.png");
            BrickPositionX = brickPositionX;
            BrickPositionY = brickPositionY;
        }

        void IGameObject.Render(ConsoleGraphics graphics)
        {
            graphics.DrawImage(ImgBrick, BrickPositionX, BrickPositionY);
        }

        void IGameObject.Update(GameEngine engine)
        {

        }
    }
}

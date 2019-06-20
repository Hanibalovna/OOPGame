using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace OOPGame
{
    class StartButton : IGameObject
    {
        private ConsoleGraphics graphics;
        private ConsoleImage ImgStartButton;
        private int ButtonPositionX;
        private int ButtonPositionY;

        public StartButton(ConsoleGraphics graphics)
        {
            this.graphics = graphics;
            ImgStartButton = graphics.LoadImage("start_button.png");
            ButtonPositionX = 100;
            ButtonPositionY = 100;
        }

        public void Render(ConsoleGraphics graphics)
        {
            throw new NotImplementedException();
        }

        public void Update(GameEngine engine)
        {
            //int mx = Input.MouseX;
            //int my = Input.MouseY;

            //if (x <= mx && x + w >= mx && y <= my && y + h >= my && Input.IsMouseLeftButtonDown)
            //    MouseDown?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler MouseDown;
    }
}

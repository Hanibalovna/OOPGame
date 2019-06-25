using NConsoleGraphics;
using System.Collections.Generic;
using System.Threading;

namespace OOPGame
{
    public abstract class GameEngine
    {
        private ConsoleGraphics graphics;
        protected List<IGameObject> objects = new List<IGameObject>();
        private List<IGameObject> tempObjects = new List<IGameObject>();
        protected List<IGameObject> delObjects = new List<IGameObject>();
        public GameEngine(ConsoleGraphics graphics)
        {
            this.graphics = graphics;
        }

        public void AddObject(IGameObject obj)
        {
            tempObjects.Add(obj);
        }
        public void removeGameObj(IGameObject Obj)
        {
            delObjects.Add(Obj);
        }
        public void Start()
        {
            while (true)
            {
                // Game Loop
                foreach (var obj in objects)
                    obj.Update(this);

                objects.AddRange(tempObjects);
                tempObjects.Clear();

                // clearing screen before painting new frame
                graphics.FillRectangle(0xFFFFFF00, 0, 0, graphics.ClientWidth, graphics.ClientHeight);
                foreach (var obj in objects)
                    obj.Render(graphics);

                // double buffering technique is used
                graphics.FlipPages();

                Thread.Sleep(25);
            }
        }
    }
}

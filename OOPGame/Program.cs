using NConsoleGraphics;
using System;

namespace OOPGame {

  public class Program {

    static void Main(string[] args) {

      Console.WindowWidth = 100;
      Console.WindowHeight = 25;
      Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
      Console.BackgroundColor = ConsoleColor.White;
      Console.CursorVisible = false;
      Console.Clear();

      ConsoleGraphics graphics = new ConsoleGraphics();

      GameEngine engine = new ArcanoidGameEngine(graphics, 100,25);
      engine.Start();
    }
  }
}

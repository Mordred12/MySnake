using System;

namespace snakе
{
    public readonly struct Pixel
    {
        private const char PixelChar = '█';
        public Pixel(int x, int y, ConsoleColor color, int pixselSize = 3)
        {
            X = x;
            Y = y;
            Color = color;
            PixselSize = pixselSize;
        }

        public int X { get;}
        public int Y { get;}
        public ConsoleColor Color { get;}
        public int PixselSize { get; }

        public void Draw()
        {
            Console.ForegroundColor = Color;

            for (int x = 0; x < PixselSize; x++)
            {
                for (int y = 0; y < PixselSize; y++)
                {
                    Console.SetCursorPosition(X * PixselSize + x, Y * PixselSize + y);
                    Console.Write(PixelChar);
                }

            }
            
            
        }
        public void Clean()
        {
            for (int x = 0; x < PixselSize; x++)
            {
                for (int y = 0; y < PixselSize; y++)
                {
                    Console.SetCursorPosition(X * PixselSize + x, Y * PixselSize + y);
                    Console.Write(' ');
                }

            }
        }
    }
}

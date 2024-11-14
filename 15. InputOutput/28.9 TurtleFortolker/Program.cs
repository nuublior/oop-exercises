using System;

namespace TurtleDrawingApp
{
    public class Canvas
    {
        private bool[,] data;
        public int Width { get; }
        public int Height { get; }

        public Canvas(int width, int height)
        {
            Width = width;
            Height = height;
            data = new bool[height, width];
        }

        public void SetPixel(int x, int y, bool value)
        {
            if (x >= 0 && x < Width && y >= 0 && y < Height)
            {
                data[y, x] = value;
            }
        }

        public void Print()
        {
            Console.WriteLine("+" + new string('-', Width) + "+");
            for (int y = 0; y < Height; y++)
            {
                Console.Write("|");
                for (int x = 0; x < Width; x++)
                {
                    Console.Write(data[y, x] ? "X" : " ");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("+" + new string('-', Width) + "+");
        }
    }

    public class Turtle
    {
        private int x;
        private int y;
        private bool draw;
        private Canvas canvas;

        public Turtle(Canvas canvas)
        {
            x = 0;
            y = 0;
            draw = false;
            this.canvas = canvas;
        }

        public void PenUp()
        {
            draw = false;
        }

        public void PenDown()
        {
            draw = true;
        }

        public void GoNorth(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                y = Math.Max(0, y - 1);
                if (draw) canvas.SetPixel(x, y, true);
            }
        }

        public void GoSouth(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                y = Math.Min(canvas.Height - 1, y + 1);
                if (draw) canvas.SetPixel(x, y, true);
            }
        }

        public void GoWest(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                x = Math.Max(0, x - 1);
                if (draw) canvas.SetPixel(x, y, true);
            }
        }

        public void GoEast(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                x = Math.Min(canvas.Width - 1, x + 1);
                if (draw) canvas.SetPixel(x, y, true);
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Canvas canvas = new Canvas(10, 10);
            Turtle turtle = new Turtle(canvas);

            turtle.GoEast(7);
            turtle.GoSouth(1);
            turtle.PenDown();
            turtle.GoEast(1);
            turtle.PenUp();
            turtle.GoWest(3);
            turtle.PenDown();
            turtle.GoWest(1);
            turtle.PenUp();
            turtle.GoWest(1);
            turtle.GoSouth(1);
            turtle.PenDown();
            turtle.GoWest(1);
            turtle.PenUp();
            turtle.GoWest(1);
            turtle.GoSouth(1);
            turtle.PenDown();
            turtle.GoWest(1);
            
         

            canvas.Print();
        }
    }
}

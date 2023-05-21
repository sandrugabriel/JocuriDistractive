using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocuriDistractive
{
    public partial class SnakeGame : Form
    {
        private int GameWidth = 500;
        private int GameHeight = 500;
        private int SnakeSize = 20;

        private Timer gameTimer;
        private List<Point> snake;
        private Point food;
        private Direction currentDirection;

        private enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        public SnakeGame()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            snake = new List<Point>();
            snake.Add(new Point(100, 100)); // Initial snake position
            snake.Add(new Point(80, 100));
            snake.Add(new Point(60, 100));

            food = GenerateFood();

            currentDirection = Direction.Right;

            gameTimer = new Timer();
            gameTimer.Tick += UpdateScreen;
            gameTimer.Interval = 200; // Snake speed (in milliseconds)
            gameTimer.Start();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (GameIsOver())
            {
                gameTimer.Stop();
                MessageBox.Show("Game over!");
                return;
            }

            MoveSnake();

            if (snake[0].Equals(food))
            {
                snake.Add(new Point(-1, -1)); // Add a new point to the snake (will be updated in the next move)
                food = GenerateFood();
            }

            Invalidate();
        }

        private void MoveSnake()
        {
            var head = snake[0];
            switch (currentDirection)
            {
                case Direction.Up:
                    snake.Insert(0, new Point(head.X, head.Y - SnakeSize));
                    break;
                case Direction.Down:
                    snake.Insert(0, new Point(head.X, head.Y + SnakeSize));
                    break;
                case Direction.Left:
                    snake.Insert(0, new Point(head.X - SnakeSize, head.Y));
                    break;
                case Direction.Right:
                    snake.Insert(0, new Point(head.X + SnakeSize, head.Y));
                    break;
            }

            snake.RemoveAt(snake.Count - 1); // Remove the last point of the snake
        }

        private bool GameIsOver()
        {
            var head = snake[0];

            // Check if the snake hits the wall
            if (head.X <= 0 || head.X >= GameWidth || head.Y <= 0 || head.Y >= GameHeight)
                return true;

            for (int i = 1; i < snake.Count; i++)
            {
                if (snake[0] == snake[i])
                {
                    return true;
                }
            }

            return false;
        }

        private Point GenerateFood()
        {
            var random = new Random();
            int maxX = GameWidth / SnakeSize;
            int maxY = GameHeight / SnakeSize;
            Point point = new Point(random.Next(0, maxX) * SnakeSize, random.Next(0, maxY) * SnakeSize);
            for (int i = 0; i < snake.Count; i++)
            {
                if (snake[i].X == point.X && snake[i].Y == point.Y)
                {
                    point = new Point(random.Next(0, maxX) * SnakeSize, random.Next(0, maxY) * SnakeSize);
                    i = 0;
                }
            }
            return point;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;

            // Draw the snake
            int ct = 0;
            foreach (var point in snake)
            {
                if (ct == 0)
                    g.FillEllipse(Brushes.White, point.X, point.Y, SnakeSize, SnakeSize);
                else g.FillEllipse(Brushes.Green, point.X, point.Y, SnakeSize, SnakeSize);

                ct++;
            }


            // Draw the food
            g.FillEllipse(Brushes.Red, food.X, food.Y, SnakeSize, SnakeSize);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            var key = e.KeyCode;

            // Change snake direction based on the arrow keys
            switch (key)
            {
                case Keys.W:
                    if (currentDirection != Direction.Down)
                        currentDirection = Direction.Up;
                    break;
                case Keys.S:
                    if (currentDirection != Direction.Up)
                        currentDirection = Direction.Down;
                    break;
                case Keys.A:
                    if (currentDirection != Direction.Right)
                        currentDirection = Direction.Left;
                    break;
                case Keys.D:
                    if (currentDirection != Direction.Left)
                        currentDirection = Direction.Right;
                    break;
            }
        }

    }
}

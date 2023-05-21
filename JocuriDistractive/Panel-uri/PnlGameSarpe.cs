using JocuriDistractive.Controllers;
using JocuriDistractive.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocuriDistractive.Panel_uri
{
    internal class PnlGameSarpe:Panel
    {


        private int GameWidth = 600;
        private int GameHeight = 600;
        private int SnakeSize = 20;

        private Timer gameTimer;
        private List<Point> snake;
        private Point food;
        public Direction currentDirection;

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

      
        Utilizator utilizator;
        Label lblpunctaj;
        public int punctaj;  
        Form1 form;





        ControllerRezultate controllerRezultate;

        public PnlGameSarpe(Form1 form1 ,Utilizator utilizator1)
        {
           
            form = form1;
          
            this.utilizator = utilizator1;
            controllerRezultate = new ControllerRezultate();

            this.TabStop = true;
          
            
            InitializeGame();

        }

        private void InitializeGame()
        {
            this.Name = "pnlGameSarpe";
            this.form.Size = new System.Drawing.Size(639, 683);
            this.Size = new System.Drawing.Size(639, 683);
            this.BackColor = Color.Gray;
            this.form.btnSarpe.Visible = false;
            this.lblpunctaj = new Label();
            this.Controls.Add(this.lblpunctaj);

            lblpunctaj.Text = "Punctaj: 0";

            snake = new List<Point>();
            snake.Add(new Point(100, 100));
            snake.Add(new Point(80, 100));

            food = GenerateFood();

            currentDirection = Direction.Right;

            gameTimer = new Timer();
            gameTimer.Tick += UpdateScreen;
            gameTimer.Interval = 200;
            gameTimer.Start();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (GameIsOver() == true)
            {
                gameTimer.Stop();
                gameTimer.Enabled = false;
                gameTimer.Stop();
                DialogResult dialogResult = MessageBox.Show("Ai pierdut! \nPunctaj: " + punctaj.ToString() + "\n Vrei sa mai aduni puncte in plus?", "Ghinion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(dialogResult == DialogResult.OK)
                {
                    this.form.removePnl("pnlGameSarpe");
                    this.form.btnSarpe.Visible = true;
                    this.form.Controls.Add(new PnlIntrebari(form, utilizator, punctaj));
                    return;
                }
                if(dialogResult == DialogResult.Cancel || dialogResult == DialogResult.Ignore) {

                    string textul = controllerRezultate.generareId().ToString() + ";" + 1.ToString() + ";" + utilizator.getemail() + ";" + punctaj.ToString();
                    controllerRezultate.save(textul);
                    this.form.removePnl("pnlGameSarpe");
                    this.form.btnSarpe.Visible = true;
                    this.form.Controls.Add(new PnlHome(form, utilizator));
                    return;
                }
                return;
            }
            else
            {
            MoveSnake();

            if (snake[0].Equals(food))
            {
                punctaj += 10;
                lblpunctaj.Text = "Punctaj: " + punctaj;
                snake.Add(new Point(-1, -1)); 
                food = GenerateFood();
            }

            Invalidate();
            }

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


            if (head.X < 0 || head.X > GameWidth || head.Y < 0 || head.Y > GameHeight)
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

        public void move( KeyEventArgs e)
        {

           
        
            var key = e.KeyCode;


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

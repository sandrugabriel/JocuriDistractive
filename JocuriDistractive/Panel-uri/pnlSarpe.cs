using JocuriDistractive.Controllers;
using JocuriDistractive.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocuriDistractive.Panel_uri
{
    internal class pnlSarpe : Panel
    {

        Form1 form;
        Utilizator utilizator;

        Button btnStart;
        PictureBox tablaSarpe;
        Button btnStop;
        Label lblPunctaj;

        PictureBox sarpe;
        PictureBox mar;
        PictureBox[] coada;

        Timer timer;

        private int punctaj = 0;

        private int x = 1, y = 0, dim = 0;

        ControllerRezultate controllerRezultate;

        public pnlSarpe(Form1 form1, Utilizator utilizator1)
        {

            form = form1;
            utilizator = utilizator1;
            coada = new PictureBox[360001];
            controllerRezultate = new ControllerRezultate();

            //pnlSarpe
            this.form.Size = new System.Drawing.Size(750, 750);
            this.form.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(937, 861);
            this.Name = "pnlSarpe";
            this.Text = "Sarpe Joc";
            this.form.KeyDown += new KeyEventHandler(form_KeyDown);

            this.btnStart = new System.Windows.Forms.Button();
            this.tablaSarpe = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblPunctaj = new System.Windows.Forms.Label();
            this.sarpe = new System.Windows.Forms.PictureBox();
            this.mar = new System.Windows.Forms.PictureBox();
            this.timer = new Timer();

            this.Controls.Add(this.lblPunctaj);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tablaSarpe);
            this.Controls.Add(this.btnStart);


            // btnStart
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(78, 630);
            this.btnStart.Size = new System.Drawing.Size(153, 61);
            this.btnStart.Text = "Start Joc";
            this.btnStart.Click += new EventHandler(btnStart_Click);

            //timer
            this.timer.Interval = 200;
            this.timer.Enabled = false;
            this.timer.Tick += new EventHandler(timer_Tick);

            //sapre
            this.sarpe.BackColor = Color.White;
            this.sarpe.Location = new Point(100, 100);
            this.sarpe.Size = new Size(18, 18);

            //mar
            this.mar.BackColor = Color.Red;
            this.mar.Location = new Point(240, 100);
            this.mar.Size = new Size(18, 18);

            // tablaSarpe
            this.tablaSarpe.Controls.Add(sarpe);
            this.tablaSarpe.Controls.Add(mar);
            this.tablaSarpe.BackColor = System.Drawing.Color.Black;
            this.tablaSarpe.Location = new System.Drawing.Point(69, 12);
            this.tablaSarpe.Size = new System.Drawing.Size(600, 600);

            // btnStop
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(331, 630);
            this.btnStop.Size = new System.Drawing.Size(153, 61);
            this.btnStop.Text = "Stop Joc";
            this.btnStop.Click += new EventHandler(btnStop_Click);

            // lblPunctaj
            this.lblPunctaj.AutoSize = true;
            this.lblPunctaj.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblPunctaj.Location = new System.Drawing.Point(530, 650);
            this.lblPunctaj.Size = new System.Drawing.Size(123, 32);
            this.lblPunctaj.Text = "Punctaj: 0";


        }

        private void mesaj()
        {


            DialogResult result = MessageBox.Show("Vrei sa joc al game mode pentru a aduna mai multe puncte?", "Game Mode", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {

                this.form.removePnl("pnlSarpe");
                this.form.Controls.Add(new pnlIntrebari(form, utilizator, punctaj));

            }
            else
            {

                string textul = controllerRezultate.generareId().ToString() + ";" + 1.ToString() + ";" + utilizator.getemail() + ";" + punctaj.ToString();
                controllerRezultate.save(textul);
                this.form.removePnl("pnlSarpe");
                this.form.Controls.Add(new pnlHome(form, utilizator));


            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            this.btnStop.Enabled = false;
            this.btnStart.Enabled = true;
            this.timer.Stop();
            this.timer.Enabled = false;

            mesaj();
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {

            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
            this.timer.Enabled = true;
            this.timer.Start();

        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (x != 1 && y != 0)
                if (e.KeyCode == Keys.A)
                {
                    x = -1;
                    y = 0;
                }

            if (x != -1 && y != 0)
                if (e.KeyCode == Keys.D)
                {
                    x = 1;
                    y = 0;
                }

            if (x != 0 && y != 1)
                if (e.KeyCode == Keys.W)
                {
                    x = 0;
                    y = -1;
                }

            if (x != 0 && y != -1)
                if (e.KeyCode == Keys.S)
                {
                    x = 0;
                    y = 1;
                }

        }

        private void timer_Tick(object sender, EventArgs e)
        {



            for (int i = dim - 1; i > 0; i--)
            {
                coada[i].Location = coada[i - 1].Location;
            }

            if (dim > 0)
            {
                coada[0].Location = sarpe.Location;
            }

            sarpe.Location = new Point(sarpe.Location.X + 20 * x, sarpe.Location.Y + 20 * y);

            for (int i = 0; i < dim; i++)
            {
                if (coada[i].Location == sarpe.Location)
                {
                    timer.Enabled = false;
                    timer.Stop();
                    MessageBox.Show("Te-ai mancat! \n Ai pierdut!", "Ghinion!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    mesaj();
                }
            }
            Random random = new Random();
            int x1 = random.Next(25) * 20;
            int y1 = random.Next(25) * 20;
            if (sarpe.Location == mar.Location)
            {
                punctaj += 10;
                lblPunctaj.Text = "Punctaj: " + punctaj.ToString();
                Point point = new Point(x1, y1);

                for (int i = 0; i < dim; i++)
                {
                    if (coada[i].Location == point)
                    {
                        x1 = random.Next(25) * 20;
                        y1 = random.Next(25) * 20;
                        point = new Point(x1, y1);
                        i = 0;
                    }
                }

                mar.Location = point;

                coada[dim] = new PictureBox();
                coada[dim].Location = sarpe.Location;
                coada[dim].BackColor = Color.Green;
                coada[dim].Size = new Size(18, 18);
                this.tablaSarpe.Controls.Add(coada[dim]);
                dim++;
            }

            if (sarpe.Location.X > 600 || sarpe.Location.Y > 600 || sarpe.Location.X < 0 || sarpe.Location.Y < 0)
            {

                timer.Stop();
                timer.Enabled = false;
                MessageBox.Show("Ai pierdut!", "Ghinion!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                mesaj();
            }


        }


    }
}

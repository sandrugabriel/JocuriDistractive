using JocuriDistractive.Models;
using JocuriDistractive.Panel_uri;
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
    public partial class Form1 : Form
    {
        public Button btnSarpe;
        Utilizator utilizator;
        public Form1()
        {
            InitializeComponent();
            Utilizator a = new Utilizator("popescu.petre@ojti2023.ro;otipopescu;abc123@A");
            utilizator = a;

            btnSarpe = new Button();

            this.Controls.Add(btnSarpe);

            // btnSarpe
            this.btnSarpe.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular);
            this.btnSarpe.ForeColor = System.Drawing.Color.White;
            this.btnSarpe.Location = new System.Drawing.Point(790, 503);
            this.btnSarpe.Size = new System.Drawing.Size(226, 93);
            this.btnSarpe.Text = "SARPE EDUCATIv";
            this.btnSarpe.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnSarpe.Click += new EventHandler(btnSarpe_Click);
            this.btnSarpe.Visible = true;
            this.btnSarpe.BringToFront();

            this.Controls.Add(new PnlHome(this, a));
            this.btnSarpe.BringToFront();
            initDown();

            this.btnSarpe.BringToFront();
        }

        private void btnSarpe_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Vrei sa incepi acum?", "Joc Sarpe", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.removePnl("pnlHome");

                this.initDown();


                this.Controls.Add(new PnlGameSarpe(this, utilizator));

            }

        }

        public void initDown()
        {
            KeyPreview = true;

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        public void removePnl(string pnl)
        {

            Control control = null;

            foreach(Control control1 in this.Controls)
            {
                if (control1.Name.Equals(pnl))
                {
                    control = control1;
                }
            }

            this.Controls.Remove(control);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Control verificarePnlGameSarpe()
        {

            foreach (Control control1 in this.Controls)
            {

                if (control1.Name.Equals("pnlGameSarpe"))
                {
                    return control1;
                }

            }

            return null;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            Control control = verificarePnlGameSarpe();
            if (control != null)
            {

                PnlGameSarpe pnlGameSarpe = (PnlGameSarpe)control;
                pnlGameSarpe.move(e);

            }


        }
    }
}

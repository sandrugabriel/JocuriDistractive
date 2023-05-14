using JocuriDistractive.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocuriDistractive.Panel_uri
{
    internal class pnlLogare:Panel
    {

        Form1 form;

        Label lblEmail;
        Label lblParola;
        TextBox txtEmail;
        TextBox txtParola;
        Label lblTitlu;
        PictureBox pctBac;
        Button btnLogare;

        ControllerUtilizatori controllerUtilizatori;

        public pnlLogare(Form1 form1)
        {

            form = form1;
            controllerUtilizatori = new ControllerUtilizatori();

            //pnlLogare
            this.Name = "pnlLogare";
            this.Text = "Logare";
            this.Size = new Size(705, 544);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");

            this.lblEmail = new Label();
            this.lblParola = new Label();
            this.txtEmail = new TextBox();
            this.txtParola = new TextBox();
            this.lblTitlu = new Label();
            this.pctBac = new PictureBox();
            this.btnLogare = new Button();

            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.pctBac);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblEmail);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 19.8F, System.Drawing.FontStyle.Regular);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(85, 214);
            this.lblEmail.Size = new System.Drawing.Size(102, 45);
            this.lblEmail.Text = "Email";
             
            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 19.8F, System.Drawing.FontStyle.Regular);
            this.lblParola.ForeColor = System.Drawing.Color.White;
            this.lblParola.Location = new System.Drawing.Point(85, 335);
            this.lblParola.Size = new System.Drawing.Size(117, 45);
            this.lblParola.Text = "Parola";
             
            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.txtEmail.Location = new System.Drawing.Point(268, 222);
            this.txtEmail.Size = new System.Drawing.Size(327, 38);
            
            // txtParola
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.txtParola.Location = new System.Drawing.Point(268, 342);
            this.txtParola.Size = new System.Drawing.Size(327, 38);
             
            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 25F);
            this.lblTitlu.Location = new System.Drawing.Point(216, 25);
            this.lblTitlu.Size = new System.Drawing.Size(217, 55);
            this.lblTitlu.Text = "Conectare";
            this.lblTitlu.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
             
            // pctBac
            this.pctBac.Location = new System.Drawing.Point(0, -7);
            this.pctBac.Size = new System.Drawing.Size(722, 112);
            this.pctBac.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            
            // btnLogare
            this.btnLogare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.btnLogare.Location = new System.Drawing.Point(249, 441);
            this.btnLogare.Size = new System.Drawing.Size(170, 67);
            this.btnLogare.Text = "Logare";
            this.btnLogare.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnLogare.ForeColor = System.Drawing.Color.White;
            this.btnLogare.Click += new EventHandler(btnLogare_Click);

        }

        private void btnLogare_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string parola = txtParola.Text;

            if (controllerUtilizatori.verificareCont(email, parola))
            {

            }
            else
                MessageBox.Show("Nu ati introdus corect email / parola", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


    }
}

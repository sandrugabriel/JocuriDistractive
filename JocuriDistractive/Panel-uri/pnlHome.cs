using JocuriDistractive.Controllers;
using JocuriDistractive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocuriDistractive.Panel_uri
{
    internal class pnlHome:Panel
    {

        Utilizator utilizator;
        ControllerUtilizatori controllerUtilizatori;
        ControllerRezultate controllerRezultate;

        PictureBox pctBack;
        Label lblTile;
        Label lblNumeEmail;
        ListView listGhiceste;
        ListView lstSarpe;
        Label lblScorGhiceste;
        Label lblScorSarpe;
        Button btnGhiceste;
        Button btnSarpe;

        Form1 form;

        public pnlHome(Form1 form1, Utilizator utilizator1)
        {
            form = form1;
            utilizator = utilizator1;
            controllerRezultate = new ControllerRezultate();
            controllerUtilizatori = new ControllerUtilizatori();

            // pnlHome
            this.form.Size = new System.Drawing.Size(1185, 656);
            this.ClientSize = new System.Drawing.Size(1185, 656);
            this.Name = "pnlHome";
            this.Text = "Home";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");

            this.pctBack = new System.Windows.Forms.PictureBox();
            this.lblTile = new System.Windows.Forms.Label();
            this.lblNumeEmail = new System.Windows.Forms.Label();
            this.listGhiceste = new System.Windows.Forms.ListView();
            this.lstSarpe = new System.Windows.Forms.ListView();
            this.lblScorGhiceste = new System.Windows.Forms.Label();
            this.lblScorSarpe = new System.Windows.Forms.Label();
            this.btnGhiceste = new System.Windows.Forms.Button();
            this.btnSarpe = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnSarpe);
            this.Controls.Add(this.btnGhiceste);
            this.Controls.Add(this.lblScorSarpe);
            this.Controls.Add(this.lblScorGhiceste);
            this.Controls.Add(this.lstSarpe);
            this.Controls.Add(this.listGhiceste);
            this.Controls.Add(this.lblNumeEmail);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.pctBack);

            // pctBack
            this.pctBack.Location = new System.Drawing.Point(-10, -3);
            this.pctBack.Size = new System.Drawing.Size(1214, 126);
            this.pctBack.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");

            // lblTile
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 19.8F, System.Drawing.FontStyle.Regular);
            this.lblTile.ForeColor = System.Drawing.Color.White;
            this.lblTile.Location = new System.Drawing.Point(512, 9);
            this.lblTile.Size = new System.Drawing.Size(216, 45);
            this.lblTile.Text = "Bine ai venit,";
            this.lblTile.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");

            // lblNumeEmail
            this.lblNumeEmail.AutoSize = true;
            this.lblNumeEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular);
            this.lblNumeEmail.ForeColor = System.Drawing.Color.White;
            this.lblNumeEmail.Location = new System.Drawing.Point(390, 65);
            this.lblNumeEmail.Size = new System.Drawing.Size(517, 36);
            this.lblNumeEmail.Text = utilizator.getnume()+"(" + utilizator.getemail() + ")";
            this.lblNumeEmail.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");

            // listGhiceste
            this.listGhiceste.HideSelection = false;
            this.listGhiceste.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listGhiceste.UseCompatibleStateImageBehavior = false;
            this.listGhiceste.View = System.Windows.Forms.View.Details;
            this.listGhiceste.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F, System.Drawing.FontStyle.Regular);
            this.listGhiceste.Location = new System.Drawing.Point(26, 225);
            this.listGhiceste.GridLines = true;
            this.listGhiceste.View = View.Details;
            this.listGhiceste.Size = new System.Drawing.Size(523, 226);
             
            // lstSarpe
            this.lstSarpe.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F, System.Drawing.FontStyle.Regular);
            this.lstSarpe.HideSelection = false;
            this.lstSarpe.GridLines = true;
            this.lstSarpe.View = View.Details;
            this.lstSarpe.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lstSarpe.Location = new System.Drawing.Point(612, 225);
            this.lstSarpe.Size = new System.Drawing.Size(523, 226);
             
            // lblScorGhiceste
            this.lblScorGhiceste.AutoSize = true;
            this.lblScorGhiceste.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F, System.Drawing.FontStyle.Regular);
            this.lblScorGhiceste.ForeColor = System.Drawing.Color.White;
            this.lblScorGhiceste.Location = new System.Drawing.Point(154, 159);
            this.lblScorGhiceste.Size = new System.Drawing.Size(280, 39);
            this.lblScorGhiceste.Text = "Top scor GHICESTE";
            
            // lblScorSarpe
            this.lblScorSarpe.AutoSize = true;
            this.lblScorSarpe.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F, System.Drawing.FontStyle.Regular);
            this.lblScorSarpe.ForeColor = System.Drawing.Color.White;
            this.lblScorSarpe.Location = new System.Drawing.Point(767, 159);
            this.lblScorSarpe.Size = new System.Drawing.Size(232, 39);
            this.lblScorSarpe.Text = "Top scor SARPE";
             
            // btnGhiceste
            this.btnGhiceste.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular);
            this.btnGhiceste.ForeColor = System.Drawing.Color.White;
            this.btnGhiceste.Location = new System.Drawing.Point(150, 503);
            this.btnGhiceste.Size = new System.Drawing.Size(226, 93);
            this.btnGhiceste.Text = "GHICESTE";
            this.btnGhiceste.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnGhiceste.Click += new EventHandler(btnGhiceste_Click);

            // btnSarpe
            this.btnSarpe.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular);
            this.btnSarpe.ForeColor = System.Drawing.Color.White;
            this.btnSarpe.Location = new System.Drawing.Point(790, 503);
            this.btnSarpe.Size = new System.Drawing.Size(226, 93);
            this.btnSarpe.Text = "SARPE EDUCATIV";
            this.btnSarpe.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");

            creeateTable(listGhiceste, controllerRezultate.getCrescGhiceste());
            creeateTable(lstSarpe,controllerRezultate.getCrescSarpe());
        }

        private void btnGhiceste_Click(object sender, EventArgs e)
        {

            this.form.removePnl("pnlHome");
            this.form.Controls.Add(new pnlGhiceste(form, utilizator));

        }

        public void creeateTable(ListView listView, List<Rezultat> listRezultat)
        {

            listView.Clear();
            listView.Columns.Add("Numele", 140, HorizontalAlignment.Left);
            listView.Columns.Add("Email", 229, HorizontalAlignment.Left);
            listView.Columns.Add("Punctaj", 150, HorizontalAlignment.Left);

            foreach (Rezultat m in listRezultat)
            {

                ListViewItem linie = new ListViewItem();

                linie.Text = controllerUtilizatori.getNumebyEmail(m.getEmail());
                linie.SubItems.Add(m.getEmail());
                linie.SubItems.Add(m.getPunctajJoc().ToString());

                listView.Items.Add(linie);
            }


        }

    }
}

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
    internal class pnlIntrebari : Panel
    {

        Form1 form;
        Utilizator utilizator;
        private int punctaj;

        RichTextBox txtIntrebare;
        RadioButton btn1;
        RadioButton btn3;
        RadioButton btn2;
        Button btnInregistrare;
        Random random;

        Itemi intrebare;

        ControllerItemi controllerItemi;
        ControllerRezultate controllerRezultate;

        public pnlIntrebari(Form1 form1, Utilizator utilizator1, int punctaj1)
        {
            form = form1;
            utilizator = utilizator1;
            punctaj = punctaj1;
            random = new Random();
            controllerItemi = new ControllerItemi();
            controllerRezultate = new ControllerRezultate();

            intrebare = controllerItemi.getItemRandom();

            // pnlIntrebare
            this.form.Size = new System.Drawing.Size(719, 630);
            this.Size = new System.Drawing.Size(719, 630);
            this.Text = "Intrebare";
            this.Name = "pnlIntrebari";

            this.txtIntrebare = new System.Windows.Forms.RichTextBox();
            this.btn1 = new System.Windows.Forms.RadioButton();
            this.btn3 = new System.Windows.Forms.RadioButton();
            this.btn2 = new System.Windows.Forms.RadioButton();
            this.btnInregistrare = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtIntrebare);


            // txtIntrebare
            this.txtIntrebare.Location = new System.Drawing.Point(40, 42);
            this.txtIntrebare.Size = new System.Drawing.Size(531, 237);
            this.txtIntrebare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.2F);
            this.txtIntrebare.Text = intrebare.getEnuntItem();

            // btn1
            this.btn1.AutoSize = true;
            this.btn1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F);
            this.btn1.Location = new System.Drawing.Point(80, 303);
            this.btn1.Size = new System.Drawing.Size(62, 27);
            this.btn1.Name = "btn1";
            this.btn1.Text = intrebare.getRspun1();

            // btn3
            this.btn3.AutoSize = true;
            this.btn3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F);
            this.btn3.Location = new System.Drawing.Point(80, 411);
            this.btn3.Size = new System.Drawing.Size(62, 27);
            this.btn3.Text = intrebare.getraspuns3();
            this.btn3.Name = "btn3";

            // btn2
            this.btn2.AutoSize = true;
            this.btn2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F);
            this.btn2.Location = new System.Drawing.Point(80, 358);
            this.btn2.Size = new System.Drawing.Size(62, 27);
            this.btn2.Text = intrebare.getRspun2();
            this.btn2.Name = "btn2";

            // btnInregistrare
            this.btnInregistrare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInregistrare.Location = new System.Drawing.Point(174, 478);
            this.btnInregistrare.Size = new System.Drawing.Size(254, 79);
            this.btnInregistrare.Text = "Inregistrare intrebare";
            this.btnInregistrare.Click += new EventHandler(btnInregistrare_Click);

        }

        private RadioButton btnsRadion()
        {

            RadioButton[] btns = new RadioButton[3];

            btns[0] = btn1;
            btns[1] = btn2;
            btns[2] = btn3;

            for (int i = 0; i < btns.Length; i++)
            {

                if (btns[i].Checked == true)
                {
                    return btns[i];
                }

            }


            return null;
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {

            if (btnsRadion().Name.Equals("btn" + intrebare.getRaspuCorect().ToString()))
            {
                punctaj += intrebare.getpunctajItem();

                MessageBox.Show("  Ai strans " + punctaj.ToString() + " \n  Ai raspuns corect!", "Felicitari!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string textul = controllerRezultate.generareId().ToString() + ";" + 1.ToString() + ";" + utilizator.getemail() + ";" + punctaj.ToString();
                controllerRezultate.save(textul);
                this.form.removePnl("pnlSarpe");
                this.form.removePnl("pnlIntrebari");
                this.form.Controls.Add(new pnlHome(form, utilizator));

            }
            else
            {
                MessageBox.Show("Nu ai raspuns corect!", "Ghinion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string textul = controllerRezultate.generareId().ToString() + ";" + 1.ToString() + ";" + utilizator.getemail() + ";" + punctaj.ToString();
                controllerRezultate.save(textul);
                this.form.removePnl("pnlSarpe");
                this.form.removePnl("pnlIntrebari");
                this.form.Controls.Add(new pnlHome(form, utilizator));
            }
                

        }


    }
}

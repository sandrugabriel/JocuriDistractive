using JocuriDistractive.Controllers;
using JocuriDistractive.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocuriDistractive.Panel_uri
{
    internal class pnlGhiceste:Panel
    {

        Form1 form;
        Utilizator utilizator;

        private string t;

        Label lblPunctaj;
        PictureBox pctImagine;
        Button btnA;
        Button btnB;
        Button btnC;
        Button btnD;
        Button btnE;
        Button btnF;
        Button btnG;
        Button btnH;
        Button btnI;
        Button btnJ;
        Button btnK;
        Button btnL;
        Button btnM;
        Button btnN;
        Button btnO;
        Button btnP;
        Button btnQ;
        Button btnR;
        Button btnS;
        Button btnT;
        Button btnU;
        Button btnV;
        Button btnW;
        Button btnX;
        Button btnY;
        Button btnZ;
        Label lblCuvant;
        List<string> cuvante;
        Random rand;
        string cuvantGhicit;

        ControllerRezultate controllerRezultate; 

        public pnlGhiceste(Form1 form1, Utilizator utilizator1)
        {
            form = form1;
            utilizator = utilizator1;
            cuvante = new List<string>();
            citirea();
            controllerRezultate = new ControllerRezultate();
            rand = new Random();
            int poz = rand.Next(0,cuvante.Count-1);
            cuvantGhicit = cuvante[poz];
            t = initializere();
            // pnlGhiceste
            this.form.Size = new System.Drawing.Size(906, 610);
            this.Size = new System.Drawing.Size(906, 591);
            this.Name = "pnlGhiceste";
            this.Text = "Ghiceste cuvant";

            this.lblPunctaj = new System.Windows.Forms.Label();
            this.pctImagine = new System.Windows.Forms.PictureBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.lblCuvant = new System.Windows.Forms.Label();

            this.Controls.Add(this.lblCuvant);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.pctImagine);
            this.Controls.Add(this.lblPunctaj);

            // lblPunctaj
            this.lblPunctaj.AutoSize = true;
            this.lblPunctaj.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunctaj.Location = new System.Drawing.Point(25, 24);
            this.lblPunctaj.Name = "lblPunctaj";
            this.lblPunctaj.Size = new System.Drawing.Size(84, 27);
            this.lblPunctaj.TabIndex = 0;
            this.lblPunctaj.Text = "Punctaj: 100";
             
            // pctImagine
            this.pctImagine.Location = new System.Drawing.Point(560, 79);
            this.pctImagine.Name = "pctImagine";
            this.pctImagine.Size = new System.Drawing.Size(200,350);
            string path = Application.StartupPath + @"/StadiiFloare/6.png";
            this.pctImagine.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pctImagine.Image = Image.FromFile(path);
             
            // btnA
            this.btnA.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(21, 473);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(37, 37);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
             
            // btnZ
            this.btnZ.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.Location = new System.Drawing.Point(537, 516);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(37, 37);
            this.btnZ.TabIndex = 3;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
             
            // btnM
            this.btnM.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(534, 473);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(37, 37);
            this.btnM.TabIndex = 4;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
             
            // btnY
            this.btnY.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(494, 516);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(37, 37);
            this.btnY.TabIndex = 5;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
             
            // btnX
            this.btnX.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(451, 516);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(37, 37);
            this.btnX.TabIndex = 6;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
             
            // btnW
            this.btnW.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(408, 516);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(37, 37);
            this.btnW.TabIndex = 7;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
             
            // btnV
            this.btnV.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(365, 516);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(37, 37);
            this.btnV.TabIndex = 8;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
             
            // btnU
            this.btnU.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Location = new System.Drawing.Point(322, 516);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(37, 37);
            this.btnU.TabIndex = 9;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
             
            // btnT
            this.btnT.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(279, 516);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(37, 37);
            this.btnT.TabIndex = 10;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
             
            // btnS
            this.btnS.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(236, 516);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(37, 37);
            this.btnS.TabIndex = 11;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
             
            // btnR
            this.btnR.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(193, 516);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(37, 37);
            this.btnR.TabIndex = 12;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            
            // btnQ
            this.btnQ.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.Location = new System.Drawing.Point(150, 516);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(37, 37);
            this.btnQ.TabIndex = 13;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
             
            // btnP
            this.btnP.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(107, 516);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(37, 37);
            this.btnP.TabIndex = 14;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
             
            // btnO
            this.btnO.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(64, 516);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(37, 37);
            this.btnO.TabIndex = 15;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
             
            // btnN
            this.btnN.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(21, 516);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(37, 37);
            this.btnN.TabIndex = 16;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
             
            // btnL
            this.btnL.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(491, 473);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(37, 37);
            this.btnL.TabIndex = 17;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
             
            // btnK
            this.btnK.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.Location = new System.Drawing.Point(451, 473);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(37, 37);
            this.btnK.TabIndex = 18;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
             
            // btnJ
            this.btnJ.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.Location = new System.Drawing.Point(408, 473);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(37, 37);
            this.btnJ.TabIndex = 19;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
             
            // btnI
            this.btnI.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(365, 473);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(37, 37);
            this.btnI.TabIndex = 20;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
             
            // btnH
            this.btnH.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(322, 473);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(37, 37);
            this.btnH.TabIndex = 21;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
             
            // btnG
            this.btnG.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(279, 473);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(37, 37);
            this.btnG.TabIndex = 22;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
             
            // btnF
            this.btnF.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(236, 473);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(37, 37);
            this.btnF.TabIndex = 23;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
             
            // btnE
            this.btnE.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(193, 473);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(37, 37);
            this.btnE.TabIndex = 24;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            
            // btnD
            this.btnD.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(150, 473);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(37, 37);
            this.btnD.TabIndex = 25;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            
            // btnC
            this.btnC.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(107, 473);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(37, 37);
            this.btnC.TabIndex = 26;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
             
            // btnB
            this.btnB.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(64, 473);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(37, 37);
            this.btnB.TabIndex = 27;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
             
            // lblCuvant
            this.lblCuvant.AutoSize = true;
            this.lblCuvant.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuvant.Location = new System.Drawing.Point(30, 421);
            this.lblCuvant.Name = "lblCuvant";
            this.lblCuvant.Size = new System.Drawing.Size(408, 36);
            this.lblCuvant.TabIndex = 28;
            this.lblCuvant.Text = initializere();

            MessageBox.Show(cuvantGhicit);

            this.btnA.Click += new EventHandler(btns_Click);
            this.btnB.Click += new EventHandler(btns_Click);
            this.btnC.Click += new EventHandler(btns_Click);
            this.btnD.Click += new EventHandler(btns_Click);
            this.btnE.Click += new EventHandler(btns_Click);
            this.btnF.Click += new EventHandler(btns_Click);
            this.btnZ.Click += new EventHandler(btns_Click);
            this.btnG.Click += new EventHandler(btns_Click);
            this.btnH.Click += new EventHandler(btns_Click);
            this.btnI.Click += new EventHandler(btns_Click);
            this.btnJ.Click += new EventHandler(btns_Click);
            this.btnK.Click += new EventHandler(btns_Click);
            this.btnL.Click += new EventHandler(btns_Click);
            this.btnM.Click += new EventHandler(btns_Click);
            this.btnN.Click += new EventHandler(btns_Click);
            this.btnO.Click += new EventHandler(btns_Click);
            this.btnP.Click += new EventHandler(btns_Click);
            this.btnQ.Click += new EventHandler(btns_Click);
            this.btnR.Click += new EventHandler(btns_Click);
            this.btnS.Click += new EventHandler(btns_Click);
            this.btnT.Click += new EventHandler(btns_Click);
            this.btnU.Click += new EventHandler(btns_Click);
            this.btnV.Click += new EventHandler(btns_Click);
            this.btnW.Click += new EventHandler(btns_Click);
            this.btnX.Click += new EventHandler(btns_Click);
            this.btnY.Click += new EventHandler(btns_Click);
        
        }
        
        public void citirea()
        {

            string path = Application.StartupPath + @"/data/Cuvinte.txt";

            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {
                cuvante.Add(t);
            }


        }

        public string initializere()
        {
            string t = "";
            for(int i=0;i<cuvantGhicit.Length;i++)
            {
                t += "_ ";
            }

            return t;
        }

        private int g = 0;
        private int ctCuv = 0;

        public void ghicire(string litera)
        {
            int ct = 0;
            for (int i = 0; i < cuvantGhicit.Length; i++)
            {
                
                if (cuvantGhicit[i].ToString() == litera || cuvantGhicit[i].ToString() == litera.ToLower())
                {
                    string textLabelNou = lblCuvant.Text.Substring(0, i * 2) + litera + lblCuvant.Text.Substring(i * 2 + 1);
                    lblCuvant.Text = textLabelNou;
                    ct++;
                }
            }

            if (ct == 0)
            {
                g++;
                int nr = 6 - g;
                if (nr <= 0)
                {
                    lblPunctaj.Text = "Punctaj: " + 0.ToString();
                    MessageBox.Show("Ai pierdut!!", "Ghinion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string textul = controllerRezultate.generareId().ToString() + ";" + 0.ToString() + ";" + utilizator.getemail() + ";" + 0.ToString();
                    controllerRezultate.save(textul);
                    this.form.removePnl("pnlGhiceste");
                    this.form.Controls.Add(new pnlHome(form, utilizator));
                }
                else
                pctImagine.Image = Image.FromFile(Application.StartupPath + @"/StadiiFloare/"+ nr.ToString() +".png");
              
            }
            else
            {
                ctCuv = ctCuv + ct;
            }

            if(ctCuv >= cuvantGhicit.Length)
            {
                MessageBox.Show("Bravo! \n Ai ghicit cuvantul!","Felicitari!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.form.removePnl("pnlGhiceste");
                int rez = 100 - (4 * g);
                string textul = controllerRezultate.generareId().ToString() + ";" + 0.ToString() + ";" + utilizator.getemail() + ";" + rez.ToString();
                controllerRezultate.save(textul);
                this.form.Controls.Add(new pnlHome(form, utilizator));
            }
            int rez1 = 100 - (4 * g);

            lblPunctaj.Text = "Punctaj: " + rez1.ToString();
        }

        private void btns_Click(object sender, EventArgs e)
        {
            string litera = sender.ToString();
            litera = litera[litera.Length - 1].ToString();
            ghicire(litera);
            Button btn = sender as Button;
            btn.Visible = false;

        }



    }
}

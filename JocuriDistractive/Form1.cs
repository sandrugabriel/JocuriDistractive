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
        public Form1()
        {
            InitializeComponent();

            Utilizator a = new Utilizator("popescu.petre@ojti2023.ro;otipopescu;abc123@A");
            this.Controls.Add(new pnlHome(this,a));

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

    }
}

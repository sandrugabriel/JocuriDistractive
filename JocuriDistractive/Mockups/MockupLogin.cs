using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocuriDistractive.Mockups
{
    public partial class MockupLogin : Form
    {
        public MockupLogin()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");
            this.pctBac.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.lblTitlu.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnLogare.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.btnLogare.ForeColor = System.Drawing.Color.White;
        }
    }
}

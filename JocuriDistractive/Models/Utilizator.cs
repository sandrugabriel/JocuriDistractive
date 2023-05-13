using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JocuriDistractive.Models
{
    internal class Utilizator
    {

        private string email;
        private string nume;
        private string password;

        public Utilizator(string email, string nume, string password)
        {
            this.email = email;
            this.nume = nume;
            this.password = password;
        }

        public Utilizator(string textul)
        {

            string[] prop = textul.Split(';');

            this.email = prop[0];
            this.nume = prop[1];
            this.password = prop[2];

        }

        public string getemail()
        {
            return this.email;
        }

        public string getnume()
        {
            return this.nume;
        }

        public string getpadd()
        {
            return this.password;
        }

    }
}

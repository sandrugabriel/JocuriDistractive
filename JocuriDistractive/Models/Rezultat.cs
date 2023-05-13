using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JocuriDistractive.Models
{
    internal class Rezultat
    {

        private int id;
        private int tipJoc;
        private string email;
        private int punctajJoc;

        public Rezultat(int id, int tipJoc, string email, int punctajJoc)
        {
            this.id = id;
            this.tipJoc = tipJoc;
            this.email = email;
            this.punctajJoc = punctajJoc;
        }

        public Rezultat(string text)
        {

            string[] prop = text.Split(';');

            this.id = int.Parse(prop[0]);
            this.tipJoc = int.Parse(prop[1]);
            this.email = prop[2];
            this.punctajJoc = int.Parse(prop[3]);

        }

        public int getId()
        {
            return id;
        }

        public int getTipJoc()
        {
            return tipJoc;
        }

        public string getEmail()
        {
            return email;
        }

        public int getPunctajJoc()
        {
            return punctajJoc;
        }


    }
}

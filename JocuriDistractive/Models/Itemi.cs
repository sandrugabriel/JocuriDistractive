using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JocuriDistractive.Models
{
    internal class Itemi
    {

        private int id;
        private string enuntItem;
        private string raspun1;
        private string raspun2;
        private string raspun3;
        private int raspunsCorect;
        private int punctajItem;

        public Itemi(int id, string enuntItem, string raspun1, string raspun2, string raspun3, int raspunsCorect, int punctajItem)
        {
            this.id = id;
            this.enuntItem = enuntItem;
            this.raspun1 = raspun1;
            this.raspun2 = raspun2;
            this.raspun3 = raspun3;
            this.raspunsCorect = raspunsCorect;
            this.punctajItem = punctajItem;
        }

        public Itemi(string text)
        {

            string[] prop = text.Split(';');

            this.id = int.Parse(prop[0]);
            this.enuntItem = prop[1];
            this.raspun1 = prop[2];
            this.raspun2 = prop[3];
            this.raspun3 = prop[4];
            this.raspunsCorect = int.Parse(prop[5]);
            this.punctajItem = int.Parse(prop[6]);


        }

        public int getId()
        {
            return id;
        }

        public string getEnuntItem()
        {
            return enuntItem;
        }

        public string getRspun1()
        {
            return this.raspun1;
        }

        public string getRspun2()
        {
            return this.raspun2;
        }

        public string getraspuns3()
        {
            return raspun3;
        }

        public int getRaspuCorect()
        {
            return this.raspunsCorect;
        }

        public int getpunctajItem()
        {
            return punctajItem;
        }

    }
}

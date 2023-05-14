using JocuriDistractive.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocuriDistractive.Controllers
{
    internal class ControllerRezultate
    {

        private List<Rezultat> rezultate;

        public ControllerRezultate()
        {

            rezultate = new List<Rezultat>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/Rezultate.txt";
            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {

                Rezultat rezultat = new Rezultat(t);

                rezultate.Add(rezultat);

            }
            
            streamReader.Close();
        }

        public List<Rezultat> getRezultatGhiceste()
        {

            List<Rezultat> list = new List<Rezultat>();

            for(int i=0;i<rezultate.Count;i++)
            {
                if (rezultate[i].getTipJoc() == 0)
                    list.Add(rezultate[i]);
            }

            return list;
        }

        public List<Rezultat> getRezultatSarpe()
        {

            List<Rezultat> list = new List<Rezultat>();

            for (int i = 0; i < rezultate.Count; i++)
            {
                if (rezultate[i].getTipJoc() == 1)
                    list.Add(rezultate[i]);
            }

            return list;
        }

        public List<Rezultat> getCrescGhiceste()
        {

            List<Rezultat> list = getRezultatGhiceste();

            int semn = 1;

            do
            {
                semn = 1;

                for(int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].getPunctajJoc() < list[i + 1].getPunctajJoc())
                    {
                        Rezultat aux = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = aux;
                        semn = 0;
                    }
                }
            }while(semn == 0);

            List<Rezultat> rezultats = new List<Rezultat>();

            for(int i = 0;i < 3; i++)
            {
                rezultats.Add(list[i]);
            }

            return rezultats;
        }


        public List<Rezultat> getCrescSarpe()
        {

            List<Rezultat> list = getRezultatSarpe();

            int semn = 1;

            do
            {
                semn = 1;

                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].getPunctajJoc() < list[i + 1].getPunctajJoc())
                    {
                        Rezultat aux = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = aux;
                        semn = 0;
                    }
                }
            } while (semn == 0);

            List<Rezultat> rezultats = new List<Rezultat>();

            for (int i = 0; i < 3; i++)
            {
                rezultats.Add(list[i]);
            }

            return rezultats;
        }


    }
}

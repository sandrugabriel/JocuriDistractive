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
    internal class ControllerUtilizatori
    {

        private List<Utilizator> utilizatori;

        public ControllerUtilizatori()
        {

            utilizatori = new List<Utilizator>();

            load();

        }
        
        public void load()
        {

            string path = Application.StartupPath + @"/data/Utilizatori.txt";

            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {

                Utilizator utilizator = new Utilizator(t);

                utilizatori.Add(utilizator);
            }


            streamReader.Close();
        }

        public bool verificareCont(string email, string parola)
        {

            for(int i=0;i<utilizatori.Count;i++)
            {

                if (utilizatori[i].getemail().Equals(email) && utilizatori[i].getpadd().Equals(parola))
                    return true;

            }

            return false;
        }


    }
}

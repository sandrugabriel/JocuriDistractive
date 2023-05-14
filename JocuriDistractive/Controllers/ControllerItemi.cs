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
    internal class ControllerItemi
    {

        private List<Itemi> itemii;

        public ControllerItemi()
        {

            itemii = new List<Itemi>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/Itemi.txt";
            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {
                Itemi a = new Itemi(t);

                itemii.Add(a);
            }

            streamReader.Close();
        }

        public Itemi getItemRandom()
        {

            Random random = new Random();

            int dim = random.Next(0, itemii.Count-1);


            return itemii[dim];
        }


    }
}

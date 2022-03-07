using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garage
{
    public partial class afficher : Form
    {
        public afficher()
        {
            InitializeComponent();
        }


        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom = comboBox1.Text;
            foreach(garage G in garagee.l)
            {
                if (G.nom == nom)
                {
                    listBox1.Items.Add(G.aff());
                }
            }

        }

        private void afficher_Load(object sender, EventArgs e)
        {
            foreach(garage G in garagee.l)
            {
                comboBox1.Items.Add(G.nom);
            }
           
        }
    }
}

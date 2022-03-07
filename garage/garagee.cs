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
    public partial class garagee : Form
    {
        public garagee()
        {
            InitializeComponent();
        }
        public static List<garage> l = new List<garage>();

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            garage D = new garage(nom);

            l.Add(D);

            MessageBox.Show("ajoute bien fait", "information");





        }

        private void button2_Click(object sender, EventArgs e)
        {
            afficher f = new afficher();
            f.Show();
        }
    }
    
}

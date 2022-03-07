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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            string modele = textBox2.Text;
            string marque = textBox3.Text;
            int prix = int.Parse(textBox4.Text);
            DateTime date = dateTimePicker1.Value;

            voiture v = new voiture(num , modele , marque , prix , date);//hna liste dyaal voiture
            garage.G.Add(v);//stockinaa voiture fdyaal garage 
            MessageBox.Show("ajoute bien fait", "information");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nu= int.Parse(textBox1.Text);


            foreach( voiture v in garage.G)
            {//hnaa 3la 9beel modif kanssemiw 3laa 9beel voiture
                if (nu == v.Num)
                {
                   v.Num  = int.Parse(textBox1.Text);
                    v.Modele = textBox2.Text;
                    v.Marque = textBox3.Text;
                    v.Prix = int.Parse(textBox4.Text);
                    v.Date = dateTimePicker1.Value;

                    MessageBox.Show("bien modifier", "information");
                }
                else
                {
                    MessageBox.Show("le numero n'existe pas", "information");
                }
               

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nu = int.Parse(textBox1.Text);
            foreach(voiture v in garage.G)
            {
                garage.G.Remove(v);
                MessageBox.Show("bien supprimer", "information");
                break;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            listBox1.Items.Clear();
            listView1.Items.Clear();
            
            int nu = int.Parse(textBox1.Text);
            foreach (voiture v in garage.G)
            {
                dataGridView1.Rows.Add(v.Num, v.Modele, v.Marque, v.Prix, v.Date);
                MessageBox.Show(v.aff(), "information");
                listView1.Items.Add(v.aff());
                listBox1.Items.Add(v.aff());
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("num", "num");
            dataGridView1.Columns.Add("Modele", "Modele");
            dataGridView1.Columns.Add("Marque", "Marque");
            dataGridView1.Columns.Add("Prix", "Prix");
            dataGridView1.Columns.Add("Date", "Date");

           listView1.Items.Add("num",(int)HorizontalAlignment.Left);
            listView1.Items.Add("Modele", (int)HorizontalAlignment.Left);
            listView1.Items.Add("Marque", (int)HorizontalAlignment.Left);
            listView1.Items.Add("Prix", (int)HorizontalAlignment.Left);
            listView1.Items.Add("Date", (int)HorizontalAlignment.Left);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            garagee B = new garagee();
            B.Show();
            this.Hide();
            //b.show bach afficher
            //hide pour cacher bach ikhrojj lina mn la forme lwlaa widooz lina taniaaa
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
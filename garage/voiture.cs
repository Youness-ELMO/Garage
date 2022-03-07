using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garage
{
   public  class voiture
    {
        int num;
        string modele;
        string marque;
        int prix;
        DateTime date;

        public string  aff()
        {
            return("le numero est: "+num+ " le modele est: " + modele+ " la marque est: " + marque + " le prix est: " + prix + " la date est: " + date);
        }



        public voiture() { }

        public voiture(int num, string modele, string marque, int prix, DateTime date)
        {
            this.num = num;
            this.modele = modele;
            this.marque = marque;
            this.prix = prix;
            this.date = date;
        }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public string Modele
        {
            get { return modele; }
            set { modele = value; }
        }

        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }


        public int Prix
        {
            get { return prix; }
            set { prix= value; }
        }


        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}

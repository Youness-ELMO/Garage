using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garage
{
    public class garage:voiture
    {
        public string nom;

        /*public string aff()
        {
            return ("le numero est: " + num + "le modele est: " + modele + "la marque est: " + marque + "le prix est: " + prix + "la date est: " + date);
        }*/

        public garage() { }
        public garage(string nom)
        {
            this.nom = nom;
        }

        //hnaa saybna wa7ed liste dyaal voiture fclasse garage
        public static List<voiture> G = new List<voiture>();




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Etudiant
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string CIN { get; set; }
        public string CNE { get; set; }
        public DateTime DateDeNaissance { get; set; }

        public Etudiant(string nom, string prenom, string cIN, string cNE, DateTime dateDeNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            CIN = cIN;
            CNE = cNE;
            DateDeNaissance = dateDeNaissance;
        }

        public Etudiant(string nom)
        {
            Nom = nom;
        }

        public Etudiant() { }


     
    }
}

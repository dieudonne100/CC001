using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Etudiant
    {
        public string Matricule;
        public string Nom;
        public string Prenom;
        public DateTime Date_naissance;
        public string Lieu_naissance;
        public string Contact;
        public string Email;
        public byte[] Photo { get; set; }

        public Etudiant()
        {

        }

    }
}

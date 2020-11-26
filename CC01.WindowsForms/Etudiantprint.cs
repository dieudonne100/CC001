using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.WindowsForms
{
  public  class Etudiantprint
    {

        public string Matricule;
        public string Nom;
        public string Prenom;
        public DateTime Date_naissance;
        public string Lieu_naissance;
        public string Contact;
        public string Email;
        public byte[] Photo { get; set; }

        public Etudiantprint(string matricule, string nom, string prenom, DateTime date_naissance, string lieu_naissance,
            string contact, string email, byte[] photo)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            Date_naissance = date_naissance;
            Lieu_naissance = lieu_naissance;
            Contact = contact;
            Email = email;
            Photo = photo;
        }
    }
}

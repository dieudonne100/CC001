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
        public string  Contact;
        public string Email;
        public byte[] Photo { get; set; }

        public Etudiant()
        {

        }

        public Etudiant(string nom, string prenom, DateTime date_naissance, string lieu_naissance, string contact, string email, string text, byte[] photo)
        {
            Nom = nom;
            Prenom = prenom;
            Date_naissance = date_naissance;
            Lieu_naissance = lieu_naissance;
            Contact = contact;
            Email = email;
            Photo = photo; 
        }

        public Etudiant(string nom, string prenom, DateTime date_naissance, string lieu_naissance, string contact, string email, string matricule)
        {
            this.Matricule = matricule;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Date_naissance = date_naissance;
            this.Lieu_naissance = lieu_naissance;
            this.Contact = contact;
            this.Email = email;
        }

        public object Non { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                   Matricule == etudiant.Matricule &&
                   Date_naissance == etudiant.Date_naissance;
        }

        public override int GetHashCode()
        {
            int hashCode = 168587438;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Matricule);
            hashCode = hashCode * -1521134295 + Date_naissance.GetHashCode();
            return hashCode;
        }
    }
}

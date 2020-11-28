using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO

{
    [Serializable]
  public  class Ecole
    {
        public string Identifiant { get; set; }
        public string Nom_Ecole { get; set; }
        public string Localisation { get; set; }
        public string ville { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string logo { get; set; }

        public Ecole()//pour la serialisation 
        {

        }

        public Ecole(string identifiant, string nom_Ecole, string localisation, string ville, string email, string contact, string logo)
        {
            Identifiant = identifiant;
            Nom_Ecole = nom_Ecole;
            Localisation = localisation;
            this.ville = ville;
            Email = email;
            Contact = contact;
            this.logo = logo;
        }

        public override bool Equals(object obj)
        {
            return obj is Ecole eole &&
                   Identifiant == eole.Identifiant;
        }

        public override int GetHashCode()
        {
            return 574969646 + EqualityComparer<string>.Default.GetHashCode(Identifiant);
        }
    }


}
using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
   public  class EcoleBLO

    {
            EcoleDAO EcoleRepo;
            public EcoleBLO(string dbFolder)
            {
            EcoleRepo = new Ecole(dbFolder);
            }
            public void CreateEtudiant(Ecole ecole)
            {
            EcoleRepo.Add(ecole);
            }
            public void DeletEtudiant(Ecole ecole)
            {
            EcoleRepo.Remove(ecole);
            }

            public IEnumerable<Ecole> GetAllEtudiant()
            {
                return EcoleRepo.Find();
            }

            public IEnumerable<Ecole> GetBymatricule(string identifiant)
            {
                return EcoleRepo.Find(x => x.Identifiant == identifiant);
            }

            public IEnumerable<Ecole> GetBy(Func<Ecole, bool> perdicate)
            {
                return EcoleRepo.Find(perdicate);
            }
            public void EditProduct(Ecole oldecole, Ecole newecolet)
            {
            EcoleRepo.Set(oldecole, newecolet);
            }
        
    }
}

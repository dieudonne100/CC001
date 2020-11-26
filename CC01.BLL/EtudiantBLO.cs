using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
   
        public class EtudiantBLO
        {
            EtudiantDAO EtudiantRepo;
            public EtudiantBLO(string dbFolder)
            {
                EtudiantRepo = new EtudiantDAO(dbFolder);
            }
            public void CreateEtudiant(Etudiant etudiant)
            {
                EtudiantRepo.Add(etudiant);
            }
            public void DeletEtudiant(Etudiant etudiant)
            {
                EtudiantRepo.Remove(etudiant);
            }

            public IEnumerable<Etudiant> GetAllEtudiant()
            {
                return EtudiantRepo.Find();
            }

            public IEnumerable<Etudiant> GetBymatricule(string matricule)
            {
                return EtudiantRepo.Find(x => x.Matricule == matricule);
            }

            public IEnumerable<Etudiant> GetBy(Func<Etudiant, bool> perdicate)
            {
                return EtudiantRepo.Find(perdicate);
            }
        public void EditProduct(Etudiant oldetudiant,Etudiant newetudiant)
        {
            EtudiantRepo.Set(oldetudiant, newetudiant);
        }
        }
}
        


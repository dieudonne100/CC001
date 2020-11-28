using CC01.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.DAL
{
   public class EcoleDAO
    {

        private List<Ecole> ecoles;
        private const string FILE_NAME = @"etudiants.json";
        private readonly string dbFolder;
        private FileInfo file;
        public EcoleDAO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create()
                    .Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    ecoles = JsonConvert.DeserializeObject<List<Ecole>>(json);
                }
            }
            if (ecoles == null)
            {
                ecoles = new List<Ecole>();
            }


        }

        public void Set(Ecole oldecole, Ecole newecole)
        {
            var oldindex = ecoles.IndexOf(oldecole);
            var newindex = ecoles.IndexOf(newecole);
            if (oldindex < 0)
                throw new KeyNotFoundException("l'ecole existe deja ");
            if (newindex >= 0 && oldindex != newindex)
                throw new DuplicateNameException("le email existe deja");
            ecoles[oldindex] = newecole;
            Save();
        }
        public void Add(Ecole ecole)
        {
            var index = ecoles.IndexOf(ecole);
            if (index >= 0)
                throw new DuplicateNameException("l'ecole existe deja");
            ecoles.Add(ecole);
            Save();
        }

        public void Remove(Ecole ecole)
        {
            ecoles.Add(ecole);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName))
            {
                string json = JsonConvert.SerializeObject(ecoles);
                sw.WriteLine(json);
            }
        }

        public void remove(Ecole ecole)
        {
            ecoles.Remove(ecole);
            Save();
        }

        public IEnumerable<Ecole> Find()
        {
            return new List<Ecole>(ecoles);
        }
        public IEnumerable<Ecole> Find(Func<Ecole, bool> predicate)
        {
            return new List<Ecole>(ecoles.Where(predicate).ToArray());
        }
    }
}


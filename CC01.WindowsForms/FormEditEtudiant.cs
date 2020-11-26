using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WindowsForms
{
    public partial class FormEditEtudiant : Form
    {
        private EtudiantBLO etudiantBLO;

        public FormEditEtudiant()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
        
    }
        private void loadData()
        {
            string value = txtRecherche.Text.ToLower();
            var etudiants = etudiantBLO.GetBy
            (
                x =>
                x.Matricule.ToLower().Contains(value) ||
                x.Nom.ToLower().Contains(value)
            ).OrderBy(x => x.Matricule).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = etudiants;
            lblCount.Text = $"{dataGridView1.RowCount} rows";
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = etudiants;
            lblCount.Text = $"{dataGridView1.RowCount} rows";
            dataGridView1.ClearSelection();

        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Form f = new FormCarteEditEtudiant();
            f.Show();
        }

        private void FormEditEtudiant_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRecherche.Text))
                loadData();
            else
                txtRecherche.Clear();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new FormCarteEditEtudiant(dataGridView1.SelectedRows[i].DataBoundItem as Etudiant,
                        loadData);
                    f.ShowDialog();
                }
          
        }
    }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("voulez vous vraiment supprimer l'etudiant??", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                for(int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    etudiantBLO.DeletEtudiant(dataGridView1.SelectedRows[i].DataBoundItem as Etudiant);
                    loadData();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<Etudiantprint> items = new List<Etudiantprint>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {

                Etudiant etud = dataGridView1.  Rows[i].DataBoundItem as Etudiant;
                items.Add(new Etudiantprint(
                    etud.Matricule,
                    etud.Nom,
                    etud.Prenom,
                    etud.Date_naissance,
                    etud.Lieu_naissance,
                    etud.Contact,
                    etud.Email,
                    etud.Photo
                    )
                    );
            }
            Form f = new FormPreview("EtudiantListe.rdlc", items);
            f.Show();
        }
    }
}

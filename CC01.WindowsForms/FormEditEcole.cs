using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WindowsForms
{
    public partial class FormListeEcole : Form
    {
        public FormListeEcole()
        {
            InitializeComponent();
        }

        

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Form f = new FormEcole();
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("voulez vous vraiment supprimer l'etudiant??", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    
            }
        }
    }
}

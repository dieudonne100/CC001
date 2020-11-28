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
    public partial class Formmenu : Form
    {
        public Formmenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ecoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormEcole();
            f.Show();
        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormEditEtudiant();
            f.Show();
        }
    }
}

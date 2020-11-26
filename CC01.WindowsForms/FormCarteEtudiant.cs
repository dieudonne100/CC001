using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WindowsForms
{
    public partial class FormCarteEditEtudiant : Form
    {
        private Action Callback;
        private Etudiant oldetudiant;
        public FormCarteEditEtudiant()
        {
            InitializeComponent();
        }
        public FormCarteEditEtudiant(Action callback) : this()
        {
            this.Callback = callback;
        }
        public FormCarteEditEtudiant(Etudiant etudiant, Action callback) : this(callback)
        {
            this.oldetudiant = etudiant;
            txtNom.Text = etudiant.Nom;
            txtPrenom.Text = etudiant.Prenom.ToString();
            txtA.Text = etudiant.Email;
            txtemail.Text = etudiant.Lieu_naissance;
            txtcontact.Text = etudiant.Contact.ToString();
            dateTim.Text = etudiant.Date_naissance.ToLongDateString(); ;
            txtMatricule.Text = etudiant.Matricule.ToString();
            pictureBox1.Image = etudiant.Photo !=null?  Image.FromStream(new MemoryStream(etudiant.Photo)): null; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                checkForm();
                Etudiant etudiant = new Etudiant(txtNom.Text.ToUpper(), txtPrenom.Text,
              DateTime.Parse(dateTim.Text), txtA.Text, txtMatricule.Text, txtemail.Text, txtcontact.Text, !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation):this.oldetudiant?.Photo) ;  
                EtudiantBLO etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
                etudiantBLO.CreateEtudiant(etudiant);
                MessageBox.Show(
                    "Save done !",
                     "Confirm",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information

                    );
                if (Callback != null)
                    Callback();
                if (oldetudiant != null)
                    Close();
                txtMatricule.Clear();
                txtNom.Clear();
                txtPrenom.Clear();
                txtcontact.Clear();
                txtemail.Clear();
                txtNom.Focus();


            }
            catch (TypingException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Typing error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Duplicate error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (Exception ex)
            {
                ex.WriteTiFile();

                    MessageBox.Show
               (
                   ex.Message,
                   "Erreur d'occurence",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
           

        }
        private void checkForm()
        {
            string text = string.Empty;
            txtNom.BackColor = Color.White;
            txtPrenom.BackColor = Color.White;
            txtMatricule.BackColor = Color.White;
            txtcontact.BackColor = Color.White;
            txtemail.BackColor = Color.White;
            txtA.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtNom.Text))
                text += " veillez entrez le nom \n";
            txtNom.BackColor = Color.BurlyWood;
            if (string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                text += "veillez entrez le prenom !\n ";
                txtPrenom.BackColor = Color.BurlyWood;
            }
            if (string.IsNullOrWhiteSpace(txtMatricule.Text))
            {
                text += "veillez entrez le matricule !\n ";
                txtMatricule.BackColor = Color.BurlyWood;
            }
            if (string.IsNullOrWhiteSpace(txtcontact.Text))
            {
                text += "veillez entrez le matricule !\n ";
                txtcontact.BackColor = Color.BurlyWood;
            }
            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                text += "veillez entrez le matricule !\n ";
                txtemail.BackColor = Color.BurlyWood;
            }
            if (string.IsNullOrWhiteSpace(txtA.Text))
            {
                text += "veillez entrez le matricule !\n ";
                txtA.BackColor = Color.BurlyWood;
            }

            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choisir la photo";
            ofd.Filter = "File image | *.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
            else
            {
                pictureBox1.ImageLocation = null;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
        }
    }
}

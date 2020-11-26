
namespace CC01.WindowsForms
{
    partial class Formmenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etudiantToolStripMenuItem,
            this.ecoleToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // etudiantToolStripMenuItem
            // 
            this.etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            this.etudiantToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.etudiantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.etudiantToolStripMenuItem.Text = "Etudiant";
            this.etudiantToolStripMenuItem.Click += new System.EventHandler(this.etudiantToolStripMenuItem_Click);
            // 
            // ecoleToolStripMenuItem
            // 
            this.ecoleToolStripMenuItem.Name = "ecoleToolStripMenuItem";
            this.ecoleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.ecoleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ecoleToolStripMenuItem.Text = "Ecole";
            this.ecoleToolStripMenuItem.Click += new System.EventHandler(this.ecoleToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Formmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}


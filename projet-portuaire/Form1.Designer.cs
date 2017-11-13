namespace projet_portuaire
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bateauxOnglet = new System.Windows.Forms.TabPage();
            this.armateursOnglet = new System.Windows.Forms.TabPage();
            this.cargaisonsOnglet = new System.Windows.Forms.TabPage();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 612);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(558, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 612);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.bateauxOnglet);
            this.tabControl1.Controls.Add(this.armateursOnglet);
            this.tabControl1.Controls.Add(this.cargaisonsOnglet);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 609);
            this.tabControl1.TabIndex = 0;
            // 
            // bateauxOnglet
            // 
            this.bateauxOnglet.Location = new System.Drawing.Point(4, 25);
            this.bateauxOnglet.Name = "bateauxOnglet";
            this.bateauxOnglet.Padding = new System.Windows.Forms.Padding(3);
            this.bateauxOnglet.Size = new System.Drawing.Size(523, 580);
            this.bateauxOnglet.TabIndex = 0;
            this.bateauxOnglet.Text = "Bateaux";
            this.bateauxOnglet.UseVisualStyleBackColor = true;
            // 
            // armateursOnglet
            // 
            this.armateursOnglet.Location = new System.Drawing.Point(4, 25);
            this.armateursOnglet.Name = "armateursOnglet";
            this.armateursOnglet.Padding = new System.Windows.Forms.Padding(3);
            this.armateursOnglet.Size = new System.Drawing.Size(523, 580);
            this.armateursOnglet.TabIndex = 1;
            this.armateursOnglet.Text = "Armateurs";
            this.armateursOnglet.UseVisualStyleBackColor = true;
            // 
            // cargaisonsOnglet
            // 
            this.cargaisonsOnglet.Location = new System.Drawing.Point(4, 25);
            this.cargaisonsOnglet.Name = "cargaisonsOnglet";
            this.cargaisonsOnglet.Size = new System.Drawing.Size(523, 580);
            this.cargaisonsOnglet.TabIndex = 2;
            this.cargaisonsOnglet.Text = "Cargaisons";
            this.cargaisonsOnglet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 636);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bateauxOnglet;
        private System.Windows.Forms.TabPage armateursOnglet;
        private System.Windows.Forms.TabPage cargaisonsOnglet;
    }
}


namespace projet_portuaire
{
    partial class VuePrincipale
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
            this.panelImage = new System.Windows.Forms.Panel();
            this.panelTab = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.bateauxOnglet = new System.Windows.Forms.TabPage();
            this.tableauBateaux = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.armateuBateaux = new System.Windows.Forms.Label();
            this.matieresDangereuseBateaux = new System.Windows.Forms.Label();
            this.tailleBateaux = new System.Windows.Forms.Label();
            this.poidsBateaux = new System.Windows.Forms.Label();
            this.armateursOnglet = new System.Windows.Forms.TabPage();
            this.cargaisonsOnglet = new System.Windows.Forms.TabPage();
            this.panelTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.bateauxOnglet.SuspendLayout();
            this.tableauBateaux.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImage
            // 
            this.panelImage.Location = new System.Drawing.Point(12, 12);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(540, 612);
            this.panelImage.TabIndex = 0;
            // 
            // panelTab
            // 
            this.panelTab.Controls.Add(this.tabControl);
            this.panelTab.Location = new System.Drawing.Point(558, 12);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(534, 612);
            this.panelTab.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.bateauxOnglet);
            this.tabControl.Controls.Add(this.armateursOnglet);
            this.tabControl.Controls.Add(this.cargaisonsOnglet);
            this.tabControl.Location = new System.Drawing.Point(3, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(531, 612);
            this.tabControl.TabIndex = 0;
            // 
            // bateauxOnglet
            // 
            this.bateauxOnglet.Controls.Add(this.tableauBateaux);
            this.bateauxOnglet.Location = new System.Drawing.Point(4, 25);
            this.bateauxOnglet.Name = "bateauxOnglet";
            this.bateauxOnglet.Padding = new System.Windows.Forms.Padding(3);
            this.bateauxOnglet.Size = new System.Drawing.Size(523, 583);
            this.bateauxOnglet.TabIndex = 0;
            this.bateauxOnglet.Text = "Bateaux";
            this.bateauxOnglet.UseVisualStyleBackColor = true;
            // 
            // tableauBateaux
            // 
            this.tableauBateaux.ColumnCount = 5;
            this.tableauBateaux.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableauBateaux.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableauBateaux.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableauBateaux.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableauBateaux.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableauBateaux.Controls.Add(this.label2, 0, 0);
            this.tableauBateaux.Controls.Add(this.armateuBateaux, 0, 0);
            this.tableauBateaux.Controls.Add(this.matieresDangereuseBateaux, 0, 0);
            this.tableauBateaux.Controls.Add(this.tailleBateaux, 0, 0);
            this.tableauBateaux.Controls.Add(this.poidsBateaux, 0, 0);
            this.tableauBateaux.Location = new System.Drawing.Point(6, 6);
            this.tableauBateaux.Name = "tableauBateaux";
            this.tableauBateaux.RowCount = 1;
            this.tableauBateaux.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableauBateaux.Size = new System.Drawing.Size(511, 43);
            this.tableauBateaux.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(316, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(102, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matières dangereuses";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // armateuBateaux
            // 
            this.armateuBateaux.BackColor = System.Drawing.Color.LightGray;
            this.armateuBateaux.Location = new System.Drawing.Point(418, 0);
            this.armateuBateaux.Margin = new System.Windows.Forms.Padding(0);
            this.armateuBateaux.Name = "armateuBateaux";
            this.armateuBateaux.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.armateuBateaux.Size = new System.Drawing.Size(93, 43);
            this.armateuBateaux.TabIndex = 3;
            this.armateuBateaux.Text = "Armateur";
            this.armateuBateaux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matieresDangereuseBateaux
            // 
            this.matieresDangereuseBateaux.BackColor = System.Drawing.Color.LightGray;
            this.matieresDangereuseBateaux.Location = new System.Drawing.Point(200, 0);
            this.matieresDangereuseBateaux.Margin = new System.Windows.Forms.Padding(0);
            this.matieresDangereuseBateaux.Name = "matieresDangereuseBateaux";
            this.matieresDangereuseBateaux.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.matieresDangereuseBateaux.Size = new System.Drawing.Size(116, 43);
            this.matieresDangereuseBateaux.TabIndex = 2;
            this.matieresDangereuseBateaux.Text = "Matières dangereuses";
            this.matieresDangereuseBateaux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tailleBateaux
            // 
            this.tailleBateaux.BackColor = System.Drawing.Color.LightGray;
            this.tailleBateaux.Location = new System.Drawing.Point(0, 0);
            this.tailleBateaux.Margin = new System.Windows.Forms.Padding(0);
            this.tailleBateaux.Name = "tailleBateaux";
            this.tailleBateaux.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tailleBateaux.Size = new System.Drawing.Size(100, 43);
            this.tailleBateaux.TabIndex = 1;
            this.tailleBateaux.Text = "Taille";
            this.tailleBateaux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poidsBateaux
            // 
            this.poidsBateaux.BackColor = System.Drawing.Color.LightGray;
            this.poidsBateaux.Location = new System.Drawing.Point(100, 0);
            this.poidsBateaux.Margin = new System.Windows.Forms.Padding(0);
            this.poidsBateaux.Name = "poidsBateaux";
            this.poidsBateaux.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.poidsBateaux.Size = new System.Drawing.Size(100, 43);
            this.poidsBateaux.TabIndex = 0;
            this.poidsBateaux.Text = "Poids";
            this.poidsBateaux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // armateursOnglet
            // 
            this.armateursOnglet.Location = new System.Drawing.Point(4, 25);
            this.armateursOnglet.Name = "armateursOnglet";
            this.armateursOnglet.Padding = new System.Windows.Forms.Padding(3);
            this.armateursOnglet.Size = new System.Drawing.Size(523, 583);
            this.armateursOnglet.TabIndex = 1;
            this.armateursOnglet.Text = "Armateurs";
            this.armateursOnglet.UseVisualStyleBackColor = true;
            // 
            // cargaisonsOnglet
            // 
            this.cargaisonsOnglet.Location = new System.Drawing.Point(4, 25);
            this.cargaisonsOnglet.Name = "cargaisonsOnglet";
            this.cargaisonsOnglet.Size = new System.Drawing.Size(523, 583);
            this.cargaisonsOnglet.TabIndex = 2;
            this.cargaisonsOnglet.Text = "Cargaisons";
            this.cargaisonsOnglet.UseVisualStyleBackColor = true;
            // 
            // VuePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 636);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.panelImage);
            this.Name = "VuePrincipale";
            this.Text = "Vue principale";
            this.panelTab.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.bateauxOnglet.ResumeLayout(false);
            this.tableauBateaux.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage armateursOnglet;
        private System.Windows.Forms.TabPage cargaisonsOnglet;
        private System.Windows.Forms.TabPage bateauxOnglet;
        private System.Windows.Forms.TableLayoutPanel tableauBateaux;
        private System.Windows.Forms.Label poidsBateaux;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label armateuBateaux;
        private System.Windows.Forms.Label matieresDangereuseBateaux;
        private System.Windows.Forms.Label tailleBateaux;
    }
}


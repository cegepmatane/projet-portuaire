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
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageGoogle = new System.Windows.Forms.PictureBox();
            this.panelTab = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.bateauxOnglet = new System.Windows.Forms.TabPage();
            this.vueListeBateau = new System.Windows.Forms.ListView();
            this.nomColoneTailleBateau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomColonePoidsBateau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomColoneMatieresDangereusesBateau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomColoneArmateurBateau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.armateursOnglet = new System.Windows.Forms.TabPage();
            this.cargaisonsOnglet = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGoogle)).BeginInit();
            this.panelTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.bateauxOnglet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.pictureBox6);
            this.panelImage.Controls.Add(this.pictureBox5);
            this.panelImage.Controls.Add(this.pictureBox3);
            this.panelImage.Controls.Add(this.pictureBox2);
            this.panelImage.Controls.Add(this.imageGoogle);
            this.panelImage.Location = new System.Drawing.Point(12, 12);
            this.panelImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(540, 612);
            this.panelImage.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::projet_portuaire.Properties.Resources.markerRouge;
            this.pictureBox6.Location = new System.Drawing.Point(360, 286);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::projet_portuaire.Properties.Resources.markerRouge;
            this.pictureBox5.Location = new System.Drawing.Point(335, 450);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::projet_portuaire.Properties.Resources.markerRouge;
            this.pictureBox3.Location = new System.Drawing.Point(305, 404);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::projet_portuaire.Properties.Resources.markerRouge;
            this.pictureBox2.Location = new System.Drawing.Point(277, 377);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // imageGoogle
            // 
            this.imageGoogle.Image = global::projet_portuaire.Properties.Resources.ImagePortMatane;
            this.imageGoogle.Location = new System.Drawing.Point(0, 27);
            this.imageGoogle.Margin = new System.Windows.Forms.Padding(4);
            this.imageGoogle.Name = "imageGoogle";
            this.imageGoogle.Size = new System.Drawing.Size(536, 549);
            this.imageGoogle.TabIndex = 0;
            this.imageGoogle.TabStop = false;
            // 
            // panelTab
            // 
            this.panelTab.Controls.Add(this.tabControl);
            this.panelTab.Location = new System.Drawing.Point(557, 12);
            this.panelTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(533, 612);
            this.panelTab.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.bateauxOnglet);
            this.tabControl.Controls.Add(this.armateursOnglet);
            this.tabControl.Controls.Add(this.cargaisonsOnglet);
            this.tabControl.Location = new System.Drawing.Point(3, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(531, 612);
            this.tabControl.TabIndex = 0;
            // 
            // bateauxOnglet
            // 
            this.bateauxOnglet.Controls.Add(this.vueListeBateau);
            this.bateauxOnglet.Location = new System.Drawing.Point(4, 25);
            this.bateauxOnglet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bateauxOnglet.Name = "bateauxOnglet";
            this.bateauxOnglet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bateauxOnglet.Size = new System.Drawing.Size(523, 583);
            this.bateauxOnglet.TabIndex = 0;
            this.bateauxOnglet.Text = "Bateaux";
            this.bateauxOnglet.UseVisualStyleBackColor = true;
            // 
            // vueListeBateau
            // 
            this.vueListeBateau.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomColoneTailleBateau,
            this.nomColonePoidsBateau,
            this.nomColoneMatieresDangereusesBateau,
            this.columnHeader4,
            this.nomColoneArmateurBateau});
            this.vueListeBateau.GridLines = true;
            this.vueListeBateau.Location = new System.Drawing.Point(8, 5);
            this.vueListeBateau.Name = "vueListeBateau";
            this.vueListeBateau.Size = new System.Drawing.Size(509, 573);
            this.vueListeBateau.TabIndex = 2;
            this.vueListeBateau.UseCompatibleStateImageBehavior = false;
            this.vueListeBateau.View = System.Windows.Forms.View.Details;
            // 
            // nomColoneTailleBateau
            // 
            this.nomColoneTailleBateau.Text = "Taille";
            this.nomColoneTailleBateau.Width = 91;
            // 
            // nomColonePoidsBateau
            // 
            this.nomColonePoidsBateau.Text = "Poids";
            this.nomColonePoidsBateau.Width = 77;
            // 
            // nomColoneMatieresDangereusesBateau
            // 
            this.nomColoneMatieresDangereusesBateau.Text = "Matières dangereuses";
            this.nomColoneMatieresDangereusesBateau.Width = 158;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 91;
            // 
            // nomColoneArmateurBateau
            // 
            this.nomColoneArmateurBateau.Text = "Armateurs";
            this.nomColoneArmateurBateau.Width = 88;
            // 
            // armateursOnglet
            // 
            this.armateursOnglet.Location = new System.Drawing.Point(4, 25);
            this.armateursOnglet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.armateursOnglet.Name = "armateursOnglet";
            this.armateursOnglet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.armateursOnglet.Size = new System.Drawing.Size(523, 583);
            this.armateursOnglet.TabIndex = 1;
            this.armateursOnglet.Text = "Armateurs";
            this.armateursOnglet.UseVisualStyleBackColor = true;
            // 
            // cargaisonsOnglet
            // 
            this.cargaisonsOnglet.Location = new System.Drawing.Point(4, 25);
            this.cargaisonsOnglet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VuePrincipale";
            this.Text = "Vue principale";
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGoogle)).EndInit();
            this.panelTab.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.bateauxOnglet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage armateursOnglet;
        private System.Windows.Forms.TabPage cargaisonsOnglet;
        private System.Windows.Forms.TabPage bateauxOnglet;
        private System.Windows.Forms.PictureBox imageGoogle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView vueListeBateau;
        private System.Windows.Forms.ColumnHeader nomColoneTailleBateau;
        private System.Windows.Forms.ColumnHeader nomColonePoidsBateau;
        private System.Windows.Forms.ColumnHeader nomColoneMatieresDangereusesBateau;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader nomColoneArmateurBateau;
    }
}


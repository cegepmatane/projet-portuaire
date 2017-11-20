using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_portuaire
{
    class Fenetre : Form
    {
        private Label labelTitre;
        private Label labelNumeroPosteAQuai;
        private Label numeroPosteAQuai;
        private String descriptionTitre;
        private Label label1;
        private Label LongueurAccostages;
        private String descriptionNumeroPosteAQuai;
        private Label label2;
        private Label profondeurDesPostes;
        private String descriptionLongueurAccostage;
        private Label label3;
        private Label CapacitePortante;
        private String descriptionProfondeurDesPostes;
        private String descriptionCapacitePortante;

        public Fenetre()
        {
            this.Text = "Détail du quai";
            InitializeComponent();

        }

        public void choisirInformationsQuai(int numeroQuai)
        {
            switch(numeroQuai)
            {
                case 1:
                    descriptionTitre = "Quai commercial";
                    descriptionNumeroPosteAQuai = "1";
                    descriptionLongueurAccostage = "186.0 m";
                    descriptionProfondeurDesPostes = "10.0 m";
                    descriptionCapacitePortante = "30.0 kPa";
                    break;

                case 2:
                    descriptionTitre = "Quai éperon";
                    descriptionNumeroPosteAQuai = "2";
                    descriptionLongueurAccostage = "92.0 m";
                    descriptionProfondeurDesPostes = "4.9 m";
                    descriptionCapacitePortante = "7.0 kPa";
                    break;

                case 3:
                    descriptionTitre = "Quai éperon";
                    descriptionNumeroPosteAQuai = "3";
                    descriptionLongueurAccostage = "134.0 m";
                    descriptionProfondeurDesPostes = "4.0 m";
                    descriptionCapacitePortante = "7.0 kPa";
                    break;

                case 4:
                    descriptionTitre = "Traversier";
                    descriptionNumeroPosteAQuai = "4";
                    descriptionLongueurAccostage = "230.0 m";
                    descriptionProfondeurDesPostes = "10.0 m";
                    descriptionCapacitePortante = "10.0 kPa";
                    break;
            }
            
            ajouterTexteALaFenetre();
        }

        public void ajouterTexteALaFenetre()
        {
            labelTitre.Text = descriptionTitre;
            numeroPosteAQuai.Text = descriptionNumeroPosteAQuai;
            LongueurAccostages.Text = descriptionLongueurAccostage;
            profondeurDesPostes.Text = descriptionProfondeurDesPostes;
            CapacitePortante.Text = descriptionCapacitePortante;
        }

        private void InitializeComponent()
        {
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelNumeroPosteAQuai = new System.Windows.Forms.Label();
            this.numeroPosteAQuai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LongueurAccostages = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profondeurDesPostes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CapacitePortante = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(68, 9);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(144, 20);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Quai Commercial";
            this.labelTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNumeroPosteAQuai
            // 
            this.labelNumeroPosteAQuai.AutoSize = true;
            this.labelNumeroPosteAQuai.Location = new System.Drawing.Point(13, 49);
            this.labelNumeroPosteAQuai.Name = "labelNumeroPosteAQuai";
            this.labelNumeroPosteAQuai.Size = new System.Drawing.Size(111, 13);
            this.labelNumeroPosteAQuai.TabIndex = 1;
            this.labelNumeroPosteAQuai.Text = "Numéro poste à quai :";
            // 
            // numeroPosteAQuai
            // 
            this.numeroPosteAQuai.AutoSize = true;
            this.numeroPosteAQuai.Location = new System.Drawing.Point(131, 49);
            this.numeroPosteAQuai.Name = "numeroPosteAQuai";
            this.numeroPosteAQuai.Size = new System.Drawing.Size(0, 13);
            this.numeroPosteAQuai.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Longueur des postes d\'accostages :";
            // 
            // LongueurAccostages
            // 
            this.LongueurAccostages.AutoSize = true;
            this.LongueurAccostages.Location = new System.Drawing.Point(198, 77);
            this.LongueurAccostages.Name = "LongueurAccostages";
            this.LongueurAccostages.Size = new System.Drawing.Size(0, 13);
            this.LongueurAccostages.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Profondeur des postes :";
            // 
            // profondeurDesPostes
            // 
            this.profondeurDesPostes.AutoSize = true;
            this.profondeurDesPostes.Location = new System.Drawing.Point(139, 108);
            this.profondeurDesPostes.Name = "profondeurDesPostes";
            this.profondeurDesPostes.Size = new System.Drawing.Size(0, 13);
            this.profondeurDesPostes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Capacité portante de l\'aire de chargement :";
            // 
            // CapacitePortante
            // 
            this.CapacitePortante.AutoSize = true;
            this.CapacitePortante.Location = new System.Drawing.Point(233, 139);
            this.CapacitePortante.Name = "CapacitePortante";
            this.CapacitePortante.Size = new System.Drawing.Size(0, 13);
            this.CapacitePortante.TabIndex = 8;
            // 
            // Fenetre
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CapacitePortante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.profondeurDesPostes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LongueurAccostages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeroPosteAQuai);
            this.Controls.Add(this.labelNumeroPosteAQuai);
            this.Controls.Add(this.labelTitre);
            this.Name = "Fenetre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }

    
}

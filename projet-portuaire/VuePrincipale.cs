using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_portuaire{
    public partial class VuePrincipale : Form{
        Fenetre fenetrePopUp;
        public VuePrincipale(){
            InitializeComponent();
            initialisationImage();
        }

        private void tailleBateaux_Click(object sender, EventArgs e)
        {
            // For Add New Row (Loop this code for add multiple rows)
            tableauBateaux.RowCount = tableauBateaux.RowCount + 1;
        }


        private void initialisationImage()
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.Show();
        }
    }
}

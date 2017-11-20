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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.Show();

            creeItemList(vueListeBateau, "ZDZQD/qzdqzd/A/zdz/ZZ");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            creeItemList(vueListeBateau, "Hello/Mon/Nom/Est/Francis");
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

        private void creeItemList(ListView listView, String chaine)
        {
            var chaineCoupee = chaine.Split('/');
            listView.Items.Clear();
            ListViewItem listeItemVue = null;
            for (int i = 0; i < chaineCoupee.Length; i++)
            {
                if (i == 0)
                {
                    listeItemVue = new ListViewItem(chaineCoupee[i]);
                }
                else
                {
                    listeItemVue.SubItems.Add(chaineCoupee[i]);
                }
            }
            listView.Items.Add(listeItemVue);
        }
    }
}

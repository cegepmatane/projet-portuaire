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
        private VueListBateau vueListeBateau;

        public VuePrincipale(){
            InitializeComponent();
            vueListeBateau = new VueListBateau(tableauListeBateau);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.Show();
            vueListeBateau.modifierListPort1();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.Show();
            vueListeBateau.modifierListPort1();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.Show();
            vueListeBateau.modifierListPort1();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.Show();
            vueListeBateau.modifierListPort1();
        }

        //Pour creer item list
        public static void creeItemList(ListView listView, String chaine) {
            var chaineCoupee = chaine.Split('/');
            listView.Items.Clear();
            ListViewItem listeItemVue = null;
            for (int i = 0; i < chaineCoupee.Length; i++) {
                if (i == 0) {
                    listeItemVue = new ListViewItem(chaineCoupee[i]);
                } else {
                    listeItemVue.SubItems.Add(chaineCoupee[i]);
                }
            }
            listView.Items.Add(listeItemVue);
        }
    }
}

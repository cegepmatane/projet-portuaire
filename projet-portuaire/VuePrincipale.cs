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
        private VueListeCargaisons vueListeCargaisons;
        private VueListeArmateur vueListArmateur;

        public VuePrincipale(){
            InitializeComponent();
            vueListeBateau = new VueListBateau(tableauListeBateau);
            vueListeCargaisons = new VueListeCargaisons(tableauListeCargaison);
            vueListArmateur = new VueListeArmateur(tableauListeArmateurs);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.choisirInformationsQuai(1);
            fenetrePopUp.Show();
            vueListeBateau.modifierListQuai1();
            vueListeCargaisons.modifierListQuai1();
            vueListArmateur.modifierListeQuai1();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.choisirInformationsQuai(2);
            fenetrePopUp.Show();
            vueListeBateau.modifierListQuai2();
            vueListeCargaisons.modifierListQuai2();
            vueListArmateur.modifierListeQuai2();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.choisirInformationsQuai(3);
            fenetrePopUp.Show();
            vueListeBateau.modifierListQuai3();
            vueListeCargaisons.modifierListQuai3();
            vueListArmateur.modifierListeQuai3();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            fenetrePopUp = new Fenetre();
            fenetrePopUp.choisirInformationsQuai(4);
            fenetrePopUp.Show();
            vueListeBateau.modifierListQuai4();
            vueListeCargaisons.modifierListQuai4();
            vueListArmateur.modifierListeQuai4();
        }

        //Pour creer item list
        public static void creeItemList(ListView listView, String chaine) {
            var chaineCoupee = chaine.Split('/');
            ListViewItem listeItemVue = null;
            for (int i = 0; i < chaineCoupee.Length; i++) {
                if (i == 0) {
                    listeItemVue = new ListViewItem(chaineCoupee[i]);
                } else {
                    listeItemVue.SubItems.Add(chaineCoupee[i]);
                    listeItemVue.Selected = false;
                }
            }
            listView.Items.Add(listeItemVue);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace projet_portuaire
{
    class VueListeCargaisons
    {
        private ListView listeView;

        public VueListeCargaisons(ListView listeView)
        {
            this.listeView = listeView;
        }

        public void modifierListQuai1()
        {
            listeView.Items.Clear();
            VuePrincipale.creeItemList(listeView, "Charbon/non");
            VuePrincipale.creeItemList(listeView, "Textiles/non");
            VuePrincipale.creeItemList(listeView, "Appareils électroniques/non");
            VuePrincipale.creeItemList(listeView, "Meubles/non");
        }

        public void modifierListQuai2()
        {
            listeView.Items.Clear();
            VuePrincipale.creeItemList(listeView, "Uranium/oui");
            VuePrincipale.creeItemList(listeView, "Amiante/oui");
            VuePrincipale.creeItemList(listeView, "Animaux/oui");
            VuePrincipale.creeItemList(listeView, "Produits de laboratoire/oui");
        }

        public void modifierListQuai3()
        {
            listeView.Items.Clear();
            VuePrincipale.creeItemList(listeView, "Acier/non");
            VuePrincipale.creeItemList(listeView, "Bois/non");
            VuePrincipale.creeItemList(listeView, "Hydrogène/oui");
            VuePrincipale.creeItemList(listeView, "Végétaux/non");
        }

        public void modifierListQuai4()
        {
            listeView.Items.Clear();
            VuePrincipale.creeItemList(listeView, "Nourriture/non");
            VuePrincipale.creeItemList(listeView, "Voitures/non");
            VuePrincipale.creeItemList(listeView, "Camions/non");
        }
    }
}

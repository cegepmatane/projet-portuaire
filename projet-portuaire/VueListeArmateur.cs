using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_portuaire {
    class VueListeArmateur {

        private ListView listView;

        public VueListeArmateur(ListView listView) {
            this.listView = listView;
        }

        public void modifierListeQuai1() {
            listView.Items.Clear();
            VuePrincipale.creeItemList(listView, "Brittany Ferries/Transports de passagers");
            VuePrincipale.creeItemList(listView, "CMA CGM/Transport de marchandises conteneurisées");
        }

        public void modifierListeQuai2() {
            listView.Items.Clear();
            VuePrincipale.creeItemList(listView, "LD Bulk/Transport de vrac sec");
            VuePrincipale.creeItemList(listView, "DFDS Seaways/Transports de passagers");
        }

        public void modifierListeQuai3() {
            listView.Items.Clear();
            VuePrincipale.creeItemList(listView, "Marfret/Transport de marchandises conteneurisées");
            VuePrincipale.creeItemList(listView, "Orange Marine/Activités offshore");
        }

        public void modifierListeQuai4() {
            listView.Items.Clear();
            VuePrincipale.creeItemList(listView, "Genavir/Océanographie et recherche sous-marine");
            VuePrincipale.creeItemList(listView, "MARITIMA SA/Transport de vrac liquide");
        }


    }
}

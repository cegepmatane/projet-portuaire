using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_portuaire {
    class VueListBateau
    {
        private ListView listView;

        public VueListBateau(ListView listView)
        {
            this.listView = listView;
        }

        public void modifierListQuai1()
        {
            listView.Items.Clear();
            VuePrincipale.creeItemList(listView, "150x20m/12 000t/50/Boluda France");
            VuePrincipale.creeItemList(listView, "100x20m/8 000t/55/Compagnie du Ponant");
        }

        public void modifierListQuai2()
        {
            listView.Items.Clear();
            VuePrincipale.creeItemList(listView, "130x40m/13 000t/43/Comex");
            VuePrincipale.creeItemList(listView, "95x20m/12 000t/25/Compagnie du Ponant");
        }

        public void modifierListQuai3() {
            listView.Items.Clear();
            VuePrincipale.creeItemList(listView, "100x30m/11 000t/48/Compagnie du Ponant");
            VuePrincipale.creeItemList(listView, "130x50m/9 000t/30/Boluda France");
        }

        public void modifierListQuai4() {
            listView.Items.Clear();
            VuePrincipale.creeItemList(listView, "133.2x22.4m/10 000t/35/NM F-A Gauthier");
        }
    }
}

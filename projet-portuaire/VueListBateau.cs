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

        public void modifierListPort1()
        {
            VuePrincipale.creeItemList(listView, "TOTO/ZDZQD/ZDQZD/ZDQZD/ZQDQZD");
        }
    }
}

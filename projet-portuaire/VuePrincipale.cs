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
        public VuePrincipale(){
            InitializeComponent();
        }

        private void tailleBateaux_Click(object sender, EventArgs e)
        {
            // For Add New Row (Loop this code for add multiple rows)
            tableauBateaux.RowCount = tableauBateaux.RowCount + 1;
        }
    }
}

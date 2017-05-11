using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDesDoctorantsV2
{
    public partial class AjouterInscription : Form
    {
        public AjouterInscription()
        {
            InitializeComponent();
        }

        private void AjouterInscription_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phdDbFinalDataSet2.Doctorant' table. You can move, or remove it, as needed.
            this.doctorantTableAdapter.Fill(this.phdDbFinalDataSet2.Doctorant);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

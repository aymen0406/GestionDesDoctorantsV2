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
    public partial class AjouterDirecteurDeThese : Form
    {
        public string nommembre;
        public string prenommembre;
        public AjouterDirecteurDeThese(string NomMembre1,string PrenomMembre1)
        {
            InitializeComponent();
            nommembre = NomMembre1;
            prenommembre = PrenomMembre1;
            txtNomFr.Text= nommembre;
            txtPrenomFr.Text = prenommembre;
            
        }


        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterDirecteurDeThese_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(208, 209, 216), 2);
            e.Graphics.DrawRectangle(couleur, 1, 1, this.Width - 2, this.Height - 2);
        }

        
    }
}

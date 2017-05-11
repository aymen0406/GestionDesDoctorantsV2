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
    public partial class AjoutDeuxiemeEncadrant : Form
    {
        public string nommembre;
        public string prenommembre;
        public AjoutDeuxiemeEncadrant(string NomMembre1, string PrenomMembre1)
        {
            InitializeComponent();
           
            nommembre = NomMembre1;
            prenommembre = PrenomMembre1;
            txtNomFr.Text = nommembre;
            txtPrenomFr.Text = prenommembre;
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjoutDeuxiemeEncadrant_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(51, 122, 183), 2);
            e.Graphics.DrawRectangle(couleur, 1, 1, this.Width - 2, this.Height - 2);
        }

        private void panelEnregistrer_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelEnregistrer.Width - 1, panelEnregistrer.Height - 1);
        }

        private void panelAnnuler_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelEnregistrer.Width - 1, panelEnregistrer.Height - 1);
        }

        private void panelAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Inscription : Form
    {


        public Inscription()
        {
            InitializeComponent();



            //BloquerErreur();
            panel2.Visible = true;
            panel1.Visible = true;

        }
      
       
        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
        
        private void panelClose_MouseEnter(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(228, 17, 41);
        }

        private void panelClose_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.Transparent;
        }

        private void panelAnnuler_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
       
        }

        private void panelEnregistrer_MouseEnter(object sender, EventArgs e)
        {
            panelEnregistrer.BackColor = Color.FromArgb(133, 202, 255);
            labelEnregistrer.ForeColor = Color.White;
        }

        private void panelEnregistrer_MouseLeave(object sender, EventArgs e)
        {
            panelEnregistrer.BackColor = Color.Transparent;
            labelEnregistrer.ForeColor = Color.FromArgb(10, 56, 84);
        }

        private void panelAnnuler_MouseEnter(object sender, EventArgs e)
        {
            panelAnnuler.BackColor = Color.FromArgb(133, 202, 255);
            labelAnnuler.ForeColor = Color.White;
        }

        private void panelAnnuler_MouseLeave(object sender, EventArgs e)
        {
            panelAnnuler.BackColor = Color.Transparent;
            labelAnnuler.ForeColor = Color.FromArgb(10, 56, 84);
        }

        private void panelEnregistrer_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelEnregistrer.Width - 1, panelEnregistrer.Height - 1);
        }

        private void panelAnnuler_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelAnnuler.Width - 1, panelAnnuler.Height - 1);
        }

        //private void btnAjouter_MouseEnter(object sender, EventArgs e)
        //{
        //    btnAjouter.BackColor = Color.FromArgb(133, 202, 255);
        //    labelAjouter.ForeColor = Color.White;
        //}

        //private void btnAjouter_MouseLeave(object sender, EventArgs e)
        //{
        //    btnAjouter.BackColor = Color.Transparent;
        //    labelAjouter.ForeColor = Color.FromArgb(10, 56, 84);
        //}

        //private void btnAjouter_Paint(object sender, PaintEventArgs e)
        //{
        //    Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
        //    e.Graphics.DrawRectangle(couleur, 0, 0, btnAjouter.Width - 1, btnAjouter.Height - 1);
        //}


       

        private void Inscription_Load(object sender, EventArgs e)
        {
            panelClose.Height = panelTitre.Height;
            panelClose.Width = panelTitre.Height;
            panelClose.Location = new Point(panelTitre.Width - panelTitre.Height, 0);
        }

        private void Inscription_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(51, 122, 183), 2);
            e.Graphics.DrawRectangle(couleur, 1, 1, this.Width - 2, this.Height - 2);
        }

        private void DGVConge_DoubleClick(object sender, EventArgs e)
        {
            panel2.Visible=false;
            panel1.Visible = true;

        }

        

       
       

    }
}

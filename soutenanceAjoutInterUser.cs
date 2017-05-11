using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDesDoctorantsV2
{
    public partial class soutenanceAjoutInterUser : UserControl
    {
         int nbClick = 0;
       
        public soutenanceAjoutInterUser()
        {
            InitializeComponent();
            btnCancelSoutFich.Visible = true;
            btnSaveSoutFich.Visible = true;
            cmbxMembre1.Visible = false;
            cmbxRoleMembre1.Visible = false;
            cmbxMembre2.Visible = false;
            cmbxRoleMembre2.Visible = false;
            cmbxMembre3.Visible = false;
            cmbxRoleMembre3.Visible = false;
            lblSoutNomFich.Visible = false;
            lblSoutRol.Visible = false;
           
            

        }

        private void btnCancelSoutFich_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Parent.Visible = false;
        }

        private void btnAddMemFich_Click(object sender, EventArgs e)
        {

            nbClick++; 
            if (nbClick == 1)
            {
                lblSoutNomFich.Visible = true;
                lblSoutRol.Visible = true;
                cmbxMembre1.Visible = true;
                cmbxRoleMembre1.Visible = true;

            }

            else if (nbClick == 2)
            {
                lblSoutNomFich.Visible = true;
                lblSoutRol.Visible = true;
                cmbxMembre2.Visible = true;
                cmbxRoleMembre2.Visible = true;

            }
            else if (nbClick == 3)
            {
                lblSoutNomFich.Visible = true;
                lblSoutRol.Visible = true;
                cmbxMembre3.Visible = true;
                cmbxRoleMembre3.Visible = true;

            }

            else if (nbClick == 4)
            {
                lblSoutNomFich.Visible = true;
                lblSoutRol.Visible = true;
                MessageBox.Show("Le jury est composé d'au plus 8 Membre");
                nbClick--;
            }
            
        }

        private void btnDelMemFich_Click(object sender, EventArgs e)
        {
            nbClick--;
            if (nbClick == 2)
            {
                lblSoutNomFich.Visible = true;
                lblSoutRol.Visible = true;
                cmbxMembre3.Visible = false;
                cmbxRoleMembre3.Visible = false;

            }

            else if (nbClick == 1)
            {
                lblSoutNomFich.Visible = true;
                lblSoutRol.Visible = true;
                cmbxMembre2.Visible = false;
                cmbxRoleMembre2.Visible = false;

            }
            else if (nbClick == 0)
            {
                lblSoutNomFich.Visible = false;
                lblSoutRol.Visible = false;
                cmbxMembre1.Visible = false;
                cmbxRoleMembre1.Visible = false;
                
            }
            else if (nbClick==-1)
            { nbClick++; }

        }

        

        private void btnSaveSoutFich_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnSaveSoutFich.Width - 1, btnSaveSoutFich.Height - 1);
        }

        private void btnCancelSoutFich_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnCancelSoutFich.Width - 1, btnCancelSoutFich.Height - 1);
        }
        
        
    }
}

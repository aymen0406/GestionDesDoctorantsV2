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
    public partial class ChoixAjoutEncadrant : Form
    {
        public ChoixAjoutEncadrant()
        {
            InitializeComponent();
        }      

        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChoixAjoutEncadrant_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(208, 209, 216), 2);
            e.Graphics.DrawRectangle(couleur, 1, 1, this.Width - 2, this.Height - 2);
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
            this.Close();
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

        private void ChoixAjoutEnseignant_Load(object sender, EventArgs e)
        {
            panelClose.Height = panelTitre.Height;
            panelClose.Width = panelTitre.Height;
            panelClose.Location = new Point(panelTitre.Width - panelTitre.Height, 0);
        }

        private void txtCin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // Set l'evenement comme etant completement fini
                return;
            }
        }

        private void panelEnregistrer_Click(object sender, EventArgs e)
        {
            if (cmbxTypeEncadreur.Text == "")
            {
                ErreurTypeEncadrant.Visible = true;
            }
            else
            {
                ErreurTypeEncadrant.Visible = false;
            }
            if (txtNomEncadrant.Text == "")
            {
                ErreurNomEncad.Visible = true;
            }
            else
            {
                ErreurNomEncad.Visible = false;
            }
            if (txtPrenomEncadrant.Text == "")
            {
                ErreurPrenomEncad.Visible = true;
            }
            else
            {
                ErreurPrenomEncad.Visible = false;
            }
            if ((txtNomEncadrant.Text != "") && (txtPrenomEncadrant.Text !="") && (cmbxTypeEncadreur.Text != ""))
            {
                string NomEncadrant = txtNomEncadrant.Text;
                string PrenomEncadrant = txtPrenomEncadrant.Text;
                string type = cmbxTypeEncadreur.Text;
                DAL.DALEnseignantChercheur M = new DAL.DALEnseignantChercheur();
                int nb = M.Chechk_Enseignant_Chercheur_Unicity(NomEncadrant, PrenomEncadrant);
                
                if (nb > 0)
                { MessageBox.Show("Membre existe déjà!!"); }
                else
                {
                    if ((type == "Directeur de thèse") )
                    {
                        AjouterDirecteurDeThese dthese = new AjouterDirecteurDeThese(NomEncadrant,PrenomEncadrant);
                        this.Close();
                         
                        dthese.Show();
                        
                    }
                    if ((type == "Co-Encadrant") )
                    {
                        AjoutDeuxiemeEncadrant frm = new AjoutDeuxiemeEncadrant(NomEncadrant, PrenomEncadrant);
                        this.Close();
                        frm.ShowDialog();
                        
                    }
                   

                    /////////nouveau enseignant
                    //if ((type == "Permanent") && (nb != 1))
                    //{
                    //    EnseignantPermanent frm = new EnseignantPermanent(CIN);
                    //    frm.ShowDialog();
                    //    this.Close();
                    //}
                    //if ((type == "Expert") && (nb != 1))
                    //{
                    //    EnseignantTemporaire frm = new EnseignantTemporaire(CIN, "Expert");
                    //    frm.ShowDialog();
                    //    this.Close();
                    //}
                    //if ((type == "Vacataire") && (nb != 1))
                    //{
                    //    EnseignantTemporaire frm = new EnseignantTemporaire(CIN, "Vacataire");
                    //    frm.ShowDialog();
                    //    this.Close();
                    //}
                    //if ((type == "Contractuel") && (nb != 1))
                    //{
                    //    EnseignantTemporaire frm = new EnseignantTemporaire(CIN, "Contractuel");
                    //    frm.ShowDialog();
                    //    this.Close();
                    //}
                }
            }
        }

        //private void panelEnregistrer_Click(object sender, EventArgs e)
        //{
        //    AjouterDirecteurDeThese dthese = new AjouterDirecteurDeThese();
        //    dthese.Visible=true;
        //    this.Close();
        //}
    }
}

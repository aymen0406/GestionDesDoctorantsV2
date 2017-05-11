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
    public partial class FormAddEtab : Form
    {
        int type, id;
        
        public FormAddEtab(int type1, int id1)
        {
            InitializeComponent();
            type = type1;
            id = id1;
            CacherErreurFr();
            if (id != 0)
            {
                Entities.Etablissement E1 = new Entities.Etablissement();
                DAL.DALEtablissement E = new DAL.DALEtablissement();
                E1 = E.SelectById(id);
                BindDataTotheInterface(E1);
            }
        }

        void BindDataTotheInterface(Entities.Etablissement G)
        {
            txtEtablissement.Text = G.NomEtablissement.Trim();
            txtPays.Text = G.Pays.Trim();
            txtVille.Text = G.Ville.Trim();
        }
        public void CacherErreurFr()
        {
            ErreurIntituleFr.Visible = false;
            ErreurIntituleFr1.Visible = false;
            
        }
        public void AfficherErreurFr()
        {
            if (txtEtablissement.Text == "")
                ErreurIntituleFr.Visible = true;
            else
                ErreurIntituleFr.Visible = false;

            if (txtPays.Text == "")
                ErreurIntituleFr1.Visible = true;
            else
                ErreurIntituleFr1.Visible = false;

            

        }
        public bool ExistErreur()
        {
            if ((txtEtablissement.Text == "") || (txtPays.Text == "") || (txtVille.Text == ""))
                return true;
            else
                return false;
        }     
        Entities.Etablissement GetDataFromInterface()
        {
            Entities.Etablissement E = new Entities.Etablissement();
            E.NomEtablissement = txtEtablissement.Text;
            E.Pays = txtPays.Text;
            E.Ville = txtVille.Text;
            return E;
        }
        void BindDataToInterface(Entities.Etablissement E)
        {
            txtEtablissement.Text = E.NomEtablissement.Trim();
            txtPays.Text = E.Pays.Trim();
            txtVille.Text = E.Ville.Trim();
        }

        private void panelEnregistrer_Click(object sender, EventArgs e)
        {
            bool res;
            res = ExistErreur();
            Entities.Etablissement c = new Entities.Etablissement();
            c = GetDataFromInterface();
            DAL.DALEtablissement C = new DAL.DALEtablissement();
            int i = C.ChechkKeyUnicity(c.NomEtablissement);

            if (res == true)
            {
                AfficherErreurFr();
            }
            else
            {
                c = GetDataFromInterface();
                if (type == 1)
                {
                    if (i == 0)
                    {
                        C.InsertEtablissement(c);
                        MessageBox.Show("Ajout bien éffectuée");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ce code existe deja veuillez Verifier");
                    }
                }
                else
                {
                    C.UpdateEtablissement(id, c);
                    MessageBox.Show("Modification bien éffectuée");
                    this.Close();
                }
            }
        }

        private void FormAddEtab_Load(object sender, EventArgs e)
        {
            panelClose.Height = panelTitre.Height;
            panelClose.Width = panelTitre.Height;
            //if (langue == "Arabe")
            //    panelClose.Location = new Point(0, 0);
            //else
                panelClose.Location = new Point(panelTitre.Width - panelClose.Width, 0);
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddEtab_Paint(object sender, PaintEventArgs e)
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
            e.Graphics.DrawRectangle(couleur, 0, 0, panelAnnuler.Width - 1, panelAnnuler.Height - 1);
        }

        private void panelAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

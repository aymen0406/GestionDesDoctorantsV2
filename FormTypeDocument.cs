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
    public partial class FormTypeDocument : Form
    {
        string langue;
        int type;
        int id1;
        public FormTypeDocument(int type1, int id)
        {
            InitializeComponent();
           
            type = type1;
            id1 = id;
            CacherErreurFr();
            if(id!=0)
            {
                Entities.TypeDocument C1 = new Entities.TypeDocument();
                DAL.DALTypeDocument D = new DAL.DALTypeDocument();
                C1 = D.SelectById(id);
                BindDataToTheInterface(C1);
            }          
        }

        public void CacherErreurFr()
        {
            ErreurIntituleFr.Visible = false;
            ErreurIntituleFr1.Visible = false;
            ErreurAbreviationFr.Visible = false;
        }
        public void AfficherErreurFr()
        {
            if (txtIntitule.Text == "")
                ErreurIntituleFr.Visible = true;
            else
                ErreurIntituleFr.Visible = false;

            if (txtIntitule1.Text == "")
                ErreurIntituleFr1.Visible = true;
            else
                ErreurIntituleFr1.Visible = false;

            if (txtCode.Text == "")
                ErreurAbreviationFr.Visible = true;
            else
                ErreurAbreviationFr.Visible = false;

        }
        public void ViderFormulaire()
        {
            txtIntitule.Text = "";
            txtIntitule1.Text = "";
            txtCode.Text = "";
        }
        public bool ExistErreur()
        {
            if ((txtIntitule.Text == "") || (txtIntitule1.Text == "") || (txtCode.Text == ""))
                return true;
            else
                return false;
        }

        Entities.TypeDocument GetDataFromInterface()
        {
            Entities.TypeDocument d = new Entities.TypeDocument();
            d.Code = txtCode.Text;
            d.LibelleFr = txtIntitule.Text;
            d.LibelleAr = txtIntitule1.Text;
           
            return d;
        }

        void BindDataToTheInterface(Entities.TypeDocument d)
        {
            txtCode.Text = d.Code.Trim();
            txtIntitule.Text = d.LibelleFr.Trim();
            txtIntitule1.Text = d.LibelleAr.Trim();
        }
        
        private void FormDepartement_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(51, 122, 183), 2);
            e.Graphics.DrawRectangle(couleur, 1, 1, this.Width - 2, this.Height - 2);
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

        private void panelEnregistrer_Click(object sender, EventArgs e)
        {
            bool res;
            res = ExistErreur();
            Entities.TypeDocument D = new Entities.TypeDocument();
            D = GetDataFromInterface();
            DAL.DALTypeDocument D1 = new DAL.DALTypeDocument();
            int nb = D1.ChechkKeyUnicity(D.Code);
            if (res == true)
            {
                AfficherErreurFr();
            }
            else
            {
                if (type == 1)//ajout
                {
                    if (nb == 0)//n'existe pas 
                    {
                        D1.InsertTypeDocumente(D);
                    }
                    else//existe
                    {
                        MessageBox.Show("Ce code existe déjà veuillez vérifier");
                    }
                }
                else// modif
                {
                    D1.UpdateTypeDocumente(id1, D);
                }
                this.Close();
            }
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

        private void FormDepartement_Load(object sender, EventArgs e)
        {
            panelClose.Height = panelTitre.Height;
            panelClose.Width = panelTitre.Height;
            panelClose.Location = new Point(panelTitre.Width - panelClose.Width, 0);
        }
    }
}

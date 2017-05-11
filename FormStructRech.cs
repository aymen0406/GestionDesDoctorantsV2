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
    public partial class FormStructRech : Form
    {
        string langue;
        int type;
        int Code1;
        public FormStructRech(int type1, int code)
        {
            InitializeComponent();
            
            type = type1;
            Code1 = code;
            CacherErreurFr();
            if(code!=0)
            {
                //Entitée.ResponsabiliteAdministratif f = new Entitée.ResponsabiliteAdministratif();
                //DAL.DALResponsabiliteAdministratif R1 = new DAL.DALResponsabiliteAdministratif();
                //f = R1.SelectById(Code1);
                //BindDataTotheInterface(f);
            }
        }

        public void CacherErreurFr()
        {
            //ErreurIntituleFr.Visible = false;
            //ErreurNomStructRech.Visible = false;
            //ErreurAbreviationFr.Visible = false;
        }
        public void AfficherErreurFr()
        {
            //if (txtIntitule.Text == "")
            //    ErreurIntituleFr.Visible = true;
            //else
            //    ErreurIntituleFr.Visible = false;

            //if (txtIntitule1.Text == "")
            //    ErreurNomStructRech.Visible = true;
            //else
            //    ErreurNomStructRech.Visible = false;

            //if (txtAbreviation.Text == "")
            //    ErreurAbreviationFr.Visible = true;
            //else
            //    ErreurAbreviationFr.Visible = false;

        }
        public void ViderFormulaire()
        {
            //txtIntitule.Text = "";
            //txtIntitule1.Text = "";
            //txtAbreviation.Text = "";
        }
        //public bool ExistErreur()
        //{
        //    if ((txtIntitule.Text == "") || (txtIntitule1.Text == "") || (txtAbreviation.Text == ""))
        //        return true;
        //    else
        //        return false;
        //}
        //void BindDataTotheInterface(Entitée.ResponsabiliteAdministratif f)
        //{
        //    txtAbreviation.Text = f.Code.Trim();
        //    txtIntitule.Text = f.IntituleFr.Trim();
        //    txtIntitule1.Text = f.IntituleAr.Trim();
        //}
        //Entitée.ResponsabiliteAdministratif GetDataFromTheInterface()
        //{
        //    Entitée.ResponsabiliteAdministratif f = new Entitée.ResponsabiliteAdministratif();
        //    f.Code = txtAbreviation.Text;
        //    f.IntituleFr = txtIntitule.Text;
        //    f.IntituleAr = txtIntitule1.Text;
        //    return f;
        //}
       
        private void FormFonctionnalite_Paint(object sender, PaintEventArgs e)
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

        //private void panelEnregistrer_Click(object sender, EventArgs e)
        //{
        //    bool res;
        //    res = ExistErreur();
        //    Entitée.ResponsabiliteAdministratif R = new Entitée.ResponsabiliteAdministratif();
        //    R = GetDataFromTheInterface();
        //    DAL.DALResponsabiliteAdministratif R1 = new DAL.DALResponsabiliteAdministratif();
        //    int nb = R1.ChechkKeyUnicity(R.Code);
        //    if (res == true)
        //    {
        //        AfficherErreurFr();
        //    }
        //    else
        //    {
        //        if (type == 1)
        //        {
        //            if (nb == 0)
        //            {
        //                R1.InsertResponsabilite(R);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Ce code existe dejà veuillez vérifier");
        //            }
        //        }
        //        else
        //        {
        //            R1.UpdateResponsabilite(Code1, R);
        //        }
        //        this.Close();
        //    }
        //}

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

        private void FormResponsabilite_Load(object sender, EventArgs e)
        {
            panelClose.Height = panelTitre.Height;
            panelClose.Width = panelTitre.Height;
            panelClose.Location = new Point(panelTitre.Width - panelClose.Width, 0);
        }

    }
}

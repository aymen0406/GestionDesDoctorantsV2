using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDesDoctorantsV2
{
    public partial class GestionCompte : Form
    {
        //int Id;
        int mode;
        int IdUser;
        public GestionCompte(int id1 )
        {
            InitializeComponent();
            txtPseudo.ReadOnly = true;
            txtPwd.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtNomPrenom.ReadOnly = true;
            txtTelephone.ReadOnly = true;
            IdUser = id1;
        //    if (IdUser != 0)
        //    {
        //        Entitée.Compte C = new Entitée.Compte();
        //        DAL.DALComptes DALC = new DAL.DALComptes();
        //        C = DALC.SelectById(IdUser);
        //        BindDataToInterface(C);
        //    }
        //}

        //Entitée.Compte GetDataFromInterface()
        //{
        //    Entitée.Compte C = new Entitée.Compte();
        //    C.Pseudo = txtPseudo.Text;
        //    C.MotDePasse = txtPwd.Text;
        //    C.Email = txtEmail.Text;
        //    C.NomPrenom = txtNomPrenom.Text;
        //    C.Telephone = int.Parse(txtTelephone.Text);
        //    return C;
        }
        
        //void BindDataToInterface(Entitée.Compte C)
        //{
        //    txtPseudo.Text = C.Pseudo.Trim();
        //    txtPwd.Text = C.MotDePasse.Trim();
        //    txtEmail.Text = C.Email.Trim();
        //    txtNomPrenom.Text = C.NomPrenom.Trim();
        //    txtTelephone.Text = "" + C.Telephone;
        //}

        public static bool IsValidMail(string mail_address)
        {
            Regex myRegex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.IgnoreCase);
            return myRegex.IsMatch(mail_address);
        }

        //public void CacherErreur()
        //{
        //    ErreurNom.Visible = false;
        //    ErreurPrenom.Visible = false;
        //    ErreurLogin.Visible = false;
        //    ErreurPassword.Visible = false;
        //    ErreurTel.Visible = false;
        //    ErreurMail.Visible = false;
        //}
        //public void AfficherErreur()
        //{
        //    if (txtNom.Text == "")
        //        ErreurNom.Visible = true;
        //    else
        //        ErreurNom.Visible = false;


        //    if (txtPrenom.Text == "")
        //        ErreurPrenom.Visible = true;
        //    else
        //        ErreurPrenom.Visible = false;


        //    if (txtLogin.Text == "")
        //        ErreurLogin.Visible = true;
        //    else
        //        ErreurLogin.Visible = false;


        //    if (txtPassword.Text == "")
        //        ErreurPassword.Visible = true;
        //    else
        //        ErreurPassword.Visible = false;


        //    if (txtTel.Text == "")
        //        ErreurTel.Visible = true;
        //    else
        //        ErreurTel.Visible = false;


        //    if ((txtMail.Text == "") || (IsValidMail(txtMail.Text) == false))
        //        ErreurMail.Visible = true;
        //    else
        //        ErreurMail.Visible = false;
        //}
        //public void ViderForm()
        //{
        //    txtNom.Text = "";
        //    txtPrenom.Text = "";
        //    txtLogin.Text = "";
        //    txtPassword.Text = "";
        //    txtTel.Text = "";
        //    txtMail.Text = "";
        //}
        //public bool ExistErreur()
        //{
        //    if ((txtNom.Text == "") || (txtPrenom.Text == "") || (txtLogin.Text == "") || (txtPassword.Text == "") || (txtTel.Text == "") || (txtMail.Text == "") || (IsValidMail(txtMail.Text) == false))
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        private void GestionCompte_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(51, 122, 183), 2);
            e.Graphics.DrawRectangle(couleur, 1, 1, this.Width - 2, this.Height - 2);
        }

        private void btnModifier_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnModifier.Width - 1, btnModifier.Height - 1);
        }

        private void btnModifier_MouseEnter(object sender, EventArgs e)
        {
            btnModifier.BackColor = Color.FromArgb(133, 202, 255);
            labelModifier.ForeColor = Color.White;
        }
        private void btnModifier_MouseLeave(object sender, EventArgs e)
        {
            btnModifier.BackColor = Color.White;
            labelModifier.ForeColor = Color.FromArgb(10, 56, 84);
        }

        private void panelClose_MouseEnter(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(228, 17, 41);
        }

        private void panelClose_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.Transparent;
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelAnnuler_Click(object sender, EventArgs e)
        {
            //CacherErreur();
            //ViderForm();
            this.Close();
        }

        //private void panelEnregistrer_Click(object sender, EventArgs e)
        //{
        //    if (mode == 0)
        //    {
        //        Entitée.Compte C = new Entitée.Compte();
        //        C = GetDataFromInterface();
        //        DAL.DALComptes DALC = new DAL.DALComptes();
        //        DALC.InsertCompte(C);
        //        MessageBox.Show("compte bien ajoutée");
        //    }
        //    else
        //    {
        //        Entitée.Compte C = new Entitée.Compte();
        //        C = GetDataFromInterface();
        //        C.IdCompte = IdUser;
        //        DAL.DALComptes DALC = new DAL.DALComptes();
        //        DALC.UpdateCompte(C);
        //        MessageBox.Show("compte bien modifiée");
        //    }
        //}

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

        private void GestionCompte_Load(object sender, EventArgs e)
        {
            panelClose.Height = panelTitre.Height;
            panelClose.Width = panelTitre.Height;
            panelClose.Location = new Point(panelTitre.Width - panelTitre.Height, 0);
        }

        private void labelModifier_Click(object sender, EventArgs e)
        {
            panelEnregistrer.Visible = true;
            panelAnnuler.Visible = true;
            btnModifier.Visible = false;
            txtPwd.UseSystemPasswordChar = false;
            txtPseudo.ReadOnly = false;
            txtPwd.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtNomPrenom.ReadOnly = false;
            txtTelephone.ReadOnly = false;
        }

        private void panelAnnuler_Click_1(object sender, EventArgs e)
        {
            panelEnregistrer.Visible = false;
            panelAnnuler.Visible = false;
            btnModifier.Visible = true;
            txtPwd.UseSystemPasswordChar = true;
            txtPseudo.ReadOnly = true;
            txtPwd.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtNomPrenom.ReadOnly = true;
            txtTelephone.ReadOnly = true;
        }

        //private void labelEnregistrer_Click(object sender, EventArgs e)
        //{
        //    panelEnregistrer.Visible = false;
        //    panelAnnuler.Visible = false;
        //    btnModifier.Visible = true;
        //    txtPwd.UseSystemPasswordChar = true;
        //    txtPseudo.ReadOnly = true;
        //    txtPwd.ReadOnly = true;
        //    txtEmail.ReadOnly = true;
        //    txtNomPrenom.ReadOnly = true;
        //    txtTelephone.ReadOnly = true;
        //    Entitée.Compte C = new Entitée.Compte();
        //    C = GetDataFromInterface();
        //    C.IdCompte = IdUser;
        //    DAL.DALComptes DALC = new DAL.DALComptes();
        //    DALC.UpdateCompte(C);
        //    MessageBox.Show("compte bien modifiée");
        //}
    }
}

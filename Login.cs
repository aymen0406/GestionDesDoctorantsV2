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
    public partial class Login : Form
    {
        public int IdUser;
        public Login()
        {
            InitializeComponent();
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 2);
            e.Graphics.DrawRectangle(couleur, 1, 1, this.Width - 2, this.Height - 2);
        }

        //private void panelConnection_Click(object sender, EventArgs e)
        //{
        //    DAL.DALComptes DALC = new DAL.DALComptes();
        //    IdUser = DALC.ExistCompte(textBoxPseudo.Text, textBoxMDP.Text);
        //    if (IdUser > 0)
        //        this.Close();
        //    else
        //    {
        //        panelErreur.Visible = true;
        //        labelErreur.Visible = true;
        //    }
        //}

        private void panelPseudo_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(188, 188, 188), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelPseudo.Width - 1, panelPseudo.Height - 1);
        }

        private void panelpwd_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(188, 188, 188), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelpwd.Width - 1, panelpwd.Height - 1);
        }

        private void textBoxPseudo_Click(object sender, EventArgs e)
        {
            labelPseudo.Visible = false;
            textBoxPseudo.Visible = true;
            panelLigne.Visible = true;
            panelLigne2.Visible = false;
        }

        private void textBoxMDP_Click(object sender, EventArgs e)
        {
            labelMDP.Visible = false;
            textBoxMDP.Visible = true;
            panelLigne2.Visible = true;
            panelLigne.Visible = false;
        }

        private void labelPseudo_Click(object sender, EventArgs e)
        {
            labelPseudo.Visible = false;
            textBoxPseudo.Visible = true;
            panelLigne.Visible = true;
            panelLigne2.Visible = false;
        }

        private void labelMDP_Click(object sender, EventArgs e)
        {
            labelMDP.Visible = false;
            textBoxMDP.Visible = true;
            panelLigne2.Visible = true;
            panelLigne.Visible = false;
        }

        private void textBoxPseudo_TextChanged(object sender, EventArgs e)
        {
            labelPseudo.Visible = false;
            textBoxPseudo.Visible = true;
            panelLigne.Visible = true;
            panelLigne2.Visible = false;
        }

        private void textBoxMDP_TextChanged(object sender, EventArgs e)
        {
            labelMDP.Visible = false;
            textBoxMDP.Visible = true;
            panelLigne2.Visible = true;
            panelLigne.Visible = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            panelLigne.Visible = false;
            panelLigne2.Visible = false;
        }

        private void checkBoxAffiche_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAffiche.Checked)
                textBoxMDP.UseSystemPasswordChar = false;
            else
                textBoxMDP.UseSystemPasswordChar = true;
        }

        private void panelErreur_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.Red, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelErreur.Width - 1, panelErreur.Height - 1);
        }
    }
}

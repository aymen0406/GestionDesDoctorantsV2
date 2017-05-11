using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDesDoctorantsV2
{
    public partial class CompteFr : UserControl
    {
        int w, h;
        DataTable dt = new DataTable();
        public CompteFr(int w1, int h1)
        {
            InitializeComponent();
            w = w1;
            h = h1;
            this.Height = h;
            this.Width = w;
        }

       
        private void CompteFr_Load(object sender, EventArgs e)
        {
            this.Width = w;
            this.Height = h;

            groupBoxRecherche.Location = new Point(10, 10);
            groupBoxRecherche.Width = this.Width - 200;
            groupBoxRecherche.Height = 60;

            groupBoxGrid.Location = new Point(10, 75);
            groupBoxGrid.Width = this.Width - 200;
            groupBoxGrid.Height = this.Height - 85;

            DGVComptes.Width = groupBoxGrid.Width - 20;
            DGVComptes.Height = groupBoxGrid.Height - 25;
            DGVComptes.Location = new Point(10, 15);

            int x = (DGVComptes.Width) / 4;
            DGVComptes.Columns[0].Width = x;
            DGVComptes.Columns[1].Width = x;
            DGVComptes.Columns[2].Width = x;
            DGVComptes.Columns[3].Width = x;

            groupBoxBoutton.Location = new Point(groupBoxRecherche.Width + 20, 10);
            groupBoxBoutton.Width = 170;
            groupBoxBoutton.Height = this.Height - 20;
         //   RaffraichirGrid();
        }

        //public void RaffraichirGrid()
        //{
        //    DAL.DALComptes DALC = new DAL.DALComptes();
        //    dt = DALC.SelectAllCompte();
        //    DGVComptes.Rows.Clear();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        DGVComptes.Rows.Add(dt.Rows[i][1].ToString().Trim(), dt.Rows[i][3].ToString().Trim(), dt.Rows[i][4].ToString().Trim(), dt.Rows[i][5].ToString().Trim());
        //    }
        //}

        private void groupBoxBoutton_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, groupBoxBoutton.Width - 1, groupBoxBoutton.Height - 1);
        }

        private void groupBoxRecherche_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, groupBoxRecherche.Width - 1, groupBoxRecherche.Height - 1);
        }

        private void DGVComptes_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, DGVComptes.Width - 1, DGVComptes.Height - 1);
        }

        private void btnAjouter_MouseEnter(object sender, EventArgs e)
        {
            btnAjouter.BackColor = Color.FromArgb(133, 202, 255);
            labelAjouter.ForeColor = Color.White;
        }

        private void btnAjouter_MouseLeave(object sender, EventArgs e)
        {
            btnAjouter.BackColor = Color.White;
            labelAjouter.ForeColor = Color.FromArgb(10, 56, 84);
        }

        private void btnAjouter_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnAjouter.Width - 1, btnAjouter.Height - 1);
        }

        private void btnModifier_MouseEnter(object sender, EventArgs e)
        {
            btnModifier.BackColor = Color.FromArgb(133, 202, 255);
            labelModifier.ForeColor = Color.White;
        }

        private void btnSupprimer_MouseEnter(object sender, EventArgs e)
        {
            btnSupprimer.BackColor = Color.FromArgb(133, 202, 255);
            labelSupprimer.ForeColor = Color.White;
        }

        private void btnModifier_MouseLeave(object sender, EventArgs e)
        {
            btnModifier.BackColor = Color.White;
            labelModifier.ForeColor = Color.FromArgb(10, 56, 84);
        }

        private void btnSupprimer_MouseLeave(object sender, EventArgs e)
        {
            btnSupprimer.BackColor = Color.White;
            labelSupprimer.ForeColor = Color.FromArgb(10, 56, 84);
        }


        private void btnModifier_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnModifier.Width - 1, btnModifier.Height - 1);
        }

        private void btnSupprimer_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnSupprimer.Width - 1, btnSupprimer.Height - 1);
        }

        private void labelAjouter_Click(object sender, EventArgs e)
        {
            //GestionCompte frm = new GestionCompte(0, 0);
            //frm.ShowDialog();
            //RaffraichirGrid();
        }

        private void labelModifier_Click(object sender, EventArgs e)
        {
            //int x = DGVComptes.CurrentRow.Index;
            //int id = int.Parse(dt.Rows[x][0].ToString());
            //GestionCompte frm = new GestionCompte(id, 1);
            //frm.ShowDialog();
            //RaffraichirGrid();
        }

        //private void labelSupprimer_Click(object sender, EventArgs e)
        //{
        //    int x = DGVComptes.CurrentRow.Index;
        //    int id = int.Parse(dt.Rows[x][0].ToString());
        //    DAL.DALComptes DALC = new DAL.DALComptes();
        //    DALC.DeleteCompte(id);
        //    MessageBox.Show("Compte bien supprimée");
        //    RaffraichirGrid();
        //}
    }
}

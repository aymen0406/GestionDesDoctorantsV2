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
    public partial class PanelEncadrantAff : UserControl
    {
        int w, h;
        public PanelEncadrantAff(int w1, int h1)
        {
            InitializeComponent();
            w = w1;
            h = h1;
            this.Height = h;
            this.Width = w; 
        }

        private void groupBoxBoutton_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, groupBoxBoutton.Width - 1, groupBoxBoutton.Height - 1);
        }

        private void PanelEncadrantAff_Load(object sender, EventArgs e)
        {
            panel1.Height = h;
            panel1.Width = w;

            //groupBox Recherche
            groupBoxRecherche.Width = panel1.Width - 200;
            groupBoxRecherche.Height = 60;
            groupBoxRecherche.Location = new Point(10, 10);

            //  //DataGrid View Enseignant
            //  int a = (DGVEnseignant.Width / 4) * 3;
            //  DGVEnseignant.Columns[0].Width = (int)(DGVEnseignant.Width / 4);
            //  DGVEnseignant.Columns[1].Width = (int)(a / 5);
            //  DGVEnseignant.Columns[2].Width = (int)(a / 4);
            //  DGVEnseignant.Columns[3].Width = (int)(a / 5);
            //  DGVEnseignant.Columns[4].Width = (int)(a / 5);
            //  DGVEnseignant.Columns[5].Width = (int)(a / 5);
            ////  DGVEnseignant.Columns[6].Width = (int)(a / 6);

            DGVEncadrant.Location = new Point(10, groupBoxRecherche.Location.Y + groupBoxRecherche.Height + 10);
            DGVEncadrant.Height = panel1.Height - 90;
            DGVEncadrant.Width = panel1.Width - 200;

            DGVEncadrant.EnableHeadersVisualStyles = false;
            //DGVEnseignant.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(91,192,222);
            DGVEncadrant.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(204, 215, 252);
            //DGVEnseignant.columnhe

            //groupbox boutton
            groupBoxBoutton.Width = 170;
            groupBoxBoutton.Height = panel1.Height - 20;
            groupBoxBoutton.Location = new Point(panel1.Width - 180, 10);

            int s = labelCritere.Width + labelValeur.Width + btnChercher.Width + cmbCritereFr.Width + cmbValeurFr.Width;
            //int t = (groupBoxRecherche.Width - s) / 2;
            int t = (groupBoxRecherche.Width - s) / 10;

            labelValeur.Visible = false;
            cmbValeurFr.Visible = false;
            btnChercher.Visible = false;
        }

        private void DGVEncadrant_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, DGVEncadrant.Width - 1, DGVEncadrant.Height - 1);
        }

        private void groupBoxRecherche_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, groupBoxRecherche.Width - 1, groupBoxRecherche.Height - 1);
        }

        private void btnAjouter_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnAjouter.Width - 1, btnAjouter.Height - 1);
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

        private void btnSupprimer_MouseEnter(object sender, EventArgs e)
        {
            btnSupprimer.BackColor = Color.FromArgb(133, 202, 255);
            labelSupprimer.ForeColor = Color.White;
        }

        private void btnSupprimer_MouseLeave(object sender, EventArgs e)
        {
            btnSupprimer.BackColor = Color.White;
            labelSupprimer.ForeColor = Color.FromArgb(10, 56, 84);
        }
    }
}

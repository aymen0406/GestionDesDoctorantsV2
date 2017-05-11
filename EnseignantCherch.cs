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
    public partial class EnseignantCherch : UserControl
    {
        int w, h;
        DataTable dt = new DataTable();
        public EnseignantCherch(int w1, int h1)
        {
            
            InitializeComponent();
            w = w1;
            h = h1;
            this.Height = h;
            this.Width = w;
        }

        public void RaffraichirGrid()
        {
            DGVEnseigCherch.Rows.Clear();
            DAL.DALEnseignantChercheur C = new DAL.DALEnseignantChercheur();
            dt = C.SelectAllEnseignantChercheur();

            int taille = dt.Rows.Count;
            if (taille > 0)
            {
                for (int i = 0; i < taille; i++)
                {
                    DGVEnseigCherch.Rows.Add(dt.Rows[i][1].ToString().Trim(), dt.Rows[i][2].ToString().Trim(), dt.Rows[i][3].ToString().Trim());
                }
            }
        }

        private void EnseignantCherch_Load(object sender, EventArgs e)
        {
            this.Height = h;
            this.Width = w;

            groupBoxRecherche.Location = new Point(10, 10);
            groupBoxRecherche.Width = this.Width - 200;
            groupBoxRecherche.Height = 60;
            //Groupbox Grid 
            groupBoxGrid.Location = new Point(10, 75);
            groupBoxGrid.Width = this.Width - 200;
            groupBoxGrid.Height = this.Height - 85;

            //Data Grid View Conge
            DGVEnseigCherch.Location = new Point(10, 15);
            DGVEnseigCherch.Height = groupBoxGrid.Height - 25;
            DGVEnseigCherch.Width = groupBoxGrid.Width - 20;

            ///GroupBox Boutton
            groupBoxBoutton.Location = new Point(groupBoxRecherche.Width + 20, 10);
            groupBoxBoutton.Width = 170;
            groupBoxBoutton.Height = this.Height - 20;
            RaffraichirGrid();
        }

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

        private void DGVEnseigCherch_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, DGVEnseigCherch.Width - 1, DGVEnseigCherch.Height - 1);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ParamEnseignantCherch frm = new ParamEnseignantCherch();
            frm.ShowDialog();
            RaffraichirGrid();
        }
    }
}

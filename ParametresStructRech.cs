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
    public partial class ParametresStructRech : UserControl
    {
        int w, h;
        DataTable dt = new DataTable();
        public ParametresStructRech(int w1,int h1)
        {
            InitializeComponent();
            w = w1;
            h = h1;
            this.Height = h;
            this.Width = w;
        }
        private void ParametresGrade_Load(object sender, EventArgs e)
        {
            this.Height = h;
            this.Width = w;
                        
            //GroupBox Recherche
            groupBoxRecherche.Location = new Point(10, 10);
            groupBoxRecherche.Width = this.Width-200;
            groupBoxRecherche.Height = 60;

            //Groupbox Grid 
            groupBoxGrid.Location = new Point(10, 75);
            groupBoxGrid.Width = this.Width-200;
            groupBoxGrid.Height = this.Height-85;

            //Data Grid View Conge
            DGVStructRech.Location = new Point(10, 15);
            DGVStructRech.Height = groupBoxGrid.Height - 25;
            DGVStructRech.Width = groupBoxGrid.Width - 20;

            ///GroupBox Boutton
            groupBoxBoutton.Location = new Point(groupBoxRecherche.Width+20, 10);
            groupBoxBoutton.Width = 170;
            groupBoxBoutton.Height = this.Height-20;
                        
           // RaffraichirGrid();
        }
        public void RaffraichirGrid()
        {
            DGVStructRech.Rows.Clear();
            DAL.DALStructureRecherche P = new DAL.DALStructureRecherche();
          //  dt = P.SelectAllstru();
            int taille = dt.Rows.Count;
            if (taille > 0)
            {
                for (int i = 0; i < taille; i++)
                {
                    DGVStructRech.Rows.Add(dt.Rows[i][1].ToString().Trim(), dt.Rows[i][2].ToString().Trim(), dt.Rows[i][3].ToString().Trim());
                }
            }
        }


        //private void btnAjouter_Click(object sender, EventArgs e)
        //{
        //    FormCommun.FormGrade frm = new FormCommun.FormGrade("Français", 1,0);
        //    frm.ShowDialog();
        //    RaffraichirGrid();
        //}
        //private void btnModifier_Click(object sender, EventArgs e)
        //{
        //    if (DGVStructRech.Rows.Count > 0)
        //    {
        //        int x1 = DGVStructRech.CurrentRow.Index;
        //        int IdGrade = int.Parse(dt.Rows[x1][0].ToString());
        //        FormCommun.FormGrade frm = new FormCommun.FormGrade("Français", 2, IdGrade);
        //        frm.ShowDialog();
        //        RaffraichirGrid();
        //    }else
        //    {
        //        MessageBox.Show("Aucun grade sélectionnée!!!");
        //    }
        //}
        //private void btnSupprimer_Click(object sender, EventArgs e)
        //{
        //    if (DGVStructRech.Rows.Count > 0)
        //    {
        //        int x1 = DGVStructRech.CurrentRow.Index;
        //        int IdGrade = int.Parse(dt.Rows[x1][0].ToString());
        //        DAL.DALTypePromotion P = new DAL.DALTypePromotion();
        //        int x = P.ChechkUsing(IdGrade);
        //        if (x == 0)
        //        {
        //            string DeleteGradeMsg = "Vous êtes sur le point de supprimer un grade.";
        //            DeleteGradeMsg += " Cliquez sur OK pour confirmer la suppression ou sur Annuler dans le cas contraire !!! ";
        //            DialogResult DeleteGradeDecision;
        //            DeleteGradeDecision = MessageBox.Show(DeleteGradeMsg, "Suppression d'un grade", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //            if (DeleteGradeDecision == DialogResult.OK)
        //            {
        //                try
        //                {
        //                    try
        //                    {
        //                        P.DeleteGrade(IdGrade);
        //                        RaffraichirGrid();
        //                    }
        //                    catch (Exception a)
        //                    {
        //                        MessageBox.Show(a.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    }

        //                }
        //                catch (Exception a)
        //                {
        //                    MessageBox.Show(a.Message, "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Suppression impossible de ce type de promotion");
        //        }
        //    }else
        //    {
        //        MessageBox.Show("Aucun Grade sélectionné!!");
        //    }
        //}


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
            e.Graphics.DrawRectangle(couleur, 0, 0, btnModifier.Width - 1, btnModifier.Height - 1);
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

        private void btnImprimer_MouseEnter(object sender, EventArgs e)
        {
            btnImprimer.BackColor = Color.FromArgb(133, 202, 255);
            labelImprimer.ForeColor = Color.White;
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

        private void btnImprimer_MouseLeave(object sender, EventArgs e)
        {
            btnImprimer.BackColor = Color.White;
            labelImprimer.ForeColor = Color.FromArgb(10, 56, 84);
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

        private void btnImprimer_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnImprimer.Width - 1, btnImprimer.Height - 1);
        }

        private void DGVGrade_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, DGVStructRech.Width - 1, DGVStructRech.Height - 1);
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormStructRech frm = new FormStructRech(1, 0);
            frm.ShowDialog();
        }

        //private void btnImprimer_Click(object sender, EventArgs e)
        //{
        //    Imprime.ListeTypePromotion frm = new Imprime.ListeTypePromotion(dt);
        //    frm.ShowDialog();
        //}

    }
}

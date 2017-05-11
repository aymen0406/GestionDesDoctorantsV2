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
    public partial class ParametresTypeDocument : UserControl
    {
        DataTable dt = new DataTable();  
        int w, h;
        public ParametresTypeDocument(int w1, int h1)
        {
            InitializeComponent();
             w = w1;
            h = h1;
            this.Height = h;
            this.Width = w;
         }
        private void ParametresDepartement_Load(object sender, EventArgs e)
        {
            this.Height = h;
            this.Width = w;
            
            //GroupBox Recherche
            groupBoxRecherche.Location = new Point(10, 10);
            groupBoxRecherche.Width =this.Width-200;
            groupBoxRecherche.Height = 60;

            //Groupbox Grid 
            groupBoxGrid.Location = new Point(10, 75);
            groupBoxGrid.Width =this.Width-200;
            groupBoxGrid.Height =this.Height-85;

            //Data Grid View Conge
            DGVTypeDocument.Location = new Point(10, 15);
            DGVTypeDocument.Height = groupBoxGrid.Height - 25;
            DGVTypeDocument.Width = groupBoxGrid.Width - 20;

            ///GroupBox Boutton
            groupBoxBoutton.Location = new Point(groupBoxRecherche.Width+20,10);
            groupBoxBoutton.Width = 170;
            groupBoxBoutton.Height = this.Height-20;
                       
            RaffraichirGrid();
        }
        public void RaffraichirGrid()
        {
            DGVTypeDocument.Rows.Clear();
            DAL.DALTypeDocument D = new DAL.DALTypeDocument();
            dt = D.SelectAllTypeDocument();
            int taille = dt.Rows.Count;
            if (taille > 0)
            {
                for (int i = 0; i < taille; i++)
                {
                    DGVTypeDocument.Rows.Add(dt.Rows[i][1].ToString().Trim(), dt.Rows[i][2].ToString().Trim(), dt.Rows[i][3].ToString().Trim());
                }
            }
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormTypeDocument frm = new FormTypeDocument(1,0);
            frm.ShowDialog();
            RaffraichirGrid();
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (DGVTypeDocument.Rows.Count >0)
            {
                int x = DGVTypeDocument.CurrentRow.Index;
                int id = int.Parse(dt.Rows[x][0].ToString());
                FormTypeDocument frm = new FormTypeDocument(2,id);
                frm.ShowDialog();
                RaffraichirGrid();
            }else
            {
                MessageBox.Show("Aucun Document sélectionnée!!");
            }
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (DGVTypeDocument.Rows.Count > 0)
            {
                int x1 = DGVTypeDocument.CurrentRow.Index;
                int id = int.Parse(dt.Rows[x1][0].ToString());
                DAL.DALTypeDocument D = new DAL.DALTypeDocument();
                int x = D.ChechkUsing(id);
                if (x == 0)
                {
                    string DeleteTypeDocumentMsg = "Vous êtes sur le point de supprimer un Type Document.";
                    DeleteTypeDocumentMsg += " Cliquez sur OK pour confirmer la suppression ou sur Annuler dans le cas contraire !!! ";
                    DialogResult DeleteTypeDocumentDecision;
                    DeleteTypeDocumentDecision = MessageBox.Show(DeleteTypeDocumentMsg, "Suppression d'un Type Document", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DeleteTypeDocumentDecision == DialogResult.OK)
                    {
                        try
                        {
                            try
                            {
                                D.DeleteTypeDocumente(id);
                                RaffraichirGrid();
                            }
                            catch (Exception a)
                            {
                                MessageBox.Show(a.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message, "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Suppression impossible");
                }
            }else
            {
                MessageBox.Show("Aucun département sélectionnée!!");
            }
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
            btnSupprimer.BackColor = Color.Transparent;
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

        private void DGVDepartement_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, DGVTypeDocument.Width - 1, DGVTypeDocument.Height - 1);
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

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            //Imprime.ListeDepartement frm = new Imprime.ListeDepartement();
            //frm.ShowDialog();
        }
    }
}

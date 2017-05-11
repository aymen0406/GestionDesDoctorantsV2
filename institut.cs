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
    public partial class institut : UserControl
    {
        int w, h;
        DataTable dt = new DataTable();
        public institut(int w1, int h1)
        {
            InitializeComponent();
            w = w1;
            h = h1;
            this.Height = h;
            this.Width = w;
        }


        public void RaffraichirGrid()
        {
            DGVInstitut.Rows.Clear();
            DAL.DALEtablissement C = new DAL.DALEtablissement();
            dt = C.SelectAllEtablissement();

            int taille = dt.Rows.Count;
            if (taille > 0)
            {
                for (int i = 0; i < taille; i++)
                {
                    DGVInstitut.Rows.Add(dt.Rows[i][1].ToString().Trim(), dt.Rows[i][2].ToString().Trim(), dt.Rows[i][3].ToString().Trim());
                }
            }
        }
        private void institut_Load(object sender, EventArgs e)
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
            DGVInstitut.Location = new Point(10, 15);
            DGVInstitut.Height = groupBoxGrid.Height - 25;
            DGVInstitut.Width = groupBoxGrid.Width - 20;

            ///GroupBox Boutton
            groupBoxBoutton.Location = new Point(groupBoxRecherche.Width + 20, 10);
            groupBoxBoutton.Width = 170;
            groupBoxBoutton.Height = this.Height - 20;
            RaffraichirGrid();
        }

        private void groupBoxRecherche_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, groupBoxRecherche.Width - 1, groupBoxRecherche.Height - 1);
        }

        private void groupBoxBoutton_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, groupBoxBoutton.Width - 1, groupBoxBoutton.Height - 1);
        }

        private void DGVInstitut_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, DGVInstitut.Width - 1, DGVInstitut.Height - 1);
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormAddEtab frm = new FormAddEtab(1,0);
            frm.ShowDialog();
            RaffraichirGrid();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            

                if (DGVInstitut.Rows.Count > 0)
            {
                int x = DGVInstitut.CurrentRow.Index;
                int id = int.Parse(dt.Rows[x][0].ToString());
                FormAddEtab frm = new FormAddEtab(2, id);
                frm.ShowDialog();
                RaffraichirGrid();
            }else
            {
                MessageBox.Show("Aucun Etablissement sélectionné!!");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (DGVInstitut.Rows.Count > 0)
            {
                int x1 = DGVInstitut.CurrentRow.Index;
                int id = int.Parse(dt.Rows[x1][0].ToString());
                DAL.DALEtablissement C = new DAL.DALEtablissement();
                int x = C.ChechkUsing(id);
                if (x == 0)
                {
                    string DeleteEtabMsg = "Vous êtes sur le point de supprimer un Etablissement.";
                    DeleteEtabMsg += " Cliquez sur OK pour confirmer la suppression ou sur Annuler dans le cas contraire !!! ";
                    DialogResult DeleteEtablissement;
                    DeleteEtablissement = MessageBox.Show(DeleteEtabMsg, "Suppression d'un etablissement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DeleteEtablissement == DialogResult.OK)
                    {
                        try
                        {
                            try
                            {
                                C.DeleteEtablissement(id);
                                MessageBox.Show("Suppression bien éffectuée");
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
                    MessageBox.Show("Cet  établissementé est déjà affecté à certains doctorant, suppression impossible ");
                }
            }
            else
            {
                MessageBox.Show("Aucun établissement séletionnée!!");
            }
        }
    }
}

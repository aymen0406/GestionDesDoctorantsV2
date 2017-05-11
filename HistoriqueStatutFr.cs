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
    public partial class HistoriqueStatutFr : Form
    {
        int Id;
        int type = 0;
        //DataTable dt = new DataTable();
        //            if ((DateTime)dt1.Rows[x][4] == Convert.ToDateTime("1/1/1753"))

        public HistoriqueStatutFr(int Identifiant)
        {
            InitializeComponent();

            panel1.Visible = false;
            BloquerErreur();     
       
            //DataTable dt1 = new DataTable();
            //Id = Identifiant;

            //DAL.DALTypeSituationAdministrative S = new DAL.DALTypeSituationAdministrative();
            //dt1 = S.SelectAllStatut();
            //for (int i = 0; i < dt1.Rows.Count; i++)
            //{
            //    this.cmbStatut.DataSource = dt1;
            //    cmbStatut.DisplayMember = "IntituleFr";
            //    cmbStatut.ValueMember = "IdTypeSituationAdmin";
            //    this.cmbStatut.DropDownStyle = ComboBoxStyle.DropDownList;
            //}

            //RaffraichirGrid();
        }

        //public void RaffraichirGrid()
        //{
        //    DGVStatutAdministratif.Rows.Clear();
        //    Entitée.TypeSituationAdministrative S = new Entitée.TypeSituationAdministrative();
        //    dt = DAL.DALHistoriqueStatut.SelectEnseignantStaut(Id);
        //    string date = "";
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        DAL.DALTypeSituationAdministrative S1 = new DAL.DALTypeSituationAdministrative();
        //        S = S1.SelectById(int.Parse(dt.Rows[i][2].ToString()));
        //        if ((DateTime)dt.Rows[i][4] == Convert.ToDateTime("1/1/1753"))
        //            date = "";
        //        else
        //            date = ((DateTime)dt.Rows[i][4]).ToShortDateString();
        //        DGVStatutAdministratif.Rows.Add(S.IntituleFr.Trim(), ((DateTime)dt.Rows[i][3]).ToString("dd/M/yyyy"), date);
        //    }
        //}
        public void BloquerErreur()
        {
            ErreurDateDebutFr.Visible = false;
            ErreurStatutFr.Visible = false;
        }
        public bool ExistErreur()
        {
            if ((CalenderDebut.Text == "") ||(cmbStatut.Text == ""))
                return false;
            else
                return true;
        }
        public void ErreurFr()
        {
            if (CalenderDebut.Text == "")
                ErreurDateDebutFr.Visible = true;
            else
                ErreurDateDebutFr.Visible = false;

            if (cmbStatut.Text == "")
                ErreurStatutFr.Visible = true;
            else
                ErreurStatutFr.Visible = false;
        }
        public void Vider()
        {
            CalenderDebut.Text = "";
            cmbStatut.Text = "";
        }
        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoriqueStatutFr_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(51, 122, 183), 2);
            e.Graphics.DrawRectangle(couleur, 1, 1, this.Width - 2, this.Height - 2);
        }

        private void btnAddStatut_Click(object sender, EventArgs e)
        {
            type = 1;
            panel1.Visible = true;
            cmbStatut.SelectedIndex = -1;
            txtDebut.Text = "";
            txtFin.Text = "";
            txtObservation.Text = "";
        }

        //private void btnModifyStatut_Click(object sender, EventArgs e)
        //{
        //    type = 2;
        //    panel1.Visible = true;
        //    int x = DGVStatutAdministratif.CurrentRow.Index;
        //    string code = dt.Rows[x][2].ToString();
        //    cmbStatut.SelectedValue = dt.Rows[x][2];
        //    txtDebut.Text =((DateTime) dt.Rows[x][3]).ToShortDateString();
        //    if ((DateTime)dt.Rows[x][4] == Convert.ToDateTime("1/1/1753"))
        //        txtFin.Text = "";
        //    else
        //        txtFin.Text =( (DateTime)dt.Rows[x][4]).ToShortDateString();
        //    txtObservation.Text = dt.Rows[x][5].ToString().Trim();
        //}

        //private void btnDeleteStatut_Click(object sender, EventArgs e)
        //{
        //    DataTable dt22 = new DataTable();
        //    int x = DGVStatutAdministratif.CurrentRow.Index;
        //    int code = int.Parse(dt.Rows[x][0].ToString());
        //    int ex = DAL.DALHistoriqueStatut.SelectCountStatut(Id);
        //    dt22 = DAL.DALHistoriqueStatut.SelectStautAcuel(Id);
        //    int idsatatutActuel = int.Parse(dt22.Rows[0][0].ToString());
        //    if ((ex == 1) || (idsatatutActuel==code))
        //    {
        //        MessageBox.Show("Suppression Impossible");
        //    }
        //    else
        //    {
        //        if (ex > 1)
        //        {
        //            string DeleteStatutMsg = "Vous êtes sur le point de supprimer un statut.";
        //            DeleteStatutMsg += " Cliquez sur OK pour confirmer la suppression ou sur Annuler dans le cas contraire !!! ";
        //            DialogResult DeleteStatutDecision;
        //            DeleteStatutDecision = MessageBox.Show(DeleteStatutMsg, "Suppression d'un statut", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //            if (DeleteStatutDecision == DialogResult.OK)
        //            {
        //                try
        //                {
        //                    try
        //                    {
        //                        DAL.DALHistoriqueStatut.SupprimerStatut(code);
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
        //    }
        //}

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
        //    int Statut =int.Parse( cmbStatut.SelectedValue.ToString());           
        //    DateTime DateD =Convert.ToDateTime( txtDebut.Text);
        //    DateTime DateF;
        //    if (txtFin.Text == "")
        //        DateF = Convert.ToDateTime("1/1/1753");
        //    else
        //        DateF = Convert.ToDateTime(txtFin.Text);
        //    string Observation = txtObservation.Text;
        //    if (res == false)
        //    {
        //        ErreurFr();
        //    }
        //    else
        //    {
        //        BloquerErreur();
        //        Vider();
        //        panel1.Visible = false;
        //        panel2.Visible = true;
        //        if (type == 1)
        //        {
        //            DAL.DALHistoriqueStatut.AjouterStatut(Id, Statut, DateD,DateF,Observation);
        //            DAL.DALHistoriqueStatut.UpdateStatutActuel(Id, Statut);
        //        }
        //        else
        //        {
        //            int x = DGVStatutAdministratif.CurrentRow.Index;
        //            DataTable dt22 = new DataTable();
        //            dt22 = DAL.DALHistoriqueStatut.SelectStautAcuel(Id);
        //            int idsatatutActuel = int.Parse(dt22.Rows[0][0].ToString());

        //            int code = int.Parse(dt.Rows[x][0].ToString());
        //            DAL.DALHistoriqueStatut.ModifierStatut(code, Statut, DateD, DateF, Observation);
        //            if (code == idsatatutActuel)
        //            {
        //                DataTable dt2 = new DataTable();
        //                dt2 = DAL.DALHistoriqueStatut.SelectStautAcuel(Id);
        //                int statut1 =int.Parse( dt2.Rows[0][1].ToString());
        //                DAL.DALHistoriqueStatut.UpdateStatutActuel(Id, statut1);
        //            }
        //        }
        //        RaffraichirGrid();
        //    }           
        //}

        private void panelAnnuler_Click(object sender, EventArgs e)
        {
            Vider();
            BloquerErreur();
            panel1.Visible = false;
            panel2.Visible = true;
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

        private void btnAjouter_MouseEnter(object sender, EventArgs e)
        {
            btnAjouter.BackColor = Color.FromArgb(133, 202, 255);
            labelAjouter.ForeColor = Color.White;
        }

        private void btnAjouter_MouseLeave(object sender, EventArgs e)
        {
            btnAjouter.BackColor = Color.Transparent;
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

        private void btnModifier_MouseLeave(object sender, EventArgs e)
        {
            btnModifier.BackColor = Color.Transparent;
            labelModifier.ForeColor = Color.FromArgb(10, 56, 84);
        }

        private void btnSupprimer_MouseLeave(object sender, EventArgs e)
        {
            btnSupprimer.BackColor = Color.Transparent;
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

        private void HistoriqueStatutFr_Load(object sender, EventArgs e)
        {
            panelClose.Height = panelTitre.Height;
            panelClose.Width = panelTitre.Height;
            panelClose.Location = new Point(panelTitre.Width - panelTitre.Height, 0);
        }

        private void DGVStatutAdministratif_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, DGVStatutAdministratif.Width - 1, DGVStatutAdministratif.Height - 1);
        }

        private void CalenderDebut_ValueChanged(object sender, EventArgs e)
        {
            txtDebut.Text = CalenderDebut.Value.ToShortDateString();
        }

        private void CalenderFin_ValueChanged(object sender, EventArgs e)
        {
            txtFin.Text = CalenderFin.Value.ToShortDateString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            type = 1;
            panel1.Visible = true;
            panel2.Visible = false;
            cmbStatut.SelectedIndex = -1;
            txtDebut.Text = "";
            txtFin.Text = "";
            txtObservation.Text = "";
        }
    }
}

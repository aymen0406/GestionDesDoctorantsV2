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
    public partial class HistoriqueAdministrative : Form
    {
        int id;
       // DataTable dt = new DataTable();

        public HistoriqueAdministrative(int id1)
        {
            InitializeComponent();
            id = id1;
        }

        private void HistoriqueAdministrative_Load(object sender, EventArgs e)
        {
            panelClose.Height = panelTitre.Height;
            panelClose.Width = panelTitre.Height;
            panelClose.Location = new Point(panelTitre.Width - panelTitre.Height, 0);
            //DataGrid View Enseignant
            //int a = (dataGridView1.Width / 2);
            //dataGridView1.Columns[0].Width = (int)(a / 3);
            //dataGridView1.Columns[1].Width = (int)(a / 3);
            //dataGridView1.Columns[2].Width = a/2;
          //  RaffraichirGrid();
        }

        //public void RaffraichirGrid() 
        //{
        //    DGVDossier.Rows.Clear();
        //    DAL.DALDossierAffectation DA = new DAL.DALDossierAffectation();
        //    dt = DA.SelectAllDossierAffectation(id);
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        DAL.DALMotifDepart DALM = new DAL.DALMotifDepart();
        //        Entitée.MotifDepart Motif = new Entitée.MotifDepart();
        //        Motif = DALM.SelectById(int.Parse(dt.Rows[i][10].ToString()));
        //        string raison = Motif.MotifAbrg.Trim();
        //        if (raison == "a")
        //            raison = "";
        //        DGVDossier.Rows.Add(
        //            dt.Rows[i][11].ToString().Trim(), dt.Rows[i][2].ToString().Trim(), dt.Rows[i][4].ToString().Trim(),
        //        dt.Rows[i][5].ToString().Trim(), dt.Rows[i][7].ToString().Trim(),raison);
        //    }

        //    DataTable dt1 = new DataTable();
        //    DAL.DALTypePromotion P = new DAL.DALTypePromotion();
        //    dt1 = P.SelectAllGrade();
        //    cmbPromotion.DataSource = dt1;
        //    cmbPromotion.DisplayMember = "Code";
        //    cmbPromotion.ValueMember = "IdTypePromotion";

        //    DataTable dt2 = new DataTable();
        //    DAL.DALMotifDepart M = new DAL.DALMotifDepart();
        //    dt2 = M.SelectAllMotif();
        //    cmbMotifDepart.DataSource = dt2;
        //    cmbMotifDepart.DisplayMember = "MotifFr";
        //    cmbMotifDepart.ValueMember = "IdMotif";
        //}
        //void BindDataToInterface(Entitée.DossierAffectation DA)
        //{
        //    cmbDiplome.Text = DA.Diplome.Trim();
        //    cmbAdmission.Text = DA.TypeAdmission;
        //    txtDateCreation.Text = DA.DateCreationDossier.ToShortDateString();
        //    txtDateCloture.Text = DA.DateClotureDossier.ToShortDateString();
        //    cmbPeriode.Text = DA.Periode.Trim();
        //    cmbPromotion.SelectedValue = DA.IdTypePromotion;
        //    txtNiveau.Text = DA.Niveau.ToString();
        //    txtAnneeUniversitaire.Text = DA.AnneeUniversitaire.Trim();
        //    cmbMotifDepart.SelectedValue = DA.MotifClotureDossier;
        //}

        //Entitée.DossierAffectation GetDataFromInterface()
        //{
        //    Entitée.DossierAffectation DA = new Entitée.DossierAffectation();
        //    DA.Diplome = cmbDiplome.Text;
        //    DA.TypeAdmission =cmbAdmission.Text ;
        //    DA.DateCreationDossier = Convert.ToDateTime (txtDateCreation.Text);
        //    DA.DateClotureDossier = Convert.ToDateTime (txtDateCloture.Text);
        //    DA.Periode=cmbPeriode.Text;
        //    DA.IdTypePromotion=int.Parse( cmbPromotion.SelectedValue.ToString() );
        //    DA.Niveau = int.Parse(txtNiveau.Text);
        //    DA.AnneeUniversitaire = txtAnneeUniversitaire.Text ;
        //    DA.MotifClotureDossier =int.Parse( cmbMotifDepart.SelectedValue.ToString() );
        //    DA.EtatDossier = "Ancien";
        //    return DA;
        //}

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, DGVDossier.Width - 1, DGVDossier.Height - 1);
        }
        private void panelClose_MouseEnter(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(228, 17, 41);
        }

        private void panelClose_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.Transparent;
        }

        private void HistoriqueAdministrative_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(51, 122, 183), 2);
            e.Graphics.DrawRectangle(couleur, 1, 1, this.Width - 2, this.Height - 2);
        }

        private void panelClose_Click(object sender, EventArgs e)
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

        private void btnModifier_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            //int x = DGVDossier.CurrentRow.Index;
            //int id1 = int.Parse(dt.Rows[x][0].ToString());
            //Entitée.DossierAffectation DA = new Entitée.DossierAffectation();
            //DAL.DALDossierAffectation DA1 = new DAL.DALDossierAffectation();
            //DA = DA1.SelectDossierAffectation1(id1);
            //BindDataToInterface(DA);
            //if (dt.Rows[x][11].ToString().Trim() == "Courant")
            //{
            //    txtDateCloture.Text = "";
            //    txtDateCloture.Enabled = false;
            //    txtDateCreation.Enabled = false;
            //    txtNiveau.Enabled = false;
            //    txtAnneeUniversitaire.Enabled = false;
            //    cmbAdmission.Enabled = false;
            //    cmbDiplome.Enabled = false;
            //    cmbMotifDepart.Enabled = false;
            //    cmbPeriode.Enabled = false;
            //    cmbPromotion.Enabled = false;
            //    dateTimePicker1.Enabled = false;
            //    dateTimePicker1.Enabled = false;
            //}
        }

        //private void btnSupprimer_Click(object sender, EventArgs e)
        //{
        //    if (DGVDossier.Rows.Count > 1)
        //    {
        //        string DeleteDossierMsg = "Vous êtes sur le point de supprimer un Dossier Affectaion d'un enseignant.";
        //        DeleteDossierMsg += " Cliquez sur OK pour confirmer la suppression ou sur Annuler dans le cas contraire !!! ";
        //        DialogResult DeleteDossierDecision;
        //        DeleteDossierDecision = MessageBox.Show(DeleteDossierMsg, "Suppression d'un Dossier", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //        int x = DGVDossier.CurrentRow.Index;
        //        int idDossier = int.Parse(dt.Rows[x][0].ToString());
        //        string etat = dt.Rows[x][11].ToString().Trim();
        //        string ResultMsg = "Enseignant Supprimée!!";
        //        if (etat == "Courant")
        //        {
        //            MessageBox.Show("Suppression Impossible");
        //        }
        //        else
        //        {
        //            if (DeleteDossierDecision == DialogResult.OK)
        //            {
        //                //try
        //                //{                    
        //                //DAL.DALDossierAdministratif.DeleteDossierAdministratif1(idDossier);
        //                MessageBox.Show(ResultMsg, "Suppression d'un enseignant", MessageBoxButtons.OK, MessageBoxIcon.Question);
        //                //}
        //                //catch (Exception A)
        //                //{
        //                //    MessageBox.Show(A.Message, "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                //}
        //            }
        //            else
        //            {
        //                MessageBox.Show("Actuellement il n'existe aucun ensignant ");
        //            }
        //        }
        //    }
        //}

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtDateCloture.Text = "" + dateTimePicker2.Value.ToShortDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDateCreation.Text = "" + dateTimePicker1.Value.ToShortDateString();
        }

        private void labelAnnuler_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void btnModifier_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        

        //private void labelEnregistrer_Click(object sender, EventArgs e)
        //{
        //    int x = DGVDossier.CurrentRow.Index;
        //    if (dt.Rows[x][11].ToString().Trim() != "Courant")
        //    {
        //        MessageBox.Show("oki");
        //        Entitée.DossierAffectation da = new Entitée.DossierAffectation();
        //        da = GetDataFromInterface();
        //        da.IdDossierAdministrative = int.Parse(dt.Rows[x][0].ToString());
        //        MessageBox.Show("" + da.IdDossierAdministrative);

        //        DAL.DALDossierAffectation d = new DAL.DALDossierAffectation();
        //        d.UpdateDossierAffectation1(da);
        //    }
        //    RaffraichirGrid();
        //    panel2.Visible = true;
        //    panel1.Visible = false;
            
        //}
    }
}
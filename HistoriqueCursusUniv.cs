using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace GestionDesDoctorantsV2
{
    public partial class HistoriqueCursusUniv : Form
    {
        int Id;
        int type = 0;
        DataTable dt1 = new DataTable();

        public HistoriqueCursusUniv(int Identifiant)
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            Id = Identifiant;

            BloquerErreur();
            
            //Remplir le combobox avec les different responsabilitées
            //DAL.DALResponsabiliteAdministratif R1 = new DAL.DALResponsabiliteAdministratif();
            //dt = R1.SelectAllResponsabilite();
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        this.cmbResponsabilite.DataSource = dt;
            //        cmbResponsabilite.DisplayMember = "IntituleFr";
            //        cmbResponsabilite.ValueMember = "IdTypeResponsabilite";
            //        this.cmbResponsabilite.DropDownStyle = ComboBoxStyle.DropDownList;
            //    }

            //    RaffraichirGrid();   
        }

        //public void RaffraichirGrid()
        //{
        //    DGVResponsabilite.Rows.Clear();
        //    Entitée.ResponsabiliteAdministratif R = new Entitée.ResponsabiliteAdministratif();

        //    //remplir le datagridview avel la liste des reponsabilité de l'enseignant sélectionnée
        //    dt1 = DAL.DALHistoriqueResponsabilite.SelectEnseignantResponsabilité(Id);
        //    string date = "";
        //    for (int i = 0; i < dt1.Rows.Count; i++)
        //    {
        //        DAL.DALResponsabiliteAdministratif R1 = new DAL.DALResponsabiliteAdministratif();
        //        R = R1.SelectById(int.Parse(dt1.Rows[i][2].ToString().Trim()));
        //        if (dt1.Rows[i][4].ToString() != "")
        //            if ((DateTime)dt1.Rows[i][4] == Convert.ToDateTime("1/1/1753"))
        //                date = "";
        //            else
        //                date = ((DateTime)dt1.Rows[i][4]).ToString("dd/M/yyyy");
        //        DGVResponsabilite.Rows.Add(R.IntituleFr.Trim(), ((DateTime)dt1.Rows[i][3]).ToString("dd/M/yyyy"), date);
        //    }         
        //}
        //public void Vider()
        //{
        //    CalenderDebut.Text = "";
        //    cmbResponsabilite.Text = "";
        //}      
        public void BloquerErreur()
        {
            ErreurResponsabiliteFr.Visible = false;
            ErreurDateDebutFr.Visible = false;
        }
        //public void ErreurFr()
        //{
        //    if (cmbResponsabilite.Text == "")
        //        ErreurResponsabiliteFr.Visible = true;
        //    else
        //        ErreurResponsabiliteFr.Visible = false;

        //    if (CalenderDebut.Text == "")
        //        ErreurDateDebutFr.Visible = true;
        //    else
        //        ErreurDateDebutFr.Visible = false;
        //}
        //public bool ExistErreur()
        //{
        //    if ((cmbResponsabilite.Text == "") || (CalenderDebut.Text == "") )
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        private void HistoriqueResponsabiliteFr_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(51, 122, 183), 2);
            e.Graphics.DrawRectangle(couleur, 1, 1, this.Width - 2, this.Height - 2);
        }

        private void btnModifyResponsabilite_Click(object sender, EventArgs e)
        {
            if (DGVResponsabilite.Rows.Count > 1)
            {
               // Vider();
                panel2.Visible = false;
                panel1.Visible = true;
                type = 2;
                //int x = DGVResponsabilite.CurrentRow.Index;
                //cmbResponsabilite.SelectedValue = dt1.Rows[x][2].ToString();
                //CalenderDebut.Value = (DateTime)(dt1.Rows[x][3]);
                //if ((DateTime)dt1.Rows[x][4] == Convert.ToDateTime("1/1/1753"))
                //    txtFin.Text = "";
                //else
                //    txtFin.Text = ((DateTime)dt1.Rows[x][4]).ToShortDateString();
                //richTextBoxObservation.Text = dt1.Rows[x][5].ToString();
            }
        }

        private void btnAddResponsabilite_Click(object sender, EventArgs e)
        {
           // Vider();
            panel2.Visible = false;
            panel1.Visible = true;
            type = 1;
            //cmbResponsabilite.SelectedIndex = -1;
            //txtDebut.Text = "";
            //txtFin.Text = "";
            //richTextBoxObservation.Text = "";
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnDeleteResponsabilite_Click(object sender, EventArgs e)
        //{
        //    string DeleteResponsabiliteMsg = "Vous êtes sur le point de supprimer une responsabilitée.";
        //    DeleteResponsabiliteMsg += " Cliquez sur OK pour confirmer la suppression ou sur Annuler dans le cas contraire !!! ";
        //    DialogResult DeleteResponsabiliteDecision;
        //    DeleteResponsabiliteDecision = MessageBox.Show(DeleteResponsabiliteMsg, "Suppression d'une responsabilitée", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    if (DeleteResponsabiliteDecision == DialogResult.OK)
        //    {
        //         try
        //         {
        //                try
        //                {
        //                    int x= DGVResponsabilite.CurrentRow.Index;
        //                    int codeR= int.Parse(dt1.Rows[x][0].ToString());
        //                    DAL.DALHistoriqueResponsabilite.SupprimerResponsabilite(codeR);
        //                    RaffraichirGrid();
        //                }
        //                catch (Exception a)
        //                {
        //                    MessageBox.Show(a.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                }


        //         }
        //         catch (Exception a)
        //         {
        //             MessageBox.Show(a.Message, "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //         }
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
        //    DateTime DateD, DateF;
        //    int resp =int.Parse( cmbResponsabilite.SelectedValue.ToString());
        //    DateD =Convert.ToDateTime( txtDebut.Text);
        //    if (txtFin.Text != "")
        //        DateF = Convert.ToDateTime(txtFin.Text);
        //    else
        //        DateF = Convert.ToDateTime("1/1/1753");
        //    string Obs = richTextBoxObservation.Text;
        //    bool res;
        //    res = ExistErreur();

        //    if (res == false)
        //    {
        //        ErreurFr();
        //    }
        //    else
        //    {
        //        Vider();
        //        BloquerErreur();
        //        panel2.Visible = true;
        //        panel1.Visible = false;
        //        //DataTable dtv = new DataTable();
        //        //dtv = DAL.DALHistoriqueResponsabilite.VerifPossibiliteAjout(Id, DateD);
                
        //        //int nb = int.Parse(dtv.Rows[0][0].ToString());

        //        //if (type == 1)
        //        //{      
        //        //    //if(nb==0)          
        //        //        DAL.DALHistoriqueResponsabilite.AjouterResponsabilite(Id, resp, DateD, DateF, Obs); 
        //        //    //else
        //        //    //    MessageBox.Show("Vous avez déjà une responsabilite obtenu à cette date");
        //        //}
        //        //else
        //        //{
        //        //    //if (nb <= 1)
        //        //    //{
        //        //        int x = DGVResponsabilite.CurrentRow.Index;
        //        //        int codeR = int.Parse(dt1.Rows[x][0].ToString());
        //        //        DAL.DALHistoriqueResponsabilite.ModifierResponsabilite(codeR, resp, DateD,DateF ,Obs);
        //        //    //}else
        //        //    //    MessageBox.Show("Vous avez déjà une responsabilite obtenu à cette date");
        //        //}
        //        //RaffraichirGrid();
        //    }
        //}

        private void panelAnnuler_Click(object sender, EventArgs e)
        {
            //Vider();
            BloquerErreur();
            panel2.Visible = true;
            panel1.Visible = false;
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

        private void HistoriqueResponsabiliteFr_Load(object sender, EventArgs e)
        {
            panelClose.Height = panelTitre.Height;
            panelClose.Width = panelTitre.Height;
            panelClose.Location = new Point(panelTitre.Width - panelTitre.Height, 0);
        }

        private void DGVResponsabilite_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, DGVResponsabilite.Width - 1, DGVResponsabilite.Height - 1);
        }

        //private void DateTimePickerDateDebut_ValueChanged(object sender, EventArgs e)
        //{
        //    txtDebut.Text = CalenderDebut.Value.ToShortDateString();
        //}

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{            
        //    txtFin.Text = CalenderFin.Value.ToShortDateString();
        //}
    }
}

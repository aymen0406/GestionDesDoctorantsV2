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
    public partial class GestSout : Form
    {
        int Id;
        DataTable dt1 = new DataTable();
        int type = 0;
        string Paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\Documents\\";
        string CorrecteFileName;
        OpenFileDialog open = new OpenFileDialog();
        string lien;
        string OldDocument;
        string extension;
        string cin;
        public GestSout(int Identifiant)
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            Id = Identifiant;

            BloquerErreur();
            panel2.Visible = true;

            //Remplir le combobox avec les different grade
            //DAL.DALTypePromotion P = new DAL.DALTypePromotion();
            //dt = P.SelectAllGrade();            
            //this.cmbGrade.DataSource = dt;
            //cmbGrade.DisplayMember = "IntituleFr";
            //cmbGrade.ValueMember = "IdTypePromotion";
            //this.cmbGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbGrade.SelectedIndex = -1;

            //DAL.DALTypeDocument D = new DAL.DALTypeDocument();
            //dt2 = D.SelectAllTypeDocument();
            //this.cmbTypeDocument.DataSource = dt2;
            //cmbTypeDocument.DisplayMember = "Code";
            //cmbTypeDocument.ValueMember = "IdTypeDocument";
            //this.cmbTypeDocument.DropDownStyle = ComboBoxStyle.DropDownList;
            //RaffraichirGrid();

            //DAL.DALEnseignant Ens = new DAL.DALEnseignant();
            //DataTable dt10 = new DataTable();
            //dt10 = Ens.SelectCINById(Id);
            //cin = (dt10.Rows[0][0].ToString()).Trim();
        }

        //public void RaffraichirGrid()
        //{
        //    DGVGrade.Rows.Clear();
        //    Entitée.TypePromotion G = new Entitée.TypePromotion();
        //    string v = "";
        //    //remplir la datagridview avec la liste des Grades d'enseignant selectionnée
        //    dt1 = DAL.DALHistoriqueGrade.SelectEnseignantGrade(Id);
        //    for (int i = 0; i < dt1.Rows.Count; i++)
        //    {
        //        if (int.Parse(dt1.Rows[i][6].ToString())== 0)
        //            v = "";
        //        else
        //            v = "Voir";
        //        DAL.DALTypePromotion P = new DAL.DALTypePromotion();
        //        G = P.SelectById(int.Parse(dt1.Rows[i][2].ToString()));
        //        DGVGrade.Rows.Add(((DateTime)dt1.Rows[i][4]).ToString("dd/M/yyyy"), G.IntituleFr.Trim(), dt1.Rows[i][3].ToString(), v);
        //    }
        //}
        //public void Vider()
        //{            
        //    txtDocument.Text = "";
        //    txtNiveau.Text = "";
        //}
        //public bool ExistErreur()
        //{
        //    if ((CalenderAffectation.Text == "") || (cmbGrade.Text == "")||((txtDocument.Text!="")&(cmbTypeDocument.SelectedIndex==-1)))
        //        return false;
        //    else
        //        return true;
        //}
        public void BloquerErreur()
        {            
            ErreurGradeFr.Visible = false;
            ErreurDateAffectationFr.Visible = false;
            ErreurTypeDocument.Visible = false;
        }
        //public void ErreurFr()
        //{
        //    if (cmbGrade.Text == "")
        //        ErreurGradeFr.Visible = true;
        //    else
        //        ErreurGradeFr.Visible = false;

        //    if (CalenderAffectation.Text == "")
        //        ErreurDateAffectationFr.Visible = true;
        //    else
        //        ErreurDateAffectationFr.Visible = false;

        //    if ((txtDocument.Text != "")&&(cmbTypeDocument.SelectedIndex==-1))
        //        ErreurTypeDocument.Visible = true;
        //    else
        //        ErreurTypeDocument.Visible = false;
        //}

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            type = 1;
            panel1.Visible = true;
            panel2.Visible = false;
           // Vider();
            BloquerErreur();
            
        }
        //private void btnModifyGrade_Click(object sender, EventArgs e)
        //{
        //    type = 2;
        //    panel1.Visible = true;
        //    panel2.Visible = false;
        //    int x = DGVGrade.CurrentRow.Index;
        //    cmbGrade.SelectedValue = dt1.Rows[x][2].ToString().Trim();
        //    txtNiveau.Text = dt1.Rows[x][3].ToString();
        //    txtDateAffectation.Text = ((DateTime)(dt1.Rows[x][4])).ToShortDateString();
        //    txtObservation.Text = dt1.Rows[x][5].ToString().Trim();
           
        //    if (int.Parse(dt1.Rows[x][6].ToString()) !=0)
        //    {
        //        DAL.DALDocuments DALDoc = new DAL.DALDocuments();
        //        DataTable dtd = new DataTable();
        //        dtd = DALDoc.SelectDocumentById(int.Parse(dt1.Rows[x][6].ToString()));
        //        txtDocument.Text = dtd.Rows[0][7].ToString().Trim();
        //        OldDocument = dtd.Rows[0][7].ToString().Trim();
        //    }else
        //    {
        //        OldDocument = "";
        //    }


        //}
        
        private void HistoriqueGradeFr_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(51, 122, 183), 2);
            e.Graphics.DrawRectangle(couleur, 1, 1, this.Width - 2, this.Height - 2);
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void btnDeleteGrade_Click(object sender, EventArgs e)
        //{
        //    int ex = DAL.DALHistoriqueGrade.SelectCountGrade(Id);
        //    if (ex > 1)
        //    {
        //        string DeleteGradeMsg = "Vous êtes sur le point de supprimer un grade.";
        //        DeleteGradeMsg += " Cliquez sur OK pour confirmer la suppression ou sur Annuler dans le cas contraire !!! ";
        //        DialogResult DeleteGradeDecision;
        //        DeleteGradeDecision = MessageBox.Show(DeleteGradeMsg, "Suppression d'un grade", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //        if (DeleteGradeDecision == DialogResult.OK)
        //        {
        //            try
        //            {
        //                try
        //                {
        //                    int x = DGVGrade.CurrentRow.Index;
        //                    int codeGrade = int.Parse(dt1.Rows[x][0].ToString());
        //                    if (int.Parse(dt1.Rows[x][6].ToString()) != 0)
        //                    {
        //                        DAL.DALDocuments DALDoc = new DAL.DALDocuments();
        //                        DataTable dtdoc = new DataTable();
        //                        dtdoc = DALDoc.SelectDocumentById(int.Parse(dt1.Rows[x][6].ToString()));
        //                        OldDocument = dtdoc.Rows[0][7].ToString().Trim();
        //                        System.IO.File.Delete(Paths + "\\" + OldDocument);
        //                        DALDoc.DeleteDocument(int.Parse(dt1.Rows[x][6].ToString()));
        //                    }
        //                    DAL.DALHistoriqueGrade.SupprimerGrade(codeGrade);
        //                    DAL.DALHistoriqueGrade.UpdateGradeActuel(0, codeGrade);
        //                    DAL.DALDossierAffectation DA = new DAL.DALDossierAffectation();
        //                    DA.UpdateGradeActuel(Id);
        //                    RaffraichirGrid();
        //                }
        //                catch (Exception a)
        //                {
        //                    MessageBox.Show(a.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                }


        //            }
        //            catch (Exception a)
        //            {
        //                MessageBox.Show(a.Message, "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Impossible de supprimer le grade de cet enseignant");
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

        //public int SaveDocument(int typedoc)
        //{            
        //    lien = cin + "\\" + CorrecteFileName;
        //    DAL.DALDocuments d = new DAL.DALDocuments();
        //    DAL.DALTypeDocument Tdoc = new DAL.DALTypeDocument();
        //    string code =System.IO.Path.GetExtension(CorrecteFileName);
        //    if (extension == ".docx")
        //        code = "Word";
        //    if (extension == ".xlx")
        //        code = "Excel";
        //    if (extension == ".pdf")
        //        code = "pdf";
        //    if ((extension == ".jpg") || (extension == ".png"))
        //        code = "Image";
        //    int iddoc1= d.AjouterDocument1(Id, typedoc, DateTime.Now, txtDocument.Text, txtDocument.Text, "", lien);

        //    System.IO.File.Copy(open.FileName, Paths + lien);
        //    return iddoc1;
        //}

        //private void panelEnregistrer_Click(object sender, EventArgs e)
        //{
        //    bool res;
        //    res = ExistErreur();
        //    int Niveau;
        //    if (res == false)
        //    {
        //        ErreurFr();
        //    }
        //    else
        //    {
        //        int iddoc;
        //        int codeGrade =int.Parse( cmbGrade.SelectedValue.ToString());
        //        DateTime DateObt = Convert.ToDateTime(txtDateAffectation.Text);
        //        try {  Niveau = int.Parse(txtNiveau.Text); }
        //        catch { Niveau = 0; }
        //        string Observation = txtObservation.Text;
        //        DataTable dt9 = new DataTable();
        //        DAL.DALDocuments doc = new DAL.DALDocuments();               
        //        BloquerErreur();
        //        panel2.Visible = true;
        //        if (type == 1)
        //        {
        //            Vider();
        //            if (txtDocument.Text != "")
        //            { iddoc = SaveDocument(int.Parse(cmbTypeDocument.SelectedValue.ToString())); }
        //            else
        //              iddoc=0;
        //            DAL.DALHistoriqueGrade.AjouterGrade(Id, codeGrade, Niveau, DateObt, Observation, iddoc);
        //            DAL.DALHistoriqueGrade.UpdateGradeActuel(Id, codeGrade);
        //            MessageBox.Show("Opération d'ajout bien effectuée");
        //        }
        //        else
        //        {
        //            int x = DGVGrade.CurrentRow.Index;
        //            int idGrade = int.Parse(dt1.Rows[x][0].ToString());
        //            if ((txtDocument.Text != "") & (OldDocument == ""))//nouveau document
        //            {
        //                iddoc = SaveDocument(int.Parse(cmbTypeDocument.SelectedValue.ToString()));
        //            }
        //            else
        //            {
        //                if ((txtDocument.Text != "") & (OldDocument == txtDocument.Text))//le meme document
        //                {
        //                    iddoc = int.Parse(dt1.Rows[x][6].ToString());
        //                }
        //                else
        //                {
        //                    if ((txtDocument.Text != "") & (OldDocument != txtDocument.Text))//modier le doc=supp+ajout
        //                    {
        //                        System.IO.File.Delete(Paths + cin + "\\" + OldDocument);
        //                        DAL.DALDocuments DalD = new DAL.DALDocuments();
        //                        DalD.DeleteDocument(int.Parse(dt1.Rows[x][6].ToString()));
        //                        iddoc = SaveDocument(int.Parse(cmbTypeDocument.SelectedValue.ToString()));
        //                    }
        //                    else
        //                    // ((txtDocument.Text == "") & (OldDocument == ""))//sans document
        //                    {
        //                        iddoc = 0;
        //                    }
        //                }
        //        }
        //            DAL.DALHistoriqueGrade.ModifierGrade(idGrade, Id, codeGrade, Niveau, DateObt, Observation, iddoc);
        //        }
        //        RaffraichirGrid();
        //    }
        //}

        private void panelAnnuler_Click(object sender, EventArgs e)
        {
            //Vider();
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

        private void HistoriqueGradeFr_Load(object sender, EventArgs e)
        {
            panelClose.Height = panelTitre.Height;
            panelClose.Width = panelTitre.Height;
            panelClose.Location = new Point(panelTitre.Width - panelTitre.Height, 0);
        }

        private void DGVGrade_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, DGVGrade.Width - 1, DGVGrade.Height - 1);
        }

        private void CalenderAffectation_ValueChanged(object sender, EventArgs e)
        {
            txtDateAffectation.Text = CalenderAffectation.Value.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open.InitialDirectory = "C:\\";
            //open.Filter = "Image Files (*.jpg)|*.jpg| All Files(*.*)|*.*";
            open.FilterIndex = 1;
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    CorrecteFileName = System.IO.Path.GetFileName(open.FileName);
                   // txtDocument.Text = CorrecteFileName;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ErreurGradeFr_Click(object sender, EventArgs e)
        {

        }

        //private void DGVGrade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (DGVGrade.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell)
        //    {
        //        int x = DGVGrade.CurrentRow.Index;
        //        DAL.DALDocuments DALD = new DAL.DALDocuments();
        //        DataTable dt20 = new DataTable();
        //        dt20 = DALD.SelectDocumentById(int.Parse(dt1.Rows[x][6].ToString()));
        //        string lien = @"C:\Users\SatelliteT\Documents\visual studio 2013\Projects\GestionEnseignant\GestionEnseignant\Documents\" + dt20.Rows[0][7].ToString().Trim();
        //        //OpenFileDialog openFileDialog1 = new OpenFileDialog();
        //        //if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //        //{
        //        System.Diagnostics.Process.Start(lien);


        //        //}
        //        //int x = DGVDocument.CurrentRow.Index;
        //        //AfficherDocument frm = new AfficherDocument(int.Parse(dt.Rows[x][0].ToString()),Paths);
        //        //frm.ShowDialog();
        //    }
        //}
    }
}

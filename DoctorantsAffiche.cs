using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace GestionDesDoctorantsV2
{
    public partial class DoctorantsAffiche : UserControl
    {
        int w, h;
        DataTable dt = new DataTable();
        DataTable dt3 = new DataTable();
        int r = 0;
        string Paths = @"C:\Users\aymen\Documents\visual studio 2013\Projects\GestionDesDoctorantsV2\GestionDesDoctorantsV2\Documents\";
        public DoctorantsAffiche(int w1, int h1)
        {
            InitializeComponent();
            w = w1;
            h = h1;
            this.Height = h;
            this.Width = w; 
        }

        private void DoctorantsAffiche_Load(object sender, EventArgs e)
        {
           
            
            
            panel1.Height = h;
            panel1.Width = w;

            //groupBox Recherche
            groupBoxRecherche.Width = panel1.Width - 200;
            groupBoxRecherche.Height = 60;
            groupBoxRecherche.Location = new Point(10, 10);

            //DataGrid View Doctorant
            int a = (DGVDoctorants.Width / 4) * 3;
            DGVDoctorants.Columns[0].Width = (int)(DGVDoctorants.Width / 4);
            DGVDoctorants.Columns[1].Width = (int)(a / 6);
            DGVDoctorants.Columns[2].Width = (int)(a / 5);
            DGVDoctorants.Columns[3].Width = (int)(a / 6);
            DGVDoctorants.Columns[4].Width = (int)(a / 6);
           // DGVDoctorants.Columns[5].Width = (int)(a / 6);
           // DGVDoctorants.Columns[6].Width = (int)(a / 6);

            DGVDoctorants.Location = new Point(10, groupBoxRecherche.Location.Y + groupBoxRecherche.Height + 10);
            DGVDoctorants.Height = panel1.Height - 90;
            DGVDoctorants.Width = panel1.Width - 200;

            DGVDoctorants.EnableHeadersVisualStyles = false;
            //DGVEnseignant.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(91,192,222);
            DGVDoctorants.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(204, 215, 252);
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
            RaffraichirGrid();
        }
        
        public void RaffraichirGrid()
        {
            
            DGVDoctorants.Rows.Clear();
            r = 0;
            DAL.DALDoctorant D = new DAL.DALDoctorant();
            dt = D.NewSelect();
            string NomPrenom = "";
            string CIN_Passeport= "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
               
                    CIN_Passeport = dt.Rows[i][1].ToString().Trim();
                NomPrenom = "" + dt.Rows[i][2].ToString().Trim() + " " + dt.Rows[i][3].ToString().Trim();
                DGVDoctorants.Rows.Add(CIN_Passeport, NomPrenom, dt.Rows[i][4].ToString().Trim(),
                    dt.Rows[i][5].ToString().Trim(), dt.Rows[i][6].ToString().Trim());

            }
            cmbCritereFr.Text = "";
            cmbCritereFr.SelectedIndex = -1;
            labelValeur.Visible = false;
            cmbValeurFr.Visible = false;
            btnChercher.Visible = false;
            cmbCritereFr.Text = "";
            cmbCritereFr.SelectedIndex = -1;
            labelValeur.Visible = false;
            cmbValeurFr.Visible = false;
            btnChercher.Visible = false;
        }

        

        //private void btnChercher_Click(object sender, EventArgs e)
        //{
        //    if ((cmbCritereFr.Text != "") & (cmbValeurFr.Text != "") & (cmbCritereFr.Text != "Tous"))
        //    {
        //        r = 1;
        //        string critere = cmbCritereFr.Text;
        //        string valeur = cmbValeurFr.Text;
        //        if (cmbCritereFr.Text == "Nom")
        //            critere = "Enseignant.NomFr";  
               
        //        if (cmbCritereFr.Text == "Prénom")
        //            critere = "PrenomFr";

        //        if (cmbCritereFr.Text == "Situation Actuelle")
        //        {
        //            critere = "SituationActuelle";
        //            valeur = cmbValeurFr.SelectedValue.ToString();
        //        }

        //        if (cmbCritereFr.Text == "Département")
        //        {
        //            critere = "Enseignant.IdDepartement";
        //            valeur = cmbValeurFr.SelectedValue.ToString();
        //        }
                
        //        if (cmbCritereFr.Text == "Position Actuelle")
        //            critere = "TypeAdmission";         
   
        //        if (cmbCritereFr.Text == "Position")
        //            critere = "StatutActuelEnseignant";

        //        if (cmbCritereFr.Text == "Promotion")
        //        {
        //            critere = "DossierAffectation.IdTypePromotion";
        //            valeur =""+ int.Parse(cmbValeurFr.SelectedValue.ToString());
        //        }
        //        DAL.DALEnseignant E = new DAL.DALEnseignant();
        //        dt3 =E.SelectByCritere(critere, valeur);
        //        DGVEnseignant.Rows.Clear();
        //        string NomPrenom = "";
        //        string matricule = "";
        //        for (int i = 0; i < dt3.Rows.Count; i++)
        //        {
        //            if (dt3.Rows[i][1].ToString().Trim() == "0000000000")
        //                matricule = "";
        //            else
        //                matricule = dt3.Rows[i][1].ToString().Trim();
        //            NomPrenom = "" + dt3.Rows[i][3].ToString().Trim() + " " + dt3.Rows[i][4].ToString().Trim();
        //            DGVEnseignant.Rows.Add(NomPrenom, dt3.Rows[i][2].ToString().Trim(), matricule,
        //                dt3.Rows[i][7].ToString().Trim(), dt.Rows[i][14].ToString().Trim(), dt3.Rows[i][11].ToString().Trim(),
        //                dt3.Rows[i][17].ToString().Trim());
        //        }
        //    }else
        //    {
        //        if ((cmbCritereFr.Text == "Tous")||(cmbCritereFr.SelectedIndex == -1))
        //        {
        //            RaffraichirGrid();
        //            r = 0;
        //        }
        //    }
        //}

       // RaffraichirGrid();
        

        //private void btnModifier_Click(object sender, EventArgs e)
        //{
        //    int id1;
        //    string type = "";
            
        //    if (DGVEnseignant.Rows.Count > 0)
        //    {
        //        if (r == 0)
        //        {
        //            int x = DGVEnseignant.CurrentRow.Index;
        //            id1 = int.Parse(dt.Rows[x][0].ToString());
        //            type = dt.Rows[x][10].ToString().Trim();
        //        }
        //        else
        //        {
        //            int x = DGVEnseignant.CurrentRow.Index;
        //            id1 = int.Parse(dt3.Rows[x][0].ToString());
        //            type = dt3.Rows[x][10].ToString().Trim();
        //        }

        //        if (type == "Permanent")
        //        {
        //            FicheEnseignantPermanant frm = new FicheEnseignantPermanant(id1);
        //            frm.ShowDialog();
        //        }
        //        else
        //        {
        //            FicheEnseignantTemporaire frm = new FicheEnseignantTemporaire(id1);
        //            frm.ShowDialog();
        //        }
        //    } else
        //    {
        //        MessageBox.Show("Actuellement il n'existe aucun enseignant");
        //    }
        //    cmbCritereFr.Text = "";
        //    cmbValeurFr.DataSource = null;
        //    cmbValeurFr.Items.Clear();
        //    RaffraichirGrid();
        //}

        //private void btnArchivage_Click(object sender, EventArgs e)
        //{
        //    if (DGVEnseignant.Rows.Count > 0)
        //    {
        //        int id1;
        //        if (r == 0)
        //        {
        //            int x = DGVEnseignant.CurrentRow.Index;
        //            id1 = int.Parse(dt.Rows[x][0].ToString());
        //        }
        //        else
        //        {
        //            int x = DGVEnseignant.CurrentRow.Index;
        //            id1 = int.Parse(dt3.Rows[x][0].ToString());
        //        }

        //        ArchiverEnseignant frm = new ArchiverEnseignant(id1);
        //        frm.ShowDialog();
        //        cmbCritereFr.Text = "";
        //        cmbValeurFr.DataSource = null;
        //        cmbValeurFr.Items.Clear();
        //        RaffraichirGrid();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Actuellement il n'existe aucun ensignant ");
        //    }
        //}

        //private void btnSupprimer_Click(object sender, EventArgs e)
        //{
        //    if (DGVEnseignant.Rows.Count > 1)
        //    {
        //        string DeleteEnseignantMsg = "Vous êtes sur le point de supprimer un enseignant.";
        //        DeleteEnseignantMsg += " Cliquez sur OK pour confirmer la suppression ou sur Annuler dans le cas contraire !!! ";
        //        DialogResult DeleteEnseignantDecision;
        //        DeleteEnseignantDecision = MessageBox.Show(DeleteEnseignantMsg, "Suppression d'un enseignant", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //        int x = DGVEnseignant.CurrentRow.Index;
        //        int identifiant;
        //        string type = "";
        //        if (r == 0)
        //        {
        //            identifiant = int.Parse(dt.Rows[x][0].ToString());
        //            type = dt.Rows[x][10].ToString();
        //        }
        //        else
        //        {
        //            identifiant = int.Parse(dt.Rows[x][0].ToString());
        //            type = dt3.Rows[x][10].ToString();
        //        }


        //        if (DeleteEnseignantDecision == DialogResult.OK)
        //        {
        //            //try
        //            //{
        //            string ResultMsg = "Enseignant Supprimée!!";


        //            if (dt.Rows[x][9].ToString().Trim() == "Permanent")
        //            {
        //                DAL.DALHistoriqueConge.DeleteEnseignantHistoriqueConge(identifiant);
        //                DAL.DALHistoriqueGrade.DeleteEnseignantHistoriqueGrade(identifiant);
        //                DAL.DALHistoriqueResponsabilite.DeleteEnseignantHistoriqueResponsabilite(identifiant);
        //                DAL.DALHistoriqueStatut.DeleteEnseignantHistoriqueStatut(identifiant);
        //                DAL.DALDossierAffectation DA = new DAL.DALDossierAffectation();
        //                DAL.DALDocuments DOC = new DAL.DALDocuments();
        //                DA.DeleteDossierAffectation(identifiant);
        //                DAL.DALCharge.DeleteEnseignantEnseignement(identifiant);
        //                DAL.DALCharge.DeleteAutreCharge(identifiant);              
        //                DAL.DALCharge.DeleteEncadrement(identifiant);
        //                DOC.DeleteDocument(identifiant);
        //                DAL.DALEnseignant E = new DAL.DALEnseignant();
        //                E.DeleteEnseignant(identifiant);
        //                Directory.Delete(Paths + dt.Rows[x][2].ToString().Trim(), true);
        //            }
        //            else
        //            {
        //                DAL.DALHistoriqueConge.DeleteEnseignantHistoriqueConge(identifiant);
        //                DAL.DALHistoriqueStatut.DeleteEnseignantHistoriqueStatut(identifiant);
        //                DAL.DALDossierAffectation DA = new DAL.DALDossierAffectation();
        //                DA.DeleteDossierAffectation(identifiant);
        //                DAL.DALCharge.DeleteEnseignantEnseignement(identifiant);
        //                DAL.DALCharge.DeleteAutreCharge(identifiant);
        //                DAL.DALCharge.DeleteEncadrement(identifiant);
        //                DAL.DALDocuments DOC = new DAL.DALDocuments();
        //                DOC.DeleteDocument(identifiant);
        //                DAL.DALEnseignant E = new DAL.DALEnseignant();
        //                E.DeleteEnseignant(identifiant);
        //                Directory.Delete(Paths + dt.Rows[x][2].ToString().Trim(), true);
        //            }


        //            MessageBox.Show(ResultMsg, "Suppression d'un enseignant", MessageBoxButtons.OK, MessageBoxIcon.Question);

        //            //}
        //            //catch (Exception A)
        //            //{
        //            //    MessageBox.Show(A.Message, "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            //}
        //        }
        //        cmbCritereFr.Text = "";
        //        cmbValeurFr.DataSource = null;
        //        cmbValeurFr.Items.Clear();
        //        RaffraichirGrid();
        //    }else
        //    {
        //        MessageBox.Show("Actuellement il n'existe aucun enseignant ");
        //    }
        //}

        //private void btnImprimer_Click(object sender, EventArgs e)
        //{
        //    DataTable dt1 = new DataTable();
        //    if (r == 0)
        //        dt1 = dt;
        //    else
        //        dt1 = dt3;
        //    if (DGVEnseignant.Rows.Count > 0)
        //    {
        //        ChoixLangImp frm = new ChoixLangImp(dt1);
        //        frm.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Actuellement il n'existe aucun ensignant ");
        //    }
        //}

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

        private void btnImprimer_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnImprimer.Width - 1, btnImprimer.Height - 1);
        }

        //private void btnImporter_Paint(object sender, PaintEventArgs e)
        //{
        //    Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
        //    e.Graphics.DrawRectangle(couleur, 0, 0, btnImporter.Width - 1, btnImporter.Height - 1);
        //}

        private void btnExporter_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnExporter.Width - 1, btnExporter.Height - 1);
        }

        private void btnArchiver_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnArchiver.Width - 1, btnArchiver.Height - 1);
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

        private void btnImprimer_MouseEnter(object sender, EventArgs e)
        {
            btnImprimer.BackColor = Color.FromArgb(133, 202, 255);
            labelImprimer.ForeColor = Color.White;
        }

        private void btnImprimer_MouseLeave(object sender, EventArgs e)
        {
            btnImprimer.BackColor = Color.White;
            labelImprimer.ForeColor = Color.FromArgb(10, 56, 84);
        }

        //private void btnImporter_MouseEnter(object sender, EventArgs e)
        //{
        //    btnImporter.BackColor = Color.FromArgb(133, 202, 255);
        //    labelImporter.ForeColor = Color.White;
        //}

        //private void btnImporter_MouseLeave(object sender, EventArgs e)
        //{
        //    btnImporter.BackColor = Color.White;
        //    labelImporter.ForeColor = Color.FromArgb(10, 56, 84);
        //}

        private void btnExporter_MouseEnter(object sender, EventArgs e)
        {
            btnExporter.BackColor = Color.FromArgb(133, 202, 255);
            labelExporter.ForeColor = Color.White;
        }

        private void btnExporter_MouseLeave(object sender, EventArgs e)
        {
            btnExporter.BackColor = Color.White;
            labelExporter.ForeColor = Color.FromArgb(10, 56, 84);
        }

        private void btnArchiver_MouseEnter(object sender, EventArgs e)
        {
            btnArchiver.BackColor = Color.FromArgb(133, 202, 255);
            labelArchiver.ForeColor = Color.White;
        }

        private void btnArchiver_MouseLeave(object sender, EventArgs e)
        {
            btnArchiver.BackColor = Color.White;
            labelArchiver.ForeColor = Color.FromArgb(10, 56, 84);
        }

        private void btnChercher_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(188, 188, 188), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnChercher.Width - 1, btnChercher.Height - 1);
        }

        private void btnChercher_MouseEnter(object sender, EventArgs e)
        {
            btnChercher.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void btnChercher_MouseLeave(object sender, EventArgs e)
        {
            btnChercher.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void DGVEnseignant_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, DGVDoctorants.Width - 1, DGVDoctorants.Height - 1);
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

        private void labelExporter_Click(object sender, EventArgs e)
        {
            DataTable tbl=dt;
            string excelFilePath = null;
            try
            {
                if (tbl == null || tbl.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                var excelApp = new Excel.Application();
                excelApp.Workbooks.Add();

                // single worksheet
                Excel._Worksheet workSheet = excelApp.ActiveSheet;

                // column headings
                for (var i = 0; i < tbl.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = tbl.Columns[i].ColumnName;
                }

                // rows
                for (var i = 0; i < tbl.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (var j = 0; j < tbl.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = tbl.Rows[i][j];
                    }
                }

                // check file path
                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    try
                    {
                        workSheet.SaveAs(excelFilePath);
                        excelApp.Quit();
                        MessageBox.Show("Excel file saved!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                            + ex.Message);
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }

       

        

        private void btnModifier_Click(object sender, EventArgs e)
        {
             int id1;
            

            if (DGVDoctorants.Rows.Count > 0)
            {
                
                if (r == 0)
                {
                    int x = DGVDoctorants.CurrentRow.Index;
                    id1 = int.Parse(dt.Rows[x][0].ToString());
                    
                }
                    
             
                else 
                {
                    int x = DGVDoctorants.CurrentRow.Index;
                    id1 = int.Parse(dt3.Rows[x][0].ToString());
                   
                }
               
                FicheDoctorants frm = new FicheDoctorants(id1);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Actuellement il n'existe aucun doctorant");
            }
            cmbCritereFr.Text = "";
            cmbValeurFr.DataSource = null;
            cmbValeurFr.Items.Clear();
            RaffraichirGrid();
            
            
           
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            Ajouter_Doctorants frm = new Ajouter_Doctorants();
            frm.ShowDialog();
            RaffraichirGrid();
        }

        private void cmbCritereFr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string table = "";
            string critere = cmbCritereFr.Text;
            DataTable dt2 = new DataTable();
            if ((cmbCritereFr.Text == "Tous") || (cmbCritereFr.SelectedIndex == -1))
            {
                r = 0;
                RaffraichirGrid();
            }
            else
            {
                r = 1;
                labelValeur.Visible = true;
                cmbValeurFr.Visible = true;
                btnChercher.Visible = true;

                //if (cmbCritereFr.Text == "Situation Actuelle")
                //{
                //    cmbValeurFr.DataSource = null;
                //    cmbValeurFr.Items.Clear();
                //    DAL.DALTypeSituationAdministrative S = new DAL.DALTypeSituationAdministrative();
                //    dt2 = S.SelectAllStatut();
                //    cmbValeurFr.DataSource = dt2;
                //    cmbValeurFr.DisplayMember = "Code";
                //    cmbValeurFr.ValueMember = "IdTypeSituationAdmin";
                //    cmbValeurFr.SelectedIndex = -1;
                //}

                //if (cmbCritereFr.Text == "Département")
                //{
                //    cmbValeurFr.DataSource = null;
                //    cmbValeurFr.Items.Clear();
                //    DAL.DALDepartement D = new DAL.DALDepartement();
                //    dt2 = D.SelectAllDepartement();
                //    cmbValeurFr.DataSource = dt2;
                //    cmbValeurFr.DisplayMember = "Code";
                //    cmbValeurFr.ValueMember = "IdDepartement";
                //    cmbValeurFr.SelectedIndex = -1;
                //}

                //if (cmbCritereFr.Text == "Position Actuelle")
                //{
                //    critere = "TypeAdmission";
                //    table = "DossierAffectation";
                //    cmbValeurFr.DataSource = null;
                //    cmbValeurFr.Items.Clear();
                //    cmbValeurFr.Text = "";
                //    DAL.DALEnseignant E = new DAL.DALEnseignant();
                //    dt2 = E.SelectValue(critere, table);
                //    for (int i = 0; i < dt2.Rows.Count; i++)
                //    {
                //        cmbValeurFr.Items.Add(dt2.Rows[i][0]);
                //    }
                //}

                if (cmbCritereFr.Text == "Nom")
                {
                    critere = "NomFr";
                    table = "Doctorant";
                    cmbValeurFr.DataSource = null;
                    cmbValeurFr.Items.Clear();
                    cmbValeurFr.Text = "";
                    DAL.DALDoctorant D = new DAL.DALDoctorant();
                    dt2 = D.SelectValue(critere, table);
                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        cmbValeurFr.Items.Add(dt2.Rows[i][0]);
                    }
                }

                //if (cmbCritereFr.Text == "Prénom")
                //{
                //    critere = "PrenomFr";
                //    table = "Enseignant where EtatActuel='Actif'";
                //    cmbValeurFr.DataSource = null;
                //    cmbValeurFr.Items.Clear();
                //    cmbValeurFr.Text = "";
                //    DAL.DALEnseignant E = new DAL.DALEnseignant();
                //    dt2 = E.SelectValue(critere, table);
                //    for (int i = 0; i < dt2.Rows.Count; i++)
                //    {
                //        cmbValeurFr.Items.Add(dt2.Rows[i][0]);
                //    }
                //}

                //if (cmbCritereFr.Text == "CIN")
                //{
                //    critere = "CIN";
                //    table = "Enseignant where EtatActuel='Actif'";
                //    cmbValeurFr.DataSource = null;
                //    cmbValeurFr.Items.Clear();
                //    cmbValeurFr.Text = "";
                //    DAL.DALEnseignant E = new DAL.DALEnseignant();
                //    dt2 = E.SelectValue(critere, table);
                //    for (int i = 0; i < dt2.Rows.Count; i++)
                //    {
                //        cmbValeurFr.Items.Add(dt2.Rows[i][0]);
                //    }
                //}

                //if (cmbCritereFr.Text == "Promotion")
                //{
                //    critere = "IdTypePromotion";
                //    table = "DossierAffectation";
                //    cmbValeurFr.DataSource = null;
                //    cmbValeurFr.Items.Clear();
                //    cmbValeurFr.Text = "";
                //    DAL.DALEnseignant E = new DAL.DALEnseignant();
                //    DAL.DALTypePromotion P = new DAL.DALTypePromotion();
                //    dt2 = P.SelectAllGrade();
                //    cmbValeurFr.DataSource = dt2;
                //    cmbValeurFr.ValueMember = "IdTypePromotion";
                //    cmbValeurFr.DisplayMember = "Code";
                //    cmbValeurFr.SelectedIndex = -1;
                //}
            }
        }

        
             

    }
}

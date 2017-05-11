using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace GestionDesDoctorantsV2
{
    public partial class Statistique : UserControl
    {
        int w, h;
        DataTable dt0 = new DataTable();
        DataTable dt1 = new DataTable();

        int mode = 0;
        public Statistique(int w1, int h1)
        {
            InitializeComponent();
            w = w1;
            h = h1;
            this.Height = h;
            this.Width = w;
        }

        //public void RaffraichirGrid()
        //{
        //    mode = 0;
        //    DataTable dt = new DataTable();
        //    DAL.DALDepartement D = new DAL.DALDepartement();
        //    dt = D.SelectAllDepartement();
        //    cmbDepartementFr.DataSource = dt;
        //    cmbDepartementFr.DisplayMember = "Code";
        //    cmbDepartementFr.ValueMember = "IdDepartement";
        //    cmbDepartementFr.SelectedIndex = -1;

        //    DataTable dt1 = new DataTable();
        //    DAL.DALTypePromotion P = new DAL.DALTypePromotion();
        //    dt1 = P.SelectAllGrade();
        //    cmbGradeFr.DataSource = dt1;
        //    cmbGradeFr.DisplayMember = "Code";
        //    cmbGradeFr.ValueMember = "IdTypePromotion";
        //    cmbGradeFr.SelectedIndex = -1;

        //    DataTable dt2 = new DataTable();
        //    DAL.DALTypeSituationAdministrative S = new DAL.DALTypeSituationAdministrative();
        //    dt2 = S.SelectAllStatut();
        //    cmbStatutFr.DataSource = dt2;
        //    cmbStatutFr.DisplayMember = "Code";
        //    cmbStatutFr.ValueMember = "IdTypeSituationAdmin";
        //    cmbStatutFr.SelectedIndex = -1;

        //    DAL.Statistiques STAT = new DAL.Statistiques();
        //   dt0 = STAT.SelectAll();
        //    string grad = "";
        //    string matricule = "";
        //    DGVStatistique.Rows.Clear();
        //    for (int i = 0; i <dt0.Rows.Count; i++)
        //    {
        //        if (dt0.Rows[i][4].ToString().Trim() == "0000000000")
        //            matricule = "";
        //        else
        //            matricule =dt0.Rows[i][4].ToString().Trim();
        //        if (dt0.Rows[i][10].ToString().Trim() == "GradeT")
        //            grad = "";
        //        else
        //            grad =dt0.Rows[i][10].ToString().Trim();
        //        DGVStatistique.Rows.Add(dt0.Rows[i][1].ToString().Trim() + " " +dt0.Rows[i][2].ToString().Trim(),
        //          dt0.Rows[i][3].ToString().Trim(), matricule,
        //          dt0.Rows[i][5].ToString().Trim(),dt0.Rows[i][6].ToString().Trim(),dt0.Rows[i][8].ToString().Trim(),
        //            grad,
        //          dt0.Rows[i][11].ToString().Trim(),dt0.Rows[i][13].ToString().Trim(),dt0.Rows[i][14].ToString().Trim());

        //    }
        //}

        private void Statistiques_Load(object sender, EventArgs e)
        {
            //panel1
            panel1.Height = this.Height - 20;
            panel1.Width = 170;
            panel1.Location = new Point(10, 10);
            
            //datagrid view
            DGVStatistique.Height = this.Height - 20;
            DGVStatistique.Width = (int)(this.Width - 200);
            DGVStatistique.Location = new Point(190, 10);


            int x1 = DGVStatistique.Width / 3;
            int x2 = ((DGVStatistique.Width / 3) * 2) / 8;
            DGVStatistique.Columns[0].Width = x1 / 2;
            DGVStatistique.Columns[1].Width = x2;
            DGVStatistique.Columns[2].Width = x2;
            DGVStatistique.Columns[3].Width = x2;
            DGVStatistique.Columns[4].Width = x1 / 2;
            DGVStatistique.Columns[5].Width = x2;
            DGVStatistique.Columns[6].Width = x2;
            DGVStatistique.Columns[7].Width = x2;
            DGVStatistique.Columns[8].Width = x2;
            DGVStatistique.Columns[9].Width = x2;
          //  RaffraichirGrid();
        }

        private void DGVStatistique_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, DGVStatistique.Width - 1, DGVStatistique.Height - 1);
        }

        private void btnChercher_MouseEnter(object sender, EventArgs e)
        {
            btnChercher.BackColor = Color.FromArgb(133, 202, 255);
            labelChercher.ForeColor = Color.White;
        }

        private void btnChercher_MouseLeave(object sender, EventArgs e)
        {
            btnChercher.BackColor = Color.White;
            labelChercher.ForeColor = Color.FromArgb(10, 56, 84);
        }

        private void btnChercher_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnChercher.Width - 1, btnChercher.Height - 1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panel1.Width - 1, panel1.Height - 1);
        }

        //private void labelChercher_Click(object sender, EventArgs e)
        //{
        //    mode = 1;
        //    string Sexe;
        //    int departement;
        //    int Promotion;
        //    String Type;
        //    int Situation;

        //    if (cmbSexeFr.Text == "")
        //        Sexe = "";
        //    else 
        //        Sexe = cmbSexeFr.Text;

        //    if (cmbDepartementFr.Text == "")
        //        departement = 0;
        //    else
        //        departement = int.Parse(cmbDepartementFr.SelectedValue.ToString());

        //    if (cmbGradeFr.Text == "")
        //        Promotion = 0;
        //    else
        //        Promotion = int.Parse(cmbGradeFr.SelectedValue.ToString());

        //    if (cmbStatutFr.Text == "")
        //        Situation = 0;
        //    else
        //        Situation = int.Parse(cmbStatutFr.SelectedValue.ToString());

        //    if (cmbType.Text == "")
        //        Type = "";
        //    else
        //        Type = cmbType.Text.Trim();

        //    DAL.Statistiques S = new DAL.Statistiques();
        //    dt1 = S.SelectByCritere(Sexe, departement, Promotion, Type, Situation);
        //    string grad = "";
        //    string matricule = "";
        //    DGVStatistique.Rows.Clear();
        //    for (int i = 0; i <dt1.Rows.Count; i++)
        //    {
        //        if (dt1.Rows[i][4].ToString().Trim() == "0000000000")
        //            matricule = "";
        //        else
        //            matricule =dt1.Rows[i][4].ToString().Trim();
        //        if (dt1.Rows[i][10].ToString().Trim() == "GradeT")
        //            grad = "";
        //        else
        //            grad =dt1.Rows[i][10].ToString().Trim();
        //        DGVStatistique.Rows.Add(dt1.Rows[i][1].ToString().Trim() + " " +dt1.Rows[i][2].ToString().Trim(),
        //           dt1.Rows[i][3].ToString().Trim(), matricule,
        //           dt1.Rows[i][5].ToString().Trim(),dt1.Rows[i][6].ToString().Trim(),dt1.Rows[i][8].ToString().Trim(),
        //            grad,
        //           dt1.Rows[i][11].ToString().Trim(),dt1.Rows[i][13].ToString().Trim(),dt1.Rows[i][14].ToString().Trim());

        //    }
        //}

        private void btnImprimer_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnImprimer.Width - 1, btnImprimer.Height - 1);
        }

        private void btnExporter_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(24, 131, 215), 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, btnExporter.Width - 1, btnExporter.Height - 1);
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

        //private void labelImprimer_Click(object sender, EventArgs e)
        //{
        //    if (mode == 0)
        //    {
        //        Imprime.Statistique frm = new Imprime.Statistique(dt0);
        //        frm.ShowDialog();
        //    }
        //    else
        //    {
        //        Imprime.Statistique frm = new Imprime.Statistique(dt1);
        //        frm.ShowDialog();
        //    }
        //}

        private void labelExporter_Click(object sender, EventArgs e)
        {
            DataTable tbl;
            if(mode==0)
                tbl = dt0;
            else
                tbl = dt0;
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
    }
}

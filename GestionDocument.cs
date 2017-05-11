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
    public partial class GestionDocument : Form
    {
        DataTable dt = new DataTable();
        int ID;
        int MODE;

        string cin;
        string Paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\Documents\\";
        string CorrecteFileName;
        OpenFileDialog open = new OpenFileDialog();
        DAL.DALDoctorant Doct1 = new DAL.DALDoctorant();
        DataTable dt1 = new DataTable();
       
        Entities.Doctorant c = new Entities.Doctorant();
        public GestionDocument(int id1, int mode1)
        {
            InitializeComponent();
            ID = id1;
            MODE = mode1;

            if (MODE!=0)
            {
                panelModifDoc.Visible = true;
                button1.Enabled = false;
                txtDocument.Enabled = false;
                //int x = DGVDocument.CurrentRow.Index;
                //int IdDoc = int.Parse(dt.Rows[x][0].ToString());
                //DataTable dt1 = new DataTable();
                //DAL.DALDocuments d = new DAL.DALDocuments();
                //dt1 = d.SelectDocumentById(IdDoc);
                //cmbTypeDocument.SelectedValue = int.Parse(dt1.Rows[0][3].ToString());
                //txtNomFr.Text = dt1.Rows[0][4].ToString().Trim();
                //txtNomAr.Text = dt1.Rows[0][5].ToString().Trim();
                //txtCommentaire.Text = dt1.Rows[0][6].ToString().Trim();
                //txtDocument.Text = dt1.Rows[0][7].ToString().Trim();
            }

            else
            {
                
                panelModifDoc.Visible = true;
                button1.Enabled = true;
                txtDocument.Enabled = true;
                cmbTypeDocument.SelectedIndex = -1;
                txtNomFr.Text = "";
                txtNomAr.Text = "";
                txtCommentaire.Text = "";
                txtDocument.Text = "";
               
            }

            DataTable dt287 = new DataTable();
            DAL.DALTypeDocument t = new DAL.DALTypeDocument();
            dt287 = t.SelectAllTypeDocument();
            cmbTypeDocument.DataSource = dt287;
            cmbTypeDocument.ValueMember = "IdTypeDocument";
            cmbTypeDocument.DisplayMember = "Code";
           
         
        }

        public void AfficherErreur()
        {
            if (cmbTypeDocument.Text == "")
                ErreurTypeDocument.Visible = true;
            else
                ErreurTypeDocument.Visible=false;
            if (txtDocument.Text == "")
                ErreurDocument.Visible = true;
            else
                ErreurDocument.Visible = false;
            if (txtNomFr.Text == "")
                ErreurNomFr.Visible = true;
            else
                ErreurNomFr.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files (*.jpg)|*.jpg| All Files(*.*)|*.*";
            open.FilterIndex = 1;
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    CorrecteFileName = System.IO.Path.GetFileName(open.FileName);
                    txtDocument.Text = CorrecteFileName;
                }
            }
        }
         


        private void labelAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
            //panel1.Visible = true;
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

       
        

      

        private void btnAjouter_Click(object sender, EventArgs e)
        {
           // mode = 0;
            panelModifDoc.Visible = true;
            button1.Enabled = true;
            txtDocument.Enabled = true;
            cmbTypeDocument.SelectedIndex = -1;
            txtNomFr.Text = "";
           txtNomAr.Text = "";
            txtCommentaire.Text = "";
            txtDocument.Text ="";
        }

        //private void labelModifier_Click(object sender, EventArgs e)
        //{
        //    mode = 1;
        //    panel2.Visible = true;
        //    button1.Enabled = false;
        //    txtDocument.Enabled = false;
        //    int x = DGVDocument.CurrentRow.Index;
        //    int IdDoc = int.Parse(dt.Rows[x][0].ToString());
        //    DataTable dt1 = new DataTable();
        //    DAL.DALDocuments d = new DAL.DALDocuments();
        //    dt1 = d.SelectDocumentById(IdDoc);
        //    cmbTypeDocument.SelectedValue = int.Parse(dt1.Rows[0][3].ToString());
        //    txtNomFr.Text = dt1.Rows[0][4].ToString().Trim();
        //    txtNomAr.Text = dt1.Rows[0][5].ToString().Trim();
        //    txtCommentaire.Text = dt1.Rows[0][6].ToString().Trim();
        //    txtDocument.Text = dt1.Rows[0][7].ToString().Trim();
        //}

        //private void btnSupprimer_Click(object sender, EventArgs e)
        //{
        //    int x = DGVDocument.CurrentRow.Index;
        //    int IdDoc = int.Parse(dt.Rows[x][0].ToString());
        //    DAL.DALDocuments d = new DAL.DALDocuments();
        //    System.IO.File.Delete(Paths+dt.Rows[x][7].ToString().Trim());
        //    d.DeleteDocument(IdDoc);
        //    d.DeleteDocumentFromConge(IdDoc);
        //    d.DeleteDocumentFromGrade(IdDoc);
        //    RaffraichirGrid();
        //}

        private void GestionDocument_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.FromArgb(51, 122, 183), 2);
            e.Graphics.DrawRectangle(couleur, 1, 1, this.Width - 2, this.Height - 2);
        }

        private void panelClose_MouseEnter(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(228, 17, 41);
        }

        private void panelClose_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.Transparent;
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelEnregistrer_Click(object sender, EventArgs e)
        {
             if ((cmbTypeDocument.Text != "") & (txtDocument.Text != "") & (txtNomFr.Text != ""))
             {
                 int type = int.Parse(cmbTypeDocument.SelectedValue.ToString());
                 string NomAr = txtNomAr.Text;
                 string NomFr = txtNomFr.Text;
                 string Commentaire = txtCommentaire.Text;
                 DateTime DateAjout = DateTime.Now;
                 string extension = "";
                 extension = System.IO.Path.GetExtension(CorrecteFileName);
                 string lien = cin + "\\" + NomFr + extension;
                 DAL.DALDocuments d = new DAL.DALDocuments();
                 if (MODE == 0)
                 {
                     d.AjouterDocument(ID, type, DateAjout, NomFr, NomAr, Commentaire, lien);

                     System.IO.File.Copy(open.FileName, Paths + lien);

                     MessageBox.Show("Document bien ajoutée");
                 }
                 else
                 {
                     int x = ID;
                     int IdDoc = int.Parse(dt.Rows[x][0].ToString());

                     System.IO.File.Move(Paths + dt.Rows[x][7].ToString().Trim(), Paths + cin + "\\" + NomFr + extension);

                     d.UpdateDocument(IdDoc, type, NomFr, NomAr, Commentaire, cin + "\\" + NomFr + extension);

                     MessageBox.Show("Modification bien éffectuée");
                 }
               
             }
             else
             {
                 AfficherErreur();
             }
        }

    }
}

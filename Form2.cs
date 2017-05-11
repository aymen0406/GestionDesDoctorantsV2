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
    public partial class Form2 : Form
    {
        public static int h = 0, w = 0;
        Timer bg = new Timer();
        int IdUser;
        public Form2()
        {
            InitializeComponent();
            this.Visible = false;
            //Login l = new Login();
           // l.ShowDialog();
          //  IdUser = l.IdUser;
        }      
        void cadreWhite(Panel p)
        {
            panel1.Visible = true;
            p.BackColor = Color.FromArgb(238, 238, 238);
            panel1.Location = new Point(p.Location.X - 1, p.Location.Y - 1);
        }

        private void MenuDoctorants_Click(object sender, EventArgs e)
        {
            cadreWhite(MenuDoctorants);
            panel1.Location = new Point(MenuDoctorants.Location.X - 1, MenuDoctorants.Location.Y - 1);
            panel1.Visible = true;
            MenuDoctorants.BackColor = Color.FromArgb(238, 238, 238);
            MenuParametres.BackColor = Color.Transparent;
            MenuStatistique.BackColor = Color.Transparent;
            MenuInscription.BackColor = Color.Transparent;
            MenuSoutenance.BackColor = Color.Transparent;
            DoctorantsAffiche doct = new DoctorantsAffiche(panel4.Width - 2, panel4.Height - 2);
            panel4.Controls.Clear();
            doct.Location = new Point(1, 1);
            panel4.Controls.Add(doct);
            labelTitreForm.Text = "Liste des Doctorants";
            labelTitreForm.Visible = true;
        }

        private void MenuInscription_Click(object sender, EventArgs e)
        {
            cadreWhite(MenuInscription);
            panel1.Location = new Point(MenuInscription.Location.X - 1, MenuInscription.Location.Y - 1);
            panel1.Visible = true;
            MenuInscription.BackColor = Color.FromArgb(238, 238, 238);
            MenuDoctorants.BackColor = Color.Transparent;
            MenuParametres.BackColor = Color.Transparent;
            MenuStatistique.BackColor = Color.Transparent;
            MenuSoutenance.BackColor = Color.Transparent;
            InscriptionPanel insc = new InscriptionPanel(panel4.Width - 2, panel4.Height - 2);
            panel4.Controls.Clear();
            insc.Location = new Point(1, 1);
            panel4.Controls.Add(insc);
            labelTitreForm.Text = "Inscription";
            labelTitreForm.Visible = true;
        }

        private void MenuSoutenance_Click(object sender, EventArgs e)
        {
            cadreWhite(MenuSoutenance);
            panel1.Location = new Point(MenuSoutenance.Location.X - 1, MenuSoutenance.Location.Y - 1);
            panel1.Visible = true;
            MenuSoutenance.BackColor = Color.FromArgb(238, 238, 238);
            MenuDoctorants.BackColor = Color.Transparent;
            MenuParametres.BackColor = Color.Transparent;
            MenuInscription.BackColor = Color.Transparent;
            MenuStatistique.BackColor = Color.Transparent;
            SoutenanceAffiche sout = new SoutenanceAffiche(panel4.Width - 2, panel4.Height - 2);
            panel4.Controls.Clear();
            sout.Location = new Point(1, 1);
            panel4.Controls.Add(sout);
            labelTitreForm.Text = "Soutenance";
            labelTitreForm.Visible = true;
        }

        private void MenuStatistique_Click(object sender, EventArgs e)
        {
            cadreWhite(MenuStatistique);
            panel1.Location = new Point(MenuStatistique.Location.X - 1, MenuStatistique.Location.Y - 1);
            panel1.Visible = true;
            MenuStatistique.BackColor = Color.FromArgb(238, 238, 238);
            MenuDoctorants.BackColor = Color.Transparent;
            MenuParametres.BackColor = Color.Transparent;
            MenuInscription.BackColor = Color.Transparent;
            MenuSoutenance.BackColor = Color.Transparent;
            //sat frm = new sat();
            Statistique frm = new Statistique(panel4.Width - 2, panel4.Height - 2);
            panel4.Controls.Clear();
            frm.Location = new Point(1, 1);
            panel4.Controls.Add(frm);
            labelTitreForm.Text = "Statistiques";
            labelTitreForm.Visible = true;
        }
        private void MenuParametresFr_Click(object sender, EventArgs e)
        {
            cadreWhite(MenuParametres);
            panel1.Location = new Point(MenuParametres.Location.X - 1, MenuParametres.Location.Y - 1);
            panel1.Visible = true;
            MenuParametres.BackColor= Color.FromArgb(238,238,238);
            MenuDoctorants.BackColor=Color.Transparent;
            MenuStatistique.BackColor=Color.Transparent;
            MenuInscription.BackColor=Color.Transparent;
            MenuSoutenance.BackColor=Color.Transparent;
            ParametreF param = new ParametreF(panel4.Width - 2, panel4.Height - 2);
            panel4.Controls.Clear();
            param.Location = new Point(1, 1);
            panel4.Controls.Add(param);
            labelTitreForm.Text = "Paramètres";
            labelTitreForm.Visible = true;
        }

        private void MenuCompte_Click(object sender, EventArgs e)
        {
            MenuCompte.BackColor = Color.FromArgb(238, 238, 238);
            MenuDoctorants.BackColor = Color.Transparent;
            MenuParametres.BackColor = Color.Transparent;
            MenuInscription.BackColor = Color.Transparent;
            MenuStatistique.BackColor = Color.Transparent;
            MenuContactFr.BackColor = Color.Transparent;
            MenuSoutenance.BackColor = Color.Transparent;
            CompteFr compte = new CompteFr(panel4.Width - 2, panel4.Height - 2);
            panel4.Controls.Clear();
            compte.Location = new Point(1, 1);
            panel4.Controls.Add(compte);
            labelTitreForm.Text = "Compte";
            labelTitreForm.Visible = true;
            GestionCompte frm = new GestionCompte(IdUser);
            frm.ShowDialog();
        }
       
        //private void MenuArchiveFr_Click(object sender, EventArgs e)
        //{
        //    cadreWhite(MenuArchiveFr);
        //    panel1.Location = new Point(MenuArchiveFr.Location.X - 1, MenuArchiveFr.Location.Y - 1);
        //    panel1.Visible = true;
        //    MenuArchiveFr.BackColor = Color.FromArgb(238, 238, 238);
        //    MenuEnseignantFr.BackColor = Color.Transparent;
        //    MenuParametresFr.BackColor = Color.Transparent;
        //    MenuStatistiqueFr.BackColor = Color.Transparent;
        //    MenuAideFr.BackColor = Color.Transparent;
        //    InscriptionAffiche insc = new InscriptionAffiche(panel4.Width - 2, panel4.Height - 2);
        //    panel4.Controls.Clear();
        //    insc.Location = new Point(1, 1);
        //    panel4.Controls.Add(insc);
        //    labelTitreForm.Text = "Archive";
        //    labelTitreForm.Visible = true;
        //}
       
        //private void MenuContactFr_Click(object sender, EventArgs e)
        //{
        //    FormFrançais.Contact frm = new FormFrançais.Contact();
        //    frm.ShowDialog();
        //}
        //private void MenuAideFr_Click(object sender, EventArgs e)
        //{
        //    cadreWhite(MenuAideFr);
        //    panel1.Location = new Point(MenuAideFr.Location.X - 1, MenuAideFr.Location.Y - 1);
        //    panel1.Visible = true;
        //    MenuAideFr.BackColor = Color.FromArgb(238, 238, 238);
        //    MenuEnseignantFr.BackColor=Color.Transparent;
        //    MenuParametresFr.BackColor=Color.Transparent;
        //    MenuArchiveFr.BackColor=Color.Transparent;
        //    MenuStatistiqueFr.BackColor=Color.Transparent;
        //    Aide aide = new Aide(panel4.Width - 2, panel4.Height - 2);
        //    panel4.Controls.Clear();
        //    aide.Location = new Point(1, 1);
        //    panel4.Controls.Add(aide);
        //    labelTitreForm.Text = "Aide";
        //    labelTitreForm.Visible = true;
        //}

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //panel titre
            panelTitre.Width = this.Width - 150;      
            
            //panel ribbon 
            panelRubban.Width = this.Width - 150;

            //localisation de composent de ribbon
            MenuContactFr.Location = new Point(this.Width - 290, 1);
            MenuCompte.Location = new Point(this.Width - 220, 1);
           // MenuLangue.Location = new Point(this.Width - 360, 1);

            //panel du centre
            panel4.Width = this.Width - 130;
            panel4.Height = this.Height - 180;
            h = panel4.Height - 2;
            w = panel4.Width - 2;            

            //label date 
            bg.Tick += (s, eventArgs) => { labeldate.Text = DateTime.Now.ToString(); };
            bg.Interval = 500;
            bg.Start();
            
            labeldate.Location = new Point(panelTitre.Width - (labeldate.Width * 3), panelTitre.Height / 3);
            labelTitre.Location = new Point(labelTitre.Location.X, panelTitre.Height / 3);

            // localisation du menu 
            int x = 80 + ((this.Height - 180) - 400) / 4;
            MenuDoctorants.Location = new Point(10, 136);
            MenuInscription.Location = new Point(10, 126 + x);
            MenuSoutenance.Location = new Point(10, 126 + (2 * x));
            MenuStatistique.Location = new Point(10, 126 + (3 * x));
            MenuParametres.Location = new Point(10, 126 + (4 * x));
           

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panel4.Width - 1, panel4.Height - 1);
        }

       

      

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

       

        //private void MenuArchiveFr_MouseEnter(object sender, EventArgs e)
        //{
        //    cadreWhite(MenuInscription);
        //    panel1.Location = new Point(MenuInscription.Location.X - 1, MenuInscription.Location.Y - 1);
        //    panel1.Visible = true;
        //    MenuInscription.BackColor = Color.FromArgb(238, 238, 238);
        //    MenuDoctorants.BackColor = Color.Transparent;
        //    MenuParametres.BackColor = Color.Transparent;
        //    MenuStatistique.BackColor = Color.Transparent;
        //    MenuSoutenance.BackColor = Color.Transparent;
        //}

       


        private void MenuParametresFr_MouseLeave(object sender, EventArgs e)
        {
            MenuParametres.BackColor = Color.Transparent;
        }

        private void MenuStatistiqueFr_MouseLeave(object sender, EventArgs e)
        {
            MenuStatistique.BackColor = Color.Transparent;
        }

    

        private void MenuContactFr_MouseEnter(object sender, EventArgs e)
        {
            MenuContactFr.BackColor = Color.FromArgb(238, 238, 238);
        }

        private void MenuCompteFr_MouseEnter(object sender, EventArgs e)
        {
            MenuCompte.BackColor = Color.FromArgb(238, 238, 238);
        }

        private void MenuCompteFr_MouseLeave(object sender, EventArgs e)
        {
            MenuCompte.BackColor = Color.Transparent;
        }

        private void MenuContactFr_MouseLeave(object sender, EventArgs e)
        {
            MenuContactFr.BackColor = Color.Transparent;
        }

        private void MenuSoutenance_MouseLeave(object sender, EventArgs e)
        {
            MenuSoutenance.BackColor = Color.Transparent;
        }

        private void panelRubban_Paint(object sender, PaintEventArgs e)
        {
            Pen couleur = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(couleur, 0, 0, panelRubban.Width - 1, panelRubban.Height - 1);
        }

        private void MenuInscription_MouseLeave(object sender, EventArgs e)
        {
            MenuInscription.BackColor = Color.Transparent;
        }

        private void MenuDoctorants_MouseLeave(object sender, EventArgs e)
        {
            MenuDoctorants.BackColor = Color.Transparent;
        }

        private void MenuParametresFr_MouseEnter(object sender, EventArgs e)
        {
            cadreWhite(MenuParametres);
            panel1.Location = new Point(MenuParametres.Location.X - 1, MenuParametres.Location.Y - 1);
            panel1.Visible = true;
            MenuParametres.BackColor = Color.FromArgb(238, 238, 238);
            MenuDoctorants.BackColor = Color.Transparent;
            MenuStatistique.BackColor = Color.Transparent;
            MenuInscription.BackColor = Color.Transparent;
            MenuSoutenance.BackColor = Color.Transparent;
        }

        private void MenuStatistiqueFr_MouseEnter(object sender, EventArgs e)
        {
            cadreWhite(MenuStatistique);
            panel1.Location = new Point(MenuStatistique.Location.X - 1, MenuStatistique.Location.Y - 1);
            panel1.Visible = true;
            MenuStatistique.BackColor = Color.FromArgb(238, 238, 238);
            MenuDoctorants.BackColor = Color.Transparent;
            MenuParametres.BackColor = Color.Transparent;
            MenuInscription.BackColor = Color.Transparent;
            MenuSoutenance.BackColor = Color.Transparent;
        }
        private void MenuDoctorants_MouseEnter(object sender, EventArgs e)
        {
            cadreWhite(MenuDoctorants);
            panel1.Location = new Point(MenuDoctorants.Location.X - 1, MenuDoctorants.Location.Y - 1);
            panel1.Visible = true;
            MenuDoctorants.BackColor = Color.FromArgb(238, 238, 238);
            MenuParametres.BackColor = Color.Transparent;
            MenuStatistique.BackColor = Color.Transparent;
            MenuInscription.BackColor = Color.Transparent;
            MenuSoutenance.BackColor = Color.Transparent;
        }

        private void MenuInscription_MouseEnter(object sender, EventArgs e)
        {
            cadreWhite(MenuInscription);
            panel1.Location = new Point(MenuDoctorants.Location.X - 1, MenuDoctorants.Location.Y - 1);
            panel1.Visible = true;
            MenuInscription.BackColor = Color.FromArgb(238, 238, 238);
            MenuParametres.BackColor = Color.Transparent;
            MenuStatistique.BackColor = Color.Transparent;
            MenuDoctorants.BackColor = Color.Transparent;
            MenuSoutenance.BackColor = Color.Transparent;
        }

        
        private void MenuSoutenance_MouseEnter(object sender, EventArgs e)
        {
            cadreWhite(MenuSoutenance);
            panel1.Location = new Point(MenuSoutenance.Location.X - 1, MenuSoutenance.Location.Y - 1);
            panel1.Visible = true;
            MenuSoutenance.BackColor = Color.FromArgb(238, 238, 238);
            MenuDoctorants.BackColor = Color.Transparent;
            MenuParametres.BackColor = Color.Transparent;
            MenuInscription.BackColor = Color.Transparent;
            MenuStatistique.BackColor = Color.Transparent;
        }

       
        

       

       

        

        //private void MenuArchiveFr_Click_1(object sender, EventArgs e)
        //{
        //    cadreWhite(MenuInscription);
        //    panel1.Location = new Point(MenuInscription.Location.X - 1, MenuInscription.Location.Y - 1);
        //    panel1.Visible = true;
        //    MenuInscription.BackColor = Color.FromArgb(238, 238, 238);
        //    MenuDoctorants.BackColor = Color.Transparent;
        //    MenuParametres.BackColor = Color.Transparent;
        //    MenuStatistique.BackColor = Color.Transparent;
        //    MenuSoutenance.BackColor = Color.Transparent;
        //    InscriptionAffiche insc = new InscriptionAffiche(panel4.Width - 2, panel4.Height - 2);
        //    panel4.Controls.Clear();
        //    insc.Location = new Point(1, 1);
        //    panel4.Controls.Add(insc);
        //    labelTitreForm.Text = "Inscription";
        //    labelTitreForm.Visible = true;
        //}

        

       

        

     
    }
}

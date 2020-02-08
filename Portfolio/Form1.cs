using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio
{
    public partial class Form1 : Form
    {
        int login; // login = 0 cand nu este logat nimeni; =1 pt. admin; =2 pt. angajat
        string userTastat, parolaTastata, user_role;
        public Form1()
        {
            InitializeComponent();
            hideMenu();
        }

        private void hideMenu()
        {
            // Ascundem din meniu optiunile Filme si Clienti .Visible = false;
            // (care va deveni vizibil dupa ce operatia log-in a avut succes)
            // Daca am vrea sa ascundem meniul in intregime:
            // menuStrip1.Hide(); menuStrip1.Show();
            ProjectsToolStripMenuItem.Visible = false;
            PortfolioToolStripMenuItem.Visible = false;
            button1.Text = "Log in";
            login = 0;
            userTastat = parolaTastata = "";
        }

        private void clearFields()
        {
            textBoxUser.Text = "";
            textBoxPassword.Text = "";
        }

        private void hideFields()
        {
            label1.Visible = false;
            textBoxUser.Visible = false;
            label2.Visible = false;
            textBoxPassword.Visible = false;
        }

        private void showFields()
        {
            label1.Visible = true;
            textBoxUser.Visible = true;
            label2.Visible = true;
            textBoxPassword.Visible = true;
        }

        private void addTechnologyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddTechnology addT = new AddTechnology();
            addT.ShowDialog();
        }

        private void addProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddProject addP = new AddProject();
            addP.ShowDialog();
        }

        private void modifyTechnologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyTechnology modifyT = new ModifyTechnology();
            modifyT.ShowDialog();
        }

        private void modifyProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyProject modifyP = new ModifyProject();
            modifyP.ShowDialog();
        }

        private void deleteTechnologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTechnology deleteT = new DeleteTechnology();
            deleteT.ShowDialog();
        }

        private void deleteProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProject deleteP = new DeleteProject();
            deleteP.ShowDialog();
        }

        private void PortfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            display.ShowDialog();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (login == 0)
                {
                    //Preluam user si parola, stergem eventualele spatii
                    // de la inceputul si sfarsitul numelui utilizator
                    userTastat = textBoxUser.Text.Trim();
                    parolaTastata = textBoxPassword.Text;
                    if (userTastat == "") throw new Exception("User field cannot be empty !");
                    if (parolaTastata == "") throw new Exception("Password field cannot be empty !");
                    // Cautam in baza de date DBvideoteca combinatia user+parola care au fost tastate
                    // Daca gasim o inregistrare ce corespunde: aducem din baza de date
                    // denumirea rolului acelui user, altfel user_role ramane sirul vid =""
                    user_role = Interogation_DB.caut_User(userTastat, parolaTastata);
                    if (user_role == "admin")
                    { // Daca rolul este de administrator ="admin" are drepturi depline
                        login = 1;
                        ProjectsToolStripMenuItem.Visible = true;
                        PortfolioToolStripMenuItem.Visible = true;
                        clearFields();
                        hideFields();
                        button1.Text = "Log out";
                    }
                    if (user_role == "user")
                    { //Daca rolul este ="user" nu are dreptul sa acceseze meniul Projects
                      // ca sa adauge o Technology sau un Project in BD
                        login = 2;
                        PortfolioToolStripMenuItem.Visible = true;
                        clearFields();
                        hideFields();
                        button1.Text = "Log out";
                    }
                    if (login == 0)
                        throw new Exception("Incorrect User or Password");
                }
                else
                {
                    // A fost apasat butonul log-out. Resetam controalele, ascundem meniul
                    textBoxUser.Text = "";
                    textBoxPassword.Text = "";
                    showFields();
                    hideMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

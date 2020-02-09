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
    public partial class AddTechnology : Form
    {
        DataTable technologiesDT;
        string name;

        public AddTechnology()
        {
            InitializeComponent();
            fill_listBoxTechnology();
        }

        private void fill_listBoxTechnology()
        {
            // Apelam metoda care interogheaza tabela categorie si depune rezultatul intr-un DataTable
            technologiesDT = Interogation_DB.select_Technology();
            // DataTable din care sunt preluate datele pentru comboListTechnologies
            listBoxTechnologies.DataSource = technologiesDT;
            // Valoarea din coloana id_categ nu se afiseaza in comboListTechnologies
            //listBoxTechnologies.ValueMember = "id_categ";
            // Denumirea tehnologiei afisata in comboListTechnologies, preluata din:
            listBoxTechnologies.DisplayMember = "nume_categorie";
            // Valoarea lui id_categ se salveaza in selectedTechnologyId, pentru elementul afisat la initializarea comboBoxTechnology
            //selectedTechnologyId = Convert.ToInt32(this.listBoxTechnologies.GetItemText(this.listBoxTechnologies.SelectedValue));
        }

        private void emptyAddTechnologyField()
        {
            textBoxTechnology.Text = "";
            name = "";
            fill_listBoxTechnology();
        }

        private void buttonAddTehnology_Click(object sender, EventArgs e)
        {
            name = textBoxTechnology.Text;
            //Verifica daca campul de <Add new technology> este gol
            if (name == "")
            {
                MessageBox.Show("Add new field cannot be empty");
            }
            else
            {
                // Salvez lungimea listei in variabila listLength;
                int listLength = technologiesDT.Rows.Count;
                //Initializez sirul technologiesList de lungime =listLength;
                String[] technologiesList = new String[listLength];

                //Verifica daca valoarea din name se afla deja in technologiesDT 
                //(daca tehnologia tastata exista deja in DB)
                foreach (DataRow dtrw in technologiesDT.Rows)
                {
                    if (dtrw.Field<string>("nume_categorie") == name)
                    {
                        MessageBox.Show("Technology allready in DataBase");
                        emptyAddTechnologyField();
                        return;
                    }
                }

                //Daca numele tehnologiei nu este in DataBase, se continua cu fereastra de confirmare
                Confirmation c = new Confirmation("Confirm DataBase entry?");
                DialogResult dr = c.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Update_DB.addTechnologyInDB(name);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("DataBase entry successfully performed");
                    emptyAddTechnologyField();
                    fill_listBoxTechnology();
                }
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("DataBase entry not performed");
                    emptyAddTechnologyField();
                }
            }
        }

        private void buttonCancelTechnology_Click(object sender, EventArgs e)
        {
            emptyAddTechnologyField();
            this.Close();
        }


        private void AddTechnology_Load(object sender, EventArgs e)
        {
        }
    }
}

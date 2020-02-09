using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; // Pentru ArrayList

namespace Portfolio
{
    public partial class DeleteTechnology : Form
    {
        DataTable technologiesDT;

        public DeleteTechnology()
        {
            InitializeComponent();
            fill_checkedListBoxDeleteTechnology();
        }

        private void fill_checkedListBoxDeleteTechnology()
        {
            // Apelam metoda care interogheaza tabela categorie si depune rezultatul intr-un DataTable
            technologiesDT = Interogation_DB.select_Technology();
            // DataTable din care sunt preluate datele pentru comboListTechnologies
            checkedListBoxDeleteTechnologies.DataSource = technologiesDT;
            // Valoarea din coloana id_categ nu se afiseaza in comboListTechnologies
            //listBoxTechnologies.ValueMember = "id_categ";
            // Denumirea tehnologiei afisata in comboListTechnologies, preluata din:
            checkedListBoxDeleteTechnologies.DisplayMember = "nume_categorie";
            // Valoarea lui id_categ se salveaza in selectedTechnologyId, pentru elementul afisat la initializarea comboBoxTechnology
            //selectedTechnologyId = Convert.ToInt32(this.listBoxTechnologies.GetItemText(this.listBoxTechnologies.SelectedValue));
        }

        private void empty_checkedListBoxDeleteTechnologies()
        {
            checkedListBoxDeleteTechnologies.ClearSelected();
            // deselecteaza tehnologia selectata
            foreach (int i in checkedListBoxDeleteTechnologies.CheckedIndices)
                checkedListBoxDeleteTechnologies.SetItemChecked(i, false);
            // debifeaza tehnologiile bifate  
        }

        private void buttonDeleteTechnologies_Click(object sender, EventArgs e)
        {
            if (checkedListBoxDeleteTechnologies.CheckedIndices.Count > 0)
            {
                Confirmation c = new Confirmation("Confirm deletion?");
                DialogResult dr = c.ShowDialog();
                ArrayList listDeleteTechnologies = new ArrayList();
                if (dr == DialogResult.Yes)
                {
                    int idTechnology;
                    try
                    {
                        foreach (int i in checkedListBoxDeleteTechnologies.CheckedIndices)
                        {
                            checkedListBoxDeleteTechnologies.SelectedIndex = i;
                            idTechnology = Convert.ToInt32(((DataRowView)checkedListBoxDeleteTechnologies.SelectedValue)["id_categ"]);
                            listDeleteTechnologies.Add(idTechnology);
                        }
                        Update_DB.deleteTechnologyInDB(listDeleteTechnologies);
                        // Dupa inregistrarea restituirii o parte din filme au fost restituite iar altele nu, sau toate au fost restituite
                        // Reincarc in CheckList cu Filme noua lista cu filmele ramase nerestituite
                        // Pentru asta "resetez" datele din dataTable filmeT (sursa pentru listDeleteTechnologies.DataSource)
                        MessageBox.Show("Deletion was succesfull");
                        technologiesDT.Clear();
                        fill_checkedListBoxDeleteTechnology();

                        //listDeleteTechnologies.DataSource = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("Deletion not performed");
                    empty_checkedListBoxDeleteTechnologies();
                }
            }
            else MessageBox.Show("You did not select a technology!");
        }

        private void buttonCancelTechnologies_Click(object sender, EventArgs e)
        {
            empty_checkedListBoxDeleteTechnologies();
            this.Close();
        }

        private void DeleteTechnology_Load(object sender, EventArgs e)
        {

        }
    }
}

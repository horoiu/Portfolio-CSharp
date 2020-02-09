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
    public partial class ModifyTechnology : Form
    {
        DataTable technologyDT;
        int selectedTechnologyId = 0;
        string newTechnologyName = "";

        public ModifyTechnology()
        {
            InitializeComponent();
            fill_ComboBoxTechnology();
        }

        private void fill_ComboBoxTechnology()
        {
            // Apelam metoda care interogheaza tabela categorie si depune rezultatul intr-un DataTable
            technologyDT = Interogation_DB.select_Technology();
            // DataTable din care sunt preluate datele pentru comboBoxTechnology
            comboBoxTehnology.DataSource = technologyDT;
            // Valoarea din coloana id_categ nu se afiseaza in comboBoxTechnology
            comboBoxTehnology.ValueMember = "id_categ";
            // Denumirea tehnologiei afisata in comboBoxTechnology, preluata din:
            comboBoxTehnology.DisplayMember = "nume_categorie";
            // Valoarea lui id_categ se salveaza in selectedTechnologyId, pentru elementul afisat la initializarea comboBoxTechnology
            selectedTechnologyId = Convert.ToInt32(this.comboBoxTehnology.GetItemText(this.comboBoxTehnology.SelectedValue));
        }        private void getIdTechnology(object sender, EventArgs e)
        {
            // Valoarea lui id_categ se salveaza in selectedTechnologyId, pentru elementul afisat la selectarea unei noi tehnologii in comboBoxTechnology
            selectedTechnologyId = Convert.ToInt32(this.comboBoxTehnology.GetItemText(this.comboBoxTehnology.SelectedValue));
        }
        private void emptyModifyTechnologyFields()
        {
            comboBoxTehnology.Text = "";
            textBoxTehnology.Text = "";
            selectedTechnologyId = 0;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (selectedTechnologyId != 0)
            {
                newTechnologyName = textBoxTehnology.Text;
                Confirmation c = new Confirmation("Confirm modification?");
                DialogResult dr = c.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Update_DB.modifyTechnologyInDB(newTechnologyName, selectedTechnologyId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Modification successfully performed");
                    emptyModifyTechnologyFields();
                    fill_ComboBoxTechnology();
                }
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("Modification not performed");
                    emptyModifyTechnologyFields();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            emptyModifyTechnologyFields();
            this.Close();
        }

        private void ModifyTechnology_Load(object sender, EventArgs e)
        {
        }

    }
}

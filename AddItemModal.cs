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
using interventory;



namespace interventory
{
    public partial class AddItemModal : UserControl
    {
        public AddItemModal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void brandTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private async Task RefreshComputerPartsAsync(DataGridView dataGridView)
        {
            try
            {
                Database db = new Database();
                var computerParts = await db.GetAllComputerPartsAsync();
                dataGridView.DataSource = computerParts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }






        private async void addNewItemButtonModal_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate numerical values before parsing
                if (!decimal.TryParse(priceTextBox.Text, out decimal price))
                {
                    MessageBox.Show("Please enter a valid decimal value for price.");
                    return;
                }
                if (!int.TryParse(quantityTextBox.Text, out int quantity))
                {
                    MessageBox.Show("Please enter a valid integer value for quantity.");
                    return;
                }

                // Instantiate your Database class
                Database db = new Database();

                // Collect input values from text boxes
                string name = nametextBox.Text;
                string brand = brandTextBox.Text;
                string category = categoryTextBox.Text;
                string supplier = supplierTextBox.Text;
                string description = descriptionTextbox.Text;

                // Call the AddComputerPart method asynchronously
                bool success = await db.AddComputerPartAsync(name, brand, category, price, quantity, supplier, description);

                if (success)
                {
                    MessageBox.Show("Item added successfully.");
                    // Optionally, clear the text boxes
                    nametextBox.Clear();
                    brandTextBox.Clear();
                    categoryTextBox.Clear();
                    priceTextBox.Clear();
                    quantityTextBox.Clear();
                    supplierTextBox.Clear();
                    descriptionTextbox.Clear();
                    this.ParentForm.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add the item.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void cancelAddButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}

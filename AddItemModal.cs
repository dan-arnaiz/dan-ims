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

        private void addNewItemButtonModal_Click(object sender, EventArgs e)
        {
            try
            {
                // Instantiate your Database class
                Database db = new Database();

                // Collect input values from text boxes
                string name = nametextBox.Text;
                string brand = brandTextBox.Text;
                string category = categoryTextBox.Text;
                decimal price = decimal.Parse(priceTextBox.Text); // Ensure this is a valid decimal
                int quantity = int.Parse(quantityTextBox.Text); // Ensure this is a valid integer
                string supplier = supplierTextBox.Text;
                string description = descriptionTextbox.Text;

                // Call the AddComputerPart method
                bool success = db.AddComputerPart(name, brand, category, price, quantity, supplier, description);

                if (success)
                {
                    MessageBox.Show("Item added successfully.");
                    // Optionally, clear the text boxes or close the modal
                }
                else
                {
                    MessageBox.Show("Failed to add the item.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numerical values for price and quantity.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void cancelAddButton_Click(object sender, EventArgs e)
        {

        }
    }
}

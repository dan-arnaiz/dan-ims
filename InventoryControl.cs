using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interventory
{
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            InitializeComponent();
        }

        private void InventoryControl_Load(object sender, EventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            using (Form modalForm = new Form())
            {
                AddItemModal addItemModal = new AddItemModal();
                modalForm.Controls.Add(addItemModal);
                addItemModal.Dock = DockStyle.Fill;
                modalForm.Size = new Size(490, 449);
                modalForm.StartPosition = FormStartPosition.CenterScreen;
                modalForm.ShowDialog();
            }
        }

        

        private void danimsDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming Database is the class that contains your database operations
                Database db = new Database();

                // Await the call to get all computer parts. Make sure this method exists and is implemented correctly.
                var computerParts = await db.GetAllComputerPartsAsync();

                // Set the data source for dataGridView1
                dataGridView1.DataSource = computerParts;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while refreshing the list: {ex.Message}");
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Check if any row is selected
            deleteButton.Visible = dataGridView1.SelectedRows.Count > 0;
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming the first cell contains the identifier (id) of the row
                int selectedRowId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                // Instantiate your Database class
                Database db = new Database();

                // Call the DeleteComputerPart method asynchronously
                bool success = await db.DeleteComputerPartAsync(selectedRowId);

                if (success)
                {
                    MessageBox.Show("Item deleted successfully.");
                    // Optionally, refresh the DataGridView to reflect the deletion
                }
                else
                {
                    MessageBox.Show("Failed to delete the item.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // Step 1 & 2: Check if a row is selected
            

            // Assuming you have a modal form named EditItemModal with textboxes for editing
            editItemModal editModal = new editItemModal();

            if (dataGridView1.CurrentRow != null)
            {
                using (Form modalForm = new Form())
                {
                    editItemModal editItemModal = new editItemModal();
                    modalForm.Controls.Add(editItemModal);
                    editItemModal.Dock = DockStyle.Fill;
                    modalForm.Size = new Size(490, 449);
                    modalForm.StartPosition = FormStartPosition.CenterScreen;
                    modalForm.ShowDialog();
                }

                var currentRow = dataGridView1.CurrentRow;
                editModal.nametextBox.Text = currentRow.Cells["nameDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
                editModal.categoryTextBox.Text = currentRow.Cells["categoryDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
                editModal.priceTextBox.Text = currentRow.Cells["priceDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
                editModal.brandTextBox.Text = currentRow.Cells["brandDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
                editModal.quantityTextBox.Text = currentRow.Cells["quantityDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
                editModal.descriptionTextbox.Text = currentRow.Cells["descriptionDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
                editModal.supplierTextBox.Text = currentRow.Cells["supplierDataGridViewTextBoxColumn"].Value?.ToString() ?? "";

                

            }
            else
            {
                MessageBox.Show("No row is currently selected.");
            }
            // Step 4: Show the modal dialog
            
            
        }
    }
}

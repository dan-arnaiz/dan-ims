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
    public partial class editItemModal : UserControl
    {
        private DataGridViewRow currentRow;

        public editItemModal()
        {
            InitializeComponent();

            // Initialize your text boxes with the current row values using updated column names
            nametextBox.Text = currentRow.Cells["nameDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
            categoryTextBox.Text = currentRow.Cells["categoryDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
            priceTextBox.Text = currentRow.Cells["priceDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
            brandTextBox.Text = currentRow.Cells["brandDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
            quantityTextBox.Text = currentRow.Cells["quantityDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
            descriptionTextbox.Text = currentRow.Cells["descriptionDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
            supplierTextBox.Text = currentRow.Cells["supplierDataGridViewTextBoxColumn"].Value?.ToString() ?? "";

        }

        private void editItemModal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void descriptionTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void brandTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancelAddButton_Click(object sender, EventArgs e)
        {

        }



        private void addNewItemButtonModal_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

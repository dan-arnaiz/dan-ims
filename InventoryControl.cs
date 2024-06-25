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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming Database is the class that contains your database operations
                Database db = new Database();

                // Call the method to get all computer parts. Make sure this method exists and is implemented correctly.
                var computerParts = db.GetAllComputerPartsAsync();

                // Set the data source for dataGridView1
                dataGridView1.DataSource = computerParts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while refreshing the list: {ex.Message}");
            }
        }
    }
}

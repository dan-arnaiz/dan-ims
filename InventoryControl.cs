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
                modalForm.ShowDialog();
            }
        }

        

        private void danimsDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

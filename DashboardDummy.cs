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
    public partial class DashboardDummy : Form
    {
        public DashboardDummy()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void inventoryButton_Click(object sender, EventArgs e)
        {
            await LoadControlAsync(new DashboardControl());
        }

        private Task LoadControlAsync(UserControl control)
        {
            return Task.Run(() =>
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => LoadControl(control)));
                }
                else
                {
                    LoadControl(control);
                }
            });
        }
        private void LoadControl(UserControl control)
        {
            mainPanel.Controls.Clear(); // Clear existing controls
            control.Dock = DockStyle.Fill; // Ensure it fills the panel
            mainPanel.Controls.Add(control); // Add the new control
        }
    }
}

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
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private async void dashBoardButtonClick_Click(object sender, EventArgs e)
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

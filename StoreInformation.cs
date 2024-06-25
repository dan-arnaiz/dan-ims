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
    public partial class StoreInformation : UserControl
    {
        public StoreInformation()
        {
            InitializeComponent();
        }

        private void StoreInformation_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backInfoButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}

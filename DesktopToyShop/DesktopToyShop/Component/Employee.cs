using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopToyShop.Component
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toyshopDataSet2.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.toyshopDataSet2.Staff);
            // TODO: This line of code loads data into the 'toyshopDataSet.Branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.toyshopDataSet.Branch);

        }
    }
}

using DesktopToyShop.CommenFiles;
using DesktopToyShop.Model;
using DesktopToyShop.Service;
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
    public partial class MenuInterface : Form
    {
       private FormOpen formOpen = new FormOpen();
        private LoginInterface login = new LoginInterface();
        private Employee employee = new Employee();
        public MenuInterface()
        {
            InitializeComponent();
        }

        private void Logout(object sender, EventArgs e)
        {
           
           formOpen.FormClose(this, login);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Employee(object sender, EventArgs e)
        {
            
            formOpen.FormOpenWithoutClose(employee);
        }
    }
}

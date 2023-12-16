using DesktopToyShop.CommenFiles;
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
        FormOpen formOpen = new FormOpen();

        public MenuInterface()
        {
            InitializeComponent();
        }

        private void Logout(object sender, EventArgs e)
        {
           LoginInterface login = new LoginInterface();
           formOpen.FormClose(this, login);


        }
    }
}

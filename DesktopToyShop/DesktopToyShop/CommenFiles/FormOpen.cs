using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopToyShop.CommenFiles
{
    public class FormOpen
    {
        public void FormClose(Form OldForm,Form NewForm)
        {
            OldForm.Hide();
            NewForm.ShowDialog();
            OldForm.Close();

        }
        public void FormOpenWithoutClose(Form NewForm)
        {
            NewForm.ShowDialog();
        }
    }
}

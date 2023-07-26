using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueGen
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void HomeBtnModule_Click(object sender, EventArgs e)
        {
            MenuAddModule menuAddModule = new MenuAddModule();
            menuAddModule.Show();
        }

        private void HomeBtnSubject_Click(object sender, EventArgs e)
        {
            MenuAddSubject menuAddSubject = new MenuAddSubject();
            menuAddSubject.Show();
        }
    }
}

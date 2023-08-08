using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QueGen
{
    public partial class MenuAddModuleView : Form
    {
        public MenuAddModuleView()
        {
            InitializeComponent();
            LoadDataModules();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataModules()
        {
            XDocument xmlLoad = XDocument.Load("modules.xml");
            DataTable dataTable = new DataTable(); //create new DataTable object to hold data
            //create new column in the display table
            dataTable.Columns.Add("Module");
            foreach (XElement item in xmlLoad.Descendants("Section"))
            {
                string module = item.Element("Module")?.Value??"";
                dataTable.Rows.Add(module);
            }
            dataGridView1.DataSource = dataTable;
        }
    }

}

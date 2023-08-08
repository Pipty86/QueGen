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
    public partial class MenuAddSubjectView : Form
    {
        public MenuAddSubjectView()
        {
            InitializeComponent();
            LoadDataSubject();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataSubject()
        {
            //prepare the database table
            XDocument xmlLoad = XDocument.Load("modules.xml");
            DataTable dtSubject = new DataTable();
            dtSubject.Columns.Add("Module");        //add column header Module
            dtSubject.Columns.Add("Subject");       //add column header Subject
            
            foreach (XElement itemsec in xmlLoad.Descendants("Section"))
            {
                string module = itemsec.Element("Module").Value;
                foreach (XElement itemsub in itemsec.Elements("Subject"))
                {
                    string subject = itemsub.Value;
                    dtSubject.Rows.Add(module, subject);
                }
            }
            dataGridView1.DataSource = dtSubject;   
        }
    }
}

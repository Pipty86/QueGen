using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Net.Configuration;

namespace QueGen
{
    public partial class MenuAddSubject : Form
    {
        string subject_name;
        string module_name;
        public MenuAddSubject()
        {
            InitializeComponent();
            PopulateComboBox();
            Label_Warning_Subject_Empty.Hide();
            Label_Warning_Module_Empty.Hide();
            ComboBoxSelectModule.Text = String.Empty;
        }

        //method to populate data into dropdown
        private void PopulateComboBox()
        {
            var xmlLoad = XDocument.Load("modules.xml");
            var modules = from key in xmlLoad.Descendants("Module") select key.Value;
            ComboBoxSelectModule.DataSource = modules.ToList();
        }
        private void AddSubject (string subject_name, string module_name)
        {
            if (subject_name == null)
            {
                Label_Warning_Subject_Empty.Show();
            }
            else if (module_name == null)
            {
                Label_Warning_Module_Empty.Show();
            }
            else
            {
                Label_Warning_Subject_Empty.Hide();
                Label_Warning_Module_Empty.Hide();
                XDocument xmlLoad = XDocument.Load("modules.xml");
                XElement newSubject = xmlLoad.Descendants("Database").FirstOrDefault(item => item.Element("Module").Value == module_name);
                newSubject.Add(new XElement("Subject", subject_name));
                xmlLoad.Save("modules.xml");
                MessageBox.Show("New Subject saved!");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            module_name = ComboBoxSelectModule.SelectedItem.ToString();
        }

        private void Input_Module_TextChanged(object sender, EventArgs e)
        {
            subject_name = Input_Subject.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSubject(subject_name, module_name);
        }

        private void Label_Warning_Subject_Empty_Click(object sender, EventArgs e)
        {

        }
    }
}

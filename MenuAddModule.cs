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
using System.Net.Configuration;

namespace QueGen
{
    public partial class MenuAddModule : Form
    {
        string module_name;
        public MenuAddModule()
        {
            InitializeComponent();
            Label_Warning_Module_Empty.Hide();
        }

        private void Input_Module_TextChanged(object sender, EventArgs e)
        {
            module_name = Input_Module.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check if the textbox for module name (Input_Module) is empty
            if (module_name == null)
            {
                Label_Warning_Module_Empty.Show();
            }
            else
            {
                Label_Warning_Module_Empty.Hide();
                if (File.Exists("modules.xml")==false)
                {
                    //creates a new xml document if non existed before
                    XElement modules =
                        new XElement("Database",
                        new XElement("Module", module_name)
                        );
                    modules.Save("modules.xml");
                }
                else
                {
                    //loads the xml document before adding
                    XDocument xmlload = XDocument.Load("modules.xml");
                    //inserts the new object modules into the existing xml doc
                    XElement new_modules = new XElement("Module", module_name);
                    //load the new modules into the existing xml doc
                    xmlload.Root.Add(new_modules);
                    xmlload.Save("modules.xml");
                }
            }
            Input_Module.Text = String.Empty;

        }

        private void Label_Warning_Module_Empty_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

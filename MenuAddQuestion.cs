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
using System.Reflection;

namespace QueGen
{
    public partial class MenuAddQuestion : Form
    {
        string mark = null;
        string level = null;
        string module = null;
        string subject = null;
        string mode = null;
        string question = null;
        string answer = null;
        public MenuAddQuestion()
        {
            InitializeComponent();
            CB_Module.Text = String.Empty;
            PopulateModule();
            CB_Subject.Text = String.Empty;
        }

        //method to add data into XML Database

        //populate module dropdown
        private void PopulateModule()
        {
            var xmlLoad = XDocument.Load("modules.xml");
            var modules = from key in xmlLoad.Descendants("Module") select key.Value;
            CB_Module.DataSource = modules.ToList();
        }

        private void CB_Module_SelectedIndexChanged(object sender, EventArgs e)
        {
            module = null;
            module = CB_Module.Text;
            PopulateSubject();
        }

        //populate subject dropdown
        private void PopulateSubject()
        {
            var xmlLoad = XDocument.Load("modules.xml");
            var subjects = xmlLoad.Descendants("Section")
            .Where(section => section.Element("Module").Value == module)
            .Elements("Subject")
            .Select(subject => subject.Value)
            .ToList();
            CB_Subject.Items.Clear();
            CB_Subject.Items.AddRange(subjects.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CB_Mark_TextChanged(object sender, EventArgs e)
        {
            mark = null;
            mark = CB_Mark.Text;
        }

        private void CB_Question_TextChanged(object sender, EventArgs e)
        {
            question = null;
            question = CB_Question.Text;
        }

        private void CB_Answer_TextChanged(object sender, EventArgs e)
        {
            answer = null;
            answer = CB_Answer.Text;
        }

        private void CB_Level_SelectedIndexChanged(object sender, EventArgs e)
        {
            level = null;
            level = CB_Level.Text;
        }

        private void CB_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = null;
            mode = CB_Mode.Text;
        }

        private void CB_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            subject = null;
            subject = CB_Subject.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (module != null && subject != null && mode != null && level != null && mark != null && question != null && answer != null)
            {
                if (File.Exists("questions.xml") == false)
                {
                    //create database
                    XElement entry =
                        new XElement("Database",
                            new XElement("Entry",
                                new XElement("Module", module),
                                new XElement("Subject", subject),
                                new XElement("Mode", mode),
                                new XElement("Level", level),
                                new XElement("Mark", mark),
                                new XElement("Question", question),
                                new XElement("Answer", answer)
                                ));
                    entry.Save("questions.xml");
                }
                else
                {
                    //loads the xml document before adding
                    XDocument xmlload = XDocument.Load("questions.xml");
                    XElement new_entry =
                        new XElement("Entry",
                                new XElement("Module", module),
                                new XElement("Subject", subject),
                                new XElement("Mode", mode),
                                new XElement("Level", level),
                                new XElement("Mark", mark),
                                new XElement("Question", question),
                                new XElement("Answer", answer)
                                );
                    xmlload.Root.Add(new_entry);
                    xmlload.Save("questions.xml");
                }
                mark = null;
                level = null;
                module = null;
                subject = null;
                mode = null;
                question = null;
                answer = null;
                CB_Module.Text = String.Empty;
                CB_Subject.Text = String.Empty;
                CB_Level.Text = String.Empty;
                CB_Mark.Text = String.Empty;
                CB_Question.Text = String.Empty;
                CB_Answer.Text = String.Empty;
                CB_Mode.Text = String.Empty;
                MessageBox.Show("Successfully entered new question!");
            }
            else
            {
                MessageBox.Show("Error : Please fill out all the fields first!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuAddQuestionView menuAddQuestionView = new MenuAddQuestionView();
            menuAddQuestionView.Show();
            menuAddQuestionView.BringToFront();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QueGen
{ 
    public partial class MenuAddQuestionView : Form
    {

        //holds private method's data
        public class QuestionData
        {
            public string Question { get; set; }
            public string Answer { get; set; }
            public string Mark { get; set; }
        }
        public MenuAddQuestionView()
        {
            InitializeComponent();
            PopulateModule();
            CB_Subject.Text = String.Empty;
        }

        private void DisplayQuestion(int index)
        {
            if (index >= 0 && index < questionDataList.Count) 
            {
                QuestionData data = questionDataList[index];
                CB_Question.Clear();
                CB_Question.AppendText($"Question\t:\t\n {data.Question}{Environment.NewLine}\n");
                CB_Question.AppendText($"Answer\t:\t\n {data.Answer}{Environment.NewLine}\n");
                CB_Question.AppendText($"Mark\t:\t {data.Mark}{Environment.NewLine}");
            }
        }

        //Start of populating comboboxes
        private void PopulateModule()
        {
            var xmlLoad = XDocument.Load("modules.xml");
            var module = from key in xmlLoad.Descendants("Module") select key.Value;
            CB_Module.DataSource = module.ToList();
        }
        private void PopulateSubject()
        {
            var xmlLoad = XDocument.Load("modules.xml");
            var subjects = xmlLoad.Descendants("Section")
            .Where(section => section.Element("Module").Value == CB_Module.SelectedItem as string)
            .Elements("Subject")
            .Select(subject => subject.Value)
            .ToList();
            CB_Subject.Items.Clear();
            CB_Subject.Items.AddRange(subjects.ToArray());
        }
        //End of populating comboboxes

        //Combobox selection's section
        private void CB_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Question.Clear();
            DisplayDataForSelection();
        }

        private void CB_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Question.Clear();
            DisplayDataForSelection();
        }

        private void CB_Level_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Question.Clear();
            DisplayDataForSelection();
        }

        private void CB_Module_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Question.Clear();
            DisplayDataForSelection();
            PopulateSubject();
        }

        private List<QuestionData> questionDataList;
        private int QuestionIndex = 0;
        private void DisplayDataForSelection() 
        {

            string selectedModule = CB_Module.SelectedItem as string;
            string selectedSubject = CB_Subject.SelectedItem as string;
            string selectedMode = CB_Mode.SelectedItem as string;
            string selectedLevel = CB_Level.SelectedItem as string;

            if (selectedModule != null && selectedSubject != null && selectedMode != null)
            {
                var xmlLoad = XDocument.Load("questions.xml");
                var query = xmlLoad.Descendants("Entry")
                    .Where(entry => entry.Element("Module").Value == selectedModule)
                    .Where(entry => entry.Element("Subject").Value == selectedSubject)
                    .Where(entry => entry.Element("Mode").Value == selectedMode);

                if (!string.IsNullOrEmpty(selectedLevel))
                {
                    query = query.Where(entry => entry.Element("Level").Value == selectedLevel);
                }

                questionDataList = query
                    .Select(section => new QuestionData
                    {
                        Question = section.Element("Question").Value,
                        Answer = section.Element("Answer").Value,
                        Mark = section.Element("Mark").Value
                    }).ToList();

                QuestionIndex = 0;
                DisplayQuestion(QuestionIndex);
            }
        }

        private void CB_Question_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CB_Question.Clear();
            DisplayQuestion(QuestionIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuestionIndex++;
            if (QuestionIndex >= questionDataList.Count)
            {
                QuestionIndex = 0;
            }
            DisplayQuestion(QuestionIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuestionIndex--;
            if (QuestionIndex < 0)
            {
                QuestionIndex = questionDataList.Count - 1;
            }
            DisplayQuestion(QuestionIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (QuestionIndex >= 0 && QuestionIndex < questionDataList.Count)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this entry?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    QuestionData deletedData = questionDataList[QuestionIndex];
                    questionDataList.RemoveAt(QuestionIndex);

                    if (QuestionIndex >= questionDataList.Count)
                    {
                        QuestionIndex = questionDataList.Count - 1;
                    }

                    if (QuestionIndex >= 0)
                    {
                        DisplayQuestion(QuestionIndex);
                    }
                    else
                    {
                        CB_Question.Clear();
                    }

                    // Delete corresponding XML elements
                    DeleteXmlQuestionElement();
                }
            }
        }
        private void DeleteXmlQuestionElement()
        {
            var xmlLoad = XDocument.Load("questions.xml");
            var Question_Del = xmlLoad.Descendants("Entry")
                .Where(q => q.Element("Module").Value == CB_Module.SelectedItem)
                .Where(q => q.Element("Subject").Value == CB_Subject.SelectedItem)
                .Where(q => q.Element("Mode").Value == CB_Mode.SelectedItem)
                .Where(q => q.Element("Level").Value == CB_Level.SelectedItem)
                .ToList();
                
            foreach (var q in Question_Del)
            {
                q.Remove();
            }
                

            xmlLoad.Save("questions.xml");
        }
    }
}

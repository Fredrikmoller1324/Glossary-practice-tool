using System;
using System.IO;
using System.Windows.Forms;
using WordTranslationLibrary;

namespace GlossaryAcademyWinform
{
    public partial class Form1 : Form
    {
        public static string SelectedList { get; set; }
        public Form1()
        {
            InitializeComponent();
            FilePaths.CreateMap();
            KeyPreview = true;
            button_SelectedListToShowWords.Enabled = false;
        }
        private void DisplayWordsInSelectedList()
        {
            DataGridWordsDisplay wordDisplay = new DataGridWordsDisplay(label_Wordcount);
            wordDisplay.Visible = true;
            Controls.Add(wordDisplay);
            wordDisplay.Dock = DockStyle.Fill;
            wordDisplay.BringToFront();
        }
        private void listBox_lists_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox_lists.SelectedItem != null)
            {
                label_Wordcount.Text = WinformFunctionality.CountWords(listBox_lists.SelectedItem.ToString()).ToString();

                WordList selectedList = WordList.LoadList(listBox_lists.GetItemText(listBox_lists.SelectedItem));

                listBox_Langugage.Items.Clear();
                for (int i = 0; i < selectedList.Languages.Length; i++)
                {
                    listBox_Langugage.Items.Add(selectedList.Languages[i]);
                }

                SelectedList = selectedList.Name;
                button_SelectedListToShowWords.Enabled = true;
            }
        }
        private void button_NewList_MouseClick(object sender, MouseEventArgs e)
        {
            AddNewList addNewList = new AddNewList(this);

            addNewList.Visible = true;
            Controls.Add(addNewList);
            addNewList.Dock = DockStyle.Fill;
            addNewList.BringToFront();
        }
        public void DisplayForm1Load()
        {
            listBox_lists.Items.Clear();
            string[] allLists = WordList.GetLists();

            foreach (string listName in allLists)
            {
                listBox_lists.Items.Add(Path.GetFileNameWithoutExtension(listName));
            }

            if (listBox_lists.Items.Count > 0) { listBox_lists.SelectedIndex = 0; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayForm1Load();
        }
        private void button_SelectedListToShowWords_Click(object sender, EventArgs e)
        {
            if(listBox_lists.Items.Count > 0)
            {
                button_SelectedListToShowWords.Enabled = true;
                DisplayWordsInSelectedList();
            } 
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_DeleteSelectedList_Click(object sender, EventArgs e)
        {
            if(listBox_lists.Items.Count > 0)
            {
                WinformFunctionality.DeleteList(listBox_lists.SelectedItem.ToString());
                DisplayForm1Load();
            }
            if(listBox_lists.Items.Count == 0)
            {
                listBox_Langugage.Items.Clear();
                label_Wordcount.Text = "0";
            }
        }
        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            DisplayForm1Load();
        }
    }
}

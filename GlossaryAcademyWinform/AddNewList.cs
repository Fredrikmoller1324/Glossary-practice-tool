using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WordTranslationLibrary;
using System.IO;

namespace GlossaryAcademyWinform
{
    public partial class AddNewList : UserControl
    {
        private string NameOfList { get; set; }
        private Form1 form11;
        public AddNewList()
        {
            InitializeComponent();
        }
        public AddNewList(Form1 form1)
        {
            InitializeComponent();
            form11 = form1;
        }
        private void button_CancelNewList_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void button_ConfirmedNewList_Click(object sender, EventArgs e)
        {
            foreach (char chars in textBox_AddListName.Text)
            {
                char[] charCheck = Path.GetInvalidPathChars();
                for (int i = 0; i < charCheck.Length; i++)
                {
                    if (charCheck[i] == chars)
                    {
                        MessageBox.Show(@"You cant use \/?:|*<> in Listname", "Invalid chars");
                        return;
                    };
                }
                char[] charCheck2 = Path.GetInvalidFileNameChars();
                for (int i = 0; i < charCheck2.Length; i++)
                {
                    if (charCheck2[i] == chars)
                    {
                        MessageBox.Show(@"You cant use \/?:|*<> in Listname", "Invalid chars");
                        return;
                    };
                }
            }
            List<string> languagesToNewList = new List<string>();
            if (textBox_AddListName.Text == string.Empty)
            {
                MessageBox.Show("You need to enter a listname");
                return;
            }
            else
            {
                NameOfList = textBox_AddListName.Text;
            }

            if(textBox_addNewLanguage.Lines.Length < 2) 
            {
                MessageBox.Show("You need atleast two languages");
                return;
            }
            foreach (string line in textBox_addNewLanguage.Lines)
            {
                string language = line.Trim();

                if (string.IsNullOrEmpty(language))
                {
                    MessageBox.Show("You need atleast two languages");
                    return;
                }

                languagesToNewList.Add(language);

                if(languagesToNewList.Count>1)
                {
                    WordList newWordlist = new WordList(NameOfList, languagesToNewList.ToArray());
                    newWordlist.Save();
                    Hide();
                }
                form11.DisplayForm1Load();
            }
        }
    }
}

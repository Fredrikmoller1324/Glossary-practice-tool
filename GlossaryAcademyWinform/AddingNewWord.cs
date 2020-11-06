using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordTranslationLibrary;

namespace GlossaryAcademyWinform
{
    public partial class AddingNewWord : UserControl
    {
        private DataGridWordsDisplay data1;
        private Button WordAdded;
        public AddingNewWord()
        {
            InitializeComponent();
        }
        public AddingNewWord(DataGridWordsDisplay data, Button button)
        {
            InitializeComponent();
            data1 = data;
            WordAdded = button;
        }
        private void AddingNewWord_Load(object sender, EventArgs e)
        {
            WordList wordList = WordList.LoadList(Form1.SelectedList);
             
            dataGridView2.Columns.Add("Languages", "Languages");
            dataGridView2.Columns.Add("AddNewWord","New word");
            dataGridView2.Columns["Languages"].ReadOnly = true;

            for (int i = 0; i < wordList.Languages.Length; i++)
            {
                dataGridView2.Rows.Add(wordList.Languages[i]);
            }

            button_addTypedWordsToList.Enabled = false;
        }
        private void button_CloseAddWordControl_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void button_addTypedWordsToList_Click(object sender, EventArgs e)
        {
            List<string> newWords = new List<string>();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                newWords.Add(row.Cells[1].Value.ToString());
            }

            WordList updatedList = WordList.LoadList(Form1.SelectedList);

            updatedList.Add(newWords.ToArray());
            updatedList.Save();
            data1.AddAllWordsToDataGrid();
            WordAdded.Enabled = true;
            Hide();
        }
        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView2.SelectedCells[0].ColumnIndex == dataGridView2.Columns.Count - 1 &&
                dataGridView2.SelectedCells[0].RowIndex == dataGridView2.Rows.Count - 1)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 1)
                        {
                            if (cell.RowIndex != dataGridView2.Rows.Count - 1)
                            {
                                if (string.IsNullOrWhiteSpace((string)cell.Value))
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
                button_addTypedWordsToList.Enabled = true;
            }
        }
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 1)
                    {
                        if (string.IsNullOrWhiteSpace((string)cell.Value))
                        {
                            button_addTypedWordsToList.Enabled = false;
                            return;
                        }
                    }
                }
            }
        }
    }
}

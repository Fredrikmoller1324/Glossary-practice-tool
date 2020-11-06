using System;
using System.Drawing;
using System.Windows.Forms;
using WordTranslationLibrary;

namespace GlossaryAcademyWinform
{
    public partial class DataGridWordsDisplay : UserControl
    {
        private Label label;
        public DataGridWordsDisplay()
        {
            InitializeComponent();
        }
        public DataGridWordsDisplay(Label labelWordCountInSelectedList)
        {
            InitializeComponent();
            label = labelWordCountInSelectedList;
        }
        public void AddAllWordsToDataGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            WordList wordList = WordList.LoadList(Form1.SelectedList);

            for (int i = 0; i < wordList.Languages.Length; i++)
            {
                dataGridView1.Columns.Add("okej", wordList.Languages[i]);
            }

            Action<string[]> sendToMethod = x =>
            {
                dataGridView1.Rows.Add(x);
            };
            wordList.List(0, sendToMethod);
        }
        private void DataGridWordsDisplay_Load(object sender, EventArgs e)
        {
            AddAllWordsToDataGrid();
            if (dataGridView1.RowCount > 0) { button_removeWordInList.Enabled = true; }
            if (dataGridView1.RowCount == 0) { button_removeWordInList.Enabled = false; }
        }
        private void button_addNewWordsToList_Click(object sender, EventArgs e)
        {
            AddingNewWord addingNewWordControl = new AddingNewWord(this,button_removeWordInList);
            Controls.Add(addingNewWordControl);
            addingNewWordControl.BringToFront();
            addingNewWordControl.Location = new Point(Form.ActiveForm.Width / 2 - addingNewWordControl.Width / 2, 50);
        }
        private void button_removeWordInList_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0) 
            {
                WordList wordList = WordList.LoadList(Form1.SelectedList);

                // Collection av celler som är markerade.
                DataGridViewSelectedCellCollection selectedCells = dataGridView1.SelectedCells;
                // Sträng-värdet från en specifik cell.
                string wordToRemove = selectedCells[0].FormattedValue.ToString();
                // int-värdet för språkcolumn
                int column = selectedCells[0].ColumnIndex;

                wordList.Remove(column, wordToRemove);
                wordList.Save();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            if(dataGridView1.RowCount == 0)
            {
                button_removeWordInList.Enabled = false;
            }
        }
        private void button_PracticeWords_Click(object sender, EventArgs e)
        {
            if (WinformFunctionality.CountWords(Form1.SelectedList) > 0)
            {
                PracticeWordsInList practiceWordsInList = new PracticeWordsInList();
                Controls.Add(practiceWordsInList);
                practiceWordsInList.Dock = DockStyle.Fill;
                practiceWordsInList.BringToFront();
            }
            else
            {             
                MessageBox.Show("You need to add words to the selected list before you can enter practicemode", "Empty list");
            }
        }
        private void button_BackToLists_Click(object sender, EventArgs e)
        {
            label.Text = WinformFunctionality.CountWords(Form1.SelectedList).ToString();
            Hide();
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            AddAllWordsToDataGrid();
            if (dataGridView1.RowCount > 0) { button_removeWordInList.Enabled = true; }
            if (dataGridView1.RowCount == 0) { button_removeWordInList.Enabled = false; }
        }
    }
}

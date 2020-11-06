using System;
using System.Windows.Forms;
using WordTranslationLibrary;

namespace GlossaryAcademyWinform
{
    public partial class PracticeWordsInList : UserControl
    {
        private ScoreBoard scoreBoard = new ScoreBoard();
        private string CorrectTranslatedWord { get; set; }
        private void AskForTranslation()
        {
            var practiceList = WordList.LoadList(Form1.SelectedList);

            Word practiceWord = practiceList.GetWordToPractice();

            label_DisplayFromLanguageWord.Text = $"Translate {practiceWord.Translations[practiceWord.FromLanguage]}" +
                $" to {practiceList.Languages[practiceWord.ToLanguage]}";

            CorrectTranslatedWord = practiceWord.Translations[practiceWord.ToLanguage];
        }
        public PracticeWordsInList()
        {
            InitializeComponent();
        }
        private void PracticeWordsInList_Load(object sender, EventArgs e)
        {
            AskForTranslation();
        }
        private void textBox_UserEnterWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                label_explainPracticeMode.Visible = false;
                if (textBox_UserEnterWord.Text == CorrectTranslatedWord)
                {
                    scoreBoard.rightAnswer++;
                    label_DisplayRightOrWrong.Text = "Your answer is correct";
                }
                else
                {
                    label_DisplayRightOrWrong.Text = "Your answer is wrong";
                }
                scoreBoard.totalSum++;

                textBox_UserEnterWord.Clear();
                AskForTranslation();
            }
            if (e.KeyCode == Keys.F1)
            {
                if (!Controls.Contains(scoreBoard))
                {
                    Controls.Add(scoreBoard);
                    scoreBoard.BringToFront();
                    scoreBoard.Show();
                }
                scoreBoard.Visible = true; ;
            }
        }
        private void textBox_UserEnterWord_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                scoreBoard.Visible = false;
            }
        }
        private void button_ExitPracticeGoToListOfWords_Click(object sender, EventArgs e)
        {
            string grade = "";
            if (scoreBoard.totalSum != 0)
            {
                if ((scoreBoard.rightAnswer / scoreBoard.totalSum) * 100 >= 90) { grade = "A"; }
                else if ((scoreBoard.rightAnswer / scoreBoard.totalSum) * 100 >= 80) { grade = "B"; }
                else if ((scoreBoard.rightAnswer / scoreBoard.totalSum) * 100 >= 75) { grade = "C"; }
                else if ((scoreBoard.rightAnswer / scoreBoard.totalSum) * 100 >= 65) { grade = "D"; }
                else if ((scoreBoard.rightAnswer / scoreBoard.totalSum) * 100 >= 50) { grade = "E"; }
                else { grade = "F"; }
                MessageBox.Show($"you answered correctly {(scoreBoard.rightAnswer / scoreBoard.totalSum) * 100} % out of {scoreBoard.totalSum} tries" +
                $"\n\n you recieved grade: {grade} ", "Grade");
                Hide();
            }
            Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlossaryAcademyWinform
{
    public partial class ScoreBoard : UserControl
    {
        // score { get parent.Score }
        public double totalSum = 0;
        public double rightAnswer = 0;

        // parent Form in constructor parameters.
        public ScoreBoard()
        {
            InitializeComponent();
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            label_DisplayingScore.Text = $"you answered corrrectly {rightAnswer} times out of {totalSum}";
        }
        private void ScoreBoard_VisibleChanged(object sender, EventArgs e)
        {
            label_DisplayingScore.Text = $"you answered corrrectly {rightAnswer} times out of {totalSum}";
        }
    }
}

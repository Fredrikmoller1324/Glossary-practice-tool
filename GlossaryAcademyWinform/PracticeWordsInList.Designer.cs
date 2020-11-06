namespace GlossaryAcademyWinform
{
    partial class PracticeWordsInList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_UserEnterWord = new System.Windows.Forms.TextBox();
            this.label_DisplayFromLanguageWord = new System.Windows.Forms.Label();
            this.label_DisplayRightOrWrong = new System.Windows.Forms.Label();
            this.button_ExitPracticeGoToListOfWords = new System.Windows.Forms.Button();
            this.label_explainPracticeMode = new System.Windows.Forms.Label();
            this.label_ViewScoreBoard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_UserEnterWord
            // 
            this.textBox_UserEnterWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_UserEnterWord.Location = new System.Drawing.Point(299, 240);
            this.textBox_UserEnterWord.Name = "textBox_UserEnterWord";
            this.textBox_UserEnterWord.Size = new System.Drawing.Size(250, 20);
            this.textBox_UserEnterWord.TabIndex = 0;
            this.textBox_UserEnterWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_UserEnterWord_KeyDown);
            this.textBox_UserEnterWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_UserEnterWord_KeyUp);
            // 
            // label_DisplayFromLanguageWord
            // 
            this.label_DisplayFromLanguageWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_DisplayFromLanguageWord.AutoSize = true;
            this.label_DisplayFromLanguageWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DisplayFromLanguageWord.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_DisplayFromLanguageWord.Location = new System.Drawing.Point(295, 202);
            this.label_DisplayFromLanguageWord.Name = "label_DisplayFromLanguageWord";
            this.label_DisplayFromLanguageWord.Size = new System.Drawing.Size(83, 20);
            this.label_DisplayFromLanguageWord.TabIndex = 1;
            this.label_DisplayFromLanguageWord.Text = "translation";
            // 
            // label_DisplayRightOrWrong
            // 
            this.label_DisplayRightOrWrong.AutoSize = true;
            this.label_DisplayRightOrWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DisplayRightOrWrong.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_DisplayRightOrWrong.Location = new System.Drawing.Point(295, 275);
            this.label_DisplayRightOrWrong.Name = "label_DisplayRightOrWrong";
            this.label_DisplayRightOrWrong.Size = new System.Drawing.Size(0, 20);
            this.label_DisplayRightOrWrong.TabIndex = 2;
            // 
            // button_ExitPracticeGoToListOfWords
            // 
            this.button_ExitPracticeGoToListOfWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ExitPracticeGoToListOfWords.Location = new System.Drawing.Point(660, 416);
            this.button_ExitPracticeGoToListOfWords.Name = "button_ExitPracticeGoToListOfWords";
            this.button_ExitPracticeGoToListOfWords.Size = new System.Drawing.Size(114, 23);
            this.button_ExitPracticeGoToListOfWords.TabIndex = 3;
            this.button_ExitPracticeGoToListOfWords.Text = "Exit Practice Mode";
            this.button_ExitPracticeGoToListOfWords.UseVisualStyleBackColor = true;
            this.button_ExitPracticeGoToListOfWords.Click += new System.EventHandler(this.button_ExitPracticeGoToListOfWords_Click);
            // 
            // label_explainPracticeMode
            // 
            this.label_explainPracticeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_explainPracticeMode.AutoSize = true;
            this.label_explainPracticeMode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_explainPracticeMode.Location = new System.Drawing.Point(296, 263);
            this.label_explainPracticeMode.Name = "label_explainPracticeMode";
            this.label_explainPracticeMode.Size = new System.Drawing.Size(250, 13);
            this.label_explainPracticeMode.TabIndex = 4;
            this.label_explainPracticeMode.Text = "Enter your answer in textbox above and press Enter";
            // 
            // label_ViewScoreBoard
            // 
            this.label_ViewScoreBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ViewScoreBoard.AutoSize = true;
            this.label_ViewScoreBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ViewScoreBoard.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_ViewScoreBoard.Location = new System.Drawing.Point(295, 316);
            this.label_ViewScoreBoard.Name = "label_ViewScoreBoard";
            this.label_ViewScoreBoard.Size = new System.Drawing.Size(160, 20);
            this.label_ViewScoreBoard.TabIndex = 5;
            this.label_ViewScoreBoard.Text = "Hold F1 to view score";
            // 
            // PracticeWordsInList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.label_ViewScoreBoard);
            this.Controls.Add(this.label_explainPracticeMode);
            this.Controls.Add(this.button_ExitPracticeGoToListOfWords);
            this.Controls.Add(this.label_DisplayRightOrWrong);
            this.Controls.Add(this.label_DisplayFromLanguageWord);
            this.Controls.Add(this.textBox_UserEnterWord);
            this.Name = "PracticeWordsInList";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.PracticeWordsInList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_UserEnterWord;
        private System.Windows.Forms.Label label_DisplayFromLanguageWord;
        private System.Windows.Forms.Label label_DisplayRightOrWrong;
        private System.Windows.Forms.Button button_ExitPracticeGoToListOfWords;
        private System.Windows.Forms.Label label_explainPracticeMode;
        private System.Windows.Forms.Label label_ViewScoreBoard;
    }
}

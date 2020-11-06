namespace GlossaryAcademyWinform
{
    partial class ScoreBoard
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
            this.label_DisplayingScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_DisplayingScore
            // 
            this.label_DisplayingScore.AutoSize = true;
            this.label_DisplayingScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DisplayingScore.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_DisplayingScore.Location = new System.Drawing.Point(54, 88);
            this.label_DisplayingScore.Name = "label_DisplayingScore";
            this.label_DisplayingScore.Size = new System.Drawing.Size(51, 20);
            this.label_DisplayingScore.TabIndex = 0;
            this.label_DisplayingScore.Text = "label1";
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.Controls.Add(this.label_DisplayingScore);
            this.Location = new System.Drawing.Point(212, 70);
            this.Name = "ScoreBoard";
            this.Size = new System.Drawing.Size(424, 238);
            this.Load += new System.EventHandler(this.ScoreBoard_Load);
            this.VisibleChanged += new System.EventHandler(this.ScoreBoard_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DisplayingScore;
    }
}

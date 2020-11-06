namespace GlossaryAcademyWinform
{
    partial class DataGridWordsDisplay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_addNewWordsToList = new System.Windows.Forms.Button();
            this.button_removeWordInList = new System.Windows.Forms.Button();
            this.button_PracticeWords = new System.Windows.Forms.Button();
            this.button_BackToLists = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(816, 489);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.VisibleChanged += new System.EventHandler(this.dataGridView1_VisibleChanged);
            // 
            // button_addNewWordsToList
            // 
            this.button_addNewWordsToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_addNewWordsToList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_addNewWordsToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addNewWordsToList.Location = new System.Drawing.Point(635, 403);
            this.button_addNewWordsToList.Name = "button_addNewWordsToList";
            this.button_addNewWordsToList.Size = new System.Drawing.Size(123, 30);
            this.button_addNewWordsToList.TabIndex = 1;
            this.button_addNewWordsToList.Text = "Add new word";
            this.button_addNewWordsToList.UseVisualStyleBackColor = false;
            this.button_addNewWordsToList.Click += new System.EventHandler(this.button_addNewWordsToList_Click);
            // 
            // button_removeWordInList
            // 
            this.button_removeWordInList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_removeWordInList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_removeWordInList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removeWordInList.Location = new System.Drawing.Point(506, 403);
            this.button_removeWordInList.Name = "button_removeWordInList";
            this.button_removeWordInList.Size = new System.Drawing.Size(123, 30);
            this.button_removeWordInList.TabIndex = 2;
            this.button_removeWordInList.Text = "Remove Word";
            this.button_removeWordInList.UseVisualStyleBackColor = false;
            this.button_removeWordInList.Click += new System.EventHandler(this.button_removeWordInList_Click);
            // 
            // button_PracticeWords
            // 
            this.button_PracticeWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_PracticeWords.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_PracticeWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PracticeWords.Location = new System.Drawing.Point(402, 403);
            this.button_PracticeWords.Name = "button_PracticeWords";
            this.button_PracticeWords.Size = new System.Drawing.Size(98, 30);
            this.button_PracticeWords.TabIndex = 4;
            this.button_PracticeWords.Text = "Practice";
            this.button_PracticeWords.UseVisualStyleBackColor = false;
            this.button_PracticeWords.Click += new System.EventHandler(this.button_PracticeWords_Click);
            // 
            // button_BackToLists
            // 
            this.button_BackToLists.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_BackToLists.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_BackToLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BackToLists.Location = new System.Drawing.Point(311, 403);
            this.button_BackToLists.Name = "button_BackToLists";
            this.button_BackToLists.Size = new System.Drawing.Size(85, 30);
            this.button_BackToLists.TabIndex = 5;
            this.button_BackToLists.Text = "Swap list";
            this.button_BackToLists.UseVisualStyleBackColor = false;
            this.button_BackToLists.Click += new System.EventHandler(this.button_BackToLists_Click);
            // 
            // DataGridWordsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.button_BackToLists);
            this.Controls.Add(this.button_PracticeWords);
            this.Controls.Add(this.button_removeWordInList);
            this.Controls.Add(this.button_addNewWordsToList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataGridWordsDisplay";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.DataGridWordsDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_addNewWordsToList;
        private System.Windows.Forms.Button button_removeWordInList;
        private System.Windows.Forms.Button button_PracticeWords;
        private System.Windows.Forms.Button button_BackToLists;
    }
}

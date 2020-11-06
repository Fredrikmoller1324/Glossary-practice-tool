namespace GlossaryAcademyWinform
{
    partial class AddingNewWord
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button_addTypedWordsToList = new System.Windows.Forms.Button();
            this.button_CloseAddWordControl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.Size = new System.Drawing.Size(224, 278);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView2_CellBeginEdit);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // button_addTypedWordsToList
            // 
            this.button_addTypedWordsToList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_addTypedWordsToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addTypedWordsToList.Location = new System.Drawing.Point(136, 231);
            this.button_addTypedWordsToList.Name = "button_addTypedWordsToList";
            this.button_addTypedWordsToList.Size = new System.Drawing.Size(75, 34);
            this.button_addTypedWordsToList.TabIndex = 1;
            this.button_addTypedWordsToList.Text = "ok";
            this.button_addTypedWordsToList.UseVisualStyleBackColor = false;
            this.button_addTypedWordsToList.Click += new System.EventHandler(this.button_addTypedWordsToList_Click);
            // 
            // button_CloseAddWordControl
            // 
            this.button_CloseAddWordControl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_CloseAddWordControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CloseAddWordControl.Location = new System.Drawing.Point(13, 231);
            this.button_CloseAddWordControl.Name = "button_CloseAddWordControl";
            this.button_CloseAddWordControl.Size = new System.Drawing.Size(75, 34);
            this.button_CloseAddWordControl.TabIndex = 2;
            this.button_CloseAddWordControl.Text = "Cancel";
            this.button_CloseAddWordControl.UseVisualStyleBackColor = false;
            this.button_CloseAddWordControl.Click += new System.EventHandler(this.button_CloseAddWordControl_Click);
            // 
            // AddingNewWord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.button_CloseAddWordControl);
            this.Controls.Add(this.button_addTypedWordsToList);
            this.Controls.Add(this.dataGridView2);
            this.Name = "AddingNewWord";
            this.Size = new System.Drawing.Size(224, 278);
            this.Load += new System.EventHandler(this.AddingNewWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button_addTypedWordsToList;
        private System.Windows.Forms.Button button_CloseAddWordControl;
    }
}

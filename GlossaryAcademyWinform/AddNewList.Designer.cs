namespace GlossaryAcademyWinform
{
    partial class AddNewList
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
            this.textBox_AddListName = new System.Windows.Forms.TextBox();
            this.label_newList = new System.Windows.Forms.Label();
            this.textBox_addNewLanguage = new System.Windows.Forms.TextBox();
            this.label_textboxaddLanguage = new System.Windows.Forms.Label();
            this.button_ConfirmedNewList = new System.Windows.Forms.Button();
            this.button_CancelNewList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_AddListName
            // 
            this.textBox_AddListName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_AddListName.Location = new System.Drawing.Point(26, 52);
            this.textBox_AddListName.Name = "textBox_AddListName";
            this.textBox_AddListName.Size = new System.Drawing.Size(354, 20);
            this.textBox_AddListName.TabIndex = 0;
            this.textBox_AddListName.Text = "Enter a List name";
            // 
            // label_newList
            // 
            this.label_newList.AutoSize = true;
            this.label_newList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_newList.Location = new System.Drawing.Point(22, 15);
            this.label_newList.Name = "label_newList";
            this.label_newList.Size = new System.Drawing.Size(69, 20);
            this.label_newList.TabIndex = 1;
            this.label_newList.Text = "New List";
            // 
            // textBox_addNewLanguage
            // 
            this.textBox_addNewLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_addNewLanguage.Location = new System.Drawing.Point(26, 131);
            this.textBox_addNewLanguage.Multiline = true;
            this.textBox_addNewLanguage.Name = "textBox_addNewLanguage";
            this.textBox_addNewLanguage.Size = new System.Drawing.Size(354, 161);
            this.textBox_addNewLanguage.TabIndex = 2;
            // 
            // label_textboxaddLanguage
            // 
            this.label_textboxaddLanguage.AutoSize = true;
            this.label_textboxaddLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_textboxaddLanguage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_textboxaddLanguage.Location = new System.Drawing.Point(22, 98);
            this.label_textboxaddLanguage.Name = "label_textboxaddLanguage";
            this.label_textboxaddLanguage.Size = new System.Drawing.Size(89, 20);
            this.label_textboxaddLanguage.TabIndex = 3;
            this.label_textboxaddLanguage.Text = "Languages";
            // 
            // button_ConfirmedNewList
            // 
            this.button_ConfirmedNewList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ConfirmedNewList.Location = new System.Drawing.Point(278, 299);
            this.button_ConfirmedNewList.Name = "button_ConfirmedNewList";
            this.button_ConfirmedNewList.Size = new System.Drawing.Size(75, 23);
            this.button_ConfirmedNewList.TabIndex = 4;
            this.button_ConfirmedNewList.Text = "Add List";
            this.button_ConfirmedNewList.UseVisualStyleBackColor = true;
            this.button_ConfirmedNewList.Click += new System.EventHandler(this.button_ConfirmedNewList_Click);
            // 
            // button_CancelNewList
            // 
            this.button_CancelNewList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CancelNewList.Location = new System.Drawing.Point(188, 299);
            this.button_CancelNewList.Name = "button_CancelNewList";
            this.button_CancelNewList.Size = new System.Drawing.Size(75, 23);
            this.button_CancelNewList.TabIndex = 5;
            this.button_CancelNewList.Text = "Cancel";
            this.button_CancelNewList.UseVisualStyleBackColor = true;
            this.button_CancelNewList.Click += new System.EventHandler(this.button_CancelNewList_Click);
            // 
            // AddNewList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.button_CancelNewList);
            this.Controls.Add(this.button_ConfirmedNewList);
            this.Controls.Add(this.label_textboxaddLanguage);
            this.Controls.Add(this.textBox_addNewLanguage);
            this.Controls.Add(this.label_newList);
            this.Controls.Add(this.textBox_AddListName);
            this.Name = "AddNewList";
            this.Size = new System.Drawing.Size(418, 339);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_AddListName;
        private System.Windows.Forms.Label label_newList;
        private System.Windows.Forms.TextBox textBox_addNewLanguage;
        private System.Windows.Forms.Label label_textboxaddLanguage;
        private System.Windows.Forms.Button button_ConfirmedNewList;
        private System.Windows.Forms.Button button_CancelNewList;
    }
}

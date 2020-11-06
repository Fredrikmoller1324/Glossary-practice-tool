using System;
using System.IO;

namespace GlossaryAcademyWinform
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_lists = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Langugage = new System.Windows.Forms.ListBox();
            this.label_Wordcount = new System.Windows.Forms.Label();
            this.label_WordCountName = new System.Windows.Forms.Label();
            this.button_NewList = new System.Windows.Forms.Button();
            this.button_SelectedListToShowWords = new System.Windows.Forms.Button();
            this.button_DeleteSelectedList = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_lists
            // 
            this.listBox_lists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_lists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_lists.FormattingEnabled = true;
            this.listBox_lists.ItemHeight = 20;
            this.listBox_lists.Location = new System.Drawing.Point(30, 72);
            this.listBox_lists.Name = "listBox_lists";
            this.listBox_lists.Size = new System.Drawing.Size(339, 284);
            this.listBox_lists.TabIndex = 0;
            this.listBox_lists.SelectedValueChanged += new System.EventHandler(this.listBox_lists_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wordlists:";
            // 
            // listBox_Langugage
            // 
            this.listBox_Langugage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_Langugage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Langugage.FormattingEnabled = true;
            this.listBox_Langugage.ItemHeight = 20;
            this.listBox_Langugage.Location = new System.Drawing.Point(417, 72);
            this.listBox_Langugage.Name = "listBox_Langugage";
            this.listBox_Langugage.Size = new System.Drawing.Size(339, 284);
            this.listBox_Langugage.TabIndex = 2;
            // 
            // label_Wordcount
            // 
            this.label_Wordcount.AutoSize = true;
            this.label_Wordcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Wordcount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Wordcount.Location = new System.Drawing.Point(334, 51);
            this.label_Wordcount.Name = "label_Wordcount";
            this.label_Wordcount.Size = new System.Drawing.Size(18, 20);
            this.label_Wordcount.TabIndex = 3;
            this.label_Wordcount.Text = "0";
            // 
            // label_WordCountName
            // 
            this.label_WordCountName.AutoSize = true;
            this.label_WordCountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WordCountName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_WordCountName.Location = new System.Drawing.Point(230, 49);
            this.label_WordCountName.Name = "label_WordCountName";
            this.label_WordCountName.Size = new System.Drawing.Size(98, 20);
            this.label_WordCountName.TabIndex = 4;
            this.label_WordCountName.Text = "Word Count:";
            // 
            // button_NewList
            // 
            this.button_NewList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_NewList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_NewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NewList.Location = new System.Drawing.Point(259, 362);
            this.button_NewList.Name = "button_NewList";
            this.button_NewList.Size = new System.Drawing.Size(110, 38);
            this.button_NewList.TabIndex = 5;
            this.button_NewList.Text = "New List";
            this.button_NewList.UseVisualStyleBackColor = false;
            this.button_NewList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_NewList_MouseClick);
            // 
            // button_SelectedListToShowWords
            // 
            this.button_SelectedListToShowWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_SelectedListToShowWords.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_SelectedListToShowWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelectedListToShowWords.Location = new System.Drawing.Point(609, 362);
            this.button_SelectedListToShowWords.Name = "button_SelectedListToShowWords";
            this.button_SelectedListToShowWords.Size = new System.Drawing.Size(141, 38);
            this.button_SelectedListToShowWords.TabIndex = 7;
            this.button_SelectedListToShowWords.Text = "Show words in list";
            this.button_SelectedListToShowWords.UseVisualStyleBackColor = false;
            this.button_SelectedListToShowWords.Click += new System.EventHandler(this.button_SelectedListToShowWords_Click);
            // 
            // button_DeleteSelectedList
            // 
            this.button_DeleteSelectedList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_DeleteSelectedList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_DeleteSelectedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteSelectedList.Location = new System.Drawing.Point(44, 363);
            this.button_DeleteSelectedList.Name = "button_DeleteSelectedList";
            this.button_DeleteSelectedList.Size = new System.Drawing.Size(98, 38);
            this.button_DeleteSelectedList.TabIndex = 9;
            this.button_DeleteSelectedList.Text = "Delete List";
            this.button_DeleteSelectedList.UseVisualStyleBackColor = false;
            this.button_DeleteSelectedList.Click += new System.EventHandler(this.button_DeleteSelectedList_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_DeleteSelectedList);
            this.Controls.Add(this.button_SelectedListToShowWords);
            this.Controls.Add(this.button_NewList);
            this.Controls.Add(this.label_WordCountName);
            this.Controls.Add(this.label_Wordcount);
            this.Controls.Add(this.listBox_Langugage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_lists);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glossary Academy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_lists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Langugage;
        private System.Windows.Forms.Label label_Wordcount;
        private System.Windows.Forms.Label label_WordCountName;
        private System.Windows.Forms.Button button_NewList;
        private System.Windows.Forms.Button button_SelectedListToShowWords;
        private System.Windows.Forms.Button button_DeleteSelectedList;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}


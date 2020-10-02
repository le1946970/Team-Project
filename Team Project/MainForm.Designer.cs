namespace Team_Project
{
    partial class MainForm
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
            this.numberFilesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberFilesTypeListBox = new System.Windows.Forms.ListBox();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reorganizeComboBox = new System.Windows.Forms.ComboBox();
            this.moreInfoListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // numberFilesTextBox
            // 
            this.numberFilesTextBox.Location = new System.Drawing.Point(28, 41);
            this.numberFilesTextBox.Name = "numberFilesTextBox";
            this.numberFilesTextBox.ReadOnly = true;
            this.numberFilesTextBox.Size = new System.Drawing.Size(123, 22);
            this.numberFilesTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of files in the directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of files per type";
            // 
            // numberFilesTypeListBox
            // 
            this.numberFilesTypeListBox.FormattingEnabled = true;
            this.numberFilesTypeListBox.ItemHeight = 16;
            this.numberFilesTypeListBox.Location = new System.Drawing.Point(28, 100);
            this.numberFilesTypeListBox.Name = "numberFilesTypeListBox";
            this.numberFilesTypeListBox.Size = new System.Drawing.Size(195, 84);
            this.numberFilesTypeListBox.TabIndex = 5;
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.ItemHeight = 16;
            this.filesListBox.Location = new System.Drawing.Point(270, 21);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(280, 228);
            this.filesListBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Reorder by:";
            // 
            // reorganizeComboBox
            // 
            this.reorganizeComboBox.FormattingEnabled = true;
            this.reorganizeComboBox.Items.AddRange(new object[] {
            "File Name",
            "File Type",
            "File Size",
            "Last Modification Date"});
            this.reorganizeComboBox.Location = new System.Drawing.Point(25, 225);
            this.reorganizeComboBox.Name = "reorganizeComboBox";
            this.reorganizeComboBox.Size = new System.Drawing.Size(198, 24);
            this.reorganizeComboBox.TabIndex = 9;
            // 
            // moreInfoListBox
            // 
            this.moreInfoListBox.FormattingEnabled = true;
            this.moreInfoListBox.ItemHeight = 16;
            this.moreInfoListBox.Location = new System.Drawing.Point(567, 21);
            this.moreInfoListBox.Name = "moreInfoListBox";
            this.moreInfoListBox.Size = new System.Drawing.Size(280, 228);
            this.moreInfoListBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 269);
            this.Controls.Add(this.moreInfoListBox);
            this.Controls.Add(this.reorganizeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(this.numberFilesTypeListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberFilesTextBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox numberFilesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox numberFilesTypeListBox;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox reorganizeComboBox;
        private System.Windows.Forms.ListBox moreInfoListBox;
    }
}


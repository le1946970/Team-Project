namespace Team_Project
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
            this.numberFilesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberFilesTypeListBox = new System.Windows.Forms.ListBox();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // numberFilesTextBox
            // 
            this.numberFilesTextBox.Location = new System.Drawing.Point(29, 65);
            this.numberFilesTextBox.Name = "numberFilesTextBox";
            this.numberFilesTextBox.Size = new System.Drawing.Size(123, 22);
            this.numberFilesTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of files in the directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of files per type";
            // 
            // numberFilesTypeListBox
            // 
            this.numberFilesTypeListBox.FormattingEnabled = true;
            this.numberFilesTypeListBox.ItemHeight = 16;
            this.numberFilesTypeListBox.Location = new System.Drawing.Point(32, 142);
            this.numberFilesTypeListBox.Name = "numberFilesTypeListBox";
            this.numberFilesTypeListBox.Size = new System.Drawing.Size(195, 180);
            this.numberFilesTypeListBox.TabIndex = 5;
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.ItemHeight = 16;
            this.filesListBox.Location = new System.Drawing.Point(268, 33);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(333, 292);
            this.filesListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 356);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(this.numberFilesTypeListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberFilesTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox numberFilesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox numberFilesTypeListBox;
        private System.Windows.Forms.ListBox filesListBox;
    }
}


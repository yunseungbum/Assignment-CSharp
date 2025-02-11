namespace NotePad
{
    partial class FindDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FindNextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CaseTextCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "찾을내용(&N):";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(88, 6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(199, 21);
            this.SearchTextBox.TabIndex = 1;
            // 
            // FindNextButton
            // 
            this.FindNextButton.Location = new System.Drawing.Point(293, 4);
            this.FindNextButton.Name = "FindNextButton";
            this.FindNextButton.Size = new System.Drawing.Size(94, 27);
            this.FindNextButton.TabIndex = 2;
            this.FindNextButton.Text = "다음찾기";
            this.FindNextButton.UseVisualStyleBackColor = true;
            this.FindNextButton.Click += new System.EventHandler(this.FindNextClick);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(293, 37);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 25);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "취소";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelClick);
            // 
            // CaseTextCheckBox
            // 
            this.CaseTextCheckBox.Location = new System.Drawing.Point(88, 33);
            this.CaseTextCheckBox.Name = "CaseTextCheckBox";
            this.CaseTextCheckBox.Size = new System.Drawing.Size(122, 24);
            this.CaseTextCheckBox.TabIndex = 4;
            this.CaseTextCheckBox.Text = "대/소문자 구분";
            this.CaseTextCheckBox.UseVisualStyleBackColor = true;
            // 
            // FindDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 132);
            this.Controls.Add(this.CaseTextCheckBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FindNextButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FindDialog";
            this.Text = "찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button FindNextButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox CaseTextCheckBox;
    }
}
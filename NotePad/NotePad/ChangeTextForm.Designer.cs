namespace NotePad
{
    partial class ChangeTextForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.ReplaceText = new System.Windows.Forms.TextBox();
            this.FindNext = new System.Windows.Forms.Button();
            this.Replace = new System.Windows.Forms.Button();
            this.ReplaceAll = new System.Windows.Forms.Button();
            this.CanceChangeText = new System.Windows.Forms.Button();
            this.CaseTextCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "찾을 내용(&N) :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "바꿀 내용(&N) :";
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(113, 31);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(206, 21);
            this.SearchText.TabIndex = 2;
            // 
            // ReplaceText
            // 
            this.ReplaceText.Location = new System.Drawing.Point(113, 60);
            this.ReplaceText.Name = "ReplaceText";
            this.ReplaceText.Size = new System.Drawing.Size(206, 21);
            this.ReplaceText.TabIndex = 3;
            // 
            // FindNext
            // 
            this.FindNext.Location = new System.Drawing.Point(335, 29);
            this.FindNext.Name = "FindNext";
            this.FindNext.Size = new System.Drawing.Size(102, 23);
            this.FindNext.TabIndex = 4;
            this.FindNext.Text = "다음찾기(&F)";
            this.FindNext.UseVisualStyleBackColor = true;
            this.FindNext.Click += new System.EventHandler(this.FindNextClick);
            // 
            // Replace
            // 
            this.Replace.Location = new System.Drawing.Point(335, 60);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(102, 23);
            this.Replace.TabIndex = 5;
            this.Replace.Text = "바꾸기(&R)";
            this.Replace.UseVisualStyleBackColor = true;
            this.Replace.Click += new System.EventHandler(this.ReplaceClick);
            // 
            // ReplaceAll
            // 
            this.ReplaceAll.Location = new System.Drawing.Point(335, 89);
            this.ReplaceAll.Name = "ReplaceAll";
            this.ReplaceAll.Size = new System.Drawing.Size(102, 23);
            this.ReplaceAll.TabIndex = 6;
            this.ReplaceAll.Text = "모두 바꾸기(&A)";
            this.ReplaceAll.UseVisualStyleBackColor = true;
            this.ReplaceAll.Click += new System.EventHandler(this.ReplaceAllClcik);
            // 
            // CanceChangeText
            // 
            this.CanceChangeText.Location = new System.Drawing.Point(335, 118);
            this.CanceChangeText.Name = "CanceChangeText";
            this.CanceChangeText.Size = new System.Drawing.Size(102, 23);
            this.CanceChangeText.TabIndex = 7;
            this.CanceChangeText.Text = "취소";
            this.CanceChangeText.UseVisualStyleBackColor = true;
            this.CanceChangeText.Click += new System.EventHandler(this.CancelClick);
            // 
            // CaseTextCheckBox
            // 
            this.CaseTextCheckBox.AutoSize = true;
            this.CaseTextCheckBox.Location = new System.Drawing.Point(24, 122);
            this.CaseTextCheckBox.Name = "CaseTextCheckBox";
            this.CaseTextCheckBox.Size = new System.Drawing.Size(125, 16);
            this.CaseTextCheckBox.TabIndex = 8;
            this.CaseTextCheckBox.Text = "대/소문자 구분(&C)";
            this.CaseTextCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChangeTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 235);
            this.Controls.Add(this.CaseTextCheckBox);
            this.Controls.Add(this.CanceChangeText);
            this.Controls.Add(this.ReplaceAll);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.FindNext);
            this.Controls.Add(this.ReplaceText);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeTextForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "바꾸기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.TextBox ReplaceText;
        private System.Windows.Forms.Button FindNext;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.Button ReplaceAll;
        private System.Windows.Forms.Button CanceChangeText;
        private System.Windows.Forms.CheckBox CaseTextCheckBox;
    }
}
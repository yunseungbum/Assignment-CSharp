namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.displayResult = new System.Windows.Forms.Label();
            this.buttonmultiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.display.Font = new System.Drawing.Font("굴림", 11F);
            this.display.ForeColor = System.Drawing.SystemColors.Control;
            this.display.Location = new System.Drawing.Point(4, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(321, 54);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Silver;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Location = new System.Drawing.Point(85, 336);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(81, 51);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.ButtonNumberClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(4, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonNumberClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(85, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ButtonNumberClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(166, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ButtonNumberClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(4, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 51);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ButtonNumberClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(85, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 51);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ButtonNumberClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(166, 222);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 51);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ButtonNumberClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(4, 165);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 51);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ButtonNumberClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Silver;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(85, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 51);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.ButtonNumberClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Silver;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(166, 165);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(81, 51);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.ButtonNumberClick);
            // 
            // buttonPercent
            // 
            this.buttonPercent.BackColor = System.Drawing.Color.Gray;
            this.buttonPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPercent.Location = new System.Drawing.Point(4, 108);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(81, 51);
            this.buttonPercent.TabIndex = 11;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = false;
            this.buttonPercent.Click += new System.EventHandler(this.ButtonPercentClick);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.BackColor = System.Drawing.Color.Gray;
            this.buttonClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearEntry.Location = new System.Drawing.Point(85, 108);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(81, 51);
            this.buttonClearEntry.TabIndex = 12;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = false;
            this.buttonClearEntry.Click += new System.EventHandler(this.ButtonClearEntryClcik);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Gray;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(166, 108);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(81, 51);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.Gray;
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivide.Location = new System.Drawing.Point(251, 165);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(81, 39);
            this.buttonDivide.TabIndex = 15;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.ButtonDivideClick);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Gray;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Location = new System.Drawing.Point(251, 255);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(81, 39);
            this.buttonMinus.TabIndex = 16;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.ButtonMinusClick);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Gray;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Location = new System.Drawing.Point(251, 303);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(81, 39);
            this.buttonPlus.TabIndex = 17;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.ButtonPlusClick);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.Gray;
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqual.Location = new System.Drawing.Point(251, 348);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(81, 39);
            this.buttonEqual.TabIndex = 18;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.ButtonResultClick);
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.Color.Silver;
            this.buttonPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoint.Location = new System.Drawing.Point(166, 336);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(81, 51);
            this.buttonPoint.TabIndex = 19;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.ButtonPointClick);
            // 
            // buttonReverse
            // 
            this.buttonReverse.BackColor = System.Drawing.Color.Silver;
            this.buttonReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReverse.Location = new System.Drawing.Point(4, 336);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(81, 51);
            this.buttonReverse.TabIndex = 20;
            this.buttonReverse.Text = "+/-";
            this.buttonReverse.UseVisualStyleBackColor = false;
            this.buttonReverse.Click += new System.EventHandler(this.ButtonReverseClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Gray;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(251, 108);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(81, 51);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "←";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
            // 
            // displayResult
            // 
            this.displayResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.displayResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayResult.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.displayResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayResult.Location = new System.Drawing.Point(12, 54);
            this.displayResult.Name = "displayResult";
            this.displayResult.Size = new System.Drawing.Size(313, 51);
            this.displayResult.TabIndex = 21;
            this.displayResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonmultiply
            // 
            this.buttonmultiply.BackColor = System.Drawing.Color.Gray;
            this.buttonmultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmultiply.Location = new System.Drawing.Point(251, 210);
            this.buttonmultiply.Name = "buttonmultiply";
            this.buttonmultiply.Size = new System.Drawing.Size(81, 39);
            this.buttonmultiply.TabIndex = 22;
            this.buttonmultiply.Text = "X";
            this.buttonmultiply.UseVisualStyleBackColor = false;
            this.buttonmultiply.Click += new System.EventHandler(this.ButtonmultiplyClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(337, 390);
            this.Controls.Add(this.buttonmultiply);
            this.Controls.Add(this.displayResult);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "계산기";
            this.Load += new System.EventHandler(this.Form1Load);
            this.Click += new System.EventHandler(this.ButtonNumberClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label displayResult;
        private System.Windows.Forms.Button buttonmultiply;
    }
}


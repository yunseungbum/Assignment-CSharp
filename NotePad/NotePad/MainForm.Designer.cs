namespace NotePad
{
    partial class Form
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMakeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.EndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReMakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoChangeTextTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.StateCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripCursorPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.FileSystemWatcher = new System.IO.FileSystemWatcher();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ReMakeToolStripMenuItem,
            this.ModeToolStripMenuItem,
            this.ViewToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMakeFileToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.NewSaveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.EndToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.FileToolStripMenuItem.Text = "파일(&F)";
            // 
            // NewMakeFileToolStripMenuItem
            // 
            this.NewMakeFileToolStripMenuItem.Name = "NewMakeFileToolStripMenuItem";
            this.NewMakeFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewMakeFileToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.NewMakeFileToolStripMenuItem.Text = "새로만들기(&N)";
            this.NewMakeFileToolStripMenuItem.Click += new System.EventHandler(this.NewMakeToolClick);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.OpenToolStripMenuItem.Text = "열기(&O)";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolClick);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.SaveToolStripMenuItem.Text = "저장(&S)";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolClick);
            // 
            // NewSaveToolStripMenuItem
            // 
            this.NewSaveToolStripMenuItem.Name = "NewSaveToolStripMenuItem";
            this.NewSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.NewSaveToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.NewSaveToolStripMenuItem.Text = "다른 이름으로 저장(&A)";
            this.NewSaveToolStripMenuItem.Click += new System.EventHandler(this.NewSaveToolClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(265, 6);
            // 
            // EndToolStripMenuItem
            // 
            this.EndToolStripMenuItem.Name = "EndToolStripMenuItem";
            this.EndToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.EndToolStripMenuItem.Text = "끝내기(&X)";
            this.EndToolStripMenuItem.Click += new System.EventHandler(this.EndToolClick);
            // 
            // ReMakeToolStripMenuItem
            // 
            this.ReMakeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.FindToolStripMenuItem,
            this.ChangeToolStripMenuItem,
            this.AllSelectToolStripMenuItem,
            this.TimeDateToolStripMenuItem});
            this.ReMakeToolStripMenuItem.Name = "ReMakeToolStripMenuItem";
            this.ReMakeToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ReMakeToolStripMenuItem.Text = "편집(&E)";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UndoToolStripMenuItem.Text = "실행취소(&U)";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.RunCancelButtonClick);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CutToolStripMenuItem.Text = "잘라내기(&T)";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutBottonClick);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CopyToolStripMenuItem.Text = "복사(&C)";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyButtonClick);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PasteToolStripMenuItem.Text = "붙여넣기(P)";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteButtonClick);
            // 
            // FindToolStripMenuItem
            // 
            this.FindToolStripMenuItem.Name = "FindToolStripMenuItem";
            this.FindToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FindToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FindToolStripMenuItem.Text = "찾기(&F)";
            this.FindToolStripMenuItem.Click += new System.EventHandler(this.FindToolClick);
            // 
            // ChangeToolStripMenuItem
            // 
            this.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem";
            this.ChangeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.ChangeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ChangeToolStripMenuItem.Text = "바꾸기";
            this.ChangeToolStripMenuItem.Click += new System.EventHandler(this.ChangeToolClick);
            // 
            // AllSelectToolStripMenuItem
            // 
            this.AllSelectToolStripMenuItem.Name = "AllSelectToolStripMenuItem";
            this.AllSelectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AllSelectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AllSelectToolStripMenuItem.Text = "모두 선택";
            this.AllSelectToolStripMenuItem.Click += new System.EventHandler(this.AllSelectToolClick);
            // 
            // TimeDateToolStripMenuItem
            // 
            this.TimeDateToolStripMenuItem.Name = "TimeDateToolStripMenuItem";
            this.TimeDateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.TimeDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TimeDateToolStripMenuItem.Text = "시간/날짜";
            this.TimeDateToolStripMenuItem.Click += new System.EventHandler(this.TimeDateToolClick);
            // 
            // ModeToolStripMenuItem
            // 
            this.ModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem,
            this.AutoChangeTextTool});
            this.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem";
            this.ModeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ModeToolStripMenuItem.Text = "서식(&O)";
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FontToolStripMenuItem.Text = "글꼴(&F)";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolClick);
            // 
            // AutoChangeTextTool
            // 
            this.AutoChangeTextTool.Name = "AutoChangeTextTool";
            this.AutoChangeTextTool.Size = new System.Drawing.Size(180, 22);
            this.AutoChangeTextTool.Text = "자동 줄 바꿈(&W)";
            this.AutoChangeTextTool.Click += new System.EventHandler(this.AutoTextChangeToolClick);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.StateCheckToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ViewToolStripMenuItem.Text = "보기&(V)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // StateCheckToolStripMenuItem
            // 
            this.StateCheckToolStripMenuItem.Checked = true;
            this.StateCheckToolStripMenuItem.CheckOnClick = true;
            this.StateCheckToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StateCheckToolStripMenuItem.Name = "StateCheckToolStripMenuItem";
            this.StateCheckToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StateCheckToolStripMenuItem.Text = "상태 표시줄";
            this.StateCheckToolStripMenuItem.Click += new System.EventHandler(this.StateCheckToolStripMenuItemClick);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCursorPosition});
            this.StatusStrip.Location = new System.Drawing.Point(0, 426);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(800, 24);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // toolStripCursorPosition
            // 
            this.toolStripCursorPosition.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripCursorPosition.Name = "toolStripCursorPosition";
            this.toolStripCursorPosition.Size = new System.Drawing.Size(71, 19);
            this.toolStripCursorPosition.Text = "Ln 1, Col 1";
            this.toolStripCursorPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBox
            // 
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Location = new System.Drawing.Point(0, 24);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox.Size = new System.Drawing.Size(800, 402);
            this.TextBox.TabIndex = 2;
            this.TextBox.WordWrap = false;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // FileSystemWatcher
            // 
            this.FileSystemWatcher.EnableRaisingEvents = true;
            this.FileSystemWatcher.SynchronizingObject = this;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form";
            this.Text = "메모장";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewMakeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReMakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllSelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem ModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.ToolStripMenuItem AutoChangeTextTool;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem StateCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.IO.FileSystemWatcher FileSystemWatcher;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCursorPosition;
    }
}


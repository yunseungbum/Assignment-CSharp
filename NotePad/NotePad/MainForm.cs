using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form : System.Windows.Forms.Form
    {
        string Filename = "";


        public Form()
        {
            InitializeComponent();
            TextBox.KeyUp += TextBoxKeyUp;
            TextBox.MouseClick += TextBoxMouseClick;
        }

        //시간
        private void TimeDateToolClick(object sender, EventArgs e)
        {
            TextBox.Text += DateTime.Now.ToString();
            TextBox.SelectionStart = TextBox.Text.Length;
            TextBox.SelectionLength = 0;
            TextBox.Focus();
        }

        //저장
        private void SaveToolClick(object sender, EventArgs e)
        {
            if (Filename == "")
            {
                this.SaveFileDialog.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
                if (SaveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                Filename = SaveFileDialog.FileName;
            }
                System.IO.File.WriteAllText(Filename, TextBox.Text);
            
        }

        //다른 이름으로 저장
        private void NewSaveToolClick(object sender, EventArgs e)
        {
            this.SaveFileDialog.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            if (SaveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            System.IO.File.WriteAllText(SaveFileDialog.FileName, TextBox.Text);
        }

        //새로 만들기
        private void NewMakeToolClick(object sender, EventArgs e)
        {
            TextBox.Text = "";
        }

        //열기
        private void OpenToolClick(object sender, EventArgs e)
        {
            this.SaveFileDialog.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Filename = OpenFileDialog.FileName;
                if (!string.IsNullOrEmpty(Filename))
                {
                    string data = System.IO.File.ReadAllText(Filename);
                    TextBox.Text = data;
                }
            }
        }

        //끝내기
        private void EndToolClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox.Text))
            {
                DialogResult result = MessageBox.Show( "변경된 내용을 저장하시겠습니까?", "저장 확인", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(Filename))
                    {
                        this.SaveFileDialog.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
                        DialogResult saveResult = SaveFileDialog.ShowDialog();

                        if (saveResult == DialogResult.OK)
                        {
                            Filename = SaveFileDialog.FileName;
                        }
                        else
                        {
                            return; 
                        }
                    }

                    System.IO.File.WriteAllText(Filename, TextBox.Text);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            Close();
        }

        //붙여넣기
        private void PasteButtonClick(object sender, EventArgs e)
        {
            TextBox.Paste();
        }
        //실행취소
        private void RunCancelButtonClick(object sender, EventArgs e)
        {
            if (TextBox.CanUndo)
            {
                TextBox.Undo();
            }
        }

        //복사
        private void CopyButtonClick(object sender, EventArgs e)
        {
            if (TextBox.SelectionLength > 0)
            {
                TextBox.Copy();
            }
        }

        //자르기
        private void CutBottonClick(object sender, EventArgs e)
        {
            if (TextBox.SelectionLength > 0)
            {
                TextBox.Cut();
            }
        }

        //자동줄바꿈
        private void AutoTextChangeToolClick(object sender, EventArgs e)
        {
            TextBox.WordWrap = !TextBox.WordWrap;
        }

        //글꼴
        private void FontToolClick(object sender, EventArgs e)
        {
            this.FontDialog.ShowDialog();
            TextBox.Font = this.FontDialog.Font;
        }

        //찾기
        private void FindToolClick(object sender, EventArgs e)
        {
            FindDialog findDialog = new FindDialog(TextBox);  
            findDialog.Show();
        }

        //바꾸기
        private void ChangeToolClick(object sender, EventArgs e)
        {
            ChangeTextForm changeTextForm = new ChangeTextForm(TextBox);
            changeTextForm.Show();
        }

        //모두 선택
        private void AllSelectToolClick(object sender, EventArgs e)
        {
            TextBox.SelectAll();
        }

        //키보드 위치
        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            UpdateStatusBar();
        }

        //마우스 위치
        private void TextBoxMouseClick(object sender, MouseEventArgs e)
        {
            UpdateStatusBar();
        }

        //커서 위치 및 문자 수 업데이트 메서드
        private void UpdateStatusBar()
        {
            int line = TextBox.GetLineFromCharIndex(TextBox.SelectionStart) + 1;
            int column = TextBox.SelectionStart - TextBox.GetFirstCharIndexOfCurrentLine() + 1;
            int strNum = TextBox.Text.Length;

            toolStripCursorPosition.Text = $"Ln {line}, Col {column}, Count {strNum}";
        }

        //상태줄표시
        private void StateCheckToolStripMenuItemClick(object sender, EventArgs e)
        {
            StatusStrip.Visible = !StatusStrip.Visible;
        }

        //새 창
        private void NewNotePadClick(object sender, EventArgs e)
        {
            Form newMemo = new Form();
            newMemo.Show();
        }
    }
}

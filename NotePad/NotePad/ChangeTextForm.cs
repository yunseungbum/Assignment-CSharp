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
    public partial class ChangeTextForm : System.Windows.Forms.Form
    {
        private TextBox MainTextBox;
        public ChangeTextForm(TextBox textBox)
        {
            InitializeComponent();
            MainTextBox = textBox;
        }

        //다음찾기
        private void FindNextClick(object sender, EventArgs e)
        {
            string searchText = SearchText.Text;
            StringComparison comparisonType = CaseTextCheckBox.Checked ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;

            int startIndex = MainTextBox.SelectionStart + MainTextBox.SelectionLength;
            int foundIndex = MainTextBox.Text.IndexOf(searchText, startIndex, comparisonType);

            if (foundIndex != -1)
            {
                MainTextBox.Select(foundIndex, searchText.Length);
                MainTextBox.Focus();
            }
            else
            {
                MessageBox.Show("더 이상 찾을 내용이 없습니다.", "찾기 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //바꾸기
        private void ReplaceClick(object sender, EventArgs e)
        {

            StringComparison comparisonType = CaseTextCheckBox.Checked ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;
            if (MainTextBox.SelectedText.Length > 0 && MainTextBox.SelectedText.Equals(SearchText.Text, comparisonType))
            {
                MainTextBox.SelectedText = ReplaceText.Text;
            }
            FindNextClick(sender, e);
        }

        //모두 바꾸기
        private void ReplaceAllClcik(object sender, EventArgs e)
        {
            string searchText = SearchText.Text;
            string replaceText = ReplaceText.Text;
            StringComparison comparisonType = CaseTextCheckBox.Checked ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;
            int currentIndex = 0;
            while ((currentIndex = MainTextBox.Text.IndexOf(searchText, currentIndex, comparisonType)) != -1)
            {
                MainTextBox.Select(currentIndex, searchText.Length);
                MainTextBox.SelectedText = replaceText;
                currentIndex += replaceText.Length;
            }

            MainTextBox.Focus();
        }

        //취소
        private void CancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

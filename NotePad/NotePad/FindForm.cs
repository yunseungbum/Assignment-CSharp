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
    public partial class FindDialog : System.Windows.Forms.Form
    {
        private TextBox MainTextBox;

        public FindDialog(TextBox textBox)
        {
            InitializeComponent();
            MainTextBox = textBox;
        }

        //다음찾기
        private void FindNextClick(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text;
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
                MessageBox.Show("텍스트를 찾을 수 없습니다.", "찾기", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchTextBox.Focus();
            }
        }

        //취소
        private void CancelClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Lotto : Form
    {
        private List<string> History = new List<string>();

        public Lotto()
        {
            InitializeComponent();
        }

        private void LottoNumButton_Click(object sender, EventArgs e)
        {
            List<int> lottoNumbers = GenerateLottoNum();
            string numbersText = string.Join("   ", lottoNumbers);
            listBox.Text = numbersText;
            History.Add(numbersText);
            listBox.Items.Add(numbersText);
        }
        private List<int> GenerateLottoNum()
        {
            Random random = new Random();   
            //중복숫자가 안나오게 사용
            HashSet<int> numbers = new HashSet<int>();

            //for문 사용시 중복문자가 나오면 숫자 6개 출력이 안됨
            while (numbers.Count < 6)
            {
                numbers.Add(random.Next(1, 46));
            }

            List<int> sortedNumbers = numbers.ToList();
            sortedNumbers.Sort();

            return sortedNumbers;
        }
    }
}

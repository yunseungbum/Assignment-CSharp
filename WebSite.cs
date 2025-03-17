using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

/* await: 비동기 작업을 시작하고 완료할때까지 기다림
 * SendKey.send: 키보드 입력을 시뮬레이션하는 함수, 특정 킬 입력을 자동으로 실행시켜줌 
  */


namespace website
{
    public partial class Form1 : Form
    {
        private ChromiumWebBrowser Browser;
        public Form1()
        {
            InitializeComponent();
            InitializeBrowser();
        }

        #region 이벤트
        //새로고침
        private void RenewClick(object sender, EventArgs e)
        {
            Browser.Reload();
            HideDataGridView();
        }

        //앞으로
        private void FrontClick(object sender, EventArgs e)
        {
            Browser.Forward();
            HideDataGridView();
        }

        //뒤로
        private void BackClick(object sender, EventArgs e)
        {
            Browser.Back();
            HideDataGridView();
        }

        //홈으로
        private void MainPageButtonClick(object sender, EventArgs e)
        {
            Browser.Load("https://www.daum.net");
            HideDataGridView();
        }

        //다음 로그인
        private void DaumLoginClick(object sender, EventArgs e)
        {
            HideDataGridView();
            CheckLoginDaum();
        }


        //쿠팡 로그인
        private void CoupangLoginClick(object sender, EventArgs e)
        {
            HideDataGridView();
            CheckLoginCoupang();
        }


        //다음 메일
        private async void DaumMailClick(object sender, EventArgs e)
        {
            Browser.Load("https://mail.daum.net/");
            await Task.Delay(1000);
            if (Browser.Address.Contains("accounts.kakao.com/login"))
            {
                DaumLoginClick(sender, e);
                Browser.Load("https://mail.daum.net/");
                await Task.Delay(3000);

            }
            DataGridView.Visible = true;
            LoadDaumMail();
        }

        //주소 검색
        private void TextUrl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GoToUrl();
                e.SuppressKeyPress = true;
            }
        }

        //브라우저 주소 변경
        private void BrowserAddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new Action(delegate{UrlText.Text = e.Address;}));
        }
        #endregion



        #region 메서드

        //쿠팡로그인 메서드
        private async void CheckLoginCoupang()
        {
            Browser.Load("https://login.coupang.com/login/login.pang?rtnUrl=https%3A%2F%2Fmc.coupang.com%2Fssr%2Fdesktop%2Forder%2Flist");

            await Task.Delay(1000);

            string script = @"
                document.querySelector('input[id=""login-email-input""]').value = 'yourId';
                document.querySelector('input[type=""password""]').value = 'yourPwd';
                document.querySelector('button[type=""submit""]').click();";
            await Browser.EvaluateScriptAsync(script);
        }


        //다음로그인 메서드
        private async void CheckLoginDaum()
        {

            string checkLoginScript = @"
                (function() {
                    return document.querySelector('.btn_logout') !== null;
                })();";
            var scriptResult = await Browser.EvaluateScriptAsync(checkLoginScript);


            if (scriptResult.Success && scriptResult.Result is bool isLoggedIn && isLoggedIn)
            {
                Browser.Load("https://www.daum.net");
            }
            else
            {
                string id = "yourId";
                string pwd = "yourPwd";

                splitContainer1.Panel2.Focus();
                Browser.Load("https://accounts.kakao.com/login/simple/?continue=https%3A%2F%2Fwww.daum.net&talk_login=#simpleLogin");

                await Task.Delay(1000);
                string login = "{TAB}{TAB}" + id + "{TAB}{TAB}" + pwd + "{TAB}{TAB}{TAB}{TAB}{ENTER}";
                SendKeys.Send(login);
            }
        }


        //TextBox에 입력된 값 추출
        private void GoToUrl()
        {
            string url = UrlText.Text.Trim();
              
                if (!url.Contains("https://") && !url.Contains("http://"))
                {
                    url = "http://" + url;
                }

                Browser.Load(url);
            
        }


        //그리드뷰 비활성화
        private void HideDataGridView()
        {
            DataGridView.Visible = false;
        }


        //실행시 메인 화면(다음)
        private void InitializeBrowser()
        {
            Cef.Initialize(new CefSettings());

            Browser = new ChromiumWebBrowser("https://www.daum.net")
            {
                Dock = DockStyle.Fill
            };

            Browser.AddressChanged += BrowserAddressChanged;
            splitContainer1.Panel2.Controls.Add(Browser);
            
        }

       
        //메일함 데이터 불러오기
        private async void LoadDaumMail()
        {
            Browser.Load("https://mail.daum.net/");
            await Task.Delay(1000); 

            string script = @"
                let emails = document.querySelectorAll('.list_mail li');
                let data = [];

                 for (let mail of emails) {
                    let sender = mail.querySelector('.link_from')?.innerText.trim();
                    let subject = mail.querySelector('.tit_subject')?.innerText.trim();
                    let date = mail.querySelector('.txt_date')?.innerText.trim();

                    data.push([sender, subject, date]); 
                   }
                    data;
                    ";

            var response = await Browser.EvaluateScriptAsync(script);

            if (response.Success && response.Result is List<object> mailList)
            {
                DataGridView.Rows.Clear();

                foreach (var item in mailList)
                {
                    var mail = item as List<object>;
                    DataGridView.Rows.Add(mail[0], mail[1], mail[2]);
                }
            }
        }
        #endregion

   
    }
}

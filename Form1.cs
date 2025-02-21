using CefSharp;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;



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
        }

        //앞으로
        private void FrontClick(object sender, EventArgs e)
        {
           Browser.Forward();
        }

        //뒤로
        private void BackClick(object sender, EventArgs e)
        {
            Browser.Back();
        }

        //다음 로그인
        private async void DaumLoginClick(object sender, EventArgs e)
        {
            string id = "ibm1544@naver.com";
            string pwd = "kimjs5248@";

            splitContainer1.Panel2.Focus();
            Browser.Load("https://accounts.kakao.com/login/simple/?continue=https%3A%2F%2Fwww.daum.net&talk_login=#simpleLogin");
            await Task.Delay(1000);
            string login = "{TAB}{TAB}" + id + "{TAB}{TAB}" + pwd + "{TAB}{TAB}{TAB}{TAB}{ENTER}";
            SendKeys.Send(login);
        }

        //쿠팡 로그인
        private async void CoupangLoginClick(object sender, EventArgs e)
        {
            Browser.Load("https://login.coupang.com/login/login.pang?rtnUrl=https%3A%2F%2Fmc.coupang.com%2Fssr%2Fdesktop%2Forder%2Flist");

            await Task.Delay(1000);

            string script = @"
                document.querySelector('input[id=""login-email-input""]').value = 'ibm1544@naver.com';
                document.querySelector('input[type=""password""]').value = 'kimjs5248@';
                document.querySelector('button[type=""submit""]').click();";
            await Browser.EvaluateScriptAsync(script);
        }

        //다음 메일
        private void DaumMailClick(object sender, EventArgs e)
        {

        }

        #endregion


        #region 메서드
        //실행시 메인 화면(다음)
        private void InitializeBrowser()
        {
            Cef.Initialize(new CefSettings());

            Browser = new ChromiumWebBrowser("https://www.daum.net")
            {
                //빈 공간 없이 꽉 차도록 크기 설정
                Dock = DockStyle.Fill
            };
            UrlText.Text = Browser.Address;
            splitContainer1.Panel2.Controls.Add(Browser);
        }
        #endregion


    }
}

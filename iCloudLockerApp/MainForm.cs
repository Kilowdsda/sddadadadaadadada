using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace iCloudLockerApp
{
    public partial class MainForm : Form
    {
        private IWebDriver? driver;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            await LoginAsync(txtLogin.Text, txtPassword.Text);
            btnLogin.Enabled = true;
        }

        private async Task LoginAsync(string login, string password)
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("https://www.icloud.com/find/");
            await Task.Delay(4000);

            var loginBox = driver.FindElement(By.CssSelector("input[id='appleId']"));
            loginBox.SendKeys(login);
            var loginNext = driver.FindElement(By.CssSelector("button[type='submit']"));
            loginNext.Click();

            await Task.Delay(4000);
            var passBox = driver.FindElement(By.CssSelector("input[id='password']"));
            passBox.SendKeys(password);
            var passNext = driver.FindElement(By.CssSelector("button[type='submit']"));
            passNext.Click();
        }

        private async void btnLock_Click(object sender, EventArgs e)
        {
            if (lstDevices.SelectedItem is string device)
            {
                await LockDeviceAsync(device);
            }
        }

        private Task LockDeviceAsync(string deviceName)
        {
            if (driver == null) return Task.CompletedTask;
            // TODO: implement device locking sequence using Selenium
            return Task.CompletedTask;
        }

        private void chkAutoLock_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: implement autolock toggle
        }
    }
}

using System.Windows.Forms;

namespace iCloudLockerApp
{
    partial class MainForm
    {
        private TabControl tabs;
        private TabPage tabLogin;
        private TabPage tabLocker;
        private TabPage tabMisc;

        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;

        private ListBox lstDevices;
        private Button btnLock;
        private CheckBox chkAutoLock;
        private TextBox txtLockMessage;
        private Label lblLockMessage;

        private Button btnTelegram;
        private Button btnDiscord;
        private Button btnSupport;

        private void InitializeComponent()
        {
            tabs = new TabControl();
            tabLogin = new TabPage();
            tabLocker = new TabPage();
            tabMisc = new TabPage();

            // TabControl
            tabs.Dock = DockStyle.Fill;
            tabs.Controls.Add(tabLogin);
            tabs.Controls.Add(tabLocker);
            tabs.Controls.Add(tabMisc);

            // Login tab
            tabLogin.Text = "iCloud Login";
            txtLogin = new TextBox { PlaceholderText = "Login", Top = 20, Left = 20, Width = 200 };
            txtPassword = new TextBox { PlaceholderText = "Password", Top = 60, Left = 20, Width = 200, UseSystemPasswordChar = true };
            btnLogin = new Button { Text = "Login", Top = 100, Left = 20, Width = 200 };
            btnLogin.Click += btnLogin_Click;
            tabLogin.Controls.Add(txtLogin);
            tabLogin.Controls.Add(txtPassword);
            tabLogin.Controls.Add(btnLogin);

            // Locker tab
            tabLocker.Text = "iPhone Locker";
            lstDevices = new ListBox { Top = 20, Left = 20, Width = 200, Height = 150 };
            btnLock = new Button { Text = "Lock", Top = 180, Left = 20, Width = 200 };
            chkAutoLock = new CheckBox { Text = "AutoLock", Top = 220, Left = 20 };
            lblLockMessage = new Label { Text = "Text for lock iPhone", Top = 250, Left = 20, Width = 200 };
            txtLockMessage = new TextBox { Top = 270, Left = 20, Width = 200 };
            btnLock.Click += btnLock_Click;
            chkAutoLock.CheckedChanged += chkAutoLock_CheckedChanged;
            tabLocker.Controls.Add(lstDevices);
            tabLocker.Controls.Add(btnLock);
            tabLocker.Controls.Add(chkAutoLock);
            tabLocker.Controls.Add(lblLockMessage);
            tabLocker.Controls.Add(txtLockMessage);

            // Misc tab
            tabMisc.Text = "Misc";
            btnTelegram = new Button { Text = "Telegram", Top = 20, Left = 20, Width = 200 };
            btnDiscord = new Button { Text = "Discord", Top = 60, Left = 20, Width = 200 };
            btnSupport = new Button { Text = "Support", Top = 100, Left = 20, Width = 200 };
            tabMisc.Controls.AddRange(new Control[] { btnTelegram, btnDiscord, btnSupport });

            // MainForm
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 350);
            Controls.Add(tabs);
            Text = "iCloud Locker";
        }
    }
}

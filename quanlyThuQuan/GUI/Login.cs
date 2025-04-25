using quanlyThuQuan.BUS;
using quanlyThuQuan.DTO;

namespace quanlyThuQuan.GUI
{
    public partial class Login : Form
    {
        public static bool isAuthenticated = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            if (Properties.Settings.Default.RememberMe)
            {
                txtUsername.Text = Properties.Settings.Default.SavedUsername;
                txtPassword.Text = Properties.Settings.Default.SavedPassword;
                chkRemember.Checked = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            AccountBUS bus = new AccountBUS();
            string error;
            AccountDTO account;

            if (bus.DangNhap(username, password, out account, out error))
            {
                // ✅ Ghi nhớ nếu người dùng check
                if (chkRemember.Checked)
                {
                    Properties.Settings.Default.SavedUsername = username;
                    Properties.Settings.Default.SavedPassword = password;
                    Properties.Settings.Default.RememberMe = true;
                }
                else
                {
                    Properties.Settings.Default.SavedUsername = "";
                    Properties.Settings.Default.SavedPassword = "";
                    Properties.Settings.Default.RememberMe = false;
                }
                Properties.Settings.Default.Save();

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Gọi MainForm
                this.Hide();
                MainForm main = new MainForm();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
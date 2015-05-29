using System;
using System.Windows.Forms;

namespace PostClient.UI
{
    public partial class AuthWindow : Form
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //using (var Client = new Pop3Client("pop.gmail.com", 995,
             //loginTextBox.Text, passwordTextBox.Text, AuthMethod.Login, true))
                {
                    Credentials.Email = loginTextBox.Text;
                    Credentials.Password = passwordTextBox.Text;
                }
                this.Hide();
                var mainWindow = new MainWindow();
                mainWindow.Closed += (s, args) => this.Close();
                mainWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
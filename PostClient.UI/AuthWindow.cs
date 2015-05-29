using System;
using System.Windows.Forms;
using OpenPop.Pop3;

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
                // The client disconnects from the server when being disposed
                using (var client = new Pop3Client())
                {
                    // Connect to the server
                    client.Connect("pop.gmail.com", 995, true);

                    Credentials.Email = loginTextBox.Text;
                    Credentials.Password = passwordTextBox.Text;

                    // Authenticate ourselves towards the server
                    client.Authenticate(Credentials.Email, Credentials.Password);
                }
                Hide();
                var mainWindow = new MainWindow();
                mainWindow.Closed += (s, args) => Close();
                mainWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
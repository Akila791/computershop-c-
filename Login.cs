using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;

namespace Techfix_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click_1(object sender, EventArgs e)
        {

            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                errorLbl.Text = "Please enter both username and password.";
                return;
            }

            var loginRequest = new
            {
                Username = username,
                Password = password
            };

            var jsonContent = JsonConvert.SerializeObject(loginRequest);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.PostAsync("https://localhost:7070/TechFix_API/Login", content);

                    if (response.IsSuccessStatusCode)
                    {
                        errorLbl.Text = "Login successful!";

                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        errorLbl.Text = "Login failed. Please check your credentials.";
                    }
                }
                catch (Exception ex)
                {
                    errorLbl.Text = "Error: " + ex.Message;
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void errorLbl_Click(object sender, EventArgs e)
        {

        }
    }
}

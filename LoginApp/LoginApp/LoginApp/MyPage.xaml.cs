using System;
using System.Collections.Generic;
 
using Xamarin.Forms;
 
namespace XamarinLoginApp
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            // Hardcoded username and password
            string validUsername = "admin";
            string validPassword = "admin";

            if (username == validUsername && password == validPassword)
            {
                // Display login success alert
                DisplayAlert("Login Success", "", "OK");
            }
            else
            {
                // Display login failed alert
                DisplayAlert("Login Failed", "", "Try Again");
            }
        }

    }
}
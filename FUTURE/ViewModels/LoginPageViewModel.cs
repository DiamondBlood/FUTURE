using DAL3.Models;
using FUTURE.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FUTURE.ViewModels
{
    internal class LoginPageViewModel
    {
        public async void LogIn(string login)
        {
            var user = new UserData();
            user.Mail = login;
            if (user != null)
            {
                Preferences.Set("user_name", user.Mail);
                Application.Current.MainPage = new AppShell();
            }
            else
                throw new Exception();
        }
    }
}

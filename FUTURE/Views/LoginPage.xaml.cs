using FUTURE.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FUTURE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private LoginPageViewModel vm = new LoginPageViewModel();
        public LoginPage()
        {
            this.BindingContext = vm;
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
        private void LogIn_Tapped(object sender, EventArgs e)
        {
            vm.LogIn(Mail.Text);
            Mail.Text = "";
        }
    }
}
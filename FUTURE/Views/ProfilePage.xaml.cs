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
    public partial class ProfilePage : ContentPage
    {
        UserDataViewModel vm = new UserDataViewModel();
        public ProfilePage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            this.BindingContext = vm;
        }
    }
}
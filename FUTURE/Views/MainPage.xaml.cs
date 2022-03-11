using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FUTURE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            
        }

        private async void MuscleUpTrainingNavigate(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.MuscleUpGoalsPage());
        }
    }
}

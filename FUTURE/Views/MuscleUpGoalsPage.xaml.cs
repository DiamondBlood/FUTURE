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
    public partial class MuscleUpGoalsPage : TabbedPage
    {
        public MuscleUpGoalsPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void Day1StartWorkout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Exercises.BrenchPress());
        }

        private async void Day3StartWorkout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Exercises.PullUp());
        }

        private async void Day5StartWorkout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Exercises.SitUp());
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
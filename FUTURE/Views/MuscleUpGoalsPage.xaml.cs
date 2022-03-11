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
    public partial class MuscleUpGoalsPage : ContentPage
    {
        public MuscleUpGoalsPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void StartWorkout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Exercises.BrenchPress());
        }
    }
}
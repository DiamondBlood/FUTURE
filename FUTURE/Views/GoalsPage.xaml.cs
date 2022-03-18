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
    public partial class GoalsPage : ContentPage
    {
        public GoalsPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
       /* private async void MuscleUpTrainingNavigate(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.MuscleUpGoalsPage());
        }*/

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.MuscleUpWorkout());
        }
    }
}
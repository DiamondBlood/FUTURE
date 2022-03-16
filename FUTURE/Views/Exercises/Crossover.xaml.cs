using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FUTURE.Views.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Crossover : ContentPage
    {
        public Crossover()
        {
            InitializeComponent();
        }
        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MuscleUpGoalsPage());
        }

        private void Ok1(object sender, EventArgs e)
        {
            OkImage1.IsVisible = true;
        }
        private void Ok2(object sender, EventArgs e)
        {
            OkImage2.IsVisible = true;
        }
        private void Ok3(object sender, EventArgs e)
        {
            OkImage3.IsVisible = true;
        }
        private void Ok4(object sender, EventArgs e)
        {
            OkImage4.IsVisible = true;
        }

        private async void NextExercise(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Crossover());
        }
    }
}
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
    public partial class DumbbellDenchpress : ContentPage
    {
        public DumbbellDenchpress()
        {
            InitializeComponent();
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MuscleUpGoalsPage());
        }

        private void Ok1(object sender, EventArgs e)
        {
            if (OkImage1.IsVisible == false)
                OkImage1.IsVisible = true;
            else
                OkImage1.IsVisible = false;
        }
        private void Ok2(object sender, EventArgs e)
        {
            if (OkImage2.IsVisible == false)
                OkImage2.IsVisible = true;
            else
                OkImage2.IsVisible = false;
        }
        private void Ok3(object sender, EventArgs e)
        {
            if (OkImage3.IsVisible == false)
                OkImage3.IsVisible = true;
            else
                OkImage3.IsVisible = false;
        }
        private void Ok4(object sender, EventArgs e)
        {
            if (OkImage4.IsVisible == false)
                OkImage4.IsVisible = true;
            else
                OkImage4.IsVisible = false;
        }

        private async void NextExercise(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Crossover());
        }
    }
}
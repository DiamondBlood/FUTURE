using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YoutubeExplode.Videos.Streams;

namespace FUTURE.Views.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrenchPress : ContentPage
    {
        public BrenchPress()
        {
            InitializeComponent();
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MuscleUpGoalsPage());
        }
    }
}
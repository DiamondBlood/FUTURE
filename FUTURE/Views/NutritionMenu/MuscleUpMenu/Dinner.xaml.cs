using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FUTURE.Views.NutritionMenu.MuscleUpMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dinner : ContentPage
    {
        public Dinner()
        {
            InitializeComponent();
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
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
    public partial class NutritionPage : TabbedPage
    {
        public NutritionPage()
        {
            InitializeComponent();
        }
        #region MuscleUpNutritionNavigation
        private async void MUBreakfast(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Breakfast());
        }
        private async void MUSnack(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Snack());
        }
        private async void MULunch(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Lunch());
        }
        private async void MUPoldnik(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Poldnik());
        }
        private async void MUDinner(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Dinner());
        }
        #endregion

        #region ReliefNutritionNvigation
        private async void SBreakfast(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Breakfast());
        }
        private async void SSnack(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Snack());
        }
        private async void SLunch(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Lunch());
        }
        private async void SPoldnik(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Poldnik());
        }
        private async void SDinner(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Dinner());
        }

        #endregion

        #region FatDownNutritionNavigation
        private async void XBreakfast(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Breakfast());
        }
        private async void XSnack(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Snack());
        }
        private async void XLunch(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Lunch());
        }
        private async void XPoldnik(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Poldnik());
        }
        private async void XDinner(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NutritionMenu.MuscleUpMenu.Dinner());
        }
        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEtecflix.categorias;
using Xamarin.Forms;

namespace AppEtecflix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("AppEtecflix.imgs.logo.png");

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Aventura_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Aventura());

            } catch(Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void Button_Comedia_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Comedia());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void Button_Drama_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Drama());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void Button_Terror_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Terror());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}

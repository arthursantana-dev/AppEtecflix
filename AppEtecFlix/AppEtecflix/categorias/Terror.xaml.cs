using AppEtecflix.paginas_filmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtecflix.categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Terror : ContentPage
    {
        public Terror()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecflix.imgs.etecflix.logo.png");

            btnCorra.Source = ImageSource.FromResource("AppEtecflix.imgposters.corra.jpg");
            btnFriday13th.Source = ImageSource.FromResource("AppEtecflix.imgposters.friday13th.jpg");
            btnIt.Source = ImageSource.FromResource("AppEtecflix.imgposters.it.jpg");

        }

        private async void btnCorra_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new corra());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro... ", ex.Message, "Ok");
            }
        }

        private async void btnIt_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new it());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro... ", ex.Message, "Ok");
            }
        }

        private async void btnFriday13th_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new friday_13th());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro... ", ex.Message, "Ok");
            }
        }
    }
}
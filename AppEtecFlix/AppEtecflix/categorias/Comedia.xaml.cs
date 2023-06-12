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
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecflix.imgs.etecflix.logo.png");

            btnGatoDeBotas.Source = ImageSource.FromResource("AppEtecflix.imgposters.gatobotas.jpg");
            btnShrek.Source = ImageSource.FromResource("AppEtecflix.imgposters.shrek.jpg");
            btnUp.Source = ImageSource.FromResource("AppEtecflix.imgposters.up.jpg");

        }

        private async void btnGatoDeBotas_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new gato_de_botas());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro... ", ex.Message, "Ok");
            }
        }

        private async void btnShrek_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new shrek());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro... ", ex.Message, "Ok");
            }
        }

        private async void btnUp_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new up());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro... ", ex.Message, "Ok");
            }
        }
    }
}
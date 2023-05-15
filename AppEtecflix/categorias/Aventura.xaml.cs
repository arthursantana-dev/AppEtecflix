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
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecflix.imgs.etecflix.logo.png");

            btnCirculoDeFogo.Source = ImageSource.FromResource("AppEtecflix.img-posters.circulodefogo.jpg");
            btnCreedIII.Source = ImageSource.FromResource("AppEtecflix.img-posters.creed3.jpg");
            btnInterestelar.Source = ImageSource.FromResource("AppEtecflix.img-posters.interestelar.jpg");


        }

        private async void btnCirculoDeFogo_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new circulo_de_fogo());
            } catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro... ", ex.Message, "Ok");
            }
        }

        private async void btnCreedIII_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new creed_iii());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro... ", ex.Message, "Ok");
            }
        }

        private async void btnInterestelar_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new interestelar());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro... ", ex.Message, "Ok");
            }
        }

    }
}
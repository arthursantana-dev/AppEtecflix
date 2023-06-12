using AppEtecflix.paginas_filmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtecflix.categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Drama : ContentPage
    {
        public Drama()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.imgs.etecflix.logo.png");

            btnAProcuraDaFelicidade.Source = ImageSource.FromResource("AppEtecflix.imgposters.aprocurafelicidade.jpg");
            btnNadaDeNovoNoFront.Source = ImageSource.FromResource("AppEtecflix.imgposters.nadanovofront.jpg");
            btnOJogoDaImitacao.Source = ImageSource.FromResource("AppEtecflix.imgposters.jogoimitação.jpg");

        }

        private async void btnAProcuraDaFelicidade_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new a_procura_da_felicidade());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro... ", ex.Message, "Ok");
            }
        }

        private async void btnOJogoDaImitacao_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new o_jogo_da_imitacao());
            } catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro... ", ex.Message, "Ok");
            }
        }

        private async void btnNadaDeNovoNoFront_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new nadadenovonofront());
            } catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro... ", ex.Message, "Ok");
            }
        }
    }
}
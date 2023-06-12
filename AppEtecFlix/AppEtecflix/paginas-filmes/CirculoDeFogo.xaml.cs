using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtecflix.paginas_filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class circulo_de_fogo : ContentPage
    {
        public circulo_de_fogo()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppEtecflix.imgs.logo.png");
            poster.Source = ImageSource.FromResource("AppEtecflix.imgposters.circulodefogo.jpg");
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' src='https://www.youtube.com/embed/R7J3RJcxv58?controls=0' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            //visualizador.Source = htmlSource;
            sinopse.Text = "Criaturas monstruosas conhecidas como Kaiju começam a emergir do mar. Para combatê-los, a humanidade desenvolve uma série de robôs gigantescos, os Jaegers. Cada um é controlado por duas pessoas por meio de uma conexão neural. Entretanto, mesmo os Jaegers se mostram insuficientes para derrotar os Kaiju. Diante deste cenário, a última esperança é um velho robô, que passa a ser comandado por um antigo piloto e uma pessoa em treinamento.";
        }
    }
}
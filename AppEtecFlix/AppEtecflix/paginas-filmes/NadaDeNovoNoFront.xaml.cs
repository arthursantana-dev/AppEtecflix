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
    public partial class nadadenovonofront : ContentPage
    {
        public nadadenovonofront()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppEtecflix.imgs.logo.png");
            poster.Source = ImageSource.FromResource("AppEtecflix.imgposters.nadanovofront.jpg");
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300' frameborder='0' src='https://www.youtube.com/embed/vwbySrsD7RU?controls=0' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            //visualizador.Source = htmlSource;
            sinopse.Text = "O adolescente Paul é convocado para atuar na linha de frente da Primeira Guerra Mundial. O jovem começa seu serviço militar de forma idealista e entusiasmada, mas logo é confrontado pela dura realidade do combate.";
        }
    }
}
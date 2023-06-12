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
    public partial class friday_13th : ContentPage
    {
        public friday_13th()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppEtecflix.imgs.logo.png");
            poster.Source = ImageSource.FromResource("AppEtecflix.imgposters.friday13th.jpg");
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300' frameborder='0' src='https://www.youtube.com/embed/cCfO1aB8CIE?controls=0' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            //visualizador.Source = htmlSource;
            sinopse.Text = "A história de um antigo homicídio em Crystal Lake não impede que alguns jovens montem um acampamento de verão no bosque. Moradores supersticiosos advertem sobre o ocorrido, mas os instrutores Jack, Alice, Bill, Marcie e Ned prestam pouca atenção aos mais velhos e acabam sendo perseguidos por um assassino brutal.";
        }
    }
}
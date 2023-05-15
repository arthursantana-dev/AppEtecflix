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

            logo.Source = ImageSource.FromResource("AppEtecFlix.imgs.etecflix.logo.png");

            btnCorra.Source = ImageSource.FromResource("AppEtecFlix.img-posters.corra.jpg");
            btnFriday13th.Source = ImageSource.FromResource("AppEtecFlix.img-posters.friday13th.jpg");
            btnIt.Source = ImageSource.FromResource("AppEtecFlix.img-posters.it.jpg");

        }

        private void btnCorra_Clicked(object sender, EventArgs e)
        {

        }

        private void btnIt_Clicked(object sender, EventArgs e)
        {

        }

        private void btnFriday13th_Clicked(object sender, EventArgs e)
        {

        }
    }
}
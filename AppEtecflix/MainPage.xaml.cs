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

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_AventuraClicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Aventura());

            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}

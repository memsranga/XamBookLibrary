using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Booky.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookDetailPage : ContentPage
    {
        public BookDetailPage(string backgroundColor)
        {
            BackgroundColor = Color.FromHex(backgroundColor);
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // delay and translate the details
        }

        async void Handle_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}

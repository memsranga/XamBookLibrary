using System;
using XamBookLibrary.Models;
using XamBookLibrary.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;

namespace XamBookLibrary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Handle_ItemTapped(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count == 0)
            {
                return;
            }

            ((CollectionView)sender).SelectedItem = null;
            var selectedCover = (e.CurrentSelection?.First() as BookModel).Cover;
            var colorHelper = DependencyService.Get<IColorHelper>();
            var dominantColor = colorHelper.GetColor(selectedCover);
            await Navigation.PushModalAsync(new BookDetailPage(dominantColor), true);
        }
    }
}

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
            InitializeComponent();
        }
    }
}

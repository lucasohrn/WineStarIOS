using System.ComponentModel;
using WineStarIOS.ViewModels;
using Xamarin.Forms;

namespace WineStarIOS.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
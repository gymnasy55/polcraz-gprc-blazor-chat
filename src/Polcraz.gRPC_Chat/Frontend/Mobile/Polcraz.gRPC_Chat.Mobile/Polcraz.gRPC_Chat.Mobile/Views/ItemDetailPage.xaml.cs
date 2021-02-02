using Polcraz.gRPC_Chat.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Polcraz.gRPC_Chat.Mobile.Views
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
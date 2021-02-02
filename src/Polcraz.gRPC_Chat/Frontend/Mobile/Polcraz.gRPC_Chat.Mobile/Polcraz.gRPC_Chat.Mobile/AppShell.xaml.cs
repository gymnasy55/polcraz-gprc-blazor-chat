using Polcraz.gRPC_Chat.Mobile.ViewModels;
using Polcraz.gRPC_Chat.Mobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Polcraz.gRPC_Chat.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

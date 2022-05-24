using Phone_Program.ViewModels;
using Phone_Program.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Phone_Program
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

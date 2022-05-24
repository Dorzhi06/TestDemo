using Phone_Program.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Phone_Program.Views
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
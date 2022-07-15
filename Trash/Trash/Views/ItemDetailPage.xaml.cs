using System.ComponentModel;
using Trash.ViewModels;
using Xamarin.Forms;

namespace Trash.Views
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
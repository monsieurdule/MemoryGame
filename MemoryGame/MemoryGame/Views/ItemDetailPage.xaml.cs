using MemoryGame.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MemoryGame.Views
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
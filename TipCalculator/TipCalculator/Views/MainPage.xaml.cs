using TipCalculator.ViewModels;
using Xamarin.Forms;

namespace TipCalculator.Views
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _vm;

        public MainPage()
        {
            InitializeComponent();

            _vm = new MainPageViewModel();
            BindingContext = _vm;
        }
    }
}

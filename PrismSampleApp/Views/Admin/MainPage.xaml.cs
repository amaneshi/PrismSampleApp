using Prism.Navigation;
using Xamarin.Forms;

namespace PrismSampleApp.Views.Admin
{
    public partial class MainPage : FlyoutPage, IFlyoutPageOptions
    {
        public static readonly BindableProperty IsPresentedAfterNavigationProperty =
            BindableProperty.Create(nameof(IsPresentedAfterNavigation), typeof(bool), typeof(MainPage), false);

        public MainPage()
        {
            Title = "Flyout Page";
            InitializeComponent();
        }

        public bool IsPresentedAfterNavigation
        {
            get => (bool)GetValue(IsPresentedAfterNavigationProperty);
            set => SetValue(IsPresentedAfterNavigationProperty, value);
        }
    }
}
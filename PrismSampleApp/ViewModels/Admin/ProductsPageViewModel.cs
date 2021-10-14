using Prism.Navigation;
using System.Diagnostics;

namespace PrismSampleApp.ViewModels.Admin
{
    public class ProductsPageViewModel : ViewModelBase
    {
        public ProductsPageViewModel(
            INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Products Page";
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            // Navigated From, fired if change detail page, but quiet on navigate outside Flyout page
            Debug.WriteLine("OnNavigatedFrom Products Page fired!");
        }
    }
}

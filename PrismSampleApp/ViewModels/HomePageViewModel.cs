using Prism.Navigation;

namespace PrismSampleApp.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        public HomePageViewModel(
            INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Home Page";
        }
    }
}
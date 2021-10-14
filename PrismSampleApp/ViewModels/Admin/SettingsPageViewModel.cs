using Prism.Navigation;
using System.Diagnostics;

namespace PrismSampleApp.ViewModels.Admin
{
    public class SettingsPageViewModel : ViewModelBase
    {
        public SettingsPageViewModel(
             INavigationService navigationService) : base(navigationService)
        {
            Title = "Settings Page";
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            // Navigated From, fired if change detail page, but quiet on navigate outside Flyout page
            Debug.WriteLine("OnNavigatedFrom Settings Page fired!");
        }
    }
}
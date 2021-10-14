using Prism.Commands;
using Prism.Navigation;
using System.Diagnostics;

namespace PrismSampleApp.ViewModels.Admin
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand<string> NavigateCommand { get; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            NavigateCommand = new DelegateCommand<string>(NavigateCommandExecuted);
        }

        private async void NavigateCommandExecuted(string path)
        {
            await NavigationService.NavigateAsync($"NavigationPage/{path}");
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            // Navigated From, fired always
            Debug.WriteLine("OnNavigatedFrom Flyout Page fired!");
        }
    }
}

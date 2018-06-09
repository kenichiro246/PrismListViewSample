using Prism.Navigation;
using Prism.Services;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PrismListViewSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private List<string> _items;
        public Command<string> ItemSelectedCommand { get; }

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) 
            : base (navigationService)
        {
            Title = "Main Page";

            _items = new List<string>
            {
                "コラ・コーラ",
                "フェンタ",
                "アクエリオンロゴス",
                "ポカリスェット",
                "綾鷲",
            };
            ItemSelectedCommand = new Command<string>(async x =>
            {
                await pageDialogService.DisplayAlertAsync("MainPage", $"Select Item : {x}", "OK");
            });
        }

        public List<string> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }
    }
}

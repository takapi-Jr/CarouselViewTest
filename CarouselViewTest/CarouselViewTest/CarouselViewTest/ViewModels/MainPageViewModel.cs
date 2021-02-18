using CarouselViewTest.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarouselViewTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private DelegateCommand nextCommand;
        public DelegateCommand NextCommand =>
            nextCommand ?? (nextCommand = new DelegateCommand(async () => await ExecuteNextCommand()));

        async Task ExecuteNextCommand()
        {
            await this.NavigationService.NavigateAsync("NextPage");
        }

        private List<Item> ngItems = new List<Item>()
        {
            new Item { Name = "NG_test1", Color = Xamarin.Forms.Color.Red },
            new Item { Name = "NG_test2", Color = Xamarin.Forms.Color.Blue },
            new Item { Name = "NG_test3", Color = Xamarin.Forms.Color.Green },
        };
        public List<Item> NgItems
        {
            get { return ngItems; }
            set { SetProperty(ref ngItems, value); }
        }

        private List<Item> okItems = new List<Item>()
        {
            new Item { Name = "OK_test1", Color = Xamarin.Forms.Color.Red },
            new Item { Name = "OK_test2", Color = Xamarin.Forms.Color.Blue },
            new Item { Name = "OK_test3", Color = Xamarin.Forms.Color.Green },
        };
        public List<Item> OkItems
        {
            get { return okItems; }
            set { SetProperty(ref okItems, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}

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

        private List<Item> items = new List<Item>()
        {
            new Item { Name = "test1", Color = Xamarin.Forms.Color.Red },
            new Item { Name = "test2", Color = Xamarin.Forms.Color.Blue },
            new Item { Name = "test3", Color = Xamarin.Forms.Color.Green },
        };
        public List<Item> Items
        {
            get { return items; }
            set { SetProperty(ref items, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}

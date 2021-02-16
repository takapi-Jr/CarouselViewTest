using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarouselViewTest.ViewModels
{
    public class NextPageViewModel : ViewModelBase
    {
        public NextPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Next Page";
        }
    }
}

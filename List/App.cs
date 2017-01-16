using List.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace List
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterSingleton(new MvxAppStart<CardsListViewModel>());
        }
    }
}
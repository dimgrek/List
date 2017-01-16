using MvvmCross.Core.ViewModels;

namespace List.ViewModels
{
    public class CardsListViewModel : MvxViewModel
    {
        private string _hello;

        public string Hello
        {
            get { return _hello; }
            set
            {
                _hello = value;
                RaisePropertyChanged(() => Hello);
            }
        }

        public override void Start()
        {
            base.Start();
            Hello = "hello from vm";
        }
    }
}
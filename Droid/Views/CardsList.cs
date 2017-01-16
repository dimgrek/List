using Android.App;
using List.ViewModels;
using MvvmCross.Droid.Views;

namespace List.Droid.Views
{
    [Activity(Label = "List", MainLauncher = true)]
    public class CardsList : MvxActivity
    {
        public new CardsListViewModel ViewModel
        {
            get { return (CardsListViewModel) base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.CardsList);
        }
    }
}
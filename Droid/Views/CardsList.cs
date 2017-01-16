using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace List.Droid.Views
{
    [Activity(Label = "List", MainLauncher = true)]
    public class CardsList : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CardsList);

        }

        //public new CardsListViewModel ViewModel
        //{
        //    get { return (CardsListViewModel) base.ViewModel; }
        //    set { base.ViewModel = value; }
        //}

        //protected override void OnViewModelSet()
        //{
        //    SetContentView(Resource.Layout.CardsList);
        //}
    }
}
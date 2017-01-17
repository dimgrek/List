using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace List.Droid.Views
{
    [Activity(Label = "List")]
    public class CardsList : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CardsList);

            //var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            //Toolbar will now take on default Action Bar characteristics
            //SetSu(toolbar);
            //You can now use and reference the ActionBar
            ActionBar.Title = "Hello from Toolbar";
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
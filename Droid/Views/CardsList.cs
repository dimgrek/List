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
    }
}
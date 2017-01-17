using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace List.Droid.Views
{
    [Activity(Label = "Add Ticket", MainLauncher = true)]
    public class AddTicket : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.AddTicket);
        }
    }
}
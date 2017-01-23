using Android.App;
using Android.OS;
using List.ViewModels;
using MvvmCross.Droid.Views;

namespace List.Droid.Views
{
    [Activity(Label = "List", MainLauncher = true)]
    public class TicketsList : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TicketsList);
        }

        protected override void OnResume()
        {
            base.OnResume();
            (ViewModel as TicketsListViewModel).RefreshTicketsCommand.Execute(null);
        }
    }
}
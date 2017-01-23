using System;

using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using List.ViewModels;
using MvvmCross.Binding.iOS.Views;
using System.Drawing;
using Foundation;
using System.Windows.Input;

namespace List.iOS
{
	public partial class TicketsList : MvxViewController
	{
		private UIBarButtonItem _addButton;
		private MvxSimpleTableViewSource _source;
		private ICommand Reload;

		public TicketsList() : base("TicketsList", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			SetupNavigationBar();
			SetupTicketsTableView();


			var set = this.CreateBindingSet<TicketsList, TicketsListViewModel>();
			set.Bind(_addButton).To(vm => vm.AddCommand);
			set.Bind(SearchBar).For(sb => sb.Text).To(vm => vm.Search);
			set.Bind(_source).To(vm => vm.FilteredList);
			//set.Bind(Reload).To(vm=>vm.LoadTicketsCommand);

			set.Apply();
		}

		void SetupTicketsTableView()
		{
			TicketsListTableView.RowHeight = UITableView.AutomaticDimension;
			_source = new MvxSimpleTableViewSource(TicketsListTableView, new NSString("TicketCell"));
			TicketsListTableView.Source = _source;
			TicketsListTableView.EstimatedRowHeight = 40f;
		}

		void SetupNavigationBar()
		{
			Title = "Tickets List";
			_addButton = new UIBarButtonItem(UIBarButtonSystemItem.Add);
			_addButton.TintColor = UIColor.Blue;
			NavigationItem.SetRightBarButtonItem(_addButton, false);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			(ViewModel as TicketsListViewModel).RefreshTicketsCommand.Execute(null);
		}
	}
}


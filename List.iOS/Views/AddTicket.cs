using System;

using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using List.ViewModels;

namespace List.iOS
{
	public partial class AddTicket : MvxViewController
	{
		public AddTicket() : base("AddTicket", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			Title = "Add Ticket";

			var set = this.CreateBindingSet<AddTicket, AddTicketViewModel>();
			set.Bind(ProblemName).To(vm=>vm.ProblemName);
			set.Bind(TopButton).To(vm=>vm.TopCommand);
			set.Bind(MediumButton).To(vm=>vm.MediumCommand);
			set.Bind(LowButton).To(vm=>vm.LowCommand);
			set.Bind(TopIndicator).For(x=>x.Hidden).To(vm=>vm.IsPriorityTop).WithConversion("InvertedBoolean");
			set.Bind(MediumIndicator).For(x=>x.Hidden).To(vm=>vm.IsPriorityMedium).WithConversion("InvertedBoolean");
			set.Bind(LowIndicator).For(x=>x.Hidden).To(vm=>vm.IsPriorityLow).WithConversion("InvertedBoolean");
			set.Bind(SaveButton).To(vm=>vm.SaveCommand);
			set.Apply();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


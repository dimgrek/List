using System;

using Foundation;
using UIKit;
using MvvmCross.Binding.BindingContext;
using List.Models;
using MvvmCross.Binding.iOS.Views;

namespace List.iOS
{
	public partial class TicketCell : MvxTableViewCell
	{
		public static readonly NSString Key = new NSString("TicketCell");
		public static readonly UINib Nib;

		static TicketCell()
		{
			Nib = UINib.FromName("TicketCell", NSBundle.MainBundle);
		}

		protected TicketCell(IntPtr handle) : base(handle)
		{
			this.DelayBind(()=>{
				var set = this.CreateBindingSet<TicketCell, Ticket>();
				set.Bind(IdLabel).To(ticket=>ticket.ID);
				set.Bind(ProblemDescription).To(ticket=>ticket.ProblemName);
				set.Bind(PriorityIndicator).For(indicator=>indicator.BackgroundColor)
				   .To(ticket=>ticket.Priority).WithConversion("PriorityToColor");
				set.Apply();
			});
		}
	}
}

// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace List.iOS
{
	[Register ("TicketCell")]
	partial class TicketCell
	{
		[Outlet]
		UIKit.UILabel IdLabel { get; set; }

		[Outlet]
		UIKit.UIView PriorityIndicator { get; set; }

		[Outlet]
		UIKit.UILabel ProblemDescription { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (IdLabel != null) {
				IdLabel.Dispose ();
				IdLabel = null;
			}

			if (PriorityIndicator != null) {
				PriorityIndicator.Dispose ();
				PriorityIndicator = null;
			}

			if (ProblemDescription != null) {
				ProblemDescription.Dispose ();
				ProblemDescription = null;
			}
		}
	}
}

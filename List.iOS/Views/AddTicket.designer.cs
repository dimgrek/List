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
	[Register ("AddTicket")]
	partial class AddTicket
	{
		[Outlet]
		UIKit.UIButton LowButton { get; set; }

		[Outlet]
		UIKit.UIView LowIndicator { get; set; }

		[Outlet]
		UIKit.UIButton MediumButton { get; set; }

		[Outlet]
		UIKit.UIView MediumIndicator { get; set; }

		[Outlet]
		UIKit.UITextField ProblemName { get; set; }

		[Outlet]
		UIKit.UIButton SaveButton { get; set; }

		[Outlet]
		UIKit.UIButton TopButton { get; set; }

		[Outlet]
		UIKit.UIView TopIndicator { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ProblemName != null) {
				ProblemName.Dispose ();
				ProblemName = null;
			}

			if (TopButton != null) {
				TopButton.Dispose ();
				TopButton = null;
			}

			if (MediumButton != null) {
				MediumButton.Dispose ();
				MediumButton = null;
			}

			if (LowButton != null) {
				LowButton.Dispose ();
				LowButton = null;
			}

			if (TopIndicator != null) {
				TopIndicator.Dispose ();
				TopIndicator = null;
			}

			if (MediumIndicator != null) {
				MediumIndicator.Dispose ();
				MediumIndicator = null;
			}

			if (LowIndicator != null) {
				LowIndicator.Dispose ();
				LowIndicator = null;
			}

			if (SaveButton != null) {
				SaveButton.Dispose ();
				SaveButton = null;
			}
		}
	}
}

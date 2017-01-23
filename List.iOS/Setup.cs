using System;
using MvvmCross.iOS.Platform;
using System.Linq;
using List.Converters;
namespace List.iOS
{
	public class Setup : MvxIosSetup
	{
		public Setup (MvvmCross.iOS.Platform.MvxApplicationDelegate appDelegate, MvvmCross.iOS.Views.Presenters.IMvxIosViewPresenter presenter)
			: base(appDelegate, presenter)
		{
		}

		protected override MvvmCross.Core.ViewModels.IMvxApplication CreateApp ()
		{
			return new App();
		}


		protected override System.Collections.Generic.IEnumerable<System.Reflection.Assembly> ValueConverterAssemblies
		{
			get
			{
				var toReturn = base.ValueConverterAssemblies.ToList();
				toReturn.Add(typeof (InvertedBooleanConverter).Assembly);
				toReturn.Add(typeof(PriorityToColorValueConverter).Assembly);
				return toReturn;
			}
		}
	}
}

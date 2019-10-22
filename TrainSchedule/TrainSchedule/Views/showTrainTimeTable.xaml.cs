using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainSchedule.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class showTrainTimeTable : ContentPage
	{
		public showTrainTimeTable ()
		{
			InitializeComponent ();

            stname.Text = tempdata.station;

		}
	}
}
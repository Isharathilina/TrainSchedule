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
	public partial class TrainTimeTable : ContentPage
	{
		public TrainTimeTable ()
		{
			InitializeComponent ();
		}



        private bool validate()
        {
            if (string.IsNullOrEmpty(Station.Text))
            {
                DisplayAlert("Erro", "Please Enter station!", "Ok");
                return false;
            }            


            else
            {
                return true;
            }
        }





        private async void showtraincliked(object sender, EventArgs e)
        {
            if (validate()) {


                tempdata.station = Station.Text;
                await Navigation.PushAsync(new showTrainTimeTable(), true);


            }

        }
    }
}
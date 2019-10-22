using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainSchedule.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddTrainData : ContentPage
	{
		public AddTrainData ()
		{
			InitializeComponent ();
		}


        public static MobileServiceClient MobileService =
         new MobileServiceClient("https://trainschedule.azurewebsites.net");



        // TimeSpan arriveTime = ArriveTime1.Time;

        //string timeString = DateTime.Today.Add(ArriveTime1.Time).ToString(ArriveTime1.Format);

       



        async  private void addBtn_Clicked(object sender, EventArgs e)
        {
            
          
            activityIndicator.IsRunning = true;
            Addbtn.IsVisible = false;



            try
            {
                TrainsTimeTable data = new TrainsTimeTable
                {
                    TrainName = TrainName1.Text,         // TrainName1.Text,
                    Station = Station1.Text,
                    ArriveTime = DateTime.Today.Add(ArriveTime1.Time),         //ArriveTime1,
                    LeaveTime = DateTime.Today.Add(LeaveTime1.Time),



            };

                await MobileService.GetTable<TrainsTimeTable>().InsertAsync(data);

                await DisplayAlert("Added", "Your Data sucessfully added!", "Ok");

                await Navigation.PushAsync(new AddTrainData(), true);

                activityIndicator.IsRunning = false;
                Addbtn.IsVisible = true;



            }
            catch (Exception ee)
            { Debug.WriteLine("" + ee); }



        }
    }
}
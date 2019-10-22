using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using TrainSchedule.Models;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainSchedule.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrainOption : ContentPage
	{
		public TrainOption ()
		{
			InitializeComponent ();
            GetdataAsync();


            fromst.Text = tempdata.trainfrom;
            tost.Text = tempdata.trainto;

          
      
           // caltime.Text = "10 min";

           // estime.Text = "10.20 AM";

        }

        public static MobileServiceClient client = new MobileServiceClient("https://trainschedule.azurewebsites.net");

        IMobileServiceTable<TrainsTimeTable> DataTable = client.GetTable<TrainsTimeTable>();




        public async Task GetdataAsync()
        {
            try
            {


                IMobileServiceTableQuery<DateTime> query = DataTable
                .Where(ur => ur.Station == tempdata.trainfrom)
                 .Select(ur => ur.ArriveTime);

                List<DateTime> items = await query.ToListAsync();
                satime.Text = items[0].ToString(("hh:mm:ss"));
                //---------------------------------


                IMobileServiceTableQuery<DateTime> query2 = DataTable
              .Where(ur => ur.Station == tempdata.trainto)
              .Select(ur => ur.ArriveTime);

                List<DateTime> items2 = await query2.ToListAsync();
                srtime.Text = items2[0].ToString(("hh:mm:ss"));
                //---------------------------------






                // finalname.Text = string.Format("{0}-{1}", items2[0].FirstName, items2[0].LastName



            }
            catch (Exception e)

            {
                
                DisplayAlert("Login", e.Message, "OK");

                Debug.WriteLine("Sync error: {0}", new[] { e.Message });
            }



        }





















    }
}
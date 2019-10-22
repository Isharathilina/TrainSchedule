using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainSchedule.MasterDetailHome
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Detail : ContentPage
    {
        public MasterDetailPage1Detail()
        {
            InitializeComponent();
           // Trainimg.Source = ImageSource.FromResource("TrainSchedule.image.train.jpg");


        }



        private bool validate()
        {
            if (string.IsNullOrEmpty(imat.Text))
            {
                DisplayAlert("Erro", "Please Enter start station!", "Ok");
                return false;
            }
            else if (string.IsNullOrEmpty(iwantogoto.Text))
            {
                DisplayAlert("Erro", "Please Enter your destination!", "Ok");
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

                tempdata.trainfrom = imat.Text;
                tempdata.trainto = iwantogoto.Text;

                await Navigation.PushAsync(new TrainOption(), true);

            }

        }
    }
}
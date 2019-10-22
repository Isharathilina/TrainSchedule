using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainSchedule.MasterDetailHome
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Master : ContentPage
    {
        public ListView ListView;

        public MasterDetailPage1Master()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPage1MasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailPage1MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPage1MenuItem> MenuItems { get; set; }
            
            public MasterDetailPage1MasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailPage1MenuItem>(new[]
                {
                    new MasterDetailPage1MenuItem { Id = 0, Title = "Search Train", TargetType = typeof(MasterDetailPage1Detail) },
                    new MasterDetailPage1MenuItem { Id = 1, Title = "Train time table", TargetType = typeof(TrainTimeTable)  },
                    new MasterDetailPage1MenuItem { Id = 3, Title = "Add Train Data", TargetType = typeof(AddTrainData)},
                    new MasterDetailPage1MenuItem { Id = 2, Title = "About", TargetType = typeof(About)  },

                   // new MasterDetailPage1MenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
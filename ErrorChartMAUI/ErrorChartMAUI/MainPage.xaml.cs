using System.Collections.ObjectModel;

namespace ErrorChartMAUI;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Production> Energy { get; set; }
   

    public MainPage()
	{
		InitializeComponent();
	}

	
	//private void Button_Clicked(object sender, EventArgs e)
	//{

 //       //Energy = new ObservableCollection<Production>()
 //       //{
 //       //    new Production { ID = 1, Coal = 100 },
 //       //    new Production { ID = 2, Coal = 200 },
 //       //    new Production { ID = 3, Coal = 300 },
 //       //    new Production { ID = 4, Coal = 400 },
 //       //    new Production { ID = 5, Coal = 500 },
 //       //    new Production {ID  = 6, Coal = 600 },
 //       //    new Production {ID  = 7, Coal = 700 }
 //       //};
 //       //scatter.ItemsSource = Energy;
 //       //error.ItemsSource=Energy;

	//}
}


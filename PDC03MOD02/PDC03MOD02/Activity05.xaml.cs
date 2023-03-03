using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC03MOD02
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Activity05 : ContentPage
	{
        ObservableCollection<employee> employees = new ObservableCollection<employee>();
public ObservableCollection<employee> Employees { get { return employees; } }
        public Activity05 ()
		{
			
			InitializeComponent ();
			{
				lst.ItemsSource = employees;

				employees.Add(new employee { DisplayName = "Pan Pan Allapitan", Position ="President", profileimage="shrek.png" });
                employees.Add(new employee { DisplayName = "Echong Dabid", Position = "Vice President", profileimage = "eric.jpg" });
                employees.Add(new employee { DisplayName = "Mary had a little lampz", Position = "Secretary", profileimage = "donkey.jpg" });
            }
		}
	}
}
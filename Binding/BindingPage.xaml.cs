using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace Binding
{
    public partial class BindingPage : ContentPage
    {
        public BindingPage()
        {
            InitializeComponent();
            this.BindingContext = new DetailsViewModel();
        }
    }





	public class DetailsViewModel : INotifyPropertyChanged
	{
		string forename, surname;

		public string Forename
		{
			get
			{
                Debug.WriteLine(forename);
				return forename;
			}
			set
			{
				if (forename != value)
				{
					forename = value;
					OnPropertyChanged("Forename");
				}
			}
		}

		public string Surname
		{
			get
			{
				return surname;
			}
			set
			{
				if (surname != value)
				{
					surname = value;
					OnPropertyChanged("Surname");
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			var changed = PropertyChanged;
			if (changed != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FormsSamples
{
	public class Employee : INotifyPropertyChanged
	{
		private string _firstName;
		public string FirstName {
			get { return _firstName; }
			set {
				_firstName = value;
				OnPropertyChanged();
			}
		}

		private string _middleName;
		public string MiddleName {
			get { return _middleName;}
			set {
				_middleName = value;
				OnPropertyChanged();
			}
		}

		private string _lastName;
		public string LastName {
			get { return _lastName;}
			set {
				_lastName = value;
				OnPropertyChanged();
			}
		}
		
		private string _errorMessage;
		public string ErrorMessage {
			get { return _errorMessage;}
			set {
				_errorMessage = value;
				OnPropertyChanged();
			}
		}

		
		
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string propName = "")
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
		}
	}
}
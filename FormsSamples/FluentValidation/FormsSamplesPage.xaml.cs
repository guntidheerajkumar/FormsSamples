//
// FormsSamplesPage.xaml.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace FormsSamples
{
	public partial class FormsSamplesPage : ContentPage
	{
		public Employee Employee { get; set; }


		private IValidationService _validationService;

		public FormsSamplesPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			BindingContext = Employee = new Employee();
			_validationService = new ValidationService();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			var validationResult = await _validationService.Validate(Employee);
			if (validationResult.IsValid) {
				Employee.ErrorMessage = string.Empty;
			} else {
				var errorMessages = validationResult.Errors.Select(vr => vr.ErrorMessage).ToArray();
				Employee.ErrorMessage = string.Join(";\n", errorMessages);
			}
		}
	}
}

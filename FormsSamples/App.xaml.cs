//
// App.xaml.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using FluentValidation;
using Xamarin.Forms;

namespace FormsSamples
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//For Fluent Validation
			//DependencyService.Register<IValidationService, ValidationService>();
			//DependencyService.Register<IValidator<Employee>, EmployeeValidator>();
			//var ci = DependencyService.Get<ILocalization>().GetCurrentCultureInfo();
			//FormsSamples.Resources.Resources.Culture = ci;
			//DependencyService.Get<ILocalization>().SetLocale(ci);
			MainPage = new NavigationPage(new DynamicGrid());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

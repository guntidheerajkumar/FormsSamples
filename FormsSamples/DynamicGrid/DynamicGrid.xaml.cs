//
// DynamicGrid.xaml.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FormsSamples
{
	public partial class DynamicGrid : ContentPage
	{
		public MainViewModel MainModel { get; set; }

		//public Command ClickCommand { get; set; }

		public DynamicGrid()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			BindingContext = MainModel = new MainViewModel();
			//MyDynamicGrid.Command = ClickCommand = new Command((obj) => {
			//	if (obj != null) {
			//		CustomData cdata = (CustomData)obj;
			//		DisplayAlert(cdata.Title, cdata.ImageUrl, "Ok");
			//	}
			//}); 
		}
	}
}

//
// DynamicGrid.xaml.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using Xamarin.Forms;

namespace FormsSamples
{
	public partial class DynamicGrid : ContentPage
	{
		public MainViewModel MainModel { get; set; }

		public DynamicGrid()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			BindingContext = MainModel = new MainViewModel(this.Navigation);
		}
	}
}

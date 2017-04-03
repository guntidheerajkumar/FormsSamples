//
// MyPage.xaml.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsSamples
{
	public partial class MyPage : ContentPage
	{
		public MyPage()
		{
			InitializeComponent();
		}
		
		protected override void OnAppearing()
		{
			base.OnAppearing();

			//lblResourceLabel1.Text = FormsSamples.Resources.Resources.myText;
		}
	}
}

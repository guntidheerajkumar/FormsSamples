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
		public ObservableCollection<CustomData> LstCustomData { get; set; }

		public Command ClickCommand { get; set; }

		public DynamicGrid()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			BindingContext = LstCustomData;

			LstCustomData = new ObservableCollection<CustomData>();
			CreateData();
			ClickCommand = new Command(() => IncreaseExecuted());
			await MyDynamicGrid.BuildTiles(LstCustomData);
		}

		private void IncreaseExecuted()
		{

		}

		private void CreateData()
		{
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "http://farm8.staticflickr.com/7107/7441697680_3ef53f81e7_b.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "https://s-media-cache-ak0.pinimg.com/736x/6d/8d/86/6d8d86223422fb7c584dd008bdb7cebb.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "https://www.oilpixel.com/upload_data/painting_image/image_after/oil-125-kid-digital-portrait-painting-12-12.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "http://farm3.static.flickr.com/2540/4099223815_516c8d7333_o.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "http://farm8.staticflickr.com/7107/7441697680_3ef53f81e7_b.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "https://s-media-cache-ak0.pinimg.com/736x/6d/8d/86/6d8d86223422fb7c584dd008bdb7cebb.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "https://www.oilpixel.com/upload_data/painting_image/image_after/oil-125-kid-digital-portrait-painting-12-12.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "http://farm3.static.flickr.com/2540/4099223815_516c8d7333_o.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "http://farm8.staticflickr.com/7107/7441697680_3ef53f81e7_b.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "https://s-media-cache-ak0.pinimg.com/736x/6d/8d/86/6d8d86223422fb7c584dd008bdb7cebb.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "https://www.oilpixel.com/upload_data/painting_image/image_after/oil-125-kid-digital-portrait-painting-12-12.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "http://farm3.static.flickr.com/2540/4099223815_516c8d7333_o.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "http://farm8.staticflickr.com/7107/7441697680_3ef53f81e7_b.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "https://s-media-cache-ak0.pinimg.com/736x/6d/8d/86/6d8d86223422fb7c584dd008bdb7cebb.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "https://www.oilpixel.com/upload_data/painting_image/image_after/oil-125-kid-digital-portrait-painting-12-12.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "http://farm3.static.flickr.com/2540/4099223815_516c8d7333_o.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "http://farm8.staticflickr.com/7107/7441697680_3ef53f81e7_b.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "https://s-media-cache-ak0.pinimg.com/736x/6d/8d/86/6d8d86223422fb7c584dd008bdb7cebb.jpg" });
			LstCustomData.Add(new CustomData() { Title = "Temporary Title 1", ImageUrl = "https://www.oilpixel.com/upload_data/painting_image/image_after/oil-125-kid-digital-portrait-painting-12-12.jpg" });
		}
	}
}

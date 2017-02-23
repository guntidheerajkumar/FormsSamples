//
// MainViewModel.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsSamples
{
	public class MainViewModel
	{
	
		private INavigation navigation {
			get;
			set;
		}
		public ObservableCollection<CustomData> LstCustomData { get; set; }

		public Command ClickCommand { get; set; }

		public MainViewModel(INavigation navigation)
		{
			this.navigation = navigation;
			LstCustomData = new ObservableCollection<CustomData>();
			CreateData();
			ClickCommand = new Command(async (obj) => { await GetData(obj); });
		}

		private async Task GetData(object obj)
		{
			await navigation.PushAsync(new MyPage());
		}

		private void CreateData()
		{

			for (int i = 0; i < 300; i++) {
				LstCustomData.Add(new CustomData() { Title = $"Temporary Title {i.ToString()}" , ImageUrl = "http://farm8.staticflickr.com/7107/7441697680_3ef53f81e7_b.jpg" });
			}

		}
	}
}

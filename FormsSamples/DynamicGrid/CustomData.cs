﻿//
// CustomData.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FormsSamples
{

	public class CustomData : INotifyPropertyChanged
	{
		private string _imageUrl;
		public string ImageUrl {
			get { return _imageUrl; }
			set {
				_imageUrl = value;
				OnPropertyChanged();
			}
		}


		private string _title;
		public string Title {
			get { return _title; }
			set {
				_title = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string propName = "")
		{
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
		}
	}

}

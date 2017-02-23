//
// TypeTemplate.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using FFImageLoading.Transformations;
using FFImageLoading.Forms.Args;
using Xamarin.Forms;
using FFImageLoading.Forms;

namespace FormsSamples
{
	public class TypeTemplate : Grid
	{

		public TypeTemplate()
		{

		}

		public TypeTemplate(object item)
		{
			this.BackgroundColor = Color.Yellow;
			BindingContext = item;
			CustomData cdata = (CustomData)item;

			var myLabel = new Label() {
				Text = cdata.Title,
				FontSize = 20,
				TextColor = Color.Black,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};

			var myImage = new CachedImage() {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 80,
				DownsampleToViewSize = true,
				Aspect = Aspect.AspectFit,
				Source = ImageSource.FromUri(new Uri(cdata.ImageUrl)),
				TransformPlaceholders = false,
				CacheType = FFImageLoading.Cache.CacheType.All,
				LoadingPlaceholder = "loading.png",
				ErrorPlaceholder = "error.png",
			};


			StackLayout layout = new StackLayout();

			layout.InputTransparent = true;
			layout.Orientation = StackOrientation.Vertical;
			layout.Children.Add(myImage);
			layout.Children.Add(myLabel);


			//RelativeLayout layout = new RelativeLayout();

			//layout.Children.Add(myImage,
			//	Constraint.Constant(0),
			//	Constraint.Constant(0),
			//	Constraint.RelativeToParent((parent) => { return parent.Width; }),
			//	Constraint.RelativeToParent((parent) => { return parent.Height; }));

			//layout.Children.Add(myLabel,
			//	Constraint.Constant(0),
			//	Constraint.Constant(0),
			//	Constraint.RelativeToParent((parent) => { return parent.Width; }),
			//	Constraint.RelativeToParent((parent) => { return parent.Height; }));

			this.Children.Add(layout);

		}
	}
}


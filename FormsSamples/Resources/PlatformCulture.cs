﻿//
// PlatformCulture.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
namespace FormsSamples
{
	public class PlatformCulture
	{
		public string LanguageCode { get; private set; }
		public string LocaleCode { get; private set; }
		public string PlatformString { get; private set; }

		public PlatformCulture(string platformCultureString)
		{
			if (string.IsNullOrEmpty(platformCultureString))
			{
				throw new ArgumentException("Expected culture identifier", "platformCultureString");
			}

			PlatformString = platformCultureString.Replace("_", "-"); // .NET expects dash, not underscore

			var dashIndex = PlatformString.IndexOf("-", StringComparison.Ordinal);
			if (dashIndex > 0)
			{
				var parts = PlatformString.Split('-');

				LanguageCode = parts[0];
				LocaleCode = parts[1];
			}
			else
			{
				LanguageCode = PlatformString;
				LocaleCode = "";
			}
		}

		public override string ToString()
		{
			return PlatformString;
		}
	}
}

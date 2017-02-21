//
// ILocalization.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using System.Globalization;

namespace FormsSamples
{
	public interface ILocalization
	{
		CultureInfo GetCurrentCultureInfo();
		void SetLocale(CultureInfo ci);
	}
}

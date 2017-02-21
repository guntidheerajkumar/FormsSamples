//
// Localization.cs
//
// Author: Dheeraj Kumar Gunti <guntidheerajkumar@gmail.com>
//
// Copyright (c) 2017 (c) Dheeraj Kumar Gunti
//
using System;
using System.Globalization;
using Xamarin.Forms;
using FormsSamples.iOS;
using System.Threading;
using Foundation;

[assembly: Dependency(typeof(Localization))]
namespace FormsSamples.iOS
{
	public class Localization : ILocalization
	{
		public CultureInfo GetCurrentCultureInfo()
		{
			var dotNetLanguage = "en";
			if (NSLocale.PreferredLanguages.Length > 0) {
				var pref = NSLocale.PreferredLanguages[0];
				dotNetLanguage = iOSToDotNet(pref);
			}
			CultureInfo ci = null;
			try {
				ci = new CultureInfo(dotNetLanguage);
			} catch (CultureNotFoundException) {
				try {
					var fallback = DotnetFallback(new PlatformCulture(dotNetLanguage));
					ci = new CultureInfo(fallback);
				} catch (CultureNotFoundException) {
					ci = new CultureInfo("en");
				}
			}

			return ci;
		}

		string DotnetFallback(PlatformCulture platformCulture)
		{
			var dotNetLanguage = platformCulture.LanguageCode;
			switch (platformCulture.LanguageCode)
			{
				case "pt":
					dotNetLanguage = "pt-PT"; // fallback to Portuguese (Portugal)
					break;

				case "gsw":
					dotNetLanguage = "de-CH"; // equivalent to German (Switzerland) for this app
					break;
			}

			return dotNetLanguage;
		}

		private string iOSToDotNet(string iOSLanguage)
		{
			var dotNetLanguage = iOSLanguage;
			switch (iOSLanguage)
			{
				case "ms-MY":   // "Malaysian (Malaysia)" not supported .NET culture
				case "ms-SG":   // "Malaysian (Singapore)" not supported .NET culture
					dotNetLanguage = "ms"; // closest supported
					break;
				case "gsw-CH":  // "Schwiizertüütsch (Swiss German)" not supported .NET culture
					dotNetLanguage = "de-CH"; // closest supported
					break;
			}

			return dotNetLanguage;
		}

		public void SetLocale(CultureInfo ci)
		{
			Thread.CurrentThread.CurrentCulture = ci;
			Thread.CurrentThread.CurrentUICulture = ci;
		}
	}
}

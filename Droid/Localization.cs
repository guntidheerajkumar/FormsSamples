using System.Globalization;
using System.Threading;
using FormsSamples.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(Localization))]
namespace FormsSamples.Droid
{
	public class Localization : ILocalization
	{
		public CultureInfo GetCurrentCultureInfo()
		{
			var dotNetLanguage = "en";
			var androidLocale = Java.Util.Locale.Default;
			dotNetLanguage = AndroidToDotNet(androidLocale.ToString().Replace("_", "-"));
			CultureInfo ci = null;
			try
			{
				ci = new CultureInfo(dotNetLanguage);
			}
			catch (CultureNotFoundException)
			{
				try
				{
					var fallback = DotnetFallback(new PlatformCulture(dotNetLanguage));

					ci = new CultureInfo(fallback);
				}
				catch (CultureNotFoundException)
				{
					ci = new CultureInfo("en");
				}
			}

			return ci;
		}

		public void SetLocale(CultureInfo ci)
		{
			Thread.CurrentThread.CurrentCulture = ci;
			Thread.CurrentThread.CurrentUICulture = ci;
		}


		private string AndroidToDotNet(string androidLanguage)
		{
			var dotNetLanguage = androidLanguage;
			switch (androidLanguage)
			{
				case "ms-BN":   // "Malaysian (Brunei)" not supported .NET culture
				case "ms-MY":   // "Malaysian (Malaysia)" not supported .NET culture
				case "ms-SG":   // "Malaysian (Singapore)" not supported .NET culture
					dotNetLanguage = "ms"; // closest supported
					break;
				case "in-ID":  // "Indonesian (Indonesia)" has different code in  .NET
					dotNetLanguage = "id-ID"; // correct code for .NET
					break;
				case "gsw-CH":  // "Schwiizertüütsch (Swiss German)" not supported .NET culture
					dotNetLanguage = "de-CH"; // closest supported
					break;
			}

			return dotNetLanguage;
		}

		private string DotnetFallback(PlatformCulture platCulture)
		{
			var dotNetLanguage = platCulture.LanguageCode;

			switch (platCulture.LanguageCode)
			{
				case "gsw":
					dotNetLanguage = "de-CH"; // equivalent to German (Switzerland) for this app
					break;
			}

			return dotNetLanguage;
		}
	}
}

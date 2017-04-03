using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace FormsSamples
{
	[ContentProperty("Text")]
	public class TranslateExtension : IMarkupExtension
	{
		readonly CultureInfo ci;
		const string ResourceId = "FormsSamples.Resources.Resources";

		public TranslateExtension()
		{
			if (Device.OS == TargetPlatform.iOS || Device.OS == TargetPlatform.Android) {
				ci = DependencyService.Get<ILocalization>().GetCurrentCultureInfo();
			}
		}

		public string Text { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			if (Text == null)
				return "";

			ResourceManager resmgr = new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly);

			var translation = resmgr.GetString(Text, ci);

			if (translation == null) {
				translation = Text;
			}
			return translation;
		}
	}
}

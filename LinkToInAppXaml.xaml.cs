//XAML Implementation

using System;
using Xamarin.Forms;

namespace WebViewSample
{
	public partial class LinkToInAppXaml : ContentPage
	{
		public LinkToInAppXaml ()
		{
			InitializeComponent ();
		}

		/// <summary>
		/// Demonstrates how to load a view for web browsing within an app.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		async void NavButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync (new InAppBrowserXaml ("https://dotnet.microsoft.com/apps/xamarin"));
		}
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace StoryboardTables
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			#if DEBUG
			Xamarin.Insights.Initialize(Xamarin.Insights.DebugModeKey);
			#else
			Xamarin.Insights.Initialize (XamarinInsights.ApiKey);
			#endif
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}

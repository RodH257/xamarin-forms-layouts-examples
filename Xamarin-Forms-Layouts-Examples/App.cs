using System;
using Xamarin.Forms;

namespace XamarinFormsLayoutsExamples
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new NavigationPage (new HomePage ());
		}
	}
}


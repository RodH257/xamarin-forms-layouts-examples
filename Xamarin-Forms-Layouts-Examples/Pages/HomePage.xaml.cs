using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Windows.Input;

namespace XamarinFormsLayoutsExamples
{
	public class HomePageViewModel
	{
		INavigation navigation;

		public HomePageViewModel (INavigation navigation)
		{
			this.navigation = navigation;

		}

		public Command NestedHorizontalStackLayout {
			get {
				return new Command (x => navigation.PushAsync (new NestedHorizontalStackLayoutPage ()));
			} 
		}

		public Command ScrollView {
			get {
				return new Command (x => navigation.PushAsync (new ScrollViewPage ()));
			} 
		}

		public Command LayoutOptionsStartCenterEnd {
			get {
				return new Command (x => navigation.PushAsync (new LayoutOptionsStartCenterEndPage ()));
			} 
		}

		public Command LayoutOptionsExpand {
			get {
				return new Command (x => navigation.PushAsync (new LayoutOptionsExpandPage ()));
			} 
		}

		public Command Grid {
			get {
				return new Command (x => navigation.PushAsync (new GridPage ()));
			} 
		}

		public Command AbsoluteLayout {
			get {
				return new Command (x => navigation.PushAsync (new AbsoluteLayoutNormalPage ()));
			} 
		}

		public Command AbsoluteLayoutProportionally {
			get {
				return new Command (x => navigation.PushAsync (new AbsoluteLayoutProportionallyPage ()));
			} 
		}

		public Command RelativeLayout {
			get {
				return new Command (x => navigation.PushAsync (new RelativeLayoutPage ()));
			} 
		}
	}

	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
			this.Title = "Layout Examples";
			this.BindingContext = new HomePageViewModel (Navigation);
		}
	}
}


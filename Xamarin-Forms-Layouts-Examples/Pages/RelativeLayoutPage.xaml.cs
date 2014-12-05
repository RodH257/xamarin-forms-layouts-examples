using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinFormsLayoutsExamples
{
	public partial class RelativeLayoutPage : ContentPage
	{
		public RelativeLayoutPage ()
		{
			InitializeComponent ();

			Label nearBottomLabel = new Label {
				Text = "near the bottom",
			};
			relativeLayout.Children.Add (nearBottomLabel, 
				Constraint.RelativeToParent (layout => {
					return layout.Width * 0.3;
				}),
				Constraint.RelativeToParent (layout => {
					return layout.Height * 0.8;
				}));

			Label aboveLabel = new Label {
				Text = "This label is",
			};
			relativeLayout.Children.Add (aboveLabel,
				Constraint.RelativeToView (nearBottomLabel, (parent, sibling) => {
					return sibling.X;
				}),
				Constraint.RelativeToView (nearBottomLabel, (parent, sibling) => {
					return sibling.Y - sibling.Height;
				}));



			//This is to get rid of compiler warnings, not necessary.
			topBox.Color = Color.Red;
		}
	}
}


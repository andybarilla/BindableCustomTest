using System;
using Xamarin.Forms;

namespace TestMVVM
{
	public class CustomEntry : StackLayout
	{
		protected Entry entry;

		public CustomEntry ()
		{
			entry = new Entry ();

			Children.Add (entry);
		}

		public static readonly BindableProperty TextProperty=BindableProperty.Create<CustomEntry, string>( p => p.Text, "" );

		public String Text {
			get { return entry.Text; }
			set { entry.Text = value; }
		}
	}
}


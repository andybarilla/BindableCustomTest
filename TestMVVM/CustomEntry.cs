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
			entry.PropertyChanged += EntryPropertyChanged;
			Children.Add (entry);
		}

		public static readonly BindableProperty TextProperty =
			BindableProperty.Create<CustomEntry, string>(
				p => p.Text,
				"",
				BindingMode.TwoWay,
				null,
				new BindableProperty.BindingPropertyChangedDelegate<string> (HandleTextChanged));
		
		public string Text {
			get { return (string)GetValue(TextProperty); }
			set { 
				SetValue (TextProperty, value);
				entry.Text = value;
			}
		}

		static void HandleTextChanged (BindableObject bindable, object oldValue, object newValue) {
			((CustomEntry)bindable).Text = newValue.ToString();
		}

		void EntryPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e) {
			if (e.PropertyName == "Text") {
				Text = ((Entry)sender).Text;
				OnPropertyChanged ("Text");
			}
		}
	}
}


using System;
using System.ComponentModel;

namespace TestMVVM
{
	public class TestViewModel : INotifyPropertyChanged
	{
		double testValue;

		public event PropertyChangedEventHandler PropertyChanged;

		public TestViewModel ()
		{
			var random = new Random ();
			testValue = random.NextDouble ();
		}

		public double TestValue 
		{
			set {
				if (testValue != value) {
					testValue = value;
					OnPropertyChanged ("TestValue");
				}
			}
			get {
				return testValue;
			}
		}

		protected virtual void OnPropertyChanged (string propertyName) {
			if (PropertyChanged != null) {
				PropertyChanged (this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}


using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace TestMVVM
{
	public class TestViewModel : INotifyPropertyChanged
	{
		string testValue;

		public event PropertyChangedEventHandler PropertyChanged;

		public TestViewModel()
		{
			TestValue = "abcdef";
		}

		public string TestValue 
		{
			set {
				if (testValue != value)
				{
					testValue = value;
					OnPropertyChanged("TestValue");
				}
			}
			get {
				return testValue;
			}
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}


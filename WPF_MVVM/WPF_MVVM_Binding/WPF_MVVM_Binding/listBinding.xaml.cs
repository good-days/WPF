using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_MVVM_Binding
{
	/// <summary>
	/// listBinding.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class listBinding : Page
	{
		public listBinding()
		{
			InitializeComponent();

			var cars = new List<Car>();

			for (int i = 0; i < 10; i++) 
			{
				cars.Add(new Car()
				{
					Speed = i * 10
				});
			}
			this.DataContext = cars;
		}
	}

	public class Human
	{ 
		public string FirstName { get; set; }
		public bool HasDrivingLicense { get; set; }
	}

	public class Car
	{
		public double Speed { get; set; }
		public Color Color { get; set; }
		public Human Driver { get; set; }
	}
}

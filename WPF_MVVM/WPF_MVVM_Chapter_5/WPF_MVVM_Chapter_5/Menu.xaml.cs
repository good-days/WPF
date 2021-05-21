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

namespace WPF_MVVM_Chapter_5
{
	/// <summary>
	/// Menu.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class Menu : Page
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void Menu_Button_Click(object sender, RoutedEventArgs e)
		{
			string controlName = sender.ToString().Split(':')[1];
			controlName = controlName.Trim();
			//MessageBox.Show(controlName);

			if (controlName.Equals("Template"))
			{
				NavigationService.Navigate(
				new Uri("/Template.xaml", UriKind.Relative)
				);
			}
			else if (controlName.Equals("Resource"))
			{
				NavigationService.Navigate(
				new Uri("/Resource.xaml", UriKind.Relative)
				);
			}
			else if (controlName.Equals("Style"))
			{
				NavigationService.Navigate(
				new Uri("/Style.xaml", UriKind.Relative)
				);
			}
			else if (controlName.Equals("Transform"))
			{
				NavigationService.Navigate(
				new Uri("/Transform.xaml", UriKind.Relative)
				);
			}
		}
	}
}

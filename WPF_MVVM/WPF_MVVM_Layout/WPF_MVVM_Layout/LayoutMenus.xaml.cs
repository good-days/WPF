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

namespace WPF_MVVM_Layout
{
	/// <summary>
	/// LayoutMenus.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class LayoutMenus : Page
	{
		public LayoutMenus()
		{
			InitializeComponent();
		}

		private void Layout_Button_Click(object sender, RoutedEventArgs e)
		{ 
			string controlName = sender.ToString().Split(':')[1];
			controlName = controlName.Trim();
			//MessageBox.Show(controlName);

			if (controlName.Equals("Canvas"))
			{
				NavigationService.Navigate(
				new Uri("/Canvas.xaml", UriKind.Relative)
				);
			}
			else if (controlName.Equals("Stack Panel"))
			{
				NavigationService.Navigate(
				new Uri("/StackPanel.xaml", UriKind.Relative)
				);
			}
			else if (controlName.Equals("Dock Panel"))
			{
				NavigationService.Navigate(
				new Uri("/DockPanel.xaml", UriKind.Relative)
				);
			}
			else if (controlName.Equals("Uniform Grid"))
			{
				NavigationService.Navigate(
				new Uri("/UniformGrid.xaml", UriKind.Relative)
				);
			}
			else if (controlName.Equals("Grid"))
			{
				NavigationService.Navigate(
				new Uri("/Grid.xaml", UriKind.Relative)
				);
			}
			else { 
			
			}
		}
	}
}

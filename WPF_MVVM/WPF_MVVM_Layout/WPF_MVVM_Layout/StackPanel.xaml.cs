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
	/// StackPanel.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class StackPanel : Page
	{
		public StackPanel()
		{
			InitializeComponent();
		}

		private void Chage_Button_Click(object sender, RoutedEventArgs e)
		{
			
			if(stack.Orientation == Orientation.Vertical)
			{
				stack.Orientation = Orientation.Horizontal;
			}
			else if (stack.Orientation == Orientation.Horizontal)
			{
				stack.Orientation = Orientation.Vertical;
			}
		}
	}
}

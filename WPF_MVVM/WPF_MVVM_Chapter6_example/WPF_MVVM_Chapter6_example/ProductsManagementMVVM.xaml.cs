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

namespace WPF_MVVM_Chapter6_example
{
	/// <summary>
	/// ProductsManagementMVVM.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class ProductsManagementMVVM : Page
	{
		public ProductsManagementMVVM()
		{
			InitializeComponent();
			// Data Context를 바인딩
			this.DataContext = new ProductsManagementMVVMViewModel();
		}
	}
}

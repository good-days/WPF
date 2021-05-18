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
using BikeShop;	// ProductFactory Class 사용을 위해 Namespace 추가

namespace WPF_MVVM_example_4._10
{
	/// <summary>
	/// ProductsManagement.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class ProductsManagement : Page
	{
		// 임시 Product 데이터 생성
		ProductsFactory factory = new ProductsFactory();

		public ProductsManagement()
		{
			InitializeComponent();
		}

		// Search Input에 찾을 Product이 입력되면 입력과 일치하는 결과들을 찾아서 dataGrid의 source로 제공
		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			dataGrid.ItemsSource = factory.FindProducts(textBox.Text);
		}
	}
}

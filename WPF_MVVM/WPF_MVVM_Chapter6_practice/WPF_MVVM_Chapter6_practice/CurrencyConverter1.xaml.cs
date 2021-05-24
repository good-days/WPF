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

namespace WPF_MVVM_Chapter6_practice
{
	/// <summary>
	/// CurrencyConverter1.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class CurrencyConverter1 : Page
	{
		public CurrencyConverter1()
		{
			InitializeComponent();
			// View에 ViewModel을 연결
			this.DataContext = new CurrencyConverterViewModel1();
		}
	}
}

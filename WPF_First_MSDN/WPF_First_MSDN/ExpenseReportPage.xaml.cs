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

namespace WPF_First_MSDN
{
    /// <summary>
    /// ExpenseReportPage.xaml에 대한 상호 작용 논리
    /// </summary>
  public partial class ExpenseReportPage : Page
  {
    public ExpenseReportPage()
    {
      InitializeComponent();
    }

    // K-2) ExpenseItHome에서 데이터를 전달 받기 위한 생성자 생성
		// Custom constructor to pass expense report data
		public ExpenseReportPage(object data) : this()
		{
			// Bind to expense report data.
			this.DataContext = data;
		}
	}
}

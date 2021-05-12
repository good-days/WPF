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
  /// ExpenseItHome.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class ExpenseItHome : Page
  {
    public ExpenseItHome()
    {
        InitializeComponent();
    }

	  private void Button_Click(object sender, RoutedEventArgs e)
	  {
      // G-2) Buuton Click Event 처리
      // View Expense Report
      //ExpenseReportPage expenseReportPage = new ExpenseReportPage();
      //this.NavigationService.Navigate(expenseReportPage);

      // K-4) 데이터 바인딩을 위한 Buuton Click Event로 변경
      ExpenseReportPage expenseReportPage = new ExpenseReportPage(this.peopleListBox.SelectedItem);
	    this.NavigationService.Navigate(expenseReportPage);
	  }
  }
}

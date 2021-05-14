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
using System.ComponentModel;
using System.Windows.Automation.Peers;

namespace WPF_DataBinding_Demo
{
	/// <summary>
	/// MainWindow.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly CollectionViewSource _listingDataView;
		public MainWindow()
		{
			InitializeComponent();
		}

    private void OpenAddProductWindow(object sender, RoutedEventArgs e)
    {
      var addProductWindow = new AddProductWindow();
      addProductWindow.ShowDialog();
    }

    private void ShowOnlyBargainsFilter(object sender, FilterEventArgs e)
    {
      var product = e.Item as AuctionItem;
      if (product != null)
      {
        // Filter out products with price 25 or above
        e.Accepted = product.CurrentPrice < 25;
      }
    }

    private void AddGrouping(object sender, RoutedEventArgs args)
    {
      // This groups the items in the view by the property "Category"
      var groupDescription = new PropertyGroupDescription { PropertyName = "Category" };
      _listingDataView.GroupDescriptions.Add(groupDescription);

      NotifyUpdate();

    }

    private void NotifyUpdate()
    {
      var listingPeer = ListBoxAutomationPeer.FromElement(Master);
      listingPeer.RaiseAutomationEvent(AutomationEvents.LiveRegionChanged);
    }

    private void RemoveGrouping(object sender, RoutedEventArgs args)
    {
      _listingDataView.GroupDescriptions.Clear();
      NotifyUpdate();
    }

    private void AddSorting(object sender, RoutedEventArgs args)
    {
      // This sorts the items first by Category and within each Category,
      // by StartDate. Notice that because Category is an enumeration,
      // the order of the items is the same as in the enumeration declaration
      _listingDataView.SortDescriptions.Add(
          new SortDescription("Category", ListSortDirection.Ascending));
      _listingDataView.SortDescriptions.Add(
          new SortDescription("StartDate", ListSortDirection.Ascending));
      NotifyUpdate();
    }

    private void RemoveSorting(object sender, RoutedEventArgs args)
    {
      _listingDataView.SortDescriptions.Clear();
      NotifyUpdate();
    }

    private void AddFiltering(object sender, RoutedEventArgs args)
    {
      _listingDataView.Filter += ShowOnlyBargainsFilter;
      NotifyUpdate();
    }

    private void RemoveFiltering(object sender, RoutedEventArgs args)
    {
      _listingDataView.Filter -= ShowOnlyBargainsFilter;
      NotifyUpdate();
    }
  }
}

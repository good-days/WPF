using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeShop;

namespace WPF_MVVM_Chapter6_example
{
	// ProductsManagement ViewModel 작성
	public class ProductsManagementMVVMViewModel : Notifier
	{
		#region

		private string searchInput;

		public string SearchInput
		{
			get { return searchInput; }
			set 
			{
				searchInput = value;
				base.OnPropertyChanged("SearchInput");
				OnSearchInputChanged();
			}
		}

		private IEnumerable<Product> foundProducts;

		public IEnumerable<Product> FoundProducts
		{
			get { return foundProducts; }
			set 
			{
				foundProducts = value;
				OnPropertyChanged("FoundProducts");
			}
		}

		private Product selectedProduct;

		public Product SelectedProduct
		{
			get { return selectedProduct; }
			set 
			{
				selectedProduct = value;
				OnPropertyChanged("SelectedProduct");
			}
		}
		#endregion

		ProductsFactory factory = new ProductsFactory();

		// ViewModel 생성자
		public ProductsManagementMVVMViewModel()
		{
			// 목록이 비어있는지 확인
			FoundProducts = Enumerable.Empty<Product>();
		}

		// Search Input으로 검색하면 list Update
		private void OnSearchInputChanged()
		{
			SelectedProduct = null;

			FoundProducts = factory.FindProducts(SearchInput);
		}
	}
}

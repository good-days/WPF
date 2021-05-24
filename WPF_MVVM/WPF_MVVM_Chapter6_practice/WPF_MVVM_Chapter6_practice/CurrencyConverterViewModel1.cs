using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Chapter6_practice
{
	// CurrencyConverter View에 연결될 ViewModel 생성
	public class CurrencyConverterViewModel1 : Notifier
	{
		
		private decimal euros;

		public decimal Euros
		{
			get { return euros; }
			set
			{
				euros = value;
				OnPropertyChanged("Euros");
				OnEurosChanged();
			}
		}

		private decimal dollars;

		public decimal Dollars
		{
			get { return dollars; }
			set
			{
				dollars = value;
				OnPropertyChanged("Dollars");
			}
		}
		private void OnEurosChanged()
		{
			Dollars = Euros * 1.1M;
		}
	
	}
}

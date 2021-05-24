using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Chapter6_practice
{
	public class Currency
	{
		public Currency(string title, decimal rate) 
		{
			Title = title;
			Rate = rate;
		}

		public string Title { get; set; }
		public decimal Rate { get; set; }
	}

	public class CurrencyConverterViewModel2 : Notifier
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

		private decimal converted;

		public decimal Converted
		{
			get { return converted; }
			set
			{
				converted = value;
				OnPropertyChanged("Converted");
			}
		}

		private Currency selectedCurrency;

		public Currency SelectedCurrency
		{
			get { return selectedCurrency; }
			set 
			{
				selectedCurrency = value;
				OnPropertyChanged("SelectedCurrency");
				OnSelectedCurrencyChanged();
			}
		}

		private IEnumerable<Currency> currencies;

		public IEnumerable<Currency> Currencies
		{
			get { return currencies; }
			set 
			{
				currencies = value;
				OnPropertyChanged("Currencies");
			}
		}

		private string resultText;

		public string ResultText
		{
			get { return resultText; }
			set
			{
				resultText = value;
				OnPropertyChanged("resultText");
			}
		}

		public CurrencyConverterViewModel2()
		{
			Currencies = new Currency[]
			{
				new Currency("US Dollar", 1.1M),
				new Currency("British Pound", 0.9M),
			};
		}

		private void OnEurosChanged()
		{
			ComputeConvertered();		
		}

		private void OnSelectedCurrencyChanged()
		{
			ComputeConvertered();
		}

		private void ComputeConvertered()
		{
			if (SelectedCurrency == null)
			{
				return;
			}

			Converted = Euros * SelectedCurrency.Rate;
			ResultText = string.Format("Amount in {0}", SelectedCurrency.Title);
		}

	}
}

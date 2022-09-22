using cryptocurrenciesInform.Services;
using cryptocurrenciesInform.ViewModels.Base;
using cryptocurrenciesInform.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using cryptocurrenciesInform.Models;

namespace cryptocurrenciesInform.ViewModels
{
    public class ConverterVM : ViewModelBase, IPageViewModel
    {
        private readonly GatherInformation information;

        #region 
        private ObservableCollection<ConvertCurrency> _convertCurrencies;
        public ObservableCollection<ConvertCurrency> ConvertCurrencies
        {
            get => _convertCurrencies;
            set => Set(ref _convertCurrencies, value);
        }
        #endregion

        #region From Currency
        public ConvertCurrency fromCurrency;
        public ConvertCurrency FromCurrency
        {
            get { return fromCurrency; }
            set
            {
                if (fromCurrency != value)
                {
                    fromCurrency = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region To Currency
        public ConvertCurrency toCurrency;
        public ConvertCurrency ToCurrency
        {
            get { return toCurrency; }
            set
            {
                if (toCurrency != value)
                {
                    toCurrency = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Count Currency
        private decimal _count = 1;
        public decimal Count
        {
            get => _count;
            set => Set(ref _count, value);
        }
        #endregion

        #region Result
        private decimal result;
        public decimal Result
        {
            get => result;
            set => Set(ref result, value);
        }
        #endregion

        private ICommand _goTo3;

        public ICommand GoTo3
        {
            get
            {
                return _goTo3 ?? (_goTo3 = new RelayCommand(x =>
                {
                    Mediator.Notify("GoTo3Screen", "");
                }));
            }
        }

        public ConverterVM()
        {
            ConvertCurrencies = new ObservableCollection<ConvertCurrency>();
            information = new GatherInformation();
            RetrieveCurrencyAsync();
        }

        async void RetrieveCurrencyAsync()
        {
            foreach (var i in await information.RetrieveConvertCurrencyAsync())
            {
                ConvertCurrencies.Add(new ConvertCurrency
                {
                    id = i.id,
                    symbol = i.symbol,
                    name = i.name + " (" + i.symbol + ")",
                    priceUsd = i.priceUsd,
                });
            }

            FirstConvert();
        }

        private RelayCommand convert;
        public ICommand Convert => convert ??= new RelayCommand(PerformConvert);

        private void PerformConvert(object commandParameter = null)
        {
            Result = Count * FromCurrency.priceUsd;
            Result /= toCurrency.priceUsd;
        }

        public void FirstConvert()
        {
            if (ConvertCurrencies.Count > 0 && FromCurrency == null && ToCurrency == null)
            {
                FromCurrency = ConvertCurrencies[0];
                ToCurrency = ConvertCurrencies[1];
                PerformConvert();
            }
        }
    }
}

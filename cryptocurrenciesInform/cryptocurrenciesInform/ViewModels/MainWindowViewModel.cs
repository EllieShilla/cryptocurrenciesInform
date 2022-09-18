using cryptocurrenciesInform.Models;
using cryptocurrenciesInform.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptocurrenciesInform.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private readonly GatherInformation getData;

        #region Заголовок окна
        private string _Title = "Crypto Currencies";
        /// <summary> Заголовок окна </summary>

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region Перечесление валют
        private ObservableCollection<Crypto> _currencies;
        private Crypto _selected_currencies;
        public ObservableCollection<Crypto> Currencies
        {
            get => _currencies;
            set => Set(ref _currencies, value);
        }

        #endregion

        public MainWindowViewModel()
        {
            Currencies = new ObservableCollection<Crypto>();
            getData = new GatherInformation();
            RetrieveCurrencyAsync();
        }

        async void RetrieveCurrencyAsync()
        {
            foreach (var i in await getData.RetrieveCurrencyAsync())
            {
                Currencies.Add(new Crypto
                {
                    id = i.id,
                    currencySymbol = i.currencySymbol,
                    rateUsd = i.rateUsd,
                    symbol = i.symbol,
                    type = i.type
                });
            }
        }

        public Crypto SelectedCurrency
        {
            get { return _selected_currencies; }
            set { Set(ref _selected_currencies, value); }
        }
    }
}

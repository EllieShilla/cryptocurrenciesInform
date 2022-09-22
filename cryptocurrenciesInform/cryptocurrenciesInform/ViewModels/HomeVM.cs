using cryptocurrenciesInform.Models;
using cryptocurrenciesInform.Services;
using cryptocurrenciesInform.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;

namespace cryptocurrenciesInform.ViewModels
{
    public class HomeVM : ViewModelBase, IPageViewModel
    {
        private readonly GatherInformation information;
        private List<CoincapCrypto> coincapCryptos;

        #region Перечисление валют
        private ObservableCollection<Crypto> _currencies;
        public ObservableCollection<Crypto> Currencies
        {
            get => _currencies;
            set => Set(ref _currencies, value);
        }
        #endregion

        #region Go To Detail View
        private ICommand _goTo2;

        public ICommand GoTo2
        {
            get
            {
                return _goTo2 ?? (_goTo2 = new RelayCommand(x =>
                {
                    Mediator.Notify("GoTo2Screen", "");
                }));
            }
        }
        #endregion

        public HomeVM()
        {
            Currencies = new ObservableCollection<Crypto>();
            information = new GatherInformation();
            RetrieveCurrencyAsync();
        }

        async void RetrieveCurrencyAsync()
        {
            coincapCryptos = new List<CoincapCrypto>();
            coincapCryptos.AddRange(await information.RetrievecoincapCryptoAsync());

            foreach (var i in await information.RetrieveCurrencyAsync())
            {
                if (coincapCryptos.FirstOrDefault(y => y.id.Equals(i.id)) != null)
                {
                    Currencies.Add(new Crypto
                    {
                        id = i.id,
                        rateUsd = decimal.Round(i.rateUsd, 4),
                        symbol = i.symbol,
                        type = i.type,
                        currencyName = ChangeString.UpperFirstChar(i.id) + "  (" + i.symbol + ")",
                        volumeUsd24Hr = decimal.Round(coincapCryptos.FirstOrDefault(y => y.id.Equals(i.id)).volumeUsd24Hr, 2),
                        changePercent24Hr = decimal.Round(coincapCryptos.FirstOrDefault(y => y.id.Equals(i.id)).changePercent24Hr, 2)
                    });
                }
            }
        }

        public Crypto selectedItem;
        public Crypto SelectedItem
        {
            get { return selectedItem; }
            set
            {
                if (selectedItem != value)
                {
                    selectedItem = value;
                    OnPropertyChanged();
                    Mediator.Notify("GoTo2Screen", selectedItem);
                }
            }
        }
    }
}

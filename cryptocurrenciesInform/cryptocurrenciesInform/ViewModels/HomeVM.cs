using cryptocurrenciesInform.Models;
using cryptocurrenciesInform.Services;
using cryptocurrenciesInform.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace cryptocurrenciesInform.ViewModels
{
    public class HomeVM : ViewModelBase, IPageViewModel
    {
        private readonly GatherInformation information;

        #region Перечесление валют
        private ObservableCollection<Crypto> _currencies;
        public ObservableCollection<Crypto> Currencies
        {
            get => _currencies;
            set => Set(ref _currencies, value);
        }
        #endregion

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

        public HomeVM()
        {
            Currencies = new ObservableCollection<Crypto>();
            information = new GatherInformation();
            RetrieveCurrencyAsync();
        }

        async void RetrieveCurrencyAsync()
        {
            foreach (var i in await information.RetrieveCurrencyAsync())
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

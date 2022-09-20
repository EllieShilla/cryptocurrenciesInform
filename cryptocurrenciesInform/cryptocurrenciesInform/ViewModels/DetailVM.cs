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
    public class DetailVM : ViewModelBase, IPageViewModel
    {
        private GatherInformation information;

        #region Markets List
        private ObservableCollection<Market> _markets;
        public ObservableCollection<Market> Markets
        {
            get => _markets;
            set => Set(ref _markets, value);
        }
        #endregion

        #region Currency Detail
        private Asset _asset;
        public Asset _Asset
        {
            get => _asset;
            set => Set(ref _asset, value);
        }
        #endregion

        #region Selected Item 
        private Crypto selectedItem;
        public Crypto SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public DetailVM()
        {
        }
        public DetailVM(Crypto crypto)
        {

            SelectedItem = crypto;
            Markets = new ObservableCollection<Market>();
            Search();
        }

        private ICommand _goTo1;

        public ICommand GoTo1
        {
            get
            {
                return _goTo1 ?? (_goTo1 = new RelayCommand(x =>
                {
                    Mediator.Notify("GoTo1Screen", "");
                }));
            }
        }


        private async void Search()
        {
            information = new GatherInformation(SelectedItem);
            AssetForSearch assetForSearch = await information.RetrieveCurrencyByNameAsync();
            if (assetForSearch == null)
            {
                SelectedItem.symbol = SelectedItem.id.ToUpper();
                information = new GatherInformation(SelectedItem);
                AssetForSearch dataAsset = await information.RetrieveCurrencyAsyncBySymbol();
                if (dataAsset != null)
                {
                    SelectedItem.id = dataAsset.id;
                    SelectedItem.symbol = dataAsset.symbol;
                }
                information = new GatherInformation(SelectedItem);
            }
            else
            {
                SelectedItem.symbol = assetForSearch.symbol;
                information = new GatherInformation(SelectedItem);

            }

            GetAsset();
            GetMarket();
        }

        public async void GetMarket()
        {
            foreach (var i in await information.RetrieveMarketsAsync())
            {
                Markets.Add(new Market
                {
                    baseId = i.baseId,
                    baseSymbol = i.baseSymbol,
                    exchangeId = i.exchangeId,
                    priceUsd = i.priceUsd,
                    quoteId = i.quoteId,
                    quoteSymbol = i.quoteSymbol
                });
            }
        }

        public async void GetAsset()
        {
            _Asset = await information.RetrieveAssetAsync();
        }


    }
}


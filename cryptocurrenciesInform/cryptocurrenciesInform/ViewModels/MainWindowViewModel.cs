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
    internal class MainWindowViewModel : ViewModelBase
    {
        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;

        #region Search
        private string _search = "Search";
        public string Search
        {
            get => _search;
            set => Set(ref _search, value);
        }
        #endregion

        public MainWindowViewModel()
        {
            PageViewModels.Add(new HomeVM());
            //PageViewModels.Add(new DetailVM());

            CurrentPageViewModel = new HomeVM();

            Mediator.Subscribe("GoTo1Screen", OnGo1Screen);
            Mediator.Subscribe("GoTo2Screen", OnGo2Screen);
        }

        private void OnGo1Screen(object obj)
        {
            ChangeViewModel(PageViewModels[0]);
        }

        private void OnGo2Screen(object obj)
        {
            ChangeViewModel(new DetailVM((Crypto)obj));
        }

        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }

        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                _currentPageViewModel = value;
                OnPropertyChanged("CurrentPageViewModel");
            }
        }

        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels.FirstOrDefault(vm => vm == viewModel);
        }

        private RelayCommand searchCurrency;
        public ICommand SearchCurrency => searchCurrency ??= new RelayCommand(PerformSearchCurrency);

        private async void PerformSearchCurrency(object commandParameter)
        {
            Crypto crypto = new Crypto();
            crypto.id = Search.ToLower();
            ChangeViewModel(new DetailVM(crypto));
        }
    }
}

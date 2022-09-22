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
        private string _search;
        public string Search
        {
            get => _search;
            set => Set(ref _search, value);
        }
        #endregion

        public MainWindowViewModel()
        {
            PageViewModels.Add(new HomeVM());
            PageViewModels.Add(new ConverterVM());
            CurrentPageViewModel = new HomeVM();

            Mediator.Subscribe("GoTo1Screen", PerformOnGo1Screen);
            Mediator.Subscribe("GoTo2Screen", OnGo2Screen);
            Mediator.Subscribe("GoTo3Screen", PerformOnGo3Screen);
        }

        private void PerformOnGo1Screen(object obj)
        {
            ChangeViewModel(PageViewModels[0]);
        }

        private void OnGo2Screen(object obj)
        {
            ChangeViewModel(new DetailVM((Crypto)obj));
        }

        private void PerformOnGo3Screen(object obj)
        {
            ChangeViewModel(PageViewModels[1]);
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
            Search = "";
        }

        private RelayCommand onGo1Screen;
        public ICommand OnGo1Screen => onGo1Screen ??= new RelayCommand(PerformOnGo1Screen);

        private RelayCommand onGo3Screen;
        public ICommand OnGo3Screen => onGo3Screen ??= new RelayCommand(PerformOnGo3Screen);
    }
}

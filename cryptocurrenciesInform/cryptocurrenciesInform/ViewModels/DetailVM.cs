using cryptocurrenciesInform.Models;
using cryptocurrenciesInform.Services;
using cryptocurrenciesInform.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace cryptocurrenciesInform.ViewModels
{
    public class DetailVM : ViewModelBase, IPageViewModel
    {
        public DetailVM(Crypto crypto)
        {
            SelectedItem = crypto;
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
    }
}

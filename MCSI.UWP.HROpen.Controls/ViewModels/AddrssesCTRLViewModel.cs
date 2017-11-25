using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCSI.UWP.HROpen.Common.Models;
using System.Collections.ObjectModel;
using MCSI.UWP.HROpen.Controls;
using System.Windows.Input;

namespace MCSI.UWP.HROpen.Controls.ViewModels
{
    public class AddressesCTRLViewModel:ViewModelBase
    { 

        public AddressesCTRLViewModel(ObservableCollection<Anonymous> addresses)
        {

            
            Addresses = addresses;

            if(addresses==null || _adresses.Count < 1)
            {
                addresses.Add(new Anonymous());
            }

            SelectedAddress = new AddressEditCTRL(addresses[0]);


        }

        private AddressEditCTRL _selectedAddress=null;

        public AddressEditCTRL SelectedAddress
        {
            get { return _selectedAddress; }

            set
            {
                _selectedAddress = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<Anonymous> _adresses;
        public ObservableCollection<Anonymous> Addresses
        {
            get { return _adresses; }

            set
            {
                _adresses = value;
                RaisePropertyChanged();
            }
        }

        //public ICommand AppBarCommands { get; set; }

        //private class AppBarCommandsClass : ICommand
        //{
        //    public event EventHandler CanExecuteChanged;

        //    AddressesCTRLViewModel _parent = null;

        //    public AppBarCommandsClass(AddressesCTRLViewModel parent)
        //    {
        //        _parent = parent;
        //    }

        //    public bool CanExecute(object parameter)
        //    {
        //        return true;
        //    }

        //    public void Execute(object parameter)
        //    {
        //        Views.CountrySubDivisionEditDialog dialog = new Views.CountrySubDivisionEditDialog();
        //        dialog.ShowAsync();
        //    }
        //}

        //Views.CountrySubDivisionEditDialog dialog = new Views.CountrySubDivisionEditDialog();
        //dialog.ShowAsync();

    }
}

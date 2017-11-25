using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCSI.UWP.HROpen.Common.Models;
using System.Collections.ObjectModel;
using MCSI.UWP.HROpen.Controls.Utilities;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;

namespace MCSI.UWP.HROpen.Controls.ViewModels
{
    public class AddressEditViewModel : ViewModelBase
    {

        private Anonymous _address = null;


        public AddressEditViewModel(Anonymous address)
        {
            AppBarCommands = new AppBarCommandsClass(this);
            SubDivisionChangedCommand = new SubDivisionChangedCommandClass(this);
            _address = address;

            SelectedCountryChangedCommand = new SelectedCountryChangedCommandClass(this);
            //address.AvailablePeriod
            //address.FormattedAddress
            //address.GeoLocation
            //address.Name
            //address.ExtendedLines
            //--==Done==--
            //address.City
            //address.CountryCode
            //address.CountrySubDivisions[0].
            //address.ExtendedLines
            //address.Line
            // address.PostalCode
            //address.PostOfficeBox
            //address.Preference
            //address.UseCode
            // address.UseCode

        }


       

        public string AddressLine
        {
            get { return _address.Line; }

            set
            {
                _address.Line = value;
                RaisePropertyChanged();
            }
        }
        public string City
        {
            get { return _address.City; }

            set
            {
                _address.City = value;
                RaisePropertyChanged();
            }
        }
        public string FormattedAddress
        {
            get { return _address.FormattedAddress; }

            set
            {
                _address.FormattedAddress = value;
                RaisePropertyChanged();
            }
        }
        public string Name
        {
            get { return _address.Name; }

            set
            {
                _address.Name = value;
                RaisePropertyChanged();
            }
        }
        public string PostalCode
        {
            get { return _address.PostalCode; }

            set
            {
                _address.PostalCode = value;
                RaisePropertyChanged();
            }
        }
        public string PostOfficeBox
        {
            get { return _address.PostOfficeBox; }

            set
            {
                _address.PostOfficeBox = value;
                RaisePropertyChanged();
            }
        }
        public int Preference
        {
            get { return _address.Preference; }

            set
            {
                _address.Preference = value;
                RaisePropertyChanged();
            }
        }
        public string UseCode
        {
            get { return _address.UseCode; }

            set
            {
                _address.UseCode = value;
                RaisePropertyChanged();
            }



            //public AddressComponentType CountrySubDivision
            //{
            //    //get { return _address.CountrySubDivisions; }
            //}





        }
        public CountryCodeList CountryCode
        {
            get { return _address.CountryCode; }

            set
            {
                _address.CountryCode = value;
            }
        }
        public ObservableCollection<AddressComponentType> CountrySubDivisions
        {
            get { return _address.CountrySubDivisions; }

            set
            {
                _address.CountrySubDivisions = value;
                RaisePropertyChanged();
            }
        }

        public Dictionary<string, string> CountryListDict

        {
            get { return EnumDictionaries.CountryList; }
        }

        public string SelectedCountry
        {
            get {
                string c = CountryListDict[Enum.GetName(typeof(CountryCodeList), _address.CountryCode)];
                return c;
            }


            set
            {
                CountryCodeList x;
                if (Enum.TryParse<CountryCodeList>(value, out x))
                {
                    _address.CountryCode = x;
                }
                RaisePropertyChanged();
            }
        }

        private AddressComponentType _selectedItem = null;
        public AddressComponentType SelectedItem
        {

            get { return _selectedItem; }

            set
            {
                _selectedItem = value;
                RaisePropertyChanged();
            }
        }


        #region Commands

        public ICommand SelectedCountryChangedCommand { get; set; }

        private class SelectedCountryChangedCommandClass : ICommand
        {
            public event EventHandler CanExecuteChanged;

            private AddressEditViewModel _parent;

            public SelectedCountryChangedCommandClass(AddressEditViewModel parent)
            {
                _parent = parent;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                _parent.SelectedCountry = parameter.ToString();
            }
        }

        public ICommand AppBarCommands { get; set; }

        private class AppBarCommandsClass : ICommand
        {
            public event EventHandler CanExecuteChanged;

            AddressEditViewModel _parent = null;

            public AppBarCommandsClass(AddressEditViewModel parent)
            {
                _parent = parent;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                _parent.GetDialog(parameter);
            }
        }

        public ICommand SubDivisionChangedCommand { get; set; }

        private class SubDivisionChangedCommandClass : ICommand
        {
            public event EventHandler CanExecuteChanged;

            private AddressEditViewModel _parent = null;

            public SubDivisionChangedCommandClass(AddressEditViewModel parent)
            {
                _parent = parent;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                //throw new NotImplementedException();
                _parent.SelectedItem = (AddressComponentType)parameter;
            }
        }

        private async void GetDialog(object parameter)
        {
            if (!parameter.ToString().Contains("Add") &&  SelectedItem == null) return;
            AddressComponentType subDivision;
            Views.CountrySubDivisionEditDialog dialog;
            ContentDialogResult x;

            switch (parameter.ToString())
            {

                

                case "Add":

                    subDivision= new AddressComponentType();
                    dialog = new Views.CountrySubDivisionEditDialog(subDivision);
                    x = await dialog.ShowAsync();
                    // string x = (dialog.DataContext as CountrySubDivisionEditViewModel).Type;

                    if (x == ContentDialogResult.Primary) _address.CountrySubDivisions.Add(subDivision);

                    break;
                case "Edit":

                    subDivision = new AddressComponentType();
                    subDivision.Type = SelectedItem.Type;
                    subDivision.Value = SelectedItem.Value;
                    dialog = new Views.CountrySubDivisionEditDialog(subDivision);
                    x = await dialog.ShowAsync();
                    if (x == ContentDialogResult.Primary) {
                        SelectedItem.Type = subDivision.Type;
                        SelectedItem.Value = subDivision.Value;
                    }
                        break;

                case "Delete":

                    MessageDialog deleteConfirm = new MessageDialog($"Are you sure you want to delete {SelectedItem.Type} {SelectedItem.Value} ?");

                    deleteConfirm.Commands.Add(new Windows.UI.Popups.UICommand("Yes") { Id = 0 });
                    deleteConfirm.Commands.Add(new Windows.UI.Popups.UICommand("No") { Id = 1 });
                    deleteConfirm.DefaultCommandIndex = 1;
                    deleteConfirm.CancelCommandIndex = 1;

                    IUICommand result = await deleteConfirm.ShowAsync();

                    if (result.Id.ToString()=="0")
                    {
                        _address.CountrySubDivisions.Remove(SelectedItem);
                        SelectedItem = null;
                    }

                    break;
            }
           
         
        }

        #endregion
    }


}



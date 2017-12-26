using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MCSI.UWP.HROpen.Common.Models;
using MCSI.UWP.HROpen.Controls.Utilities;
using Windows.UI.Xaml.Controls;

namespace MCSI.UWP.HROpen.Controls.ViewModels
{
    public class PersonViewModel : ViewModelBase
    {


        private PersonType _person = null;
        private IdentifierTypeCTRL _iDCtrl;

        private NameTypeCTRL _nameTypeCTRL = null;
        private AddressesCTRL _addressesCTRL = null;

        public delegate void SavePersonToFileeHandler(object sender, PersonEventArgs e);
        public event SavePersonToFileeHandler OnSavePersonToFile;


        public PersonViewModel(PersonType person)
        {
            _person = person;
            _iDCtrl = new IdentifierTypeCTRL(person.Id);
                       
            IDContent = _iDCtrl;

            AppBarCommands = new AppBarCommandsClass(this);

            Anonymous Item;

        }

        public void initializePerson(PersonType person)
        {
            _person = person;
        }

        private UserControl _iDContent;
        public UserControl IDContent
        {
            get { return _iDContent; }

            set
            {
                _iDContent = value;
                RaisePropertyChanged();
            }

        }

        public PersonType Person { get { return _person; } }


        public string FormattedName
        {
            get { return _person.Name.FormattedName; }

            set
            {
                _person.Name.FormattedName = value;
            }
        }


        private async Task AppBarSelectionAsync(object parmeter)
        {
            switch (parmeter.ToString())
            {

                case "ID":

                   
                    IDContent = _iDCtrl;
                    break;

                case "Name":

                    if (_nameTypeCTRL == null) _nameTypeCTRL = new NameTypeCTRL(_person.Name);

                    IDContent = _nameTypeCTRL;

                   
                    break;
                case "Addresses":

                    if(_addressesCTRL==null) _addressesCTRL= new AddressesCTRL(_person.Communication.Address);
                    IDContent = _addressesCTRL;                
                    break;

                case "Save":

                    //  FileOpenPicker picker = new FileOpenPicker();
                    //  picker.SuggestedStartLocation = PickerLocationId.Unspecified;
                    //  StorageFile x = await picker.PickSingleFileAsync();

                    //if (await Utilities.Repository.SavePerson(_personType))
                    //{

                    //}

                    if(OnSavePersonToFile != null)
                    {
                        PersonEventArgs args = new PersonEventArgs() { Person = this.Person };
                        OnSavePersonToFile(this, args);
                    }


                    break;

                case "Find":
                    //_personType = await Utilities.Repository.GetPerson();

                    break;
            }

            

        }

        #region Commands
        public ICommand AppBarCommands { get; set; }

        public class AppBarCommandsClass : ICommand
        {
            public event EventHandler CanExecuteChanged;

            private PersonViewModel _parent = null;

            public AppBarCommandsClass(PersonViewModel parent)
            {
                _parent = parent;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                this._parent.AppBarSelectionAsync(parameter);
            }
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using MCSI.UWP.HROpen.Controls;
using MCSI.UWP.HROpen.Common.Models;
using Windows.Storage.Pickers;
using Windows.Storage;

namespace MCSI.UWP.HROpen.ViewModels
{
    class MainPageViewModel:ViewModelBase
    {

        private UserControl _mainContent = null;
        private HomeCTRL _HomeCTRL = new HomeCTRL();
        private IdentifierTypeCTRL _identifierTypeCTRL;// = new IdentifierTypeCTRL(null);
        private PersonType _personType = Utilities.Repository.CreateNewPerson();
        private PersonCTRL _personCTRL = null;

        public MainPageViewModel()
        {
            AppBarCommands = new AppBarCommandsClass(this);
            MainContent = _HomeCTRL;
            MCSI.UWP.HROpen.Controls.Utilities.EnumDictionaries.Init();
        }


        private async Task AppBarSelectionAsync( object parmeter)
        {
            switch (parmeter.ToString())
            {

                case "Home":

                    MainContent = _HomeCTRL;
                    break;

                case "People":

                    _personCTRL = new PersonCTRL(_personType);
                    // MainContent = new IdentifierTypeCTRL(_personType.Id?? null);
                    MainContent = _personCTRL;
                    break;
                case "Save":

                  //  FileOpenPicker picker = new FileOpenPicker();
                  ////  picker.SuggestedStartLocation = PickerLocationId.Unspecified;
                  //  StorageFile x = await picker.PickSingleFileAsync();

                  if( await Utilities.Repository.SavePerson(_personType))
                    {

                    }

                    break;

                case "Find":
                    _personType = await Utilities.Repository.GetPerson();

                    break;
            }

        }


        public UserControl MainContent {
            get { return _mainContent; }
            set
            {
                _mainContent = value;
                RaisePropertyChanged();
            }
        }

        #region Commands
        public ICommand AppBarCommands { get; set; }

        public class AppBarCommandsClass : ICommand
        {
            public event EventHandler CanExecuteChanged;

            private MainPageViewModel _parent = null;

            public AppBarCommandsClass(MainPageViewModel parent)
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

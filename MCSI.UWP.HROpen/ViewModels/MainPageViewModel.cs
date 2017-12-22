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

        //instntiate the HomeCTRL since it is the initial view and is
        //always used.
        private HomeCTRL _HomeCTRL = new HomeCTRL();

        //these UI Controls are intantiated upon request.
        private UserControl _mainContent = null;
        private IdentifierTypeCTRL _identifierTypeCTRL;// = new IdentifierTypeCTRL(null);  
        private PersonCTRL _personCTRL = null;
        private PersonLocaterCTRL _personLocator = null;
        private string _statusPersoName = string.Empty;


        //There always needs to be an actuve person type. So we instantiate
        // a deault person type that the user can use to create a new user
        //when the app first starts up. If the user decides to open an existing
        //person type then this instance is thrown away or an option to save is
        //presented ifany changes have been made to this instance.
        private PersonType _personType = Utilities.Repository.CurrentPerson;


        #region behaviors and methods

        public MainPageViewModel()
        {
            //initiate all ICommands, display the default UI and
            //initiate dictionaries based on Application Enums
            StatusPersonName = Utilities.Repository.CurrentPerson.Name.FormattedName;
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

                case "OpenFile":

                    if (_personLocator == null) _personLocator = new PersonLocaterCTRL();
                    MainContent = _personLocator;
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
                    string test = await Utilities.Repository.GetPerson("");

                    break;

                   
            }
            StatusPersonName= Utilities.Repository.CurrentPerson.Name.FormattedName;

        }

        #endregion

        #region public properties

        //binding for content control that represents the selected activety
        //in the main pane.
        public UserControl MainContent {
            get { return _mainContent; }
            set
            {
                _mainContent = value;
                RaisePropertyChanged();
            }
        }

        //binding for the current person's name displayed in the status bar
        public string StatusPersonName
        {
            get { return _statusPersoName; }

            set
            {
                _statusPersoName = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region Commands

        /// <summary>
        /// Manages responses to app Bar button selections
        /// </summary>
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

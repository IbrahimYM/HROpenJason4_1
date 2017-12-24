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
using Windows.System.Threading;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Windows.UI;

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
        private SolidColorBrush _statusColor = new SolidColorBrush(Colors.Black);

        private DispatcherTimer timer;

        //There always needs to be an active person type. So we instantiate
        // a deault person type that the user can use to create a new user
        //when the app first starts up. If the user decides to open an existing
        //person type then this instance is thrown away or an option to save is
        //presented if any changes have been made to this instance.
        private PersonType _personType;// = Utilities.Repository.CreateNewPerson();
     
        #region behaviors and methods

        public MainPageViewModel()
        {


            //initiate all ICommands, display the default UI and
            //initiate dictionaries based on Application Enums
            Utilities.Repository.CurrentPerson = Utilities.Repository.CreateNewPerson();
            _personType = Utilities.Repository.CurrentPerson;
            //StatusPersonName = Utilities.Repository.CurrentPerson.Name.FormattedName;

            AppBarCommands = new AppBarCommandsClass(this);
            MainContent = _HomeCTRL;
            MCSI.UWP.HROpen.Controls.Utilities.EnumDictionaries.Init();

            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0,1);

        }

        //the reason for this dispatch timer is twofold at the moment.
        //1. To ensure that the UI reflects the most up to date state of the 
        //application. Not all changes can be event driven directly. So in
        //the timer tick, I set property values to triger the INotifyPropertyChanged
        //events.
        //2. To ensure that all activities in the MainPageViewModel are using the
        //latest version of the _PersonType object.  I have found that sometimes
        //during a string of events and metod calls, the _personType object does not
        //have he current version. But a second time around it does. So something is
        //blocking the reference update. The Timer Tick acts as a process interupt
        //allowing the reference update to happen within the UI thread. I do not like
        //the approach, but it works for now. Anyone reading this that has a suggestion
        //please speak up!
        private void Timer_Tick(object sender, object e)
        {
            StatusPersonName = _personType.Name.FormattedName;
            StatusMessage = string.Empty;
            StatusColor = null;
        }

        private async Task AppBarSelectionAsync( object parmeter)
        {
            timer.Stop();
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

                    _personCTRL = new PersonCTRL (_personType);

                    timer.Start();

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
                    string test = await Utilities.Repository.GetPersonFromFile("");

                    break;

                  
            }

            //_personType = (_personCTRL.DataContext as MCSI.UWP.HROpen.Controls.ViewModels.PersonViewModel).Person;
          


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
            get {
                // return _statusPersoName;
                return _personType.Name.FormattedName;
            }

            set
            {
               // _statusPersoName = value;
                RaisePropertyChanged();
            }
        }
        

        public string StatusMessage
        {
            get { return $"({Utilities.Repository.CurrentPersonStatus()})"; }

            set
            {

                RaisePropertyChanged();
            }
        }
        
        //black indicates unchanged. red indicates changes pending.
        public SolidColorBrush StatusColor
        {
            get { return Utilities.Repository.IsCurrentPersonDirty() ? new SolidColorBrush(Colors.Red) : new SolidColorBrush(Colors.Black); }

            set { RaisePropertyChanged(); }
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

            public async void Execute(object parameter)
            {
               
               await  this._parent.AppBarSelectionAsync(parameter);
               
            }
        }

        #endregion
    }
}

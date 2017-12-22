using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace MCSI.UWP.HROpen.ViewModels
{
    class PersonLocaterViewModel:ViewModelBase
    {
        public PersonLocaterViewModel()
        {
            AppBarCommands = new AppBarCommandsClass(this);
            PersonFileStatus = Utilities.Repository.CurrentPersonStatus();

        }


        #region pubic properties

        //where the current person file is stored if
        //originated from file system.
        //otherwise entpry string.
        private string _filePath=string.Empty;
        public string FilePath
        {
            get { return _filePath; }

            set
            {
                _filePath = value;
                RaisePropertyChanged();
            }
        }

        //dispalys the currnt status of the PersonFile instance.
        private string _personFileStatus = string.Empty;
        public string PersonFileStatus
        {
            get { return _personFileStatus; }
            set
            {
                _personFileStatus = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        /// <summary>
        /// Branches logic according to App Bar Button Selections
        /// </summary>
        /// <param name="parameter"></param>
        public async void AppBarSelection(object parameter)
        {

            switch (parameter.ToString())
            {

                case "OpenFile":

                    OpenHRJFile();

                    break;
                    

                case "NewFile":

                    break;

            }
        }

       
        private async void OpenHRJFile()
        {

            //FileOpenPicker openPicker = new FileOpenPicker();
            //openPicker.ViewMode = PickerViewMode.Thumbnail;
            //openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            //openPicker.FileTypeFilter.Add("*");
            //openPicker.FileTypeFilter.Add(".hrj");
            //StorageFile file = await openPicker.PickSingleFileAsync();
            //if (file != null)
            //{
            //    FilePath = file.Path;
            //}
            //else
            //{
            //    //  
            //}

           FilePath = await Utilities.Repository.GetPerson("");

        }

        #region Commands
       
        /// <summary>
        /// Manages responses tp app bar button selections
        /// </summary>
        public ICommand AppBarCommands { get; set; }
        public class AppBarCommandsClass : ICommand
        {
            public event EventHandler CanExecuteChanged;

            private PersonLocaterViewModel _parent = null;

            public AppBarCommandsClass(PersonLocaterViewModel parent)
            {
                _parent = parent;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                this._parent.AppBarSelection(parameter);
            }
        }

#endregion

    
    }
}

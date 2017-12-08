using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MCSI.UWP.HROpen.ViewModels
{
    class PersonLocaterViewModel:ViewModelBase
    {
        public PersonLocaterViewModel()
        {
            AppBarCommands = new AppBarCommandsClass(this);

        }

 /// <summary>
 /// Branches logic according to App Bar Button Selections
 /// </summary>
 /// <param name="parameter"></param>
        public async void AppBarSelection(object parameter)
        {

            switch (parameter.ToString())
            {


                case "OpenFile":

                    break;

                case "NewFile":

                    break;

            }
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

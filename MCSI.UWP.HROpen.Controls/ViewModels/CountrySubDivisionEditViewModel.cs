using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MCSI.UWP.HROpen.Common.Models;

namespace MCSI.UWP.HROpen.Controls.ViewModels
{
    class CountrySubDivisionEditViewModel:ViewModelBase
    {

        //public delegate void ButtonClickedHandler(object source, ButtonClickedEventargs e);

        //public event ButtonClickedHandler OnButtonClicked;


        private AddressComponentType _subDivision;
        public CountrySubDivisionEditViewModel(AddressComponentType subDivision)
        {

            _subDivision = subDivision;


            //ErrorMsg = "No Errors";
            //ButtonClickCommand = new ButtonClickComandClass(this);

        }

        private string _errorMsg = string.Empty;
        public string ErrorMsg
        {
            get { return _errorMsg; }

            set
            {
                _errorMsg = value;
                RaisePropertyChanged();
            }
        }
        public string Type
        {
            get    { return _subDivision.Type; }

            set
            {
                _subDivision.Type = value;
                RaisePropertyChanged();
            }
        }
        public string Value
        {
            get { return _subDivision.Value; }

            set
            {
                _subDivision.Value = value;
                RaisePropertyChanged();
            }
        }
        public ICommand ButtonClickCommand { get; set; }
        private class ButtonClickComandClass : ICommand
        {
            public event EventHandler CanExecuteChanged;

            private CountrySubDivisionEditViewModel _parent = null;

            public ButtonClickComandClass(CountrySubDivisionEditViewModel parent)
            {
                _parent = parent;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                //_parent.OnButtonClicked(this, new ButtonClickedEventargs(){Type=_parent.Type, Value=_parent.Value);

                //Views.CountrySubDivisionEditDialog dialog = new Views.CountrySubDivisionEditDialog();
                //dialog.ShowAsync();
                
            }
        }

    }

    //public class ButtonClickedEventargs : EventArgs
    //{
    //    public string Type { get;  set; }
    //    public string Value { get;  set; }
    //    public string Action { get; set; }
    //}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MCSI.UWP.HROpen.Common.Models;
using MCSI.UWP.HROpen.Controls.Utilities;




namespace MCSI.UWP.HROpen.Controls.ViewModels
{
    class NameTypeCTRLViewModel:ViewModelBase
    {

        private PersonNameType _personNameType;
        public NameTypeCTRLViewModel(PersonNameType personNameType)
        {
            _personNameType = personNameType;

           // _personNameType.Language = LanguageCodeList.EnUS;
            LanguageChangedCommand = new LanguageChangedCommandClass(this);

        }
        public  Dictionary<string, string> LanguageListDict

        {
            get { return EnumDictionaries.LangList; }
        }
        public string SelectedLanguage
        {

            get {

                string l = LanguageListDict[Enum.GetName(typeof(LanguageCodeList), _personNameType.Language)];
                return l;}

            set {

                // _personNameType.Language = Enum.Parse(typeof(LanguageCodeList), value);
                LanguageCodeList x;
                if (Enum.TryParse<LanguageCodeList>(value, out x) ){
                    _personNameType.Language = x;
                }
                    RaisePropertyChanged();

            }
        }
        public string Alias
        {
            get { return _personNameType.Alias; }

            set
            {
                _personNameType.Alias = value;
                RaisePropertyChanged();
            }
        }
        public string Family
        {
            get { return _personNameType.Family; }

            set
            {
                _personNameType.Family = value;
                RaisePropertyChanged();
            }
        }
        public string FormerFmily
        {
            get { return _personNameType.FormerFamily; }

            set
            {
                _personNameType.FormerFamily = value;
                RaisePropertyChanged();
            }
        }
        public string GenerationlAffixCode
        {
            get { return _personNameType.GenerationlAffixCode; }

            set
            {
                _personNameType.GenerationlAffixCode = value;
                RaisePropertyChanged();
            }
        }
        public string Initials
        {
            get { return _personNameType.Initials; }

            set
            {
                _personNameType.Initials = value;
                RaisePropertyChanged();
            }
        }
        public string Given
        {
            get { return _personNameType.Given; }

            set
            {
                _personNameType.Given = value;
                RaisePropertyChanged();
            }
        }
        public string FormattedNameType
        {
            get { return _personNameType.FormattedName; }

            set
            {
                _personNameType.FormattedName = value;
                RaisePropertyChanged();
            }
        }
        public LanguageCodeList Language
        {
            get { return _personNameType.Language; }

            set
            {
                _personNameType.Language = value;
                RaisePropertyChanged();
            }
        }
        public string Legal
        {
            get { return _personNameType.Legal; }

            set
            {
                _personNameType.Legal = value;
                RaisePropertyChanged();
            }
        }
        public string Middle
        {
            get { return _personNameType.Middle; }

            set
            {
                _personNameType.Middle = value;
                RaisePropertyChanged();
            }
        }
        public string Preferred
        {
            get { return _personNameType.Preferred; }

            set
            {
                _personNameType.Preferred = value;
                RaisePropertyChanged();
            }
        }
        public string PreferredSalutationCode
        {
            get { return _personNameType.PreferredSalutationCode; }

            set
            {
                _personNameType.PreferredSalutationCode = value;
                RaisePropertyChanged();
            }
        }
        public string QualificationAffixCode
        {
            get { return _personNameType.QualificationAffixCode; }

            set
            {
                _personNameType.QualificationAffixCode = value;
                RaisePropertyChanged();
            }
        }
        public string TitleAffixCode
        {
            get { return _personNameType.TitleAffixCode; }

            set
            {
                _personNameType.TitleAffixCode = value;
                RaisePropertyChanged();
            }
        }
        public ICommand LanguageChangedCommand { get; set; }
        private class LanguageChangedCommandClass : ICommand
        {
            public event EventHandler CanExecuteChanged;

            private NameTypeCTRLViewModel _parent = null;

            public LanguageChangedCommandClass(NameTypeCTRLViewModel parent)
            {
                _parent = parent;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                _parent.SelectedLanguage = parameter.ToString();
            }
        }


    }
}

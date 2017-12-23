using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCSI.UWP.HROpen.Common.Models;

namespace MCSI.UWP.HROpen.Controls.ViewModels
{


    class IdentifierTypeViewModel : ViewModelBase
    {

        private IdentifierType _identifierType;

        public IdentifierTypeViewModel(IdentifierType identifierType = null)
        {

            _identifierType = identifierType;
           
           // _identifierType.SchemeVersionId = null;

        }

        public string Value
        {
            get { return _identifierType.Value; }

            set
            {
                _identifierType.Value = value;
                RaisePropertyChanged();
            }
        }

        public string SchemeId
        {
            get { return _identifierType.SchemeId; }

            set
            {
                _identifierType.SchemeId = value;
                RaisePropertyChanged();
            }
        }

        public string SchemeAgencyID
        {
            get { return _identifierType.SchemeAgencyId; }

            set
            {
                _identifierType.SchemeAgencyId = value;
            }
        }

        public string SchemeLink
        {
            get { return _identifierType.SchemeLink; }

            set
            {
                _identifierType.SchemeLink = value;
                RaisePropertyChanged();
            }
        }

        public string SchemeVersionID
        {
            get { return _identifierType.SchemeVersionId; }
            set
            {
                _identifierType.SchemeVersionId = value;
                RaisePropertyChanged();
            }
        }

    }
}

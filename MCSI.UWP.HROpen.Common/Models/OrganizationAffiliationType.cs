using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>OLD: Contains information about a person's affiliation with a trade, professional, or similar organization or group formed around a common purpose or cause.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class OrganizationAffiliationType : System.ComponentModel.INotifyPropertyChanged
    {
        private OrganizationType _organization = new OrganizationType();
        private AffiliatedOrganizationTypeCodeList _affiliationTypeCode;
        private IdentifierType _memberId = new IdentifierType();
        private string _role;
        private System.DateTime _startDate;
        private System.DateTime _endDate;
        private System.Collections.ObjectModel.ObservableCollection<string> _descriptions = new System.Collections.ObjectModel.ObservableCollection<string>();
        private System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType> _attachmentReferences = new System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType>();

        [Newtonsoft.Json.JsonProperty("organization", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OrganizationType Organization
        {
            get { return _organization; }
            set
            {
                if (_organization != value)
                {
                    _organization = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The type of association or organization with which a person is affiliated. In most contexts, this would be an organizational affiliation other than that with an employer. Typically, would be an affiliation with an association, trade organization, or union.</summary>
        [Newtonsoft.Json.JsonProperty("affiliationTypeCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AffiliatedOrganizationTypeCodeList AffiliationTypeCode
        {
            get { return _affiliationTypeCode; }
            set
            {
                if (_affiliationTypeCode != value)
                {
                    _affiliationTypeCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("memberId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdentifierType MemberId
        {
            get { return _memberId; }
            set
            {
                if (_memberId != value)
                {
                    _memberId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("role", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Role
        {
            get { return _role; }
            set
            {
                if (_role != value)
                {
                    _role = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime StartDate
        {
            get { return _startDate; }
            set
            {
                if (_startDate != value)
                {
                    _startDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime EndDate
        {
            get { return _endDate; }
            set
            {
                if (_endDate != value)
                {
                    _endDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("descriptions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Descriptions
        {
            get { return _descriptions; }
            set
            {
                if (_descriptions != value)
                {
                    _descriptions = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("attachmentReferences", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType> AttachmentReferences
        {
            get { return _attachmentReferences; }
            set
            {
                if (_attachmentReferences != value)
                {
                    _attachmentReferences = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static OrganizationAffiliationType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<OrganizationAffiliationType>(data);
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}

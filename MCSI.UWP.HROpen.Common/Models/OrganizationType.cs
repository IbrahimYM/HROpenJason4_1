using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>Basic information to identify and reference a specific organization.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class OrganizationType : OrganizationReferenceType, System.ComponentModel.INotifyPropertyChanged
    {
        private IdentifierType _taxId = new IdentifierType();
        private IdentifierType _legalId = new IdentifierType();
        private System.Collections.ObjectModel.ObservableCollection<string> _industryCodes = new System.Collections.ObjectModel.ObservableCollection<string>();
        private double _headCount;
        private AmountType _revenue = new AmountType();
        private TextType _description = new TextType();
        private GeographicResponsibilityCodeList _geographicResponsibilityCode;
        private OwnershipTypeCodeList _ownershipType;
        private string _stockSymbol;
        private string _workEnvironment;
        private System.Collections.ObjectModel.ObservableCollection<SpecifiedPersonType> _contacts = new System.Collections.ObjectModel.ObservableCollection<SpecifiedPersonType>();
        private string _domainName;

        [Newtonsoft.Json.JsonProperty("taxId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdentifierType TaxId
        {
            get { return _taxId; }
            set
            {
                if (_taxId != value)
                {
                    _taxId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("legalId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdentifierType LegalId
        {
            get { return _legalId; }
            set
            {
                if (_legalId != value)
                {
                    _legalId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The industry codes with which the organization is engaged.</summary>
        [Newtonsoft.Json.JsonProperty("industryCodes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> IndustryCodes
        {
            get { return _industryCodes; }
            set
            {
                if (_industryCodes != value)
                {
                    _industryCodes = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("headCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double HeadCount
        {
            get { return _headCount; }
            set
            {
                if (_headCount != value)
                {
                    _headCount = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("revenue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AmountType Revenue
        {
            get { return _revenue; }
            set
            {
                if (_revenue != value)
                {
                    _revenue = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TextType Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("geographicResponsibilityCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GeographicResponsibilityCodeList GeographicResponsibilityCode
        {
            get { return _geographicResponsibilityCode; }
            set
            {
                if (_geographicResponsibilityCode != value)
                {
                    _geographicResponsibilityCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("ownershipType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OwnershipTypeCodeList OwnershipType
        {
            get { return _ownershipType; }
            set
            {
                if (_ownershipType != value)
                {
                    _ownershipType = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("stockSymbol", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StockSymbol
        {
            get { return _stockSymbol; }
            set
            {
                if (_stockSymbol != value)
                {
                    _stockSymbol = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Work Environment type e.g., Office, Workshop, Factory, etc</summary>
        [Newtonsoft.Json.JsonProperty("workEnvironment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkEnvironment
        {
            get { return _workEnvironment; }
            set
            {
                if (_workEnvironment != value)
                {
                    _workEnvironment = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The people at the organization who can be used contacts.</summary>
        [Newtonsoft.Json.JsonProperty("contacts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<SpecifiedPersonType> Contacts
        {
            get { return _contacts; }
            set
            {
                if (_contacts != value)
                {
                    _contacts = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The internet domain to help identify the organization and a reference to find additional information.</summary>
        [Newtonsoft.Json.JsonProperty("domainName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DomainName
        {
            get { return _domainName; }
            set
            {
                if (_domainName != value)
                {
                    _domainName = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static OrganizationType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<OrganizationType>(data);
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

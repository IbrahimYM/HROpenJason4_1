using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>Represents common data about a person.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PersonBaseType : PersonReferenceType, System.ComponentModel.INotifyPropertyChanged
    {
        private IdentifierType _legalId = new IdentifierType();
        private System.DateTime _birthDate;
        private GenderCodeList _gender;
        private System.Collections.ObjectModel.ObservableCollection<CountryCodeList> _citizenship = new System.Collections.ObjectModel.ObservableCollection<CountryCodeList>();
        private System.Collections.ObjectModel.ObservableCollection<CountryCodeList> _residenceCountry = new System.Collections.ObjectModel.ObservableCollection<CountryCodeList>();
        private string _militaryStatus;
        private System.Collections.ObjectModel.ObservableCollection<string> _ethnicity = new System.Collections.ObjectModel.ObservableCollection<string>();

        /// <summary>The legal identifier of a person. The issuer is most likely a country or state.</summary>
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

        /// <summary>The birth date of a person.</summary>
        [Newtonsoft.Json.JsonProperty("birthDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (_birthDate != value)
                {
                    _birthDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The gender of a person.</summary>
        [Newtonsoft.Json.JsonProperty("gender", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GenderCodeList Gender
        {
            get { return _gender; }
            set
            {
                if (_gender != value)
                {
                    _gender = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The citizenships that a person holds. This is a legal citizenship in a country (as opposed to nationality which may or may not be a country).</summary>
        [Newtonsoft.Json.JsonProperty("citizenship", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<CountryCodeList> Citizenship
        {
            get { return _citizenship; }
            set
            {
                if (_citizenship != value)
                {
                    _citizenship = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The country (or countries) where a person currently resides.</summary>
        [Newtonsoft.Json.JsonProperty("residenceCountry", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<CountryCodeList> ResidenceCountry
        {
            get { return _residenceCountry; }
            set
            {
                if (_residenceCountry != value)
                {
                    _residenceCountry = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The military status of a person.</summary>
        [Newtonsoft.Json.JsonProperty("militaryStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MilitaryStatus
        {
            get { return _militaryStatus; }
            set
            {
                if (_militaryStatus != value)
                {
                    _militaryStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The ethnicity (or ethnicity of a person. Ethnicity is an ethnic group or a social group that shares a common and distinctive culture, religion, and/or language.</summary>
        [Newtonsoft.Json.JsonProperty("ethnicity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Ethnicity
        {
            get { return _ethnicity; }
            set
            {
                if (_ethnicity != value)
                {
                    _ethnicity = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PersonBaseType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PersonBaseType>(data);
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

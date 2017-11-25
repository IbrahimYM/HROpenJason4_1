using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AddressType : System.ComponentModel.INotifyPropertyChanged
    {
        private string _line;
        private System.Collections.ObjectModel.ObservableCollection<AddressComponentType> _extendedLines = new System.Collections.ObjectModel.ObservableCollection<AddressComponentType>();
        private CountryCodeList _countryCode;
        private System.Collections.ObjectModel.ObservableCollection<AddressComponentType> _countrySubDivisions = new System.Collections.ObjectModel.ObservableCollection<AddressComponentType>();
        private string _city;
        private string _postalCode;
        private string _postOfficeBox;
        private GeoType _geoLocation = new GeoType();
        private string _formattedAddress;

        /// <summary>Street line address</summary>
        [Newtonsoft.Json.JsonProperty("line", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Line
        {
            get { return _line; }
            set
            {
                if (_line != value)
                {
                    _line = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Extended address components (e.g. apartment or suite number).</summary>
        [Newtonsoft.Json.JsonProperty("extendedLines", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<AddressComponentType> ExtendedLines
        {
            get { return _extendedLines; }
            set
            {
                if (_extendedLines != value)
                {
                    _extendedLines = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("countryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CountryCodeList CountryCode
        {
            get { return _countryCode; }
            set
            {
                if (_countryCode != value)
                {
                    _countryCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Qualifies the further divisions of the Country. These may be Districts, Regions, States, Provinces etc.</summary>
        [Newtonsoft.Json.JsonProperty("countrySubDivisions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<AddressComponentType> CountrySubDivisions
        {
            get { return _countrySubDivisions; }
            set
            {
                if (_countrySubDivisions != value)
                {
                    _countrySubDivisions = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("postalCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostalCode
        {
            get { return _postalCode; }
            set
            {
                if (_postalCode != value)
                {
                    _postalCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("postOfficeBox", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostOfficeBox
        {
            get { return _postOfficeBox; }
            set
            {
                if (_postOfficeBox != value)
                {
                    _postOfficeBox = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("geoLocation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GeoType GeoLocation
        {
            get { return _geoLocation; }
            set
            {
                if (_geoLocation != value)
                {
                    _geoLocation = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("formattedAddress", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FormattedAddress
        {
            get { return _formattedAddress; }
            set
            {
                if (_formattedAddress != value)
                {
                    _formattedAddress = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static AddressType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AddressType>(data);
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

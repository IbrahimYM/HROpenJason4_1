using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PhoneType : System.ComponentModel.INotifyPropertyChanged
    {
        private string _countryDialingCode;
        private string _areaDialingCode;
        private string _dialNumber;
        private string _phoneExtension;
        private string _access;
        private string _formattedNumber;

        /// <summary>The country dialing code for a communication number.</summary>
        [Newtonsoft.Json.JsonProperty("countryDialingCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CountryDialingCode
        {
            get { return _countryDialingCode; }
            set
            {
                if (_countryDialingCode != value)
                {
                    _countryDialingCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The area dialing code for a communication number.</summary>
        [Newtonsoft.Json.JsonProperty("areaDialingCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AreaDialingCode
        {
            get { return _areaDialingCode; }
            set
            {
                if (_areaDialingCode != value)
                {
                    _areaDialingCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The communication number, not including country dialing or area dialing codes.</summary>
        [Newtonsoft.Json.JsonProperty("dialNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DialNumber
        {
            get { return _dialNumber; }
            set
            {
                if (_dialNumber != value)
                {
                    _dialNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The extension of the associated communication number.</summary>
        [Newtonsoft.Json.JsonProperty("phoneExtension", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PhoneExtension
        {
            get { return _phoneExtension; }
            set
            {
                if (_phoneExtension != value)
                {
                    _phoneExtension = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The text that permits access to the electronic network of the associated communication number such as telephone network, for example 9, *70.</summary>
        [Newtonsoft.Json.JsonProperty("access", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Access
        {
            get { return _access; }
            set
            {
                if (_access != value)
                {
                    _access = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Specifies details of an actual formatted number</summary>
        [Newtonsoft.Json.JsonProperty("formattedNumber", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string FormattedNumber
        {
            get { return _formattedNumber; }
            set
            {
                if (_formattedNumber != value)
                {
                    _formattedNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PhoneType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PhoneType>(data);
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

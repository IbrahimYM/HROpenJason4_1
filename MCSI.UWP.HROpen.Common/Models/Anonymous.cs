using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace MCSI.UWP.HROpen.Common.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Anonymous : AddressType, System.ComponentModel.INotifyPropertyChanged
    {
        private string _name;
        private string _useCode;
        private int _preference;
        private System.Collections.Generic.Dictionary<string, object> _availablePeriod = new System.Collections.Generic.Dictionary<string, object>();

        /// <summary>Provide description for particular communication item</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Code identifying the usage of the contact point e.g. business, private, etc.</summary>
        [Newtonsoft.Json.JsonProperty("useCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UseCode
        {
            get { return _useCode; }
            set
            {
                if (_useCode != value)
                {
                    _useCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Provide priority for given communication item</summary>
        [Newtonsoft.Json.JsonProperty("preference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Preference
        {
            get { return _preference; }
            set
            {
                if (_preference != value)
                {
                    _preference = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("availablePeriod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, object> AvailablePeriod
        {
            get { return _availablePeriod; }
            set
            {
                if (_availablePeriod != value)
                {
                    _availablePeriod = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Anonymous FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Anonymous>(data);
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>An identifier is a character string used to uniquely identify one instance of an object within an identification scheme that is managed by an agency. Use this type when the list or values are controlled by an external entity, the list or values are public and could be referenced or validated.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class IdentifierType : System.ComponentModel.INotifyPropertyChanged
    {
        private string _value;
        private string _schemeId;
        private string _schemeVersionId;
        private string _schemeAgencyId;
        private string _description;
        private string _schemeLink;
        private string _agencyUri;

        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The identification of the identifier scheme.</summary>
        [Newtonsoft.Json.JsonProperty("schemeId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchemeId
        {
            get { return _schemeId; }
            set
            {
                if (_schemeId != value)
                {
                    _schemeId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The identification of the version of the identifier scheme.</summary>
        [Newtonsoft.Json.JsonProperty("schemeVersionId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchemeVersionId
        {
            get { return _schemeVersionId; }
            set
            {
                if (_schemeVersionId != value)
                {
                    _schemeVersionId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The identification of the agency that manages the identifier scheme.</summary>
        [Newtonsoft.Json.JsonProperty("schemeAgencyId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchemeAgencyId
        {
            get { return _schemeAgencyId; }
            set
            {
                if (_schemeAgencyId != value)
                {
                    _schemeAgencyId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description
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

        /// <summary>The URI that identifies where the identification scheme data is located.</summary>
        [Newtonsoft.Json.JsonProperty("schemeLink", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchemeLink
        {
            get { return _schemeLink; }
            set
            {
                if (_schemeLink != value)
                {
                    _schemeLink = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The URI that identifies where the identification scheme is located</summary>
        [Newtonsoft.Json.JsonProperty("agencyUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AgencyUri
        {
            get { return _agencyUri; }
            set
            {
                if (_agencyUri != value)
                {
                    _agencyUri = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static IdentifierType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IdentifierType>(data);
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

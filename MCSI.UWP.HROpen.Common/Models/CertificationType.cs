using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>A document or confirmation certifying the status or acquirements of the bearer, or his fulfilment of conditions which authorize him to act or practise in a specified way; hence, often equal to a certificate.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CertificationType : System.ComponentModel.INotifyPropertyChanged
    {
        private IdentifierType _id = new IdentifierType();
        private string _name;
        private EntityType _type = new EntityType();
        private string _status;
        private EffectiveTimePeriod _effectiveTimePeriod = new EffectiveTimePeriod();
        private FormattedDateTimeType _firstIssued;
        private OrganizationType _issuingAuthority = new OrganizationType();
        private System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType> _attachmentReferences = new System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType>();
        private System.Collections.ObjectModel.ObservableCollection<string> _descriptions = new System.Collections.ObjectModel.ObservableCollection<string>();

        /// <summary>A unique identifier to the certificate as defined by the issuing authority.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdentifierType Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The common name of the certificate.</summary>
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

        /// <summary>The type of the certificate.</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EntityType Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The status of the certificate. While this is an open string, common status include active, expired, pending, suspended.</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The time period for which the certificiate is valid and considered active.</summary>
        [Newtonsoft.Json.JsonProperty("effectiveTimePeriod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EffectiveTimePeriod EffectiveTimePeriod
        {
            get { return _effectiveTimePeriod; }
            set
            {
                if (_effectiveTimePeriod != value)
                {
                    _effectiveTimePeriod = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The original issue date of the certificate. Often this is useful when the certifiates need to be renewed often, and it is important to know how long the certificate has been held.</summary>
        [Newtonsoft.Json.JsonProperty("firstIssued", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FormattedDateTimeType FirstIssued
        {
            get { return _firstIssued; }
            set
            {
                if (_firstIssued != value)
                {
                    _firstIssued = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The organization that issued the certificate.</summary>
        [Newtonsoft.Json.JsonProperty("issuingAuthority", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OrganizationType IssuingAuthority
        {
            get { return _issuingAuthority; }
            set
            {
                if (_issuingAuthority != value)
                {
                    _issuingAuthority = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>References to attachments in the message that provide evidence of the issue or the validity of the license.</summary>
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

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static CertificationType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CertificationType>(data);
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

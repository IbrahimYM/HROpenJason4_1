using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>Describes a disability associated with a specified person. Want of ability to discharge a function. Incapacity in the eye of the law. (PRELIMINARY/PROPOSAL)</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DisabilitySummaryType : System.ComponentModel.INotifyPropertyChanged
    {
        private DisabilityLevelCodeList _disabilityLevelCode;
        private double _percentage;
        private string _disabilityTypeCode;
        private FormattedDateTimeType _disabilityDate;
        private FormattedDateTimeType _disabilityCertifiedDate;
        private FormattedDateTimeType _recoveryDate;
        private System.Collections.ObjectModel.ObservableCollection<string> _accomodationTypeCode = new System.Collections.ObjectModel.ObservableCollection<string>();
        private CommentType _comment = new CommentType();
        private EffectiveTimePeriod _effectiveDate = new EffectiveTimePeriod();

        /// <summary>A value from an external code list classifying the level of disability.</summary>
        [Newtonsoft.Json.JsonProperty("disabilityLevelCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DisabilityLevelCodeList DisabilityLevelCode
        {
            get { return _disabilityLevelCode; }
            set
            {
                if (_disabilityLevelCode != value)
                {
                    _disabilityLevelCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The amount of disability as a percentage of impairment. This should be defined by a medical board based on standards.</summary>
        [Newtonsoft.Json.JsonProperty("percentage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Percentage
        {
            get { return _percentage; }
            set
            {
                if (_percentage != value)
                {
                    _percentage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A value from an external code list classifying the type of disability. Examples: 1. DisabilityConditionType as defined by PESC.org; 2. U.S. Office of Special Education Programs (OSEP) Primary and Secondary Disability Codes; 3. 'Total', 'Partial', and 'Residual' as broad classifications of disability in certain contexts (Acord.org).</summary>
        [Newtonsoft.Json.JsonProperty("disabilityTypeCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DisabilityTypeCode
        {
            get { return _disabilityTypeCode; }
            set
            {
                if (_disabilityTypeCode != value)
                {
                    _disabilityTypeCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The date on which an injury occurred or which is otherwise associated as the start of a period ofdisability.</summary>
        [Newtonsoft.Json.JsonProperty("disabilityDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FormattedDateTimeType DisabilityDate
        {
            get { return _disabilityDate; }
            set
            {
                if (_disabilityDate != value)
                {
                    _disabilityDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The date on which a person a person's disabled status is verified by a doctor or medical professional.</summary>
        [Newtonsoft.Json.JsonProperty("disabilityCertifiedDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FormattedDateTimeType DisabilityCertifiedDate
        {
            get { return _disabilityCertifiedDate; }
            set
            {
                if (_disabilityCertifiedDate != value)
                {
                    _disabilityCertifiedDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The date on which a person is determined to have recovered from an injury or disability.</summary>
        [Newtonsoft.Json.JsonProperty("recoveryDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FormattedDateTimeType RecoveryDate
        {
            get { return _recoveryDate; }
            set
            {
                if (_recoveryDate != value)
                {
                    _recoveryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A code identifying a type of assistance or technology required to accomodate a disability. This is a value from an external code list.</summary>
        [Newtonsoft.Json.JsonProperty("accomodationTypeCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> AccomodationTypeCode
        {
            get { return _accomodationTypeCode; }
            set
            {
                if (_accomodationTypeCode != value)
                {
                    _accomodationTypeCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Additional comments on the disability.</summary>
        [Newtonsoft.Json.JsonProperty("comment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CommentType Comment
        {
            get { return _comment; }
            set
            {
                if (_comment != value)
                {
                    _comment = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Effective date of the defined disability.</summary>
        [Newtonsoft.Json.JsonProperty("effectiveDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EffectiveTimePeriod EffectiveDate
        {
            get { return _effectiveDate; }
            set
            {
                if (_effectiveDate != value)
                {
                    _effectiveDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static DisabilitySummaryType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DisabilitySummaryType>(data);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{

    /// <summary>A document or other record providing evidence of a competency or that is treated as a proxy for the existence of the competency. Examples include: an assessment result; a performance appraisal; an educational degree; a supervisor's observation; etc.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CompetencyEvidenceType : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<IdentifierType> _ids = new System.Collections.ObjectModel.ObservableCollection<IdentifierType>();
        private string _evidenceTypeCode;
        private string _evidenceName;
        private System.Collections.ObjectModel.ObservableCollection<string> _descriptions = new System.Collections.ObjectModel.ObservableCollection<string>();
        private IdentifierType _evidenceRequirementsId = new IdentifierType();
        private System.Collections.ObjectModel.ObservableCollection<ScoreType> _scores = new System.Collections.ObjectModel.ObservableCollection<ScoreType>();
        private OpenEndPeriodType _effectivePeriod;
        private FormattedDateTimeType _verificationDate;
        private string _verificationSourceName;
        private AttachmentReferenceType _attachmentReference = new AttachmentReferenceType();

        [Newtonsoft.Json.JsonProperty("ids", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<IdentifierType> Ids
        {
            get { return _ids; }
            set
            {
                if (_ids != value)
                {
                    _ids = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A code categorizing the type of evidence that substantiates a related competency. For example, 'assessment,' 'degree,' 'performance appraisal' etc.</summary>
        [Newtonsoft.Json.JsonProperty("evidenceTypeCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EvidenceTypeCode
        {
            get { return _evidenceTypeCode; }
            set
            {
                if (_evidenceTypeCode != value)
                {
                    _evidenceTypeCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A name or label for the evidence.</summary>
        [Newtonsoft.Json.JsonProperty("evidenceName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EvidenceName
        {
            get { return _evidenceName; }
            set
            {
                if (_evidenceName != value)
                {
                    _evidenceName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Description of the evidence requirement.</summary>
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

        /// <summary>An identifier for a policy associated with or governing the type of evidence. For example, a policy setting a confidence level or minimum requirement for the associated evidence.</summary>
        [Newtonsoft.Json.JsonProperty("evidenceRequirementsId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdentifierType EvidenceRequirementsId
        {
            get { return _evidenceRequirementsId; }
            set
            {
                if (_evidenceRequirementsId != value)
                {
                    _evidenceRequirementsId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Scores supporting the competency evidence.</summary>
        [Newtonsoft.Json.JsonProperty("scores", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ScoreType> Scores
        {
            get { return _scores; }
            set
            {
                if (_scores != value)
                {
                    _scores = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("effectivePeriod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OpenEndPeriodType EffectivePeriod
        {
            get { return _effectivePeriod; }
            set
            {
                if (_effectivePeriod != value)
                {
                    _effectivePeriod = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The date on which the associated information or fact was verified.</summary>
        [Newtonsoft.Json.JsonProperty("verificationDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FormattedDateTimeType VerificationDate
        {
            get { return _verificationDate; }
            set
            {
                if (_verificationDate != value)
                {
                    _verificationDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The name of the service, person, or agent from which the verification was obtained.</summary>
        [Newtonsoft.Json.JsonProperty("verificationSourceName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VerificationSourceName
        {
            get { return _verificationSourceName; }
            set
            {
                if (_verificationSourceName != value)
                {
                    _verificationSourceName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("attachmentReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AttachmentReferenceType AttachmentReference
        {
            get { return _attachmentReference; }
            set
            {
                if (_attachmentReference != value)
                {
                    _attachmentReference = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static CompetencyEvidenceType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CompetencyEvidenceType>(data);
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

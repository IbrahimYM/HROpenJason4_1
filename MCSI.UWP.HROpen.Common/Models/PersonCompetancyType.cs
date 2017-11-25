using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>A specified person competency is a competency within the context of a personal record (profile, appraisal, assessment) assessed or asserted at specified level of proficiency.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PersonCompetencyType : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<IdentifierType> _competencyIds = new System.Collections.ObjectModel.ObservableCollection<IdentifierType>();
        private string _competencyName;
        private string _description;
        private BaseScoreType _proficiencyLevel = new BaseScoreType();
        private FormattedDateTimeType _lastUsedDate;
        private MeasureType _experienceMeasure = new MeasureType();
        private BaseScoreType _interestLevel = new BaseScoreType();
        private System.Collections.ObjectModel.ObservableCollection<CompetencyDimensionType> _competencyDimensions = new System.Collections.ObjectModel.ObservableCollection<CompetencyDimensionType>();
        private CompetencyEvidenceType _competencyEvidence = new CompetencyEvidenceType();
        private System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType> _attachmentReferences = new System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType>();

        /// <summary>A unique identifier for a competency definition.</summary>
        [Newtonsoft.Json.JsonProperty("competencyIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<IdentifierType> CompetencyIds
        {
            get { return _competencyIds; }
            set
            {
                if (_competencyIds != value)
                {
                    _competencyIds = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A human readable, descriptive name for the given competency.</summary>
        [Newtonsoft.Json.JsonProperty("competencyName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompetencyName
        {
            get { return _competencyName; }
            set
            {
                if (_competencyName != value)
                {
                    _competencyName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Brief description of the named competency.</summary>
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

        /// <summary>A minimum level of proficiency for a competency  associated with a position, role, course, or other item. The proficiency level is expressed as a score a point scale or a mark among range of values.</summary>
        [Newtonsoft.Json.JsonProperty("proficiencyLevel", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BaseScoreType ProficiencyLevel
        {
            get { return _proficiencyLevel; }
            set
            {
                if (_proficiencyLevel != value)
                {
                    _proficiencyLevel = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("lastUsedDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FormattedDateTimeType LastUsedDate
        {
            get { return _lastUsedDate; }
            set
            {
                if (_lastUsedDate != value)
                {
                    _lastUsedDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The number of years of experience associated with the given entity. For example, this may be years of experience asserted or claimed by a candidate as evidence of a competency.  Or it may be the assertion of a competency evidence policy or requirement for years of experience associated with a position or role. Use the unitCode to specify 'years' or 'months'.</summary>
        [Newtonsoft.Json.JsonProperty("experienceMeasure", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MeasureType ExperienceMeasure
        {
            get { return _experienceMeasure; }
            set
            {
                if (_experienceMeasure != value)
                {
                    _experienceMeasure = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A rating of a person's interest associated with a competency.</summary>
        [Newtonsoft.Json.JsonProperty("interestLevel", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BaseScoreType InterestLevel
        {
            get { return _interestLevel; }
            set
            {
                if (_interestLevel != value)
                {
                    _interestLevel = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("competencyDimensions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<CompetencyDimensionType> CompetencyDimensions
        {
            get { return _competencyDimensions; }
            set
            {
                if (_competencyDimensions != value)
                {
                    _competencyDimensions = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("competencyEvidence", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CompetencyEvidenceType CompetencyEvidence
        {
            get { return _competencyEvidence; }
            set
            {
                if (_competencyEvidence != value)
                {
                    _competencyEvidence = value;
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

        public static PersonCompetencyType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PersonCompetencyType>(data);
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

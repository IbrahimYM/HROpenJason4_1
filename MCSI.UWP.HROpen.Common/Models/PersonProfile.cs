using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{

    /// <summary>Personal profile</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PersonProfile : System.ComponentModel.INotifyPropertyChanged
    {
        private string _profileName;
        private LanguageCodeList _languageCode;
        private System.Collections.ObjectModel.ObservableCollection<EducationAttendanceType> _education = new System.Collections.ObjectModel.ObservableCollection<EducationAttendanceType>();
        private System.Collections.ObjectModel.ObservableCollection<EmployerHistoryType> _employment = new System.Collections.ObjectModel.ObservableCollection<EmployerHistoryType>();
        private System.Collections.ObjectModel.ObservableCollection<MilitaryServiceType> _militaryService = new System.Collections.ObjectModel.ObservableCollection<MilitaryServiceType>();
        private System.Collections.ObjectModel.ObservableCollection<LicenseType> _licenses = new System.Collections.ObjectModel.ObservableCollection<LicenseType>();
        private System.Collections.ObjectModel.ObservableCollection<CertificationType> _certifications = new System.Collections.ObjectModel.ObservableCollection<CertificationType>();
        private System.Collections.ObjectModel.ObservableCollection<PatentType> _patents = new System.Collections.ObjectModel.ObservableCollection<PatentType>();
        private System.Collections.ObjectModel.ObservableCollection<PublicationType> _publications = new System.Collections.ObjectModel.ObservableCollection<PublicationType>();
        private System.Collections.ObjectModel.ObservableCollection<PersonCompetencyType> _qualifications = new System.Collections.ObjectModel.ObservableCollection<PersonCompetencyType>();
        private System.Collections.ObjectModel.ObservableCollection<OrganizationAffiliationType> _affiliations = new System.Collections.ObjectModel.ObservableCollection<OrganizationAffiliationType>();
        private System.Collections.ObjectModel.ObservableCollection<SecurityCredentialType> _securityCredentials = new System.Collections.ObjectModel.ObservableCollection<SecurityCredentialType>();
        private System.Collections.ObjectModel.ObservableCollection<RefereeType> _references = new System.Collections.ObjectModel.ObservableCollection<RefereeType>();
        private System.Collections.ObjectModel.ObservableCollection<AttachmentType> _attachments = new System.Collections.ObjectModel.ObservableCollection<AttachmentType>();

        /// <summary>The name given to the profile.</summary>
        [Newtonsoft.Json.JsonProperty("profileName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProfileName
        {
            get { return _profileName; }
            set
            {
                if (_profileName != value)
                {
                    _profileName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The primary language of the content of the profile.</summary>
        [Newtonsoft.Json.JsonProperty("languageCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LanguageCodeList LanguageCode
        {
            get { return _languageCode; }
            set
            {
                if (_languageCode != value)
                {
                    _languageCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The education history of the person.</summary>
        [Newtonsoft.Json.JsonProperty("education", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<EducationAttendanceType> Education
        {
            get { return _education; }
            set
            {
                if (_education != value)
                {
                    _education = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The employment history of the person.</summary>
        [Newtonsoft.Json.JsonProperty("employment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<EmployerHistoryType> Employment
        {
            get { return _employment; }
            set
            {
                if (_employment != value)
                {
                    _employment = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The military history of the person.</summary>
        [Newtonsoft.Json.JsonProperty("militaryService", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<MilitaryServiceType> MilitaryService
        {
            get { return _militaryService; }
            set
            {
                if (_militaryService != value)
                {
                    _militaryService = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The licenses that the person holds.</summary>
        [Newtonsoft.Json.JsonProperty("licenses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<LicenseType> Licenses
        {
            get { return _licenses; }
            set
            {
                if (_licenses != value)
                {
                    _licenses = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The certifications that the person holds.</summary>
        [Newtonsoft.Json.JsonProperty("certifications", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<CertificationType> Certifications
        {
            get { return _certifications; }
            set
            {
                if (_certifications != value)
                {
                    _certifications = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The patents with which the person is involved.</summary>
        [Newtonsoft.Json.JsonProperty("patents", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<PatentType> Patents
        {
            get { return _patents; }
            set
            {
                if (_patents != value)
                {
                    _patents = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The publications with which the person is involved.</summary>
        [Newtonsoft.Json.JsonProperty("publications", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<PublicationType> Publications
        {
            get { return _publications; }
            set
            {
                if (_publications != value)
                {
                    _publications = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The competencies of the person.</summary>
        [Newtonsoft.Json.JsonProperty("qualifications", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<PersonCompetencyType> Qualifications
        {
            get { return _qualifications; }
            set
            {
                if (_qualifications != value)
                {
                    _qualifications = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The organizations with which the person is affiliated.</summary>
        [Newtonsoft.Json.JsonProperty("affiliations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<OrganizationAffiliationType> Affiliations
        {
            get { return _affiliations; }
            set
            {
                if (_affiliations != value)
                {
                    _affiliations = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The security credentials that the person holds.</summary>
        [Newtonsoft.Json.JsonProperty("securityCredentials", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<SecurityCredentialType> SecurityCredentials
        {
            get { return _securityCredentials; }
            set
            {
                if (_securityCredentials != value)
                {
                    _securityCredentials = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The references of the person.</summary>
        [Newtonsoft.Json.JsonProperty("references", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<RefereeType> References
        {
            get { return _references; }
            set
            {
                if (_references != value)
                {
                    _references = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Attachments or online references related to the person's profile.</summary>
        [Newtonsoft.Json.JsonProperty("attachments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<AttachmentType> Attachments
        {
            get { return _attachments; }
            set
            {
                if (_attachments != value)
                {
                    _attachments = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PersonProfile FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PersonProfile>(data);
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

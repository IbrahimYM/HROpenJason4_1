using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>Represents full person information</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PersonType : PersonBaseType, System.ComponentModel.INotifyPropertyChanged
    {
        private MeasureType _height = new MeasureType();
        private object _weight;
        private DisabilityType _disability = new DisabilityType();
        private bool _tobaccoUserIndicator;
        private string _hairColor;
        private string _eyeColor;
        private System.Collections.ObjectModel.ObservableCollection<string> _identifyingMarks = new System.Collections.ObjectModel.ObservableCollection<string>();
        private int _age;
        private string _bloodType;
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
        private IdentifierType _passportId = new IdentifierType();
        private string _fatherName;
        private string _motherName;
        private System.Collections.ObjectModel.ObservableCollection<string> _race = new System.Collections.ObjectModel.ObservableCollection<string>();
        private string _birthPlace;
        private System.DateTime _deathDate;
        private System.Collections.ObjectModel.ObservableCollection<string> _nationality = new System.Collections.ObjectModel.ObservableCollection<string>();
        private string _maritalStatus;
        private System.Collections.ObjectModel.ObservableCollection<string> _visa = new System.Collections.ObjectModel.ObservableCollection<string>();
        private System.Collections.ObjectModel.ObservableCollection<string> _religion = new System.Collections.ObjectModel.ObservableCollection<string>();
        private string _studentType;
        private bool _studentIndicator;
        private string _studentStatus;

        /// <summary>The height of the person.</summary>
        [Newtonsoft.Json.JsonProperty("height", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MeasureType Height
        {
            get { return _height; }
            set
            {
                if (_height != value)
                {
                    _height = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The weight of the person.</summary>
        [Newtonsoft.Json.JsonProperty("weight", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Weight
        {
            get { return _weight; }
            set
            {
                if (_weight != value)
                {
                    _weight = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A type of disability that a person has.</summary>
        [Newtonsoft.Json.JsonProperty("disability", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DisabilityType Disability
        {
            get { return _disability; }
            set
            {
                if (_disability != value)
                {
                    _disability = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>An indicator that a person is a tobacco user.</summary>
        [Newtonsoft.Json.JsonProperty("tobaccoUserIndicator", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool TobaccoUserIndicator
        {
            get { return _tobaccoUserIndicator; }
            set
            {
                if (_tobaccoUserIndicator != value)
                {
                    _tobaccoUserIndicator = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The color of the hair of a person.</summary>
        [Newtonsoft.Json.JsonProperty("hairColor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HairColor
        {
            get { return _hairColor; }
            set
            {
                if (_hairColor != value)
                {
                    _hairColor = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The color of the eyes of a person.</summary>
        [Newtonsoft.Json.JsonProperty("eyeColor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EyeColor
        {
            get { return _eyeColor; }
            set
            {
                if (_eyeColor != value)
                {
                    _eyeColor = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A list of identifiying marks of a person.</summary>
        [Newtonsoft.Json.JsonProperty("identifyingMarks", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> IdentifyingMarks
        {
            get { return _identifyingMarks; }
            set
            {
                if (_identifyingMarks != value)
                {
                    _identifyingMarks = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The age of a person (in years).</summary>
        [Newtonsoft.Json.JsonProperty("age", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Age
        {
            get { return _age; }
            set
            {
                if (_age != value)
                {
                    _age = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The blood type of a person.</summary>
        [Newtonsoft.Json.JsonProperty("bloodType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BloodType
        {
            get { return _bloodType; }
            set
            {
                if (_bloodType != value)
                {
                    _bloodType = value;
                    RaisePropertyChanged();
                }
            }
        }

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

        /// <summary>The passport identification number from the issuing country</summary>
        [Newtonsoft.Json.JsonProperty("passportId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdentifierType PassportId
        {
            get { return _passportId; }
            set
            {
                if (_passportId != value)
                {
                    _passportId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The surname of the father of the person.</summary>
        [Newtonsoft.Json.JsonProperty("fatherName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FatherName
        {
            get { return _fatherName; }
            set
            {
                if (_fatherName != value)
                {
                    _fatherName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The surname of the mother of the person.</summary>
        [Newtonsoft.Json.JsonProperty("motherName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MotherName
        {
            get { return _motherName; }
            set
            {
                if (_motherName != value)
                {
                    _motherName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The identified race(s) of the person.A race is defined as a group of people sharing the same culture, history, language, etc.</summary>
        [Newtonsoft.Json.JsonProperty("race", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Race
        {
            get { return _race; }
            set
            {
                if (_race != value)
                {
                    _race = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The birth place of the person.</summary>
        [Newtonsoft.Json.JsonProperty("birthPlace", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BirthPlace
        {
            get { return _birthPlace; }
            set
            {
                if (_birthPlace != value)
                {
                    _birthPlace = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>If the person is deceased, the legal date that the person died.</summary>
        [Newtonsoft.Json.JsonProperty("deathDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime DeathDate
        {
            get { return _deathDate; }
            set
            {
                if (_deathDate != value)
                {
                    _deathDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The nationality (or nationalities) of the person. Nationality is acquirable by descent, by birth or adoption in the country and/or by marriage. It is not a legal status like citizenship.</summary>
        [Newtonsoft.Json.JsonProperty("nationality", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Nationality
        {
            get { return _nationality; }
            set
            {
                if (_nationality != value)
                {
                    _nationality = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The marital status of the person.</summary>
        [Newtonsoft.Json.JsonProperty("maritalStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaritalStatus
        {
            get { return _maritalStatus; }
            set
            {
                if (_maritalStatus != value)
                {
                    _maritalStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The visas that this person holds.</summary>
        [Newtonsoft.Json.JsonProperty("visa", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Visa
        {
            get { return _visa; }
            set
            {
                if (_visa != value)
                {
                    _visa = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The religions of the person of the person.</summary>
        [Newtonsoft.Json.JsonProperty("religion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Religion
        {
            get { return _religion; }
            set
            {
                if (_religion != value)
                {
                    _religion = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The type of student (if the person is a student).</summary>
        [Newtonsoft.Json.JsonProperty("studentType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StudentType
        {
            get { return _studentType; }
            set
            {
                if (_studentType != value)
                {
                    _studentType = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>An indicator that this person is a student.</summary>
        [Newtonsoft.Json.JsonProperty("studentIndicator", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool StudentIndicator
        {
            get { return _studentIndicator; }
            set
            {
                if (_studentIndicator != value)
                {
                    _studentIndicator = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The status of the student (if the person is a student).</summary>
        [Newtonsoft.Json.JsonProperty("studentStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StudentStatus
        {
            get { return _studentStatus; }
            set
            {
                if (_studentStatus != value)
                {
                    _studentStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PersonType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PersonType>(data);
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

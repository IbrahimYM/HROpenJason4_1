using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>A collection of demographic and personal data about a person.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PersonLegal : System.ComponentModel.INotifyPropertyChanged
    {
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

        public static PersonLegal FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PersonLegal>(data);
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

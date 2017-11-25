using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>Contains details about the student's degree. A degree is a recognized completion of studies at a school (such as a college or university). A certificate, which may be a diploma or degree, is generally issued in recognition of having completed the course of study.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class EducationDegreeType : EntityType, System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<string> _codes = new System.Collections.ObjectModel.ObservableCollection<string>();
        private FormattedDateTimeType _date;
        private System.Collections.ObjectModel.ObservableCollection<EducationSpecializationType> _specializations = new System.Collections.ObjectModel.ObservableCollection<EducationSpecializationType>();
        private ScoreType _score = new ScoreType();
        private System.Collections.ObjectModel.ObservableCollection<string> _academicHonors = new System.Collections.ObjectModel.ObservableCollection<string>();
        private bool _currentlyAttendingIndicator;
        private IscedCodeList _iscedEducationLevelCode;

        [Newtonsoft.Json.JsonProperty("codes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Codes
        {
            get { return _codes; }
            set
            {
                if (_codes != value)
                {
                    _codes = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FormattedDateTimeType Date
        {
            get { return _date; }
            set
            {
                if (_date != value)
                {
                    _date = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The focus of study for the student's degree. This may include majors, minors, emphasis or other foci.</summary>
        [Newtonsoft.Json.JsonProperty("specializations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<EducationSpecializationType> Specializations
        {
            get { return _specializations; }
            set
            {
                if (_specializations != value)
                {
                    _specializations = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ScoreType Score
        {
            get { return _score; }
            set
            {
                if (_score != value)
                {
                    _score = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("academicHonors", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> AcademicHonors
        {
            get { return _academicHonors; }
            set
            {
                if (_academicHonors != value)
                {
                    _academicHonors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicator that the person is still attending.</summary>
        [Newtonsoft.Json.JsonProperty("currentlyAttendingIndicator", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool CurrentlyAttendingIndicator
        {
            get { return _currentlyAttendingIndicator; }
            set
            {
                if (_currentlyAttendingIndicator != value)
                {
                    _currentlyAttendingIndicator = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>ISCED: International Standard Classification of Education - is the standard classificaiton of the education level of this attendance.</summary>
        [Newtonsoft.Json.JsonProperty("iscedEducationLevelCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IscedCodeList IscedEducationLevelCode
        {
            get { return _iscedEducationLevelCode; }
            set
            {
                if (_iscedEducationLevelCode != value)
                {
                    _iscedEducationLevelCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static EducationDegreeType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<EducationDegreeType>(data);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>Contains details documenting a person's attendance at an educational institution. (OED Institution, n. An establishment, organization, or association, instituted for the promotion of education.)</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class EducationAttendanceType : BaseHistoryType, System.ComponentModel.INotifyPropertyChanged
    {
        private OrganizationType _institution = new OrganizationType();
        private OrganizationType _department = new OrganizationType();
        private System.Collections.ObjectModel.ObservableCollection<string> _programs = new System.Collections.ObjectModel.ObservableCollection<string>();
        private System.Collections.ObjectModel.ObservableCollection<EntityType> _educationLevelCodes = new System.Collections.ObjectModel.ObservableCollection<EntityType>();
        private IscedCodeList _iscedEducationLevelCode;
        private bool _goodStandingIndicator;
        private System.Collections.ObjectModel.ObservableCollection<EducationDegreeType> _educationDegrees = new System.Collections.ObjectModel.ObservableCollection<EducationDegreeType>();
        private System.Collections.ObjectModel.ObservableCollection<Anonymous> _otherAttendancePeriods = new System.Collections.ObjectModel.ObservableCollection<Anonymous>();

        /// <summary>The institution to which the person attended.</summary>
        [Newtonsoft.Json.JsonProperty("institution", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OrganizationType Institution
        {
            get { return _institution; }
            set
            {
                if (_institution != value)
                {
                    _institution = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The department at the institution to which the person attended.</summary>
        [Newtonsoft.Json.JsonProperty("department", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OrganizationType Department
        {
            get { return _department; }
            set
            {
                if (_department != value)
                {
                    _department = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The list of programs to which the person attended.</summary>
        [Newtonsoft.Json.JsonProperty("programs", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Programs
        {
            get { return _programs; }
            set
            {
                if (_programs != value)
                {
                    _programs = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The identifier to the level of the education attendance. This could be country-specific or industry-specific classifications.</summary>
        [Newtonsoft.Json.JsonProperty("educationLevelCodes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<EntityType> EducationLevelCodes
        {
            get { return _educationLevelCodes; }
            set
            {
                if (_educationLevelCodes != value)
                {
                    _educationLevelCodes = value;
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

        /// <summary>Indicator that the person is currently in good standing according to the rules of the educational institution.</summary>
        [Newtonsoft.Json.JsonProperty("goodStandingIndicator", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool GoodStandingIndicator
        {
            get { return _goodStandingIndicator; }
            set
            {
                if (_goodStandingIndicator != value)
                {
                    _goodStandingIndicator = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The degrees which were awarded or in process at the institution.</summary>
        [Newtonsoft.Json.JsonProperty("educationDegrees", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<EducationDegreeType> EducationDegrees
        {
            get { return _educationDegrees; }
            set
            {
                if (_educationDegrees != value)
                {
                    _educationDegrees = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Additional periods of attendance</summary>
        [Newtonsoft.Json.JsonProperty("otherAttendancePeriods", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Anonymous> OtherAttendancePeriods
        {
            get { return _otherAttendancePeriods; }
            set
            {
                if (_otherAttendancePeriods != value)
                {
                    _otherAttendancePeriods = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static EducationAttendanceType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<EducationAttendanceType>(data);
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

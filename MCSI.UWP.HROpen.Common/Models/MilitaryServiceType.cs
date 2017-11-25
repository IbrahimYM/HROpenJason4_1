using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>History of military service. Service or employment in a military branch.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class MilitaryServiceType : BaseHistoryType, System.ComponentModel.INotifyPropertyChanged
    {
        private CountryCodeList _countryCode;
        private string _serviceNumber;
        private string _branch;
        private string _division;
        private string _startingRank;
        private string _endingRank;
        private bool _currentRankIndicator;
        private System.Collections.ObjectModel.ObservableCollection<string> _campaigns = new System.Collections.ObjectModel.ObservableCollection<string>();
        private System.Collections.ObjectModel.ObservableCollection<string> _expertises = new System.Collections.ObjectModel.ObservableCollection<string>();
        private System.Collections.ObjectModel.ObservableCollection<string> _honors = new System.Collections.ObjectModel.ObservableCollection<string>();
        private System.Collections.ObjectModel.ObservableCollection<string> _disciplinaryActions = new System.Collections.ObjectModel.ObservableCollection<string>();
        private string _dischargeStatus;
        private System.Collections.ObjectModel.ObservableCollection<CommentType> _comments = new System.Collections.ObjectModel.ObservableCollection<CommentType>();

        /// <summary>The country to which this mlitary service was performed.</summary>
        [Newtonsoft.Json.JsonProperty("countryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CountryCodeList CountryCode
        {
            get { return _countryCode; }
            set
            {
                if (_countryCode != value)
                {
                    _countryCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The military service number or identifier of the person as defined by the country, branch, and/or division.</summary>
        [Newtonsoft.Json.JsonProperty("serviceNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ServiceNumber
        {
            get { return _serviceNumber; }
            set
            {
                if (_serviceNumber != value)
                {
                    _serviceNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The military office or department in which the person served; e.g. army, navy.</summary>
        [Newtonsoft.Json.JsonProperty("branch", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Branch
        {
            get { return _branch; }
            set
            {
                if (_branch != value)
                {
                    _branch = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The military division as defined in the military branch and country.  It could be a portion of an army or fleet, consisting of a definite number of troops or vessels, under one commanding officer; also applied to a definite portion of a squadron or battalion.</summary>
        [Newtonsoft.Json.JsonProperty("division", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Division
        {
            get { return _division; }
            set
            {
                if (_division != value)
                {
                    _division = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The rank which the person held in the miltary service at the beginning of the service period.</summary>
        [Newtonsoft.Json.JsonProperty("startingRank", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StartingRank
        {
            get { return _startingRank; }
            set
            {
                if (_startingRank != value)
                {
                    _startingRank = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The rank which the person held at the end of the military service period.</summary>
        [Newtonsoft.Json.JsonProperty("endingRank", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndingRank
        {
            get { return _endingRank; }
            set
            {
                if (_endingRank != value)
                {
                    _endingRank = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>An indicator that the rank is currently held.</summary>
        [Newtonsoft.Json.JsonProperty("currentRankIndicator", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool CurrentRankIndicator
        {
            get { return _currentRankIndicator; }
            set
            {
                if (_currentRankIndicator != value)
                {
                    _currentRankIndicator = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A list of campaigns to which the person was involved during the service period</summary>
        [Newtonsoft.Json.JsonProperty("campaigns", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Campaigns
        {
            get { return _campaigns; }
            set
            {
                if (_campaigns != value)
                {
                    _campaigns = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A list of expertise that the person developed during the service period</summary>
        [Newtonsoft.Json.JsonProperty("expertises", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Expertises
        {
            get { return _expertises; }
            set
            {
                if (_expertises != value)
                {
                    _expertises = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A list of honors that the person received during the service period</summary>
        [Newtonsoft.Json.JsonProperty("honors", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Honors
        {
            get { return _honors; }
            set
            {
                if (_honors != value)
                {
                    _honors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A list of disciplinary actions taken during the service period</summary>
        [Newtonsoft.Json.JsonProperty("disciplinaryActions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> DisciplinaryActions
        {
            get { return _disciplinaryActions; }
            set
            {
                if (_disciplinaryActions != value)
                {
                    _disciplinaryActions = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>If this is not a currently held service, the discharge status for the service period. e.g. honorable, dishonorable, general.</summary>
        [Newtonsoft.Json.JsonProperty("dischargeStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DischargeStatus
        {
            get { return _dischargeStatus; }
            set
            {
                if (_dischargeStatus != value)
                {
                    _dischargeStatus = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Additional comments about the Military service history.</summary>
        [Newtonsoft.Json.JsonProperty("comments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<CommentType> Comments
        {
            get { return _comments; }
            set
            {
                if (_comments != value)
                {
                    _comments = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static MilitaryServiceType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MilitaryServiceType>(data);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{

    /// <summary>The details about a persons tenure within position.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PositionHistoryType : BaseHistoryType, System.ComponentModel.INotifyPropertyChanged
    {
        private string _title;
        private ResourceRelationshipCodeList _resourceRelationshipCode;
        private bool _vendorEmployeeIndicator;
        private OrganizationType _organization = new OrganizationType();
        private LocationType _location = new LocationType();
        private System.Collections.ObjectModel.ObservableCollection<EntityType> _jobCategories = new System.Collections.ObjectModel.ObservableCollection<EntityType>();
        private System.Collections.ObjectModel.ObservableCollection<EntityType> _jobLevels = new System.Collections.ObjectModel.ObservableCollection<EntityType>();

        /// <summary>The title that the person held for this position.</summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The relationship of the person to the organization - an employee or an employee of another company (contract or temporary staffing).</summary>
        [Newtonsoft.Json.JsonProperty("resourceRelationshipCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ResourceRelationshipCodeList ResourceRelationshipCode
        {
            get { return _resourceRelationshipCode; }
            set
            {
                if (_resourceRelationshipCode != value)
                {
                    _resourceRelationshipCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Indicator that this person was a vendor employee for this position.</summary>
        [Newtonsoft.Json.JsonProperty("vendorEmployeeIndicator", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool VendorEmployeeIndicator
        {
            get { return _vendorEmployeeIndicator; }
            set
            {
                if (_vendorEmployeeIndicator != value)
                {
                    _vendorEmployeeIndicator = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The department, sub-company, office, or other sub-organization to which the person was employed.</summary>
        [Newtonsoft.Json.JsonProperty("organization", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OrganizationType Organization
        {
            get { return _organization; }
            set
            {
                if (_organization != value)
                {
                    _organization = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The location of the position to which the person was employed.</summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LocationType Location
        {
            get { return _location; }
            set
            {
                if (_location != value)
                {
                    _location = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The job categories under which the position is classified. These may be international, national, industry, or company categories as defined by the entity owner.</summary>
        [Newtonsoft.Json.JsonProperty("jobCategories", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<EntityType> JobCategories
        {
            get { return _jobCategories; }
            set
            {
                if (_jobCategories != value)
                {
                    _jobCategories = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The job levels under which this position is classified. These may be international, national, industry or company levels as defined by the entity owner.</summary>
        [Newtonsoft.Json.JsonProperty("jobLevels", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<EntityType> JobLevels
        {
            get { return _jobLevels; }
            set
            {
                if (_jobLevels != value)
                {
                    _jobLevels = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PositionHistoryType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PositionHistoryType>(data);
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

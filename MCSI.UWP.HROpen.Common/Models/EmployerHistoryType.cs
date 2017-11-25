using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>The prior and current details of a person's employment, work, or relevant experience such as might be reported within a professional profile, CV, resume, employment application, or similar document. Details of a particular tenure of employment or work with an organization.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class EmployerHistoryType : BaseHistoryType, System.ComponentModel.INotifyPropertyChanged
    {
        private OrganizationType _organization = new OrganizationType();
        private System.Collections.ObjectModel.ObservableCollection<PositionHistoryType> _positionHistories = new System.Collections.ObjectModel.ObservableCollection<PositionHistoryType>();

        /// <summary>The specific organization to which the person held positions or performed work.</summary>
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

        /// <summary>The set of positions that the person held at the organization.</summary>
        [Newtonsoft.Json.JsonProperty("positionHistories", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<PositionHistoryType> PositionHistories
        {
            get { return _positionHistories; }
            set
            {
                if (_positionHistories != value)
                {
                    _positionHistories = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static EmployerHistoryType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<EmployerHistoryType>(data);
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

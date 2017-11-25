using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{        
    /// <summary>REMARK: THIS IS A PRELIMINARY VERSION OF DISABILITY TYPE EMERGED FROM INITIAL DISCUSSIONS WITHIN THE RECRUITING WORK GROUP - OLD: Describes a disability associated with a specified person. Want of ability to discharge a function. Incapacity in the eye of the law.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DisabilityType : System.ComponentModel.INotifyPropertyChanged
    {
        private bool _indicator;
        private System.Collections.ObjectModel.ObservableCollection<DisabilitySummaryType> _summary = new System.Collections.ObjectModel.ObservableCollection<DisabilitySummaryType>();

        [Newtonsoft.Json.JsonProperty("indicator", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Indicator
        {
            get { return _indicator; }
            set
            {
                if (_indicator != value)
                {
                    _indicator = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<DisabilitySummaryType> Summary
        {
            get { return _summary; }
            set
            {
                if (_summary != value)
                {
                    _summary = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static DisabilityType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DisabilityType>(data);
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

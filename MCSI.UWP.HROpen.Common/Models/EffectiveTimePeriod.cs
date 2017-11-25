using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{

    /// <summary>A time period in which an associated object is effective.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class EffectiveTimePeriod : System.ComponentModel.INotifyPropertyChanged
    {
        private System.DateTime _validFrom;
        private System.DateTime _validTo;

        [Newtonsoft.Json.JsonProperty("validFrom", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime ValidFrom
        {
            get { return _validFrom; }
            set
            {
                if (_validFrom != value)
                {
                    _validFrom = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("validTo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime ValidTo
        {
            get { return _validTo; }
            set
            {
                if (_validTo != value)
                {
                    _validTo = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static EffectiveTimePeriod FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<EffectiveTimePeriod>(data);
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

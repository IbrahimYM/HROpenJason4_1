using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>Single period between years. The end year is optional and should be used in cases where the end of the period is unknown or uncertain.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class YearOpenEndPeriodType : System.ComponentModel.INotifyPropertyChanged
    {
        private string _start;
        private string _end;

        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Start
        {
            get { return _start; }
            set
            {
                if (_start != value)
                {
                    _start = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string End
        {
            get { return _end; }
            set
            {
                if (_end != value)
                {
                    _end = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static YearOpenEndPeriodType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<YearOpenEndPeriodType>(data);
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

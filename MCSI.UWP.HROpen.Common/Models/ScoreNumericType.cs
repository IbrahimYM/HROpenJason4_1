using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>A numeric measurement of abilities, capacity to learn, in the assessment of personality, or in other measurable characteristics.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ScoreNumericType : System.ComponentModel.INotifyPropertyChanged
    {
        private double _value;
        private ScoreNumericCodeList _scoreCode;
        private double _interval;
        private double _minimum;
        private double _maximum;

        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        public double Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("scoreCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ScoreNumericCodeList ScoreCode
        {
            get { return _scoreCode; }
            set
            {
                if (_scoreCode != value)
                {
                    _scoreCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A range between one number and another.</summary>
        [Newtonsoft.Json.JsonProperty("interval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Interval
        {
            get { return _interval; }
            set
            {
                if (_interval != value)
                {
                    _interval = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Optional. Indicates lower value for a range.</summary>
        [Newtonsoft.Json.JsonProperty("minimum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Minimum
        {
            get { return _minimum; }
            set
            {
                if (_minimum != value)
                {
                    _minimum = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Optional. Indicates upper value for a range.</summary>
        [Newtonsoft.Json.JsonProperty("maximum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Maximum
        {
            get { return _maximum; }
            set
            {
                if (_maximum != value)
                {
                    _maximum = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ScoreNumericType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ScoreNumericType>(data);
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

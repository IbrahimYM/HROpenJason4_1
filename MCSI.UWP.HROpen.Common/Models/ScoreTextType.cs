using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>A non-numeric or textual representation of a Score.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ScoreTextType : System.ComponentModel.INotifyPropertyChanged
    {
        private string _value;
        private string _scoreTextCode;
        private string _minimum;
        private string _maximum;

        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Value
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

        /// <summary>Default: CourseGrade. A code used to textually classify the type scoring methodology or convention.</summary>
        [Newtonsoft.Json.JsonProperty("scoreTextCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScoreTextCode
        {
            get { return _scoreTextCode; }
            set
            {
                if (_scoreTextCode != value)
                {
                    _scoreTextCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Optional. Describes the minumum score.</summary>
        [Newtonsoft.Json.JsonProperty("minimum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Minimum
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

        /// <summary>Optional. Describes the maximum score.</summary>
        [Newtonsoft.Json.JsonProperty("maximum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Maximum
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

        public static ScoreTextType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ScoreTextType>(data);
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

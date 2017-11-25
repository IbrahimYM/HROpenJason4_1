using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>A measurable characteristic of a competency. Examples might include 'frequency of use,' 'level of interest,' etc.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CompetencyDimensionType : System.ComponentModel.INotifyPropertyChanged
    {
        private string _dimensionType;
        private ScoreType _score = new ScoreType();

        /// <summary>A code classifying the type of competency dimension.</summary>
        [Newtonsoft.Json.JsonProperty("dimensionType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DimensionType
        {
            get { return _dimensionType; }
            set
            {
                if (_dimensionType != value)
                {
                    _dimensionType = value;
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

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static CompetencyDimensionType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CompetencyDimensionType>(data);
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

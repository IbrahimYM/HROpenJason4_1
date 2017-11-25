using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>Type object to contain either numeric or text scores.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class BaseScoreType : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<ScoreNumericType> _scoresNumeric = new System.Collections.ObjectModel.ObservableCollection<ScoreNumericType>();
        private System.Collections.ObjectModel.ObservableCollection<ScoreTextType> _scoresText = new System.Collections.ObjectModel.ObservableCollection<ScoreTextType>();

        /// <summary>Numeric scores for a test.</summary>
        [Newtonsoft.Json.JsonProperty("scoresNumeric", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ScoreNumericType> ScoresNumeric
        {
            get { return _scoresNumeric; }
            set
            {
                if (_scoresNumeric != value)
                {
                    _scoresNumeric = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Text scores for a test.</summary>
        [Newtonsoft.Json.JsonProperty("scoresText", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ScoreTextType> ScoresText
        {
            get { return _scoresText; }
            set
            {
                if (_scoresText != value)
                {
                    _scoresText = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static BaseScoreType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BaseScoreType>(data);
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

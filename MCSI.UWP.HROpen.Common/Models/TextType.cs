using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>Text is a character string such as a finite set of characters generally in the form of words of a language.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class TextType : System.ComponentModel.INotifyPropertyChanged
    {
        private string _value;
        private LanguageCodeList _languageCode;

        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
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

        [Newtonsoft.Json.JsonProperty("languageCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LanguageCodeList LanguageCode
        {
            get { return _languageCode; }
            set
            {
                if (_languageCode != value)
                {
                    _languageCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static TextType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TextType>(data);
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

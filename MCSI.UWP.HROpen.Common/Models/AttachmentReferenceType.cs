using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>Attachment reference within document domain</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AttachmentReferenceType : System.ComponentModel.INotifyPropertyChanged
    {
        private IdentifierType _reference = new IdentifierType();
        private string _uri;
        private System.Collections.ObjectModel.ObservableCollection<string> _descriptions = new System.Collections.ObjectModel.ObservableCollection<string>();

        [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdentifierType Reference
        {
            get { return _reference; }
            set
            {
                if (_reference != value)
                {
                    _reference = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Internal instance JSON pointer reference</summary>
        [Newtonsoft.Json.JsonProperty("uri", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Uri
        {
            get { return _uri; }
            set
            {
                if (_uri != value)
                {
                    _uri = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("descriptions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> Descriptions
        {
            get { return _descriptions; }
            set
            {
                if (_descriptions != value)
                {
                    _descriptions = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static AttachmentReferenceType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AttachmentReferenceType>(data);
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

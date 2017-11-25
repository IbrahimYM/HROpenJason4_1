using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>Basic type that contains all properties common to a person's profile history entry - intended for use in education history, employment history or military history.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class BaseHistoryType : System.ComponentModel.INotifyPropertyChanged
    {
        private IdentifierType _id = new IdentifierType();
        private FormattedDateTimeType _start;
        private FormattedDateTimeType _end;
        private bool _current;
        private System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType> _attachmentReferences = new System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType>();
        private System.Collections.ObjectModel.ObservableCollection<string> _descriptions = new System.Collections.ObjectModel.ObservableCollection<string>();

        /// <summary>The identifier for the history.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdentifierType Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The start date of the history if known.</summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FormattedDateTimeType Start
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

        /// <summary>The end date of the history if known.</summary>
        [Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FormattedDateTimeType End
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

        /// <summary>Indicator that the person's history entry is current active (i.e. if education, still at the school. If work history, still working at the organization)</summary>
        [Newtonsoft.Json.JsonProperty("current", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Current
        {
            get { return _current; }
            set
            {
                if (_current != value)
                {
                    _current = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Attachment references supporting the history entry.</summary>
        [Newtonsoft.Json.JsonProperty("attachmentReferences", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType> AttachmentReferences
        {
            get { return _attachmentReferences; }
            set
            {
                if (_attachmentReferences != value)
                {
                    _attachmentReferences = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Additional details or descriptions about the history entry.</summary>
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

        public static BaseHistoryType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BaseHistoryType>(data);
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

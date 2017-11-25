using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PublicationType : System.ComponentModel.INotifyPropertyChanged
    {
        private IdentifierType _id = new IdentifierType();
        private PublicationTypeCodeList _type;
        private System.DateTime _date;
        private string _title;
        private string _abstract;
        private System.Collections.ObjectModel.ObservableCollection<Anonymous> _contributors = new System.Collections.ObjectModel.ObservableCollection<Anonymous>();
        private System.Collections.ObjectModel.ObservableCollection<Anonymous> _copyrights = new System.Collections.ObjectModel.ObservableCollection<Anonymous>();
        private System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType> _attachmentReferences = new System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType>();
        private LanguageCodeList _languageCode;
        private System.Collections.ObjectModel.ObservableCollection<CommentType> _comments = new System.Collections.ObjectModel.ObservableCollection<CommentType>();
        private string _journal;
        private string _issn;
        private string _volume;
        private string _issue;
        private string _pages;
        private string _edition;
        private string _chapters;
        private string _isbn;
        private string _publisher;
        private LocationType _publisherLocation = new LocationType();
        private EventType _event = new EventType();

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

        /// <summary>Type of publication, such as a book or article.</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        public PublicationTypeCodeList Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime Date
        {
            get { return _date; }
            set
            {
                if (_date != value)
                {
                    _date = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("abstract", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Abstract
        {
            get { return _abstract; }
            set
            {
                if (_abstract != value)
                {
                    _abstract = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("contributors", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Anonymous> Contributors
        {
            get { return _contributors; }
            set
            {
                if (_contributors != value)
                {
                    _contributors = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A list of copyright holders and year when the copyright was issued.</summary>
        [Newtonsoft.Json.JsonProperty("copyrights", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Anonymous> Copyrights
        {
            get { return _copyrights; }
            set
            {
                if (_copyrights != value)
                {
                    _copyrights = value;
                    RaisePropertyChanged();
                }
            }
        }

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

        /// <summary>The language of the publication.</summary>
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

        /// <summary>Comments related to the publication.</summary>
        [Newtonsoft.Json.JsonProperty("comments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<CommentType> Comments
        {
            get { return _comments; }
            set
            {
                if (_comments != value)
                {
                    _comments = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The journal where the publication was published.</summary>
        [Newtonsoft.Json.JsonProperty("journal", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Journal
        {
            get { return _journal; }
            set
            {
                if (_journal != value)
                {
                    _journal = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The ISSN (International Standard Serial Number) issued for the publication.</summary>
        [Newtonsoft.Json.JsonProperty("issn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Issn
        {
            get { return _issn; }
            set
            {
                if (_issn != value)
                {
                    _issn = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("volume", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Volume
        {
            get { return _volume; }
            set
            {
                if (_volume != value)
                {
                    _volume = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("issue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Issue
        {
            get { return _issue; }
            set
            {
                if (_issue != value)
                {
                    _issue = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("pages", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pages
        {
            get { return _pages; }
            set
            {
                if (_pages != value)
                {
                    _pages = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("edition", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Edition
        {
            get { return _edition; }
            set
            {
                if (_edition != value)
                {
                    _edition = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("chapters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Chapters
        {
            get { return _chapters; }
            set
            {
                if (_chapters != value)
                {
                    _chapters = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("isbn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Isbn
        {
            get { return _isbn; }
            set
            {
                if (_isbn != value)
                {
                    _isbn = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("publisher", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Publisher
        {
            get { return _publisher; }
            set
            {
                if (_publisher != value)
                {
                    _publisher = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("publisherLocation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LocationType PublisherLocation
        {
            get { return _publisherLocation; }
            set
            {
                if (_publisherLocation != value)
                {
                    _publisherLocation = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("event", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EventType Event
        {
            get { return _event; }
            set
            {
                if (_event != value)
                {
                    _event = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PublicationType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PublicationType>(data);
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

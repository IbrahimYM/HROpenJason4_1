using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>OLD: A person who may be referred to for information or guidance on the character or other qualities of someone, spec. of an applicant for employment, for an academic or other award, or the like.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class RefereeType : System.ComponentModel.INotifyPropertyChanged
    {
        private IdentifierType _refereeId = new IdentifierType();
        private PersonNameType _personName = new PersonNameType();
        private string _positionTitle;
        private string _organizationName;
        private CommunicationType _communication = new CommunicationType();
        private double _yearsKnown;
        private RelationshipTypeCodeList _relationship;
        private System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType> _attachmentReferences = new System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType>();
        private System.Collections.ObjectModel.ObservableCollection<CommentType> _comments = new System.Collections.ObjectModel.ObservableCollection<CommentType>();

        [Newtonsoft.Json.JsonProperty("refereeId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdentifierType RefereeId
        {
            get { return _refereeId; }
            set
            {
                if (_refereeId != value)
                {
                    _refereeId = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("personName", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public PersonNameType PersonName
        {
            get { return _personName; }
            set
            {
                if (_personName != value)
                {
                    _personName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("positionTitle", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PositionTitle
        {
            get { return _positionTitle; }
            set
            {
                if (_positionTitle != value)
                {
                    _positionTitle = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("organizationName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationName
        {
            get { return _organizationName; }
            set
            {
                if (_organizationName != value)
                {
                    _organizationName = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("communication", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CommunicationType Communication
        {
            get { return _communication; }
            set
            {
                if (_communication != value)
                {
                    _communication = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("yearsKnown", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double YearsKnown
        {
            get { return _yearsKnown; }
            set
            {
                if (_yearsKnown != value)
                {
                    _yearsKnown = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("relationship", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RelationshipTypeCodeList Relationship
        {
            get { return _relationship; }
            set
            {
                if (_relationship != value)
                {
                    _relationship = value;
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

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RefereeType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RefereeType>(data);
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

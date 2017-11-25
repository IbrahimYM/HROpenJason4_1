using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PatentType : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<IdentifierType> _ids = new System.Collections.ObjectModel.ObservableCollection<IdentifierType>();
        private string _title;
        private System.Collections.ObjectModel.ObservableCollection<string> _inventorNames = new System.Collections.ObjectModel.ObservableCollection<string>();
        private System.Collections.ObjectModel.ObservableCollection<string> _assigneeNames = new System.Collections.ObjectModel.ObservableCollection<string>();
        private OrganizationType _issuingAuthority = new OrganizationType();
        private PatentStatusCodeList _status;
        private System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType> _attachmentReferences = new System.Collections.ObjectModel.ObservableCollection<AttachmentReferenceType>();
        private System.Collections.ObjectModel.ObservableCollection<string> _descriptions = new System.Collections.ObjectModel.ObservableCollection<string>();

        [Newtonsoft.Json.JsonProperty("ids", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<IdentifierType> Ids
        {
            get { return _ids; }
            set
            {
                if (_ids != value)
                {
                    _ids = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The patent title as registered with the government organization.</summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
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

        /// <summary>The list of inventors who are registered on the patent.</summary>
        [Newtonsoft.Json.JsonProperty("inventorNames", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> InventorNames
        {
            get { return _inventorNames; }
            set
            {
                if (_inventorNames != value)
                {
                    _inventorNames = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The list of assignees who are registered on the patent.</summary>
        [Newtonsoft.Json.JsonProperty("assigneeNames", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> AssigneeNames
        {
            get { return _assigneeNames; }
            set
            {
                if (_assigneeNames != value)
                {
                    _assigneeNames = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The agency under which the patent is registered</summary>
        [Newtonsoft.Json.JsonProperty("issuingAuthority", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OrganizationType IssuingAuthority
        {
            get { return _issuingAuthority; }
            set
            {
                if (_issuingAuthority != value)
                {
                    _issuingAuthority = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The current status of the patent. Statuses include filed, pending, issued.</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PatentStatusCodeList Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>References to the patent.</summary>
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

        public static PatentType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PatentType>(data);
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

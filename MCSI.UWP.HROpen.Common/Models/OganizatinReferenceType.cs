using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>Basic information to reference a specific organization.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class OrganizationReferenceType : EntityType, System.ComponentModel.INotifyPropertyChanged
    {
        private ResponsibilityCodeList _responsibilityCode;
        private CommunicationType _communication = new CommunicationType();

        [Newtonsoft.Json.JsonProperty("responsibilityCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ResponsibilityCodeList ResponsibilityCode
        {
            get { return _responsibilityCode; }
            set
            {
                if (_responsibilityCode != value)
                {
                    _responsibilityCode = value;
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

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static OrganizationReferenceType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<OrganizationReferenceType>(data);
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

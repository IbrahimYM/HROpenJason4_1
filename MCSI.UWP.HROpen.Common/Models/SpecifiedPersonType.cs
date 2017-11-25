using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>Contains information to identify a person associated with the interaction or entity.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SpecifiedPersonType : PersonReferenceType, System.ComponentModel.INotifyPropertyChanged
    {
        private string _roleCode;

        [Newtonsoft.Json.JsonProperty("roleCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RoleCode
        {
            get { return _roleCode; }
            set
            {
                if (_roleCode != value)
                {
                    _roleCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static SpecifiedPersonType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SpecifiedPersonType>(data);
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

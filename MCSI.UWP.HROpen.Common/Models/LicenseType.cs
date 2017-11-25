using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>Authoritative permission to hold a certain status or to do certain things, e.g. to practise some trade or profession. (OED license, n. a. A formal, usually a printed or written permission from a constituted authority to do something. b. The document embodying such a permission.)</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class LicenseType : CertificationType, System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<Anonymous> _endorsements = new System.Collections.ObjectModel.ObservableCollection<Anonymous>();
        private System.Collections.ObjectModel.ObservableCollection<Anonymous> _restrictions = new System.Collections.ObjectModel.ObservableCollection<Anonymous>();
        private System.Collections.ObjectModel.ObservableCollection<Anonymous> _violations = new System.Collections.ObjectModel.ObservableCollection<Anonymous>();

        /// <summary>The modifications to the base license as authorized by the issuing authority that allow for additional access or grant additional qualifications. Examples include different variations of drivers or pilot licenses that allow for additional vehicles to be operated.</summary>
        [Newtonsoft.Json.JsonProperty("endorsements", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Anonymous> Endorsements
        {
            get { return _endorsements; }
            set
            {
                if (_endorsements != value)
                {
                    _endorsements = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The modifications to the base license as authorized by the issuing authority that restrict access or remove permissions or authority. Examples include requiring vision ware while operating a motor vehicle, or requiring an additional licensed operator to accompany the licensee while operating a vehicle.</summary>
        [Newtonsoft.Json.JsonProperty("restrictions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Anonymous> Restrictions
        {
            get { return _restrictions; }
            set
            {
                if (_restrictions != value)
                {
                    _restrictions = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Provide a list of violations or transgressions against the license as per the licensing authority or other authorities. Examples include points violations on a drivers license due to speeding.</summary>
        [Newtonsoft.Json.JsonProperty("violations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Anonymous> Violations
        {
            get { return _violations; }
            set
            {
                if (_violations != value)
                {
                    _violations = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static LicenseType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<LicenseType>(data);
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

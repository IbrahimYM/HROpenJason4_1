using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{

    /// <summary>Person physical information</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PersonPhysical : System.ComponentModel.INotifyPropertyChanged
    {
        private MeasureType _height = new MeasureType();
        private object _weight;
        private DisabilityType _disability = new DisabilityType();
        private bool _tobaccoUserIndicator;
        private string _hairColor;
        private string _eyeColor;
        private System.Collections.ObjectModel.ObservableCollection<string> _identifyingMarks = new System.Collections.ObjectModel.ObservableCollection<string>();
        private int _age;
        private string _bloodType;

        /// <summary>The height of the person.</summary>
        [Newtonsoft.Json.JsonProperty("height", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MeasureType Height
        {
            get { return _height; }
            set
            {
                if (_height != value)
                {
                    _height = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The weight of the person.</summary>
        [Newtonsoft.Json.JsonProperty("weight", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Weight
        {
            get { return _weight; }
            set
            {
                if (_weight != value)
                {
                    _weight = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A type of disability that a person has.</summary>
        [Newtonsoft.Json.JsonProperty("disability", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DisabilityType Disability
        {
            get { return _disability; }
            set
            {
                if (_disability != value)
                {
                    _disability = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>An indicator that a person is a tobacco user.</summary>
        [Newtonsoft.Json.JsonProperty("tobaccoUserIndicator", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool TobaccoUserIndicator
        {
            get { return _tobaccoUserIndicator; }
            set
            {
                if (_tobaccoUserIndicator != value)
                {
                    _tobaccoUserIndicator = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The color of the hair of a person.</summary>
        [Newtonsoft.Json.JsonProperty("hairColor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HairColor
        {
            get { return _hairColor; }
            set
            {
                if (_hairColor != value)
                {
                    _hairColor = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The color of the eyes of a person.</summary>
        [Newtonsoft.Json.JsonProperty("eyeColor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EyeColor
        {
            get { return _eyeColor; }
            set
            {
                if (_eyeColor != value)
                {
                    _eyeColor = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>A list of identifiying marks of a person.</summary>
        [Newtonsoft.Json.JsonProperty("identifyingMarks", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> IdentifyingMarks
        {
            get { return _identifyingMarks; }
            set
            {
                if (_identifyingMarks != value)
                {
                    _identifyingMarks = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The age of a person (in years).</summary>
        [Newtonsoft.Json.JsonProperty("age", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Age
        {
            get { return _age; }
            set
            {
                if (_age != value)
                {
                    _age = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The blood type of a person.</summary>
        [Newtonsoft.Json.JsonProperty("bloodType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BloodType
        {
            get { return _bloodType; }
            set
            {
                if (_bloodType != value)
                {
                    _bloodType = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PersonPhysical FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PersonPhysical>(data);
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

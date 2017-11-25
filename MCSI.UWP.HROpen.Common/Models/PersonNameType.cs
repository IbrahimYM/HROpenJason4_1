using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{

#pragma warning disable // Disable all warnings

    /// <summary>A component for capturing summary or fine-grain data comprising a person's name</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PersonNameType : Localization, System.ComponentModel.INotifyPropertyChanged
    {
        private string _formattedName;
        private string _legal;
        private string _given;
        private string _preferred;
        private string _middle;
        private string _family;
        private string _alias;
        private string _formerFamily;
        private string _preferredSalutationCode;
        private string _generationAffixCode;
        private string _qualificationAffixCode;
        private string _titleAffixCode;
        private string _initials;

        /// <summary>The formatted name of a person, as it would be written out together (for example, on a mailing label).</summary>
        [Newtonsoft.Json.JsonProperty("formattedName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FormattedName
        {
            get { return _formattedName; }
            set
            {
                if (_formattedName != value)
                {
                    _formattedName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The legal name of a person (typically used if it differs from family name).</summary>
        [Newtonsoft.Json.JsonProperty("legal", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Legal
        {
            get { return _legal; }
            set
            {
                if (_legal != value)
                {
                    _legal = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The given name of a person</summary>
        [Newtonsoft.Json.JsonProperty("given", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Given
        {
            get { return _given; }
            set
            {
                if (_given != value)
                {
                    _given = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The preferred name of a person (if it differs from given name).</summary>
        [Newtonsoft.Json.JsonProperty("preferred", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Preferred
        {
            get { return _preferred; }
            set
            {
                if (_preferred != value)
                {
                    _preferred = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The middle names or initials of a person.</summary>
        [Newtonsoft.Json.JsonProperty("middle", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Middle
        {
            get { return _middle; }
            set
            {
                if (_middle != value)
                {
                    _middle = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The family name (or surname) of a person.</summary>
        [Newtonsoft.Json.JsonProperty("family", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Family
        {
            get { return _family; }
            set
            {
                if (_family != value)
                {
                    _family = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>An alias or (or also known as) name of a person.</summary>
        [Newtonsoft.Json.JsonProperty("alias", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Alias
        {
            get { return _alias; }
            set
            {
                if (_alias != value)
                {
                    _alias = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The former family name of a person (used if the person's name was changed).</summary>
        [Newtonsoft.Json.JsonProperty("formerFamily", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FormerFamily
        {
            get { return _formerFamily; }
            set
            {
                if (_formerFamily != value)
                {
                    _formerFamily = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The salutation used to address a person (such as Dr., Mr., Mrs.).</summary>
        [Newtonsoft.Json.JsonProperty("preferredSalutationCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PreferredSalutationCode
        {
            get { return _preferredSalutationCode; }
            set
            {
                if (_preferredSalutationCode != value)
                {
                    _preferredSalutationCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The generational affix attached to a person's name (such as Jr., Sr., II, III).</summary>
        [Newtonsoft.Json.JsonProperty("generationAffixCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GenerationlAffixCode
        {
            get { return _generationAffixCode; }
            set
            {
                if (_generationAffixCode != value)
                {
                    _generationAffixCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The qualifiation affix attached to a person's name (such as M.Sc., Ph.D).</summary>
        [Newtonsoft.Json.JsonProperty("qualificationAffixCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string QualificationAffixCode
        {
            get { return _qualificationAffixCode; }
            set
            {
                if (_qualificationAffixCode != value)
                {
                    _qualificationAffixCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The title affix attached to a person's name (such as Esq., K.B.E.).</summary>
        [Newtonsoft.Json.JsonProperty("titleAffixCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TitleAffixCode
        {
            get { return _titleAffixCode; }
            set
            {
                if (_titleAffixCode != value)
                {
                    _titleAffixCode = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>The initials of a person.</summary>
        [Newtonsoft.Json.JsonProperty("initials", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Initials
        {
            get { return _initials; }
            set
            {
                if (_initials != value)
                {
                    _initials = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PersonNameType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PersonNameType>(data);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>A set of enumerations describing the numeric type of scoring scheme.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum ScoreNumericCodeList
    {
        [System.Runtime.Serialization.EnumMember(Value = "Percentile")]
        Percentile = 0,

        [System.Runtime.Serialization.EnumMember(Value = "RawScore")]
        RawScore = 1,

        [System.Runtime.Serialization.EnumMember(Value = "Stanine")]
        Stanine = 2,

        [System.Runtime.Serialization.EnumMember(Value = "Sten")]
        Sten = 3,

        [System.Runtime.Serialization.EnumMember(Value = "T-score")]
        TScore = 4,

        [System.Runtime.Serialization.EnumMember(Value = "Z-score")]
        ZScore = 5,

        [System.Runtime.Serialization.EnumMember(Value = "IntelligenceQuotient")]
        IntelligenceQuotient = 6,

        [System.Runtime.Serialization.EnumMember(Value = "Scaled")]
        Scaled = 7,

        [System.Runtime.Serialization.EnumMember(Value = "NormalCurve")]
        NormalCurve = 8,

        [System.Runtime.Serialization.EnumMember(Value = "GPA")]
        GPA = 9,

    }
}

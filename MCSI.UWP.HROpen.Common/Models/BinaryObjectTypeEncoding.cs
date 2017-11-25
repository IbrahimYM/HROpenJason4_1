using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
   
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum BinaryObjectTypeEncoding
    {
        [System.Runtime.Serialization.EnumMember(Value = "7bit")]
        _7bit = 0,

        [System.Runtime.Serialization.EnumMember(Value = "8bit")]
        _8bit = 1,

        [System.Runtime.Serialization.EnumMember(Value = "binary")]
        Binary = 2,

        [System.Runtime.Serialization.EnumMember(Value = "quoted-printable")]
        QuotedPrintable = 3,

        [System.Runtime.Serialization.EnumMember(Value = "base64")]
        Base64 = 4,

        [System.Runtime.Serialization.EnumMember(Value = "ietf-token")]
        IetfToken = 5,

        [System.Runtime.Serialization.EnumMember(Value = "x-token")]
        XToken = 6,

    }
}

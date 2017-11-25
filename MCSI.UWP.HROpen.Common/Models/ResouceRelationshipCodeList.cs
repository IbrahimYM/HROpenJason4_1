using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSI.UWP.HROpen.Common.Models
{
    /// <summary>A code classifying a resource's employment relationship with repect to an associated organization within an assignment. In the vast majority of cases, a resource can be classified as either an employee (a "direct hire") or a vendor's employee. The "Vendor Employee" concept encompasses those self employed and those sourced through a staffing or leasing company. A third value of "Other" may be used to fit rare exceptions, such as a customer employee who has a role in a project or process and must be considered in the provisioning of an HR system.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.9.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum ResourceRelationshipCodeList
    {
        [System.Runtime.Serialization.EnumMember(Value = "Employee")]
        Employee = 0,

        [System.Runtime.Serialization.EnumMember(Value = "VendorEmployee")]
        VendorEmployee = 1,

        [System.Runtime.Serialization.EnumMember(Value = "Other")]
        Other = 2,

    }
}

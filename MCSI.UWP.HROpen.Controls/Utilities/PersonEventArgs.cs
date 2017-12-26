using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCSI.UWP.HROpen.Common.Models;

namespace MCSI.UWP.HROpen.Controls.Utilities
{
    public class PersonEventArgs:EventArgs
    {
        public PersonType Person { get; set; }


    }
}

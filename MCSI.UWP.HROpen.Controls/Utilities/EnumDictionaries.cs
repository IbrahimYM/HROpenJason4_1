using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCSI.UWP.HROpen.Common.Models;

namespace MCSI.UWP.HROpen.Controls.Utilities
{
    public static class EnumDictionaries
    {

        public static Dictionary<string, string> LangList = new Dictionary<string, string>();
        public static Dictionary<string, string> CountryList = new Dictionary<string, string>();

        public static void Init()
        {

            LangList.Clear();

            foreach (LanguageCodeList item in Enum.GetValues(typeof(LanguageCodeList)))
            {
                LangList.Add(item.ToString(), item.ToString());
            }

            CountryList.Clear();

            foreach (CountryCodeList item in Enum.GetValues(typeof(CountryCodeList)))
            {
                CountryList.Add(item.ToString(), item.ToString());
            }


        }





        
    }
}

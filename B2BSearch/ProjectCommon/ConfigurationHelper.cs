using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace B2BSearch.ProjectCommon
{
    public static class ConfigurationHelper
    {
        public static string AppKey = WebConfigurationManager.AppSettings["AppKey"];

    }
}

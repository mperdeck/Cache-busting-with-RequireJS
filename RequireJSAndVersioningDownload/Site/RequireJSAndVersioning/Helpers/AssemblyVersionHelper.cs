using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequireJSAndVersioning.Helpers
{
    public static class AssemblyVersionHelper
    {
        /// <summary>
        /// Returns the version of the currently executing assembly.
        /// Note that this is different from the file version of that dll.
        /// </summary>
        /// <param name="helper"></param>
        /// <returns></returns>
        public static string AssemblyVersion(this HtmlHelper helper)
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}

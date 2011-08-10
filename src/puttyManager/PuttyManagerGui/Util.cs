using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PuttyManagerGui
{
    class Util
    {
        /// <summary>
        /// Gets the assembly title.
        /// </summary>
        /// <value>The assembly title.</value>
        public static string AssemblyTitle
        {
            get
            {
                var defaultTitle = System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
                var title = getAssemblyAttribute<AssemblyTitleAttribute>();
                if (title == null || string.IsNullOrEmpty(title.Title))
                {
                    // If there was no Title attribute, or if the Title attribute was the empty string, return the .exe name
                    return defaultTitle;
                }
                // If it is not an empty string, return it
                return title.Title;
            }
        }

        private static TAttr getAssemblyAttribute<TAttr>() where TAttr : Attribute
        {
            // Get all Title attributes on this assembly
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(TAttr), false);
            // If there is at least one Title attribute
            if (attributes.Length > 0)
            {
                // Select the first one
                var titleAttribute = (TAttr)attributes[0];
                return titleAttribute;
            }
            return null;
        }
    }
}

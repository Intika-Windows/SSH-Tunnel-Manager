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

        public static string AssemblyDescription
        {
            get
            {
                var title = getAssemblyAttribute<AssemblyDescriptionAttribute>();
                if (title == null || string.IsNullOrEmpty(title.Description))
                {
                    return "";
                }
                return title.Description;
            }
        }

        public static string AssemblyConfiguration
        {
            get
            {
                var title = getAssemblyAttribute<AssemblyConfigurationAttribute>();
                if (title == null || string.IsNullOrEmpty(title.Configuration))
                {
                    return "";
                }
                return title.Configuration;
            }
        }

        public static string AssemblyCompany
        {
            get
            {
                var title = getAssemblyAttribute<AssemblyCompanyAttribute>();
                if (title == null || string.IsNullOrEmpty(title.Company))
                {
                    return "";
                }
                return title.Company;
            }
        }

        public static string AssemblyProduct
        {
            get
            {
                var title = getAssemblyAttribute<AssemblyProductAttribute>();
                if (title == null || string.IsNullOrEmpty(title.Product))
                {
                    return "";
                }
                return title.Product;
            }
        }

        public static string AssemblyCopyright
        {
            get
            {
                var title = getAssemblyAttribute<AssemblyCopyrightAttribute>();
                if (title == null || string.IsNullOrEmpty(title.Copyright))
                {
                    return "";
                }
                return title.Copyright;
            }
        }

        public static string AssemblyVersion
        {
            get
            {
                var title = getAssemblyAttribute<AssemblyVersionAttribute>();
                if (title == null || string.IsNullOrEmpty(title.Version))
                {
                    return "";
                }
                return title.Version;
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
                var attribute = (TAttr)attributes[0];
                return attribute;
            }
            return null;
        }
    }
}

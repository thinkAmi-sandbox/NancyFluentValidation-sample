using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyFluentValidationSample
{
    public class RazorConfig : Nancy.ViewEngines.Razor.IRazorConfiguration
    {
        public IEnumerable<string> GetAssemblyNames()
        {
            yield return "NancyFluentValidationSample";
        }

        public IEnumerable<string> GetDefaultNamespaces()
        {
            yield return "NancyFluentValidationSample";
        }

        public bool AutoIncludeModelNamespace
        {
            get { return true; }
        }
    }
}

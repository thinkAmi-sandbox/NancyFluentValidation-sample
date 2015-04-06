using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyFluentValidationSample
{
    public class HomeModel
    {
        public string Text { get; set; }
        public string TextArea { get; set; }
        public string Tel { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public List<string> ErrorMessages { get; set; }
    } 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24
{
    public class Source
    {
        public int CommonProperty1 { get; set; }
        public string CommonProperty2 { get; set; }

    }
    public class DestinationClass
    {
        public int CommonProperty1 { get; set; }
        public string CommonProperty2 { get; set; }
        public bool AdditionalProperty { get; set; }
    }
}

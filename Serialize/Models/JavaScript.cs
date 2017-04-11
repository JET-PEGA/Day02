using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize.Models
{
    public class JavaScript
    {
        public JRaw OnLoadFunction { get; set; }
        public JRaw OnUnloadFunction { get; set; }
    }
}

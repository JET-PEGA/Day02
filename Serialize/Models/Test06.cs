using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize.Models
{
    public class Test06
    {
        public string A { get; set; } = null;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string B { get; set; } = null;

        [JsonProperty(PropertyName = " CCC")]
        public string C { get; set; } = "c";

        public Enum D { get; set; } = Enum.Type1;

        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Enum E { get; set; } = Enum.Type1;

    }
}

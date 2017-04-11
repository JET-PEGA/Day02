using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize.Models
{
    /// <summary>
    /// 排序
    /// </summary>
    public class Test05
    {
        [JsonProperty(Order = 3)]
        public string A { get; set; } = "a";

        [JsonProperty(Order = 2)]
        public string B { get; set; } = "b";

        [JsonProperty(Order = 1)]
        public string C { get; set; } = "c";
    }
}

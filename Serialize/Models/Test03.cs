using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize.Models
{
    /// <summary>
    /// 正面表列
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Test03
    {
        [JsonProperty]
        public string A { get; set; } = "a";

        public string B { get; set; } = "b";

        [JsonProperty]
        public string C { get; set; } = "c";
    }
}

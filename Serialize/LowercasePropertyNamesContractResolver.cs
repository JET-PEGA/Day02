using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize
{
    /// <summary>
    /// 轉小寫的 ContractResolver
    /// </summary>
    public class LowercasePropertyNamesContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string key)
        {
            return key.ToLower();
        }
    }
}

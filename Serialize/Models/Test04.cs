using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialize.Models
{
    /// <summary>
    /// 資料合約
    /// </summary>
    [DataContract]
    public class Test04
    {
        public string A { get; set; } = "a";

        [DataMember]
        public string B { get; set; } = "b";

        [DataMember]
        public string C { get; set; } = "c";
    }
}

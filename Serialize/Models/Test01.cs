using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize.Models
{
    /// <summary>
    /// 測試類別 01
    /// </summary>
    public class Test01
    {
        /// <summary>
        /// 字串測試
        /// </summary>
        public string A { get; set; } = "a";

        /// <summary>
        /// 數字測試
        /// </summary>
        public int B { get; set; } = 1;

        /// <summary>
        /// 浮點數測試
        /// </summary>
        public double C { get; set; } = 2;

        /// <summary>
        /// 布林測試
        /// </summary>
        public bool D { get; set; } = true;

        /// <summary>
        /// 時間測試
        /// </summary>
        public DateTime E { get; set; } = new DateTime(2008, 11, 2, 9, 0, 0);

        /// <summary>
        /// 陣列測試
        /// </summary>
        public string[] F { get; set; } = new string[] { "f1", "f2", "f3" };

        /// <summary>
        /// 清單測試
        /// </summary>
        public List<string> G { get; set; } = new List<string> { "f1", "f2", "f3" };

        /// <summary>
        /// 字典測試
        /// </summary>
        public Dictionary<string, string> H { get; set; } = new Dictionary<string, string> { { "K1","a"},{"K2","b" } };

        /// <summary>
        /// 列舉測試
        /// </summary>
        Enum I { get; set; }

        /// <summary>
        /// null測試
        /// </summary>
        public string J { get; set; } = null;

        /// <summary>
        /// 私有欄位不顯示
        /// </summary>
        private string K { get; set; } = null;

        /// <summary>
        /// 駝峰表示法
        /// </summary>
        public string CamelCase { get; set; } = "駝峰表示法";

    }
}

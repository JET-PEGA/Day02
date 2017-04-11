using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize.Models
{
    public class Member
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 員工編號
        /// </summary>
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// 專業等級
        /// </summary>
        public double Level { get; set; }

        /// <summary>
        /// 負責專案
        /// </summary>
        public Job[] Projects { get; set; }

        /// <summary>
        /// 啟用
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}

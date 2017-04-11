using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deserialize.Models
{
    /// <summary>
    /// 工作 類別
    /// </summary>
    public class Job
    {
        /// <summary>
        /// 專案名稱
        /// </summary>
        public string ProjectName { get; set; } = "LA0900384";

        /// <summary>
        /// 角色
        /// </summary>
        public RoleType Role;
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Serialize.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            cboTest.Items.Add(new Item("預設轉換測試 Test01", "Test01"));
            cboTest.Items.Add(new Item("負面表列 Test02", "Test02"));
            cboTest.Items.Add(new Item("正面表列 Test03", "Test03"));
            cboTest.Items.Add(new Item("DataContract Test04", "Test04"));
            cboTest.Items.Add(new Item("排序 Test05", "Test05"));
            cboTest.Items.Add(new Item("列舉輸出 Test06", "Test06"));
            cboTest.Items.Add(new Item("預設轉換測試 Test07", "Test07"));
            cboTest.Items.Add(new Item("預設轉換測試 Test08", "Test08"));
            cboTest.Items.Add(new Item("預設轉換測試 Test09", "Test0"));
            cboTest.Items.Add(new Item("預設轉換測試 Test10", "Test0"));
            cboTest.Items.Add(new Item("預設轉換測試 Test11", "Test0"));
            cboTest.Items.Add(new Item("預設轉換測試 Test12", "Test0"));
            cboTest.Items.Add(new Item("預設轉換測試 Test13", "Test0"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerializeObject_Click(object sender, EventArgs e)
        {
            string json = "";
            Item item = (Item)cboTest.SelectedItem;

            // 沒選取就結束
            if (item == null)
            {
                // 展示用var 建立一個物件做序列化
                var definition = new { Time = DateTime.Now, Message = "沒有選擇測試類別" };
                txtJson.Text = JsonConvert.SerializeObject(definition);

                return;
            }

            // 序列化設定 
            JsonSerializerSettings settings = new JsonSerializerSettings();

            // 
            if (rdoFormatting.Checked)
                settings.Formatting = Formatting.Indented;
            
            // 
            if (rdoNullValueHandling.Checked)
                settings.NullValueHandling = NullValueHandling.Ignore;
            
            // 駝峰表示法
            if (rdoContractResolver.Checked)
                settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            
            // 格式化日期
            if (rdoDataFormatString.Checked)
                settings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
            
            // MS 日期格式
            if (rdoDateFormatHandling.Checked)
                settings.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;
            // 
            if (rdoCustomContractResolver.Checked)
                settings.ContractResolver = new LowercasePropertyNamesContractResolver();

            switch (item.Value)
            {
                case "Test01":
                    json = JsonConvert.SerializeObject(new Test01(), settings);
                    break;
                case "Test02":
                    json = JsonConvert.SerializeObject(new Test02(), settings);
                    break;
                case "Test03":
                    json = JsonConvert.SerializeObject(new Test03(), settings);
                    break;
                case "Test04":
                    json = JsonConvert.SerializeObject(new Test04(), settings);
                    break;

                case "Test05":
                    json = JsonConvert.SerializeObject(new Test05(), settings);
                    break;

                case "Test06":
                    json = JsonConvert.SerializeObject(new Test06(), settings);
                    break;
                case "Test07":
                    json = JsonConvert.SerializeObject(new Test07(), settings);
                    break;
                case "Test08":
                    json = JsonConvert.SerializeObject(new Test08(), settings);
                    break;


            }

            txtJson.Text = json;

        }



        private string Test01()
        {
            Test01 m = new Test01();

            return JsonConvert.SerializeObject(new Test01()); // 預設 Include
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string Test01x()
        {
            Member m = new Member();
            m.Name = "Jet";
            m.EmployeeNumber = "LA0900384";
            m.Level = 5;
            m.Projects = new Job[] { new Job { ProjectName = "SOA", Role= RoleType.SA },
                                            new Job { ProjectName = "QApi", Role = RoleType.PM } };
            m.Active = true;
            m.CreateTime = new DateTime(2008, 11, 2, 9, 0, 0);
            return JsonConvert.SerializeObject(m); // 預設 Include
        }

    }
}

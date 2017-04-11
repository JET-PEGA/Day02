using Deserialize.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deserialize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeserializeObject_Click(object sender, EventArgs e)
        {

            // 序列化設定 
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.MissingMemberHandling = MissingMemberHandling.Error;

            Test01 test01 = JsonConvert.DeserializeObject<Test01>(txtJson.Text, settings);
        }
    }
}

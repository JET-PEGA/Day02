namespace Serialize
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtJson = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.rdoStringEnumConverter = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.rdoCustomContractResolver = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.rdoContractResolver = new System.Windows.Forms.RadioButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.rdoDateFormatHandling = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.rdoDataFormatString = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rdoNullValueHandling = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.rdoFormatting = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTest = new System.Windows.Forms.ComboBox();
            this.btnSerializeObject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtJson
            // 
            this.txtJson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJson.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtJson.Location = new System.Drawing.Point(6, 6);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(1324, 1007);
            this.txtJson.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox7);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox10);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox8);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox9);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSerializeObject);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtJson);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Size = new System.Drawing.Size(2009, 1019);
            this.splitContainer1.SplitterDistance = 669;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton13);
            this.groupBox7.Controls.Add(this.radioButton14);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(6, 662);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(657, 80);
            this.groupBox7.TabIndex = 29;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(68, 35);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(65, 28);
            this.radioButton13.TabIndex = 3;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "否";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(156, 35);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(65, 28);
            this.radioButton14.TabIndex = 2;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "是";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.radioButton19);
            this.groupBox10.Controls.Add(this.rdoStringEnumConverter);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.Location = new System.Drawing.Point(6, 582);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(657, 80);
            this.groupBox10.TabIndex = 28;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "列舉名稱";
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.Location = new System.Drawing.Point(68, 35);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(65, 28);
            this.radioButton19.TabIndex = 3;
            this.radioButton19.TabStop = true;
            this.radioButton19.Text = "否";
            this.radioButton19.UseVisualStyleBackColor = true;
            // 
            // rdoStringEnumConverter
            // 
            this.rdoStringEnumConverter.AutoSize = true;
            this.rdoStringEnumConverter.Location = new System.Drawing.Point(156, 35);
            this.rdoStringEnumConverter.Name = "rdoStringEnumConverter";
            this.rdoStringEnumConverter.Size = new System.Drawing.Size(65, 28);
            this.rdoStringEnumConverter.TabIndex = 2;
            this.rdoStringEnumConverter.TabStop = true;
            this.rdoStringEnumConverter.Text = "是";
            this.rdoStringEnumConverter.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.radioButton15);
            this.groupBox8.Controls.Add(this.rdoCustomContractResolver);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(6, 502);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(657, 80);
            this.groupBox8.TabIndex = 27;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "屬性名稱改小寫";
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(68, 35);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(65, 28);
            this.radioButton15.TabIndex = 3;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "否";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // rdoCustomContractResolver
            // 
            this.rdoCustomContractResolver.AutoSize = true;
            this.rdoCustomContractResolver.Location = new System.Drawing.Point(156, 35);
            this.rdoCustomContractResolver.Name = "rdoCustomContractResolver";
            this.rdoCustomContractResolver.Size = new System.Drawing.Size(65, 28);
            this.rdoCustomContractResolver.TabIndex = 2;
            this.rdoCustomContractResolver.TabStop = true;
            this.rdoCustomContractResolver.Text = "是";
            this.rdoCustomContractResolver.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton9);
            this.groupBox5.Controls.Add(this.rdoContractResolver);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(6, 422);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(657, 80);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "屬性改CamelCase表示法";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(68, 35);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(65, 28);
            this.radioButton9.TabIndex = 3;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "否";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // rdoContractResolver
            // 
            this.rdoContractResolver.AutoSize = true;
            this.rdoContractResolver.Location = new System.Drawing.Point(156, 35);
            this.rdoContractResolver.Name = "rdoContractResolver";
            this.rdoContractResolver.Size = new System.Drawing.Size(65, 28);
            this.rdoContractResolver.TabIndex = 2;
            this.rdoContractResolver.TabStop = true;
            this.rdoContractResolver.Text = "是";
            this.rdoContractResolver.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.radioButton17);
            this.groupBox9.Controls.Add(this.rdoDateFormatHandling);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.Location = new System.Drawing.Point(6, 342);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(657, 80);
            this.groupBox9.TabIndex = 22;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "日期字串輸出MicrosoftDateFormat格式";
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(68, 35);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(65, 28);
            this.radioButton17.TabIndex = 3;
            this.radioButton17.TabStop = true;
            this.radioButton17.Text = "否";
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // rdoDateFormatHandling
            // 
            this.rdoDateFormatHandling.AutoSize = true;
            this.rdoDateFormatHandling.Location = new System.Drawing.Point(156, 35);
            this.rdoDateFormatHandling.Name = "rdoDateFormatHandling";
            this.rdoDateFormatHandling.Size = new System.Drawing.Size(65, 28);
            this.rdoDateFormatHandling.TabIndex = 2;
            this.rdoDateFormatHandling.TabStop = true;
            this.rdoDateFormatHandling.Text = "是";
            this.rdoDateFormatHandling.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.rdoDataFormatString);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(6, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(657, 80);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "日期字串輸出格式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "ex.\"yyyy-MM-dd HH:mm:ss\"";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(68, 35);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(65, 28);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "否";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // rdoDataFormatString
            // 
            this.rdoDataFormatString.AutoSize = true;
            this.rdoDataFormatString.Location = new System.Drawing.Point(156, 35);
            this.rdoDataFormatString.Name = "rdoDataFormatString";
            this.rdoDataFormatString.Size = new System.Drawing.Size(65, 28);
            this.rdoDataFormatString.TabIndex = 2;
            this.rdoDataFormatString.TabStop = true;
            this.rdoDataFormatString.Text = "是";
            this.rdoDataFormatString.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.rdoNullValueHandling);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(6, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 80);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "屬性為null忽略序列化";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(68, 35);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 28);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "否";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rdoNullValueHandling
            // 
            this.rdoNullValueHandling.AutoSize = true;
            this.rdoNullValueHandling.Location = new System.Drawing.Point(156, 35);
            this.rdoNullValueHandling.Name = "rdoNullValueHandling";
            this.rdoNullValueHandling.Size = new System.Drawing.Size(65, 28);
            this.rdoNullValueHandling.TabIndex = 2;
            this.rdoNullValueHandling.TabStop = true;
            this.rdoNullValueHandling.Text = "是";
            this.rdoNullValueHandling.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Controls.Add(this.rdoFormatting);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(6, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(657, 80);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "JSON字串格式化";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(68, 35);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(65, 28);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "否";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // rdoFormatting
            // 
            this.rdoFormatting.AutoSize = true;
            this.rdoFormatting.Location = new System.Drawing.Point(156, 35);
            this.rdoFormatting.Name = "rdoFormatting";
            this.rdoFormatting.Size = new System.Drawing.Size(65, 28);
            this.rdoFormatting.TabIndex = 2;
            this.rdoFormatting.TabStop = true;
            this.rdoFormatting.Text = "是";
            this.rdoFormatting.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTest);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class範本";
            // 
            // cboTest
            // 
            this.cboTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTest.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboTest.FormattingEnabled = true;
            this.cboTest.Location = new System.Drawing.Point(68, 35);
            this.cboTest.Name = "cboTest";
            this.cboTest.Size = new System.Drawing.Size(389, 40);
            this.cboTest.TabIndex = 0;
            // 
            // btnSerializeObject
            // 
            this.btnSerializeObject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSerializeObject.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSerializeObject.Location = new System.Drawing.Point(6, 912);
            this.btnSerializeObject.Name = "btnSerializeObject";
            this.btnSerializeObject.Size = new System.Drawing.Size(657, 101);
            this.btnSerializeObject.TabIndex = 3;
            this.btnSerializeObject.Text = "SerializeObject";
            this.btnSerializeObject.UseVisualStyleBackColor = true;
            this.btnSerializeObject.Click += new System.EventHandler(this.btnSerializeObject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2021, 1031);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "Serialize";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtJson;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSerializeObject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton rdoFormatting;
        private System.Windows.Forms.ComboBox cboTest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton rdoDataFormatString;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdoNullValueHandling;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton rdoDateFormatHandling;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.RadioButton rdoStringEnumConverter;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton rdoCustomContractResolver;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton rdoContractResolver;
        private System.Windows.Forms.Label label1;
    }
}


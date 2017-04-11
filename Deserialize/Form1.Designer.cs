namespace Deserialize
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
            this.btnDeserializeObject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJson
            // 
            this.txtJson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJson.Location = new System.Drawing.Point(0, 0);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(1596, 850);
            this.txtJson.TabIndex = 4;
            this.txtJson.Text = "{\r\n  \"A\":\"a\",\r\n  \"B\":\"b\",\r\n  \"C\":\"c\"\r\n}";
            // 
            // btnDeserializeObject
            // 
            this.btnDeserializeObject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeserializeObject.Location = new System.Drawing.Point(0, 723);
            this.btnDeserializeObject.Name = "btnDeserializeObject";
            this.btnDeserializeObject.Size = new System.Drawing.Size(1596, 127);
            this.btnDeserializeObject.TabIndex = 5;
            this.btnDeserializeObject.Text = "DeserializeObject";
            this.btnDeserializeObject.UseVisualStyleBackColor = true;
            this.btnDeserializeObject.Click += new System.EventHandler(this.btnDeserializeObject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 850);
            this.Controls.Add(this.btnDeserializeObject);
            this.Controls.Add(this.txtJson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJson;
        private System.Windows.Forms.Button btnDeserializeObject;
    }
}


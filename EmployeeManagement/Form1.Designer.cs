namespace EmployeeManagement
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel員工管理系統標頭欄 = new System.Windows.Forms.Panel();
            this.lab員工管理系統 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn離開 = new System.Windows.Forms.Button();
            this.btn員工資料 = new System.Windows.Forms.Button();
            this.btn員工 = new System.Windows.Forms.Button();
            this.PictureBox員工封面 = new System.Windows.Forms.PictureBox();
            this.Panel員工管理系統標頭欄.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox員工封面)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel員工管理系統標頭欄
            // 
            this.Panel員工管理系統標頭欄.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel員工管理系統標頭欄.Controls.Add(this.lab員工管理系統);
            this.Panel員工管理系統標頭欄.Location = new System.Drawing.Point(0, 0);
            this.Panel員工管理系統標頭欄.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel員工管理系統標頭欄.Name = "Panel員工管理系統標頭欄";
            this.Panel員工管理系統標頭欄.Size = new System.Drawing.Size(1041, 106);
            this.Panel員工管理系統標頭欄.TabIndex = 0;
            // 
            // lab員工管理系統
            // 
            this.lab員工管理系統.AutoSize = true;
            this.lab員工管理系統.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab員工管理系統.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab員工管理系統.Location = new System.Drawing.Point(304, 22);
            this.lab員工管理系統.Name = "lab員工管理系統";
            this.lab員工管理系統.Size = new System.Drawing.Size(391, 60);
            this.lab員工管理系統.TabIndex = 0;
            this.lab員工管理系統.Text = "員工管理系統";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btn離開);
            this.panel2.Controls.Add(this.btn員工資料);
            this.panel2.Controls.Add(this.btn員工);
            this.panel2.Location = new System.Drawing.Point(3, 104);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 579);
            this.panel2.TabIndex = 1;
            // 
            // btn離開
            // 
            this.btn離開.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn離開.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn離開.Location = new System.Drawing.Point(37, 439);
            this.btn離開.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn離開.Name = "btn離開";
            this.btn離開.Size = new System.Drawing.Size(141, 68);
            this.btn離開.TabIndex = 2;
            this.btn離開.Text = "離開";
            this.btn離開.UseVisualStyleBackColor = false;
            this.btn離開.Click += new System.EventHandler(this.btn離開_Click);
            // 
            // btn員工資料
            // 
            this.btn員工資料.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn員工資料.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn員工資料.Location = new System.Drawing.Point(37, 240);
            this.btn員工資料.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn員工資料.Name = "btn員工資料";
            this.btn員工資料.Size = new System.Drawing.Size(141, 68);
            this.btn員工資料.TabIndex = 1;
            this.btn員工資料.Text = "員工資料";
            this.btn員工資料.UseVisualStyleBackColor = false;
            this.btn員工資料.Click += new System.EventHandler(this.btn員工資料_Click);
            // 
            // btn員工
            // 
            this.btn員工.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn員工.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn員工.Location = new System.Drawing.Point(37, 56);
            this.btn員工.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn員工.Name = "btn員工";
            this.btn員工.Size = new System.Drawing.Size(141, 68);
            this.btn員工.TabIndex = 0;
            this.btn員工.Text = "員工";
            this.btn員工.UseVisualStyleBackColor = false;
            this.btn員工.Click += new System.EventHandler(this.btn員工_Click);
            // 
            // PictureBox員工封面
            // 
            this.PictureBox員工封面.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox員工封面.BackgroundImage")));
            this.PictureBox員工封面.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox員工封面.Location = new System.Drawing.Point(239, 104);
            this.PictureBox員工封面.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox員工封面.Name = "PictureBox員工封面";
            this.PictureBox員工封面.Size = new System.Drawing.Size(803, 579);
            this.PictureBox員工封面.TabIndex = 2;
            this.PictureBox員工封面.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 685);
            this.Controls.Add(this.PictureBox員工封面);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel員工管理系統標頭欄);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel員工管理系統標頭欄.ResumeLayout(false);
            this.Panel員工管理系統標頭欄.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox員工封面)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel員工管理系統標頭欄;
        private System.Windows.Forms.Label lab員工管理系統;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn員工;
        private System.Windows.Forms.Button btn離開;
        private System.Windows.Forms.Button btn員工資料;
        private System.Windows.Forms.PictureBox PictureBox員工封面;
    }
}


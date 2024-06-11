namespace EmployeeManagement
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl新增員工 = new System.Windows.Forms.Label();
            this.gbox員工 = new System.Windows.Forms.GroupBox();
            this.lbl編號 = new System.Windows.Forms.Label();
            this.lbl姓名 = new System.Windows.Forms.Label();
            this.lbl年齡 = new System.Windows.Forms.Label();
            this.lbl薪資 = new System.Windows.Forms.Label();
            this.lbl生日 = new System.Windows.Forms.Label();
            this.lbl電子郵件 = new System.Windows.Forms.Label();
            this.lbl福利 = new System.Windows.Forms.Label();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.txtbox姓名 = new System.Windows.Forms.TextBox();
            this.txtbox年齡 = new System.Windows.Forms.TextBox();
            this.txtbox電子郵件 = new System.Windows.Forms.TextBox();
            this.txtbox生日 = new System.Windows.Forms.TextBox();
            this.txtbox薪資 = new System.Windows.Forms.TextBox();
            this.txtbox福利 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn加入 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.dgv員工 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbox員工.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv員工)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lbl新增員工);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbl新增員工
            // 
            this.lbl新增員工.AutoSize = true;
            this.lbl新增員工.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl新增員工.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl新增員工.Location = new System.Drawing.Point(332, 25);
            this.lbl新增員工.Name = "lbl新增員工";
            this.lbl新增員工.Size = new System.Drawing.Size(118, 48);
            this.lbl新增員工.TabIndex = 0;
            this.lbl新增員工.Text = "員工";
            // 
            // gbox員工
            // 
            this.gbox員工.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbox員工.Controls.Add(this.btn刪除);
            this.gbox員工.Controls.Add(this.btn新增);
            this.gbox員工.Controls.Add(this.btn加入);
            this.gbox員工.Controls.Add(this.pictureBox2);
            this.gbox員工.Controls.Add(this.txtbox福利);
            this.gbox員工.Controls.Add(this.txtbox薪資);
            this.gbox員工.Controls.Add(this.txtbox生日);
            this.gbox員工.Controls.Add(this.txtbox電子郵件);
            this.gbox員工.Controls.Add(this.txtbox年齡);
            this.gbox員工.Controls.Add(this.txtbox姓名);
            this.gbox員工.Controls.Add(this.txtboxID);
            this.gbox員工.Controls.Add(this.lbl福利);
            this.gbox員工.Controls.Add(this.lbl電子郵件);
            this.gbox員工.Controls.Add(this.lbl生日);
            this.gbox員工.Controls.Add(this.lbl薪資);
            this.gbox員工.Controls.Add(this.lbl年齡);
            this.gbox員工.Controls.Add(this.lbl姓名);
            this.gbox員工.Controls.Add(this.lbl編號);
            this.gbox員工.Font = new System.Drawing.Font("新細明體", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbox員工.Location = new System.Drawing.Point(2, 103);
            this.gbox員工.Name = "gbox員工";
            this.gbox員工.Size = new System.Drawing.Size(798, 368);
            this.gbox員工.TabIndex = 1;
            this.gbox員工.TabStop = false;
            this.gbox員工.Text = "員工";
            // 
            // lbl編號
            // 
            this.lbl編號.AutoSize = true;
            this.lbl編號.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl編號.Location = new System.Drawing.Point(27, 46);
            this.lbl編號.Name = "lbl編號";
            this.lbl編號.Size = new System.Drawing.Size(54, 21);
            this.lbl編號.TabIndex = 0;
            this.lbl編號.Text = "編號";
            // 
            // lbl姓名
            // 
            this.lbl姓名.AutoSize = true;
            this.lbl姓名.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl姓名.Location = new System.Drawing.Point(27, 93);
            this.lbl姓名.Name = "lbl姓名";
            this.lbl姓名.Size = new System.Drawing.Size(54, 21);
            this.lbl姓名.TabIndex = 1;
            this.lbl姓名.Text = "姓名";
            // 
            // lbl年齡
            // 
            this.lbl年齡.AutoSize = true;
            this.lbl年齡.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl年齡.Location = new System.Drawing.Point(27, 146);
            this.lbl年齡.Name = "lbl年齡";
            this.lbl年齡.Size = new System.Drawing.Size(54, 21);
            this.lbl年齡.TabIndex = 2;
            this.lbl年齡.Text = "年齡";
            // 
            // lbl薪資
            // 
            this.lbl薪資.AutoSize = true;
            this.lbl薪資.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl薪資.Location = new System.Drawing.Point(27, 288);
            this.lbl薪資.Name = "lbl薪資";
            this.lbl薪資.Size = new System.Drawing.Size(54, 21);
            this.lbl薪資.TabIndex = 3;
            this.lbl薪資.Text = "薪資";
            // 
            // lbl生日
            // 
            this.lbl生日.AutoSize = true;
            this.lbl生日.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl生日.Location = new System.Drawing.Point(27, 240);
            this.lbl生日.Name = "lbl生日";
            this.lbl生日.Size = new System.Drawing.Size(54, 21);
            this.lbl生日.TabIndex = 4;
            this.lbl生日.Text = "生日";
            // 
            // lbl電子郵件
            // 
            this.lbl電子郵件.AutoSize = true;
            this.lbl電子郵件.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl電子郵件.Location = new System.Drawing.Point(27, 193);
            this.lbl電子郵件.Name = "lbl電子郵件";
            this.lbl電子郵件.Size = new System.Drawing.Size(98, 21);
            this.lbl電子郵件.TabIndex = 5;
            this.lbl電子郵件.Text = "電子郵件";
            // 
            // lbl福利
            // 
            this.lbl福利.AutoSize = true;
            this.lbl福利.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl福利.Location = new System.Drawing.Point(27, 335);
            this.lbl福利.Name = "lbl福利";
            this.lbl福利.Size = new System.Drawing.Size(54, 21);
            this.lbl福利.TabIndex = 6;
            this.lbl福利.Text = "福利";
            // 
            // txtboxID
            // 
            this.txtboxID.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxID.Location = new System.Drawing.Point(138, 41);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.Size = new System.Drawing.Size(211, 36);
            this.txtboxID.TabIndex = 7;
            // 
            // txtbox姓名
            // 
            this.txtbox姓名.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox姓名.Location = new System.Drawing.Point(138, 85);
            this.txtbox姓名.Name = "txtbox姓名";
            this.txtbox姓名.Size = new System.Drawing.Size(211, 36);
            this.txtbox姓名.TabIndex = 8;
            // 
            // txtbox年齡
            // 
            this.txtbox年齡.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox年齡.Location = new System.Drawing.Point(138, 131);
            this.txtbox年齡.Name = "txtbox年齡";
            this.txtbox年齡.Size = new System.Drawing.Size(211, 36);
            this.txtbox年齡.TabIndex = 9;
            // 
            // txtbox電子郵件
            // 
            this.txtbox電子郵件.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox電子郵件.Location = new System.Drawing.Point(138, 178);
            this.txtbox電子郵件.Name = "txtbox電子郵件";
            this.txtbox電子郵件.Size = new System.Drawing.Size(211, 36);
            this.txtbox電子郵件.TabIndex = 10;
            // 
            // txtbox生日
            // 
            this.txtbox生日.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox生日.Location = new System.Drawing.Point(138, 225);
            this.txtbox生日.Name = "txtbox生日";
            this.txtbox生日.Size = new System.Drawing.Size(211, 36);
            this.txtbox生日.TabIndex = 11;
            // 
            // txtbox薪資
            // 
            this.txtbox薪資.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox薪資.Location = new System.Drawing.Point(138, 273);
            this.txtbox薪資.Name = "txtbox薪資";
            this.txtbox薪資.Size = new System.Drawing.Size(211, 36);
            this.txtbox薪資.TabIndex = 12;
            // 
            // txtbox福利
            // 
            this.txtbox福利.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox福利.Location = new System.Drawing.Point(138, 320);
            this.txtbox福利.Name = "txtbox福利";
            this.txtbox福利.Size = new System.Drawing.Size(211, 36);
            this.txtbox福利.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(385, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(407, 203);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btn加入
            // 
            this.btn加入.BackColor = System.Drawing.Color.Yellow;
            this.btn加入.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn加入.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入.Location = new System.Drawing.Point(385, 261);
            this.btn加入.Name = "btn加入";
            this.btn加入.Size = new System.Drawing.Size(116, 48);
            this.btn加入.TabIndex = 15;
            this.btn加入.Text = "加入";
            this.btn加入.UseVisualStyleBackColor = false;
            this.btn加入.Click += new System.EventHandler(this.btn加入_Click);
            // 
            // btn新增
            // 
            this.btn新增.BackColor = System.Drawing.Color.Yellow;
            this.btn新增.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn新增.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增.Location = new System.Drawing.Point(526, 261);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(116, 48);
            this.btn新增.TabIndex = 16;
            this.btn新增.Text = "新增";
            this.btn新增.UseVisualStyleBackColor = false;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // btn刪除
            // 
            this.btn刪除.BackColor = System.Drawing.Color.Yellow;
            this.btn刪除.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn刪除.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Location = new System.Drawing.Point(670, 261);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(116, 48);
            this.btn刪除.TabIndex = 17;
            this.btn刪除.Text = "刪除";
            this.btn刪除.UseVisualStyleBackColor = false;
            // 
            // dgv員工
            // 
            this.dgv員工.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv員工.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv員工.Location = new System.Drawing.Point(2, 472);
            this.dgv員工.Name = "dgv員工";
            this.dgv員工.RowTemplate.Height = 24;
            this.dgv員工.Size = new System.Drawing.Size(798, 142);
            this.dgv員工.TabIndex = 2;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.dgv員工);
            this.Controls.Add(this.gbox員工);
            this.Controls.Add(this.panel1);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbox員工.ResumeLayout(false);
            this.gbox員工.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv員工)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl新增員工;
        private System.Windows.Forms.GroupBox gbox員工;
        private System.Windows.Forms.Label lbl姓名;
        private System.Windows.Forms.Label lbl編號;
        private System.Windows.Forms.Label lbl福利;
        private System.Windows.Forms.Label lbl電子郵件;
        private System.Windows.Forms.Label lbl生日;
        private System.Windows.Forms.Label lbl薪資;
        private System.Windows.Forms.Label lbl年齡;
        private System.Windows.Forms.TextBox txtbox薪資;
        private System.Windows.Forms.TextBox txtbox生日;
        private System.Windows.Forms.TextBox txtbox電子郵件;
        private System.Windows.Forms.TextBox txtbox年齡;
        private System.Windows.Forms.TextBox txtbox姓名;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.TextBox txtbox福利;
        private System.Windows.Forms.Button btn加入;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn刪除;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.DataGridView dgv員工;
    }
}
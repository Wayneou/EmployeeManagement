namespace EmployeeManagement
{
    partial class EmployeeInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl員工個人資料 = new System.Windows.Forms.Label();
            this.btn顯示員工資料 = new System.Windows.Forms.Button();
            this.dgv員工資料 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv員工資料)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lbl員工個人資料);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbl員工個人資料
            // 
            this.lbl員工個人資料.AutoSize = true;
            this.lbl員工個人資料.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl員工個人資料.Location = new System.Drawing.Point(225, 27);
            this.lbl員工個人資料.Name = "lbl員工個人資料";
            this.lbl員工個人資料.Size = new System.Drawing.Size(314, 48);
            this.lbl員工個人資料.TabIndex = 0;
            this.lbl員工個人資料.Text = "員工個人資料";
            // 
            // btn顯示員工資料
            // 
            this.btn顯示員工資料.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn顯示員工資料.Location = new System.Drawing.Point(1, 104);
            this.btn顯示員工資料.Name = "btn顯示員工資料";
            this.btn顯示員工資料.Size = new System.Drawing.Size(798, 76);
            this.btn顯示員工資料.TabIndex = 1;
            this.btn顯示員工資料.Text = "顯示員工資料";
            this.btn顯示員工資料.UseVisualStyleBackColor = true;
            this.btn顯示員工資料.Click += new System.EventHandler(this.btn顯示員工資料_Click);
            // 
            // dgv員工資料
            // 
            this.dgv員工資料.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv員工資料.Location = new System.Drawing.Point(1, 181);
            this.dgv員工資料.Name = "dgv員工資料";
            this.dgv員工資料.RowTemplate.Height = 24;
            this.dgv員工資料.Size = new System.Drawing.Size(798, 268);
            this.dgv員工資料.TabIndex = 2;
            // 
            // EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv員工資料);
            this.Controls.Add(this.btn顯示員工資料);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv員工資料)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl員工個人資料;
        private System.Windows.Forms.Button btn顯示員工資料;
        private System.Windows.Forms.DataGridView dgv員工資料;
    }
}
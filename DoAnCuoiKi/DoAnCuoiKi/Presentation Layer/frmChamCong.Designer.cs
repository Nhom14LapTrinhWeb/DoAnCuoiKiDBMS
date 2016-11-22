namespace DoAnCuoiKi
{
    partial class frmChamCong
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
            this.rbtKhongPhep = new System.Windows.Forms.RadioButton();
            this.rbtCoPhep = new System.Windows.Forms.RadioButton();
            this.dtpToDay = new System.Windows.Forms.DateTimePicker();
            this.btnNghi = new System.Windows.Forms.Button();
            this.btnDiemDanh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtKhongPhep
            // 
            this.rbtKhongPhep.AutoSize = true;
            this.rbtKhongPhep.Location = new System.Drawing.Point(503, 179);
            this.rbtKhongPhep.Name = "rbtKhongPhep";
            this.rbtKhongPhep.Size = new System.Drawing.Size(83, 17);
            this.rbtKhongPhep.TabIndex = 24;
            this.rbtKhongPhep.TabStop = true;
            this.rbtKhongPhep.Text = "Không phép";
            this.rbtKhongPhep.UseVisualStyleBackColor = true;
            this.rbtKhongPhep.CheckedChanged += new System.EventHandler(this.rbtKhongPhep_CheckedChanged);
            // 
            // rbtCoPhep
            // 
            this.rbtCoPhep.AutoSize = true;
            this.rbtCoPhep.Location = new System.Drawing.Point(386, 179);
            this.rbtCoPhep.Name = "rbtCoPhep";
            this.rbtCoPhep.Size = new System.Drawing.Size(65, 17);
            this.rbtCoPhep.TabIndex = 23;
            this.rbtCoPhep.TabStop = true;
            this.rbtCoPhep.Text = "Có phép";
            this.rbtCoPhep.UseVisualStyleBackColor = true;
            // 
            // dtpToDay
            // 
            this.dtpToDay.Location = new System.Drawing.Point(386, 65);
            this.dtpToDay.Name = "dtpToDay";
            this.dtpToDay.Size = new System.Drawing.Size(200, 20);
            this.dtpToDay.TabIndex = 21;
            // 
            // btnNghi
            // 
            this.btnNghi.Location = new System.Drawing.Point(386, 244);
            this.btnNghi.Name = "btnNghi";
            this.btnNghi.Size = new System.Drawing.Size(75, 23);
            this.btnNghi.TabIndex = 20;
            this.btnNghi.Text = "Vắng mặt";
            this.btnNghi.UseVisualStyleBackColor = true;
            // 
            // btnDiemDanh
            // 
            this.btnDiemDanh.Location = new System.Drawing.Point(386, 110);
            this.btnDiemDanh.Name = "btnDiemDanh";
            this.btnDiemDanh.Size = new System.Drawing.Size(75, 23);
            this.btnDiemDanh.TabIndex = 19;
            this.btnDiemDanh.Text = "Có mặt";
            this.btnDiemDanh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Danh sách công nhân";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(271, 402);
            this.dataGridView1.TabIndex = 25;
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbtKhongPhep);
            this.Controls.Add(this.rbtCoPhep);
            this.Controls.Add(this.dtpToDay);
            this.Controls.Add(this.btnNghi);
            this.Controls.Add(this.btnDiemDanh);
            this.Controls.Add(this.label1);
            this.Name = "frmChamCong";
            this.Text = "Chấm công";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtKhongPhep;
        private System.Windows.Forms.RadioButton rbtCoPhep;
        private System.Windows.Forms.DateTimePicker dtpToDay;
        private System.Windows.Forms.Button btnNghi;
        private System.Windows.Forms.Button btnDiemDanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
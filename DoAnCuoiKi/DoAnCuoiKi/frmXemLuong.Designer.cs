﻿namespace DoAnCuoiKi
{
    partial class frmXemLuong
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
            this.lsvXemLuong = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtLoaiNV = new System.Windows.Forms.TextBox();
            this.txtTenCN = new System.Windows.Forms.TextBox();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvXemLuong
            // 
            this.lsvXemLuong.Location = new System.Drawing.Point(17, 206);
            this.lsvXemLuong.Name = "lsvXemLuong";
            this.lsvXemLuong.Size = new System.Drawing.Size(655, 63);
            this.lsvXemLuong.TabIndex = 18;
            this.lsvXemLuong.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tháng";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(395, 127);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtLoaiNV
            // 
            this.txtLoaiNV.Location = new System.Drawing.Point(135, 88);
            this.txtLoaiNV.Name = "txtLoaiNV";
            this.txtLoaiNV.ReadOnly = true;
            this.txtLoaiNV.Size = new System.Drawing.Size(147, 20);
            this.txtLoaiNV.TabIndex = 15;
            // 
            // txtTenCN
            // 
            this.txtTenCN.Location = new System.Drawing.Point(424, 20);
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.ReadOnly = true;
            this.txtTenCN.Size = new System.Drawing.Size(147, 20);
            this.txtTenCN.TabIndex = 14;
            // 
            // txtMaCN
            // 
            this.txtMaCN.Location = new System.Drawing.Point(135, 20);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.ReadOnly = true;
            this.txtMaCN.Size = new System.Drawing.Size(147, 20);
            this.txtMaCN.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên công nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loại nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã công nhân";
            // 
            // frmXemLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 314);
            this.Controls.Add(this.lsvXemLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtLoaiNV);
            this.Controls.Add(this.txtTenCN);
            this.Controls.Add(this.txtMaCN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmXemLuong";
            this.Text = "Xem lương";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvXemLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtLoaiNV;
        private System.Windows.Forms.TextBox txtTenCN;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
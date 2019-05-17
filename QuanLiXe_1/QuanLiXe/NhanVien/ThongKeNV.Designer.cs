namespace QuanLiXe
{
    partial class ThongKeNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTho = new System.Windows.Forms.DataGridView();
            this.ptbBack = new System.Windows.Forms.PictureBox();
            this.ptbGiamSat = new System.Windows.Forms.PictureBox();
            this.ptbVanPhong = new System.Windows.Forms.PictureBox();
            this.ptbTho = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGiamSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVanPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thợ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(683, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Văn Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1046, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giám Sát";
            // 
            // dgvTho
            // 
            this.dgvTho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTho.Location = new System.Drawing.Point(117, 33);
            this.dgvTho.Name = "dgvTho";
            this.dgvTho.Size = new System.Drawing.Size(1260, 548);
            this.dgvTho.TabIndex = 4;
            // 
            // ptbBack
            // 
            this.ptbBack.Image = global::QuanLiXe.Properties.Resources._1;
            this.ptbBack.Location = new System.Drawing.Point(12, 33);
            this.ptbBack.Name = "ptbBack";
            this.ptbBack.Size = new System.Drawing.Size(100, 50);
            this.ptbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBack.TabIndex = 5;
            this.ptbBack.TabStop = false;
            this.ptbBack.Click += new System.EventHandler(this.ptbBack_Click_1);
            // 
            // ptbGiamSat
            // 
            this.ptbGiamSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ptbGiamSat.Image = global::QuanLiXe.Properties.Resources.Capture;
            this.ptbGiamSat.Location = new System.Drawing.Point(963, 144);
            this.ptbGiamSat.Name = "ptbGiamSat";
            this.ptbGiamSat.Size = new System.Drawing.Size(269, 331);
            this.ptbGiamSat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbGiamSat.TabIndex = 2;
            this.ptbGiamSat.TabStop = false;
            this.ptbGiamSat.Click += new System.EventHandler(this.ptbGiamSat_Click);
            // 
            // ptbVanPhong
            // 
            this.ptbVanPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ptbVanPhong.Image = global::QuanLiXe.Properties.Resources.big_106676_QpV;
            this.ptbVanPhong.Location = new System.Drawing.Point(608, 144);
            this.ptbVanPhong.Name = "ptbVanPhong";
            this.ptbVanPhong.Size = new System.Drawing.Size(264, 331);
            this.ptbVanPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbVanPhong.TabIndex = 1;
            this.ptbVanPhong.TabStop = false;
            this.ptbVanPhong.Click += new System.EventHandler(this.ptbVanPhong_Click);
            // 
            // ptbTho
            // 
            this.ptbTho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ptbTho.Image = global::QuanLiXe.Properties.Resources._11;
            this.ptbTho.Location = new System.Drawing.Point(259, 144);
            this.ptbTho.Name = "ptbTho";
            this.ptbTho.Size = new System.Drawing.Size(276, 331);
            this.ptbTho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbTho.TabIndex = 0;
            this.ptbTho.TabStop = false;
            this.ptbTho.Click += new System.EventHandler(this.ptbTho_Click);
            // 
            // ThongKeNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 647);
            this.Controls.Add(this.ptbBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbGiamSat);
            this.Controls.Add(this.ptbVanPhong);
            this.Controls.Add(this.ptbTho);
            this.Controls.Add(this.dgvTho);
            this.Name = "ThongKeNV";
            this.Text = "ThongKeNV";
            this.Load += new System.EventHandler(this.ThongKeNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGiamSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVanPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbTho;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbVanPhong;
        private System.Windows.Forms.PictureBox ptbGiamSat;
        private System.Windows.Forms.DataGridView dgvTho;
        private System.Windows.Forms.PictureBox ptbBack;
    }
}
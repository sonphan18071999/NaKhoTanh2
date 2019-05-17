namespace QuanLiXe
{
    partial class ThongKeNVUC1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1083, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Giám Sát";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(720, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Văn Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Thợ";
            // 
            // dgvTho
            // 
            this.dgvTho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTho.Location = new System.Drawing.Point(154, 37);
            this.dgvTho.Name = "dgvTho";
            this.dgvTho.Size = new System.Drawing.Size(1134, 548);
            this.dgvTho.TabIndex = 20;
            // 
            // ptbBack
            // 
            this.ptbBack.Image = global::QuanLiXe.Properties.Resources._1;
            this.ptbBack.Location = new System.Drawing.Point(49, 37);
            this.ptbBack.Name = "ptbBack";
            this.ptbBack.Size = new System.Drawing.Size(100, 50);
            this.ptbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBack.TabIndex = 21;
            this.ptbBack.TabStop = false;
            this.ptbBack.Click += new System.EventHandler(this.ptbBack_Click);
            // 
            // ptbGiamSat
            // 
            this.ptbGiamSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ptbGiamSat.Image = global::QuanLiXe.Properties.Resources.Capture;
            this.ptbGiamSat.Location = new System.Drawing.Point(1000, 148);
            this.ptbGiamSat.Name = "ptbGiamSat";
            this.ptbGiamSat.Size = new System.Drawing.Size(269, 331);
            this.ptbGiamSat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbGiamSat.TabIndex = 16;
            this.ptbGiamSat.TabStop = false;
            this.ptbGiamSat.Click += new System.EventHandler(this.ptbGiamSat_Click);
            // 
            // ptbVanPhong
            // 
            this.ptbVanPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ptbVanPhong.Image = global::QuanLiXe.Properties.Resources.big_106676_QpV;
            this.ptbVanPhong.Location = new System.Drawing.Point(645, 148);
            this.ptbVanPhong.Name = "ptbVanPhong";
            this.ptbVanPhong.Size = new System.Drawing.Size(264, 331);
            this.ptbVanPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbVanPhong.TabIndex = 15;
            this.ptbVanPhong.TabStop = false;
            this.ptbVanPhong.Click += new System.EventHandler(this.ptbVanPhong_Click);
            // 
            // ptbTho
            // 
            this.ptbTho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ptbTho.Image = global::QuanLiXe.Properties.Resources._11;
            this.ptbTho.Location = new System.Drawing.Point(296, 148);
            this.ptbTho.Name = "ptbTho";
            this.ptbTho.Size = new System.Drawing.Size(276, 331);
            this.ptbTho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbTho.TabIndex = 14;
            this.ptbTho.TabStop = false;
            this.ptbTho.Click += new System.EventHandler(this.ptbTho_Click);
            // 
            // ThongKeNVUC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptbBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbGiamSat);
            this.Controls.Add(this.ptbVanPhong);
            this.Controls.Add(this.ptbTho);
            this.Controls.Add(this.dgvTho);
            this.Name = "ThongKeNVUC1";
            this.Size = new System.Drawing.Size(1463, 622);
            this.Load += new System.EventHandler(this.ThongKeNVUC1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGiamSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVanPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbGiamSat;
        private System.Windows.Forms.PictureBox ptbVanPhong;
        private System.Windows.Forms.PictureBox ptbTho;
        private System.Windows.Forms.DataGridView dgvTho;
    }
}

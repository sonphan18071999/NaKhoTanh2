namespace QuanLiXe
{
    partial class NhanVienUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnThongTinNV = new System.Windows.Forms.Panel();
            this.btnCa = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnThongKeNV = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._DESKTOP_RRRHOP4NhanVien = new QuanLiXe._DESKTOP_RRRHOP4NhanVien();
            this.nHANVIENTableAdapter = new QuanLiXe._DESKTOP_RRRHOP4NhanVienTableAdapters.NHANVIENTableAdapter();
            this.chiaCaUC1 = new QuanLiXe.ChiaCaUC();
            this.editNhanVienUC1 = new QuanLiXe.EditNhanVienUC();
            this.addNhanVienUC1 = new QuanLiXe.AddNhanVienUC();
            this.thongKeNVUC11 = new QuanLiXe.ThongKeNVUC1();
            this.panelNhanVien = new System.Windows.Forms.Panel();
            this.btThongKeNV = new System.Windows.Forms.Button();
            this.btCaLamViec = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btHopDongGuiXe = new System.Windows.Forms.Button();
            this.btHopDongThueXe = new System.Windows.Forms.Button();
            this.btThongTinNV = new System.Windows.Forms.Button();
            this.panelClickNV = new System.Windows.Forms.Panel();
            this.btGioiThieuNV = new System.Windows.Forms.Button();
            this.pnThongTinNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_RRRHOP4NhanVien)).BeginInit();
            this.panelNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1189, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 42);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(696, 87);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(452, 42);
            this.txtSearch.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDelete.Location = new System.Drawing.Point(33, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 88);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnEdit.Location = new System.Drawing.Point(33, 202);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(179, 90);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAdd.Location = new System.Drawing.Point(33, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 88);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnThongTinNV
            // 
            this.pnThongTinNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnThongTinNV.BackColor = System.Drawing.Color.Transparent;
            this.pnThongTinNV.Controls.Add(this.btnCa);
            this.pnThongTinNV.Controls.Add(this.btnShow);
            this.pnThongTinNV.Controls.Add(this.btnThongKeNV);
            this.pnThongTinNV.Controls.Add(this.btnDelete);
            this.pnThongTinNV.Controls.Add(this.btnEdit);
            this.pnThongTinNV.Controls.Add(this.btnAdd);
            this.pnThongTinNV.Location = new System.Drawing.Point(1676, 3);
            this.pnThongTinNV.Margin = new System.Windows.Forms.Padding(2);
            this.pnThongTinNV.Name = "pnThongTinNV";
            this.pnThongTinNV.Size = new System.Drawing.Size(247, 795);
            this.pnThongTinNV.TabIndex = 11;
            this.pnThongTinNV.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCa
            // 
            this.btnCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCa.Location = new System.Drawing.Point(33, 643);
            this.btnCa.Name = "btnCa";
            this.btnCa.Size = new System.Drawing.Size(180, 104);
            this.btnCa.TabIndex = 65;
            this.btnCa.Text = "Chia ca";
            this.btnCa.UseVisualStyleBackColor = true;
            this.btnCa.Click += new System.EventHandler(this.btnCa_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnShow.Location = new System.Drawing.Point(33, 526);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(180, 90);
            this.btnShow.TabIndex = 64;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnThongKeNV
            // 
            this.btnThongKeNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThongKeNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThongKeNV.BackgroundImage")));
            this.btnThongKeNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThongKeNV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThongKeNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeNV.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnThongKeNV.Location = new System.Drawing.Point(33, 417);
            this.btnThongKeNV.Name = "btnThongKeNV";
            this.btnThongKeNV.Size = new System.Drawing.Size(180, 90);
            this.btnThongKeNV.TabIndex = 6;
            this.btnThongKeNV.Text = " Thống kê";
            this.btnThongKeNV.UseVisualStyleBackColor = true;
            this.btnThongKeNV.Click += new System.EventHandler(this.btnThongKeNV_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToResizeColumns = false;
            this.dgvNhanVien.AllowUserToResizeRows = false;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cmndDataGridViewTextBoxColumn,
            this.avaDataGridViewImageColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dgvNhanVien.DataSource = this.nHANVIENBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNhanVien.Location = new System.Drawing.Point(331, 148);
            this.dgvNhanVien.Name = "dgvNhanVien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhanVien.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1086, 796);
            this.dgvNhanVien.TabIndex = 61;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "maNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "ID";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cmndDataGridViewTextBoxColumn
            // 
            this.cmndDataGridViewTextBoxColumn.DataPropertyName = "cmnd";
            this.cmndDataGridViewTextBoxColumn.HeaderText = "CMND";
            this.cmndDataGridViewTextBoxColumn.Name = "cmndDataGridViewTextBoxColumn";
            // 
            // avaDataGridViewImageColumn
            // 
            this.avaDataGridViewImageColumn.DataPropertyName = "ava";
            this.avaDataGridViewImageColumn.HeaderText = "Avatar";
            this.avaDataGridViewImageColumn.Name = "avaDataGridViewImageColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this._DESKTOP_RRRHOP4NhanVien;
            // 
            // _DESKTOP_RRRHOP4NhanVien
            // 
            this._DESKTOP_RRRHOP4NhanVien.DataSetName = "_DESKTOP_RRRHOP4NhanVien";
            this._DESKTOP_RRRHOP4NhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // chiaCaUC1
            // 
            this.chiaCaUC1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chiaCaUC1.Location = new System.Drawing.Point(331, 138);
            this.chiaCaUC1.Name = "chiaCaUC1";
            this.chiaCaUC1.Size = new System.Drawing.Size(1352, 1597);
            this.chiaCaUC1.TabIndex = 64;
            // 
            // editNhanVienUC1
            // 
            this.editNhanVienUC1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.editNhanVienUC1.BackColor = System.Drawing.Color.RoyalBlue;
            this.editNhanVienUC1.Location = new System.Drawing.Point(310, 3);
            this.editNhanVienUC1.Name = "editNhanVienUC1";
            this.editNhanVienUC1.Size = new System.Drawing.Size(1300, 904);
            this.editNhanVienUC1.TabIndex = 63;
            // 
            // addNhanVienUC1
            // 
            this.addNhanVienUC1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addNhanVienUC1.BackColor = System.Drawing.Color.RoyalBlue;
            this.addNhanVienUC1.Location = new System.Drawing.Point(310, 0);
            this.addNhanVienUC1.Name = "addNhanVienUC1";
            this.addNhanVienUC1.Size = new System.Drawing.Size(1311, 904);
            this.addNhanVienUC1.TabIndex = 62;
            // 
            // thongKeNVUC11
            // 
            this.thongKeNVUC11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.thongKeNVUC11.BackColor = System.Drawing.Color.LightSkyBlue;
            this.thongKeNVUC11.Location = new System.Drawing.Point(351, 60);
            this.thongKeNVUC11.Name = "thongKeNVUC11";
            this.thongKeNVUC11.Size = new System.Drawing.Size(1355, 832);
            this.thongKeNVUC11.TabIndex = 15;
            // 
            // panelNhanVien
            // 
            this.panelNhanVien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelNhanVien.Controls.Add(this.btThongKeNV);
            this.panelNhanVien.Controls.Add(this.btCaLamViec);
            this.panelNhanVien.Controls.Add(this.pictureBox3);
            this.panelNhanVien.Controls.Add(this.btHopDongGuiXe);
            this.panelNhanVien.Controls.Add(this.btHopDongThueXe);
            this.panelNhanVien.Controls.Add(this.btThongTinNV);
            this.panelNhanVien.Controls.Add(this.panelClickNV);
            this.panelNhanVien.Controls.Add(this.btGioiThieuNV);
            this.panelNhanVien.Location = new System.Drawing.Point(-1, 3);
            this.panelNhanVien.Name = "panelNhanVien";
            this.panelNhanVien.Size = new System.Drawing.Size(316, 909);
            this.panelNhanVien.TabIndex = 65;
            // 
            // btThongKeNV
            // 
            this.btThongKeNV.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btThongKeNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThongKeNV.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btThongKeNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThongKeNV.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKeNV.ForeColor = System.Drawing.Color.Transparent;
            this.btThongKeNV.Location = new System.Drawing.Point(3, 628);
            this.btThongKeNV.Name = "btThongKeNV";
            this.btThongKeNV.Size = new System.Drawing.Size(349, 85);
            this.btThongKeNV.TabIndex = 9;
            this.btThongKeNV.Text = "Thống kê ";
            this.btThongKeNV.UseVisualStyleBackColor = true;
            // 
            // btCaLamViec
            // 
            this.btCaLamViec.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btCaLamViec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCaLamViec.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btCaLamViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCaLamViec.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCaLamViec.ForeColor = System.Drawing.Color.Transparent;
            this.btCaLamViec.Location = new System.Drawing.Point(3, 547);
            this.btCaLamViec.Name = "btCaLamViec";
            this.btCaLamViec.Size = new System.Drawing.Size(349, 85);
            this.btCaLamViec.TabIndex = 8;
            this.btCaLamViec.Text = "Ca làm việc";
            this.btCaLamViec.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(32, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(282, 147);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btHopDongGuiXe
            // 
            this.btHopDongGuiXe.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btHopDongGuiXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHopDongGuiXe.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btHopDongGuiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHopDongGuiXe.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHopDongGuiXe.ForeColor = System.Drawing.Color.Transparent;
            this.btHopDongGuiXe.Location = new System.Drawing.Point(3, 461);
            this.btHopDongGuiXe.Name = "btHopDongGuiXe";
            this.btHopDongGuiXe.Size = new System.Drawing.Size(349, 90);
            this.btHopDongGuiXe.TabIndex = 5;
            this.btHopDongGuiXe.Text = "Hợp đồng gửi xe";
            this.btHopDongGuiXe.UseVisualStyleBackColor = true;
            // 
            // btHopDongThueXe
            // 
            this.btHopDongThueXe.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btHopDongThueXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHopDongThueXe.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btHopDongThueXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHopDongThueXe.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHopDongThueXe.ForeColor = System.Drawing.Color.Transparent;
            this.btHopDongThueXe.Location = new System.Drawing.Point(3, 369);
            this.btHopDongThueXe.Name = "btHopDongThueXe";
            this.btHopDongThueXe.Size = new System.Drawing.Size(346, 87);
            this.btHopDongThueXe.TabIndex = 4;
            this.btHopDongThueXe.Text = "Hợp đồng thuê xe";
            this.btHopDongThueXe.UseVisualStyleBackColor = true;
            // 
            // btThongTinNV
            // 
            this.btThongTinNV.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btThongTinNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThongTinNV.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btThongTinNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThongTinNV.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongTinNV.ForeColor = System.Drawing.Color.Transparent;
            this.btThongTinNV.Location = new System.Drawing.Point(3, 268);
            this.btThongTinNV.Name = "btThongTinNV";
            this.btThongTinNV.Size = new System.Drawing.Size(346, 95);
            this.btThongTinNV.TabIndex = 2;
            this.btThongTinNV.Text = "Thông tin nhân viên";
            this.btThongTinNV.UseVisualStyleBackColor = true;
            this.btThongTinNV.Click += new System.EventHandler(this.btThongTinNV_Click);
            // 
            // panelClickNV
            // 
            this.panelClickNV.BackColor = System.Drawing.Color.AliceBlue;
            this.panelClickNV.Location = new System.Drawing.Point(3, 176);
            this.panelClickNV.Name = "panelClickNV";
            this.panelClickNV.Size = new System.Drawing.Size(23, 80);
            this.panelClickNV.TabIndex = 1;
            // 
            // btGioiThieuNV
            // 
            this.btGioiThieuNV.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btGioiThieuNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGioiThieuNV.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btGioiThieuNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGioiThieuNV.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGioiThieuNV.ForeColor = System.Drawing.Color.Transparent;
            this.btGioiThieuNV.Location = new System.Drawing.Point(3, 176);
            this.btGioiThieuNV.Name = "btGioiThieuNV";
            this.btGioiThieuNV.Size = new System.Drawing.Size(349, 86);
            this.btGioiThieuNV.TabIndex = 0;
            this.btGioiThieuNV.Text = "Giới thiệu";
            this.btGioiThieuNV.UseVisualStyleBackColor = true;
            // 
            // NhanVienUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.panelNhanVien);
            this.Controls.Add(this.pnThongTinNV);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.chiaCaUC1);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.editNhanVienUC1);
            this.Controls.Add(this.addNhanVienUC1);
            this.Controls.Add(this.thongKeNVUC11);
            this.Name = "NhanVienUC";
            this.Size = new System.Drawing.Size(1967, 904);
            this.Load += new System.EventHandler(this.NhanVienUC_Load);
            this.pnThongTinNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_RRRHOP4NhanVien)).EndInit();
            this.panelNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnThongTinNV;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnThongKeNV;
        private ThongKeNVUC1 thongKeNVUC11;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private _DESKTOP_RRRHOP4NhanVien _DESKTOP_RRRHOP4NhanVien;
        private _DESKTOP_RRRHOP4NhanVienTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn avaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private AddNhanVienUC addNhanVienUC1;
        private EditNhanVienUC editNhanVienUC1;
        //private System.Windows.Forms.Button btnChiaca;
        private ChiaCaUC chiaCaUC1;
        private System.Windows.Forms.Button btnCa;
        public System.Windows.Forms.Panel panelNhanVien;
        private System.Windows.Forms.Button btThongKeNV;
        private System.Windows.Forms.Button btCaLamViec;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btHopDongGuiXe;
        private System.Windows.Forms.Button btHopDongThueXe;
        private System.Windows.Forms.Button btThongTinNV;
        private System.Windows.Forms.Panel panelClickNV;
        private System.Windows.Forms.Button btGioiThieuNV;
    }
}

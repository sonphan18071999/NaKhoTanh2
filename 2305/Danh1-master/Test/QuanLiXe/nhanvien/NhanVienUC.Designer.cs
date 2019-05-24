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
            this.btnShowNhanVien = new System.Windows.Forms.Button();
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
            this.panelNhanVien = new System.Windows.Forms.Panel();
            this.menuNhanVien = new System.Windows.Forms.MenuStrip();
            this.giớThiệuiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhânViênToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hợpĐồngThuêXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hợpĐồngGửiXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caLàmViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmSửaXóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLuongNhanVien = new System.Windows.Forms.DataGridView();
            this.thongKeNVUC11 = new QuanLiXe.ThongKeNVUC1();
            this.editNhanVienUC1 = new QuanLiXe.EditNhanVienUC();
            this.addNhanVienUC1 = new QuanLiXe.AddNhanVienUC();
            this.lichNhanVien1 = new QuanLiXe.LichNhanVien();
            this.pnThongTinNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_RRRHOP4NhanVien)).BeginInit();
            this.panelNhanVien.SuspendLayout();
            this.menuNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(822, 165);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 42);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(225, 162);
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
            this.btnDelete.Location = new System.Drawing.Point(11, 314);
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
            this.btnEdit.Location = new System.Drawing.Point(11, 197);
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
            this.btnAdd.Location = new System.Drawing.Point(11, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 88);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnThongTinNV
            // 
            this.pnThongTinNV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnThongTinNV.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnThongTinNV.Controls.Add(this.btnShowNhanVien);
            this.pnThongTinNV.Controls.Add(this.btnDelete);
            this.pnThongTinNV.Controls.Add(this.btnEdit);
            this.pnThongTinNV.Controls.Add(this.btnAdd);
            this.pnThongTinNV.Location = new System.Drawing.Point(1250, 196);
            this.pnThongTinNV.Margin = new System.Windows.Forms.Padding(2);
            this.pnThongTinNV.Name = "pnThongTinNV";
            this.pnThongTinNV.Size = new System.Drawing.Size(193, 551);
            this.pnThongTinNV.TabIndex = 11;
            this.pnThongTinNV.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnShowNhanVien
            // 
            this.btnShowNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowNhanVien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowNhanVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowNhanVien.BackgroundImage")));
            this.btnShowNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowNhanVien.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnShowNhanVien.Location = new System.Drawing.Point(10, 422);
            this.btnShowNhanVien.Name = "btnShowNhanVien";
            this.btnShowNhanVien.Size = new System.Drawing.Size(180, 88);
            this.btnShowNhanVien.TabIndex = 7;
            this.btnShowNhanVien.Text = "All";
            this.btnShowNhanVien.UseVisualStyleBackColor = false;
            this.btnShowNhanVien.Click += new System.EventHandler(this.btnShowNhanVien_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToResizeColumns = false;
            this.dgvNhanVien.AllowUserToResizeRows = false;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.dgvNhanVien.Location = new System.Drawing.Point(6, 225);
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
            this.dgvNhanVien.Size = new System.Drawing.Size(1246, 939);
            this.dgvNhanVien.TabIndex = 61;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
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
            // panelNhanVien
            // 
            this.panelNhanVien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelNhanVien.Controls.Add(this.menuNhanVien);
            this.panelNhanVien.Location = new System.Drawing.Point(6, 56);
            this.panelNhanVien.Name = "panelNhanVien";
            this.panelNhanVien.Size = new System.Drawing.Size(316, 55);
            this.panelNhanVien.TabIndex = 65;
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giớThiệuiToolStripMenuItem});
            this.menuNhanVien.Location = new System.Drawing.Point(0, 0);
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuNhanVien.Size = new System.Drawing.Size(316, 53);
            this.menuNhanVien.TabIndex = 10;
            this.menuNhanVien.Text = "menuStrip1";
            // 
            // giớThiệuiToolStripMenuItem
            // 
            this.giớThiệuiToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.giớThiệuiToolStripMenuItem.BackgroundImage = global::QuanLiXe.Properties.Resources.avatar_default_icon;
            this.giớThiệuiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNhânViênToolStripMenuItem,
            this.thôngTinNhânViênToolStripMenuItem1,
            this.hợpĐồngThuêXeToolStripMenuItem,
            this.hợpĐồngGửiXeToolStripMenuItem,
            this.caLàmViệcToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.thêmSửaXóaToolStripMenuItem,
            this.lươngNhânViênToolStripMenuItem});
            this.giớThiệuiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giớThiệuiToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSalmon;
            this.giớThiệuiToolStripMenuItem.Image = global::QuanLiXe.Properties.Resources.avatar_default_icon;
            this.giớThiệuiToolStripMenuItem.Name = "giớThiệuiToolStripMenuItem";
            this.giớThiệuiToolStripMenuItem.Size = new System.Drawing.Size(130, 49);
            this.giớThiệuiToolStripMenuItem.Text = "Menu";
            // 
            // thôngTinNhânViênToolStripMenuItem
            // 
            this.thôngTinNhânViênToolStripMenuItem.Name = "thôngTinNhânViênToolStripMenuItem";
            this.thôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(439, 50);
            this.thôngTinNhânViênToolStripMenuItem.Text = "Giới thiệu";
            this.thôngTinNhânViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNhânViênToolStripMenuItem_Click);
            // 
            // thôngTinNhânViênToolStripMenuItem1
            // 
            this.thôngTinNhânViênToolStripMenuItem1.Name = "thôngTinNhânViênToolStripMenuItem1";
            this.thôngTinNhânViênToolStripMenuItem1.Size = new System.Drawing.Size(439, 50);
            this.thôngTinNhânViênToolStripMenuItem1.Text = "Thông tin nhân viên";
            this.thôngTinNhânViênToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinNhânViênToolStripMenuItem1_Click);
            // 
            // hợpĐồngThuêXeToolStripMenuItem
            // 
            this.hợpĐồngThuêXeToolStripMenuItem.Name = "hợpĐồngThuêXeToolStripMenuItem";
            this.hợpĐồngThuêXeToolStripMenuItem.Size = new System.Drawing.Size(439, 50);
            this.hợpĐồngThuêXeToolStripMenuItem.Text = "Hợp đồng thuê xe";
            this.hợpĐồngThuêXeToolStripMenuItem.Click += new System.EventHandler(this.hợpĐồngThuêXeToolStripMenuItem_Click);
            // 
            // hợpĐồngGửiXeToolStripMenuItem
            // 
            this.hợpĐồngGửiXeToolStripMenuItem.Name = "hợpĐồngGửiXeToolStripMenuItem";
            this.hợpĐồngGửiXeToolStripMenuItem.Size = new System.Drawing.Size(439, 50);
            this.hợpĐồngGửiXeToolStripMenuItem.Text = "Hợp đồng gửi xe";
            this.hợpĐồngGửiXeToolStripMenuItem.Click += new System.EventHandler(this.hợpĐồngGửiXeToolStripMenuItem_Click);
            // 
            // caLàmViệcToolStripMenuItem
            // 
            this.caLàmViệcToolStripMenuItem.Name = "caLàmViệcToolStripMenuItem";
            this.caLàmViệcToolStripMenuItem.Size = new System.Drawing.Size(439, 50);
            this.caLàmViệcToolStripMenuItem.Text = "Chia ca nhân viên";
            this.caLàmViệcToolStripMenuItem.Click += new System.EventHandler(this.caLàmViệcToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(439, 50);
            this.thốngKêToolStripMenuItem.Text = "Thống kê loại nhân viên";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // thêmSửaXóaToolStripMenuItem
            // 
            this.thêmSửaXóaToolStripMenuItem.Name = "thêmSửaXóaToolStripMenuItem";
            this.thêmSửaXóaToolStripMenuItem.Size = new System.Drawing.Size(439, 50);
            this.thêmSửaXóaToolStripMenuItem.Text = "Thêm, Sửa,Xóa";
            this.thêmSửaXóaToolStripMenuItem.Click += new System.EventHandler(this.thêmSửaXóaToolStripMenuItem_Click);
            // 
            // lươngNhânViênToolStripMenuItem
            // 
            this.lươngNhânViênToolStripMenuItem.Name = "lươngNhânViênToolStripMenuItem";
            this.lươngNhânViênToolStripMenuItem.Size = new System.Drawing.Size(439, 50);
            this.lươngNhânViênToolStripMenuItem.Text = "Lương nhân viên";
            this.lươngNhânViênToolStripMenuItem.Click += new System.EventHandler(this.lươngNhânViênToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(411, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 36);
            this.label1.TabIndex = 69;
            this.label1.Text = "Bảng lương nhân viên tuần";
            // 
            // dgvLuongNhanVien
            // 
            this.dgvLuongNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuongNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvLuongNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuongNhanVien.Location = new System.Drawing.Point(146, 165);
            this.dgvLuongNhanVien.Name = "dgvLuongNhanVien";
            this.dgvLuongNhanVien.Size = new System.Drawing.Size(958, 653);
            this.dgvLuongNhanVien.TabIndex = 68;
            // 
            // thongKeNVUC11
            // 
            this.thongKeNVUC11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thongKeNVUC11.BackColor = System.Drawing.Color.CornflowerBlue;
            this.thongKeNVUC11.Location = new System.Drawing.Point(125, 196);
            this.thongKeNVUC11.Name = "thongKeNVUC11";
            this.thongKeNVUC11.Size = new System.Drawing.Size(1080, 800);
            this.thongKeNVUC11.TabIndex = 67;
            // 
            // editNhanVienUC1
            // 
            this.editNhanVienUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.editNhanVienUC1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editNhanVienUC1.Location = new System.Drawing.Point(14, 131);
            this.editNhanVienUC1.Name = "editNhanVienUC1";
            this.editNhanVienUC1.Size = new System.Drawing.Size(1241, 1033);
            this.editNhanVienUC1.TabIndex = 63;
            // 
            // addNhanVienUC1
            // 
            this.addNhanVienUC1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addNhanVienUC1.BackColor = System.Drawing.Color.RoyalBlue;
            this.addNhanVienUC1.Location = new System.Drawing.Point(6, 165);
            this.addNhanVienUC1.Name = "addNhanVienUC1";
            this.addNhanVienUC1.Size = new System.Drawing.Size(1249, 863);
            this.addNhanVienUC1.TabIndex = 62;
            // 
            // lichNhanVien1
            // 
            this.lichNhanVien1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lichNhanVien1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lichNhanVien1.Location = new System.Drawing.Point(-21, 210);
            this.lichNhanVien1.Name = "lichNhanVien1";
            this.lichNhanVien1.Size = new System.Drawing.Size(1266, 688);
            this.lichNhanVien1.TabIndex = 66;
            // 
            // NhanVienUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.panelNhanVien);
            this.Controls.Add(this.pnThongTinNV);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thongKeNVUC11);
            this.Controls.Add(this.editNhanVienUC1);
            this.Controls.Add(this.addNhanVienUC1);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.lichNhanVien1);
            this.Controls.Add(this.dgvLuongNhanVien);
            this.Name = "NhanVienUC";
            this.Size = new System.Drawing.Size(1445, 1047);
            this.Load += new System.EventHandler(this.NhanVienUC_Load);
            this.pnThongTinNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_RRRHOP4NhanVien)).EndInit();
            this.panelNhanVien.ResumeLayout(false);
            this.panelNhanVien.PerformLayout();
            this.menuNhanVien.ResumeLayout(false);
            this.menuNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNhanVien)).EndInit();
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
        public System.Windows.Forms.Panel panelNhanVien;
        private System.Windows.Forms.MenuStrip menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem giớThiệuiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hợpĐồngThuêXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hợpĐồngGửiXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caLàmViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private LichNhanVien lichNhanVien1;
        private System.Windows.Forms.ToolStripMenuItem thêmSửaXóaToolStripMenuItem;
        private System.Windows.Forms.Button btnShowNhanVien;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhânViênToolStripMenuItem1;
        private ThongKeNVUC1 thongKeNVUC11;
        private System.Windows.Forms.ToolStripMenuItem lươngNhânViênToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLuongNhanVien;
    }
}


namespace PBL3.GUI
{
    partial class fQLNhapKho
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
            this.gvSP = new System.Windows.Forms.DataGridView();
            this.ccbSapXep = new System.Windows.Forms.ComboBox();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvNhap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.huyBtn = new System.Windows.Forms.Button();
            this.luuBtn = new System.Windows.Forms.Button();
            this.txtIDNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.cbbTenNCC = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbSP = new System.Windows.Forms.ComboBox();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numUDSL = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSL)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSP
            // 
            this.gvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSP.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.gvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSP.Location = new System.Drawing.Point(655, 232);
            this.gvSP.Margin = new System.Windows.Forms.Padding(2);
            this.gvSP.MultiSelect = false;
            this.gvSP.Name = "gvSP";
            this.gvSP.RowHeadersWidth = 51;
            this.gvSP.RowTemplate.Height = 24;
            this.gvSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSP.Size = new System.Drawing.Size(384, 299);
            this.gvSP.TabIndex = 58;
            // 
            // ccbSapXep
            // 
            this.ccbSapXep.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ccbSapXep.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbSapXep.FormattingEnabled = true;
            this.ccbSapXep.Location = new System.Drawing.Point(463, 279);
            this.ccbSapXep.Margin = new System.Windows.Forms.Padding(2);
            this.ccbSapXep.Name = "ccbSapXep";
            this.ccbSapXep.Size = new System.Drawing.Size(166, 23);
            this.ccbSapXep.TabIndex = 49;
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.ForeColor = System.Drawing.Color.White;
            this.btnSapXep.Image = global::PBL3.Properties.Resources.baseline_sort_white_24dp;
            this.btnSapXep.Location = new System.Drawing.Point(343, 268);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(2);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(116, 43);
            this.btnSapXep.TabIndex = 48;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSapXep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSapXep.UseVisualStyleBackColor = false;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(140, 279);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 21);
            this.txtSearch.TabIndex = 46;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSo_KeyPress);
            // 
            // dgvNhap
            // 
            this.dgvNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhap.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhap.Location = new System.Drawing.Point(16, 324);
            this.dgvNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhap.Name = "dgvNhap";
            this.dgvNhap.ReadOnly = true;
            this.dgvNhap.RowHeadersWidth = 51;
            this.dgvNhap.RowTemplate.Height = 24;
            this.dgvNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhap.Size = new System.Drawing.Size(613, 207);
            this.dgvNhap.TabIndex = 42;
            this.dgvNhap.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNhap_RowHeaderMouseClick);
            this.dgvNhap.SelectionChanged += new System.EventHandler(this.dgvNhap_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.huyBtn);
            this.groupBox1.Controls.Add(this.luuBtn);
            this.groupBox1.Controls.Add(this.txtIDNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbTenNV);
            this.groupBox1.Controls.Add(this.cbbTenNCC);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(20, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 185);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // huyBtn
            // 
            this.huyBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.huyBtn.Enabled = false;
            this.huyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.huyBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huyBtn.ForeColor = System.Drawing.Color.White;
            this.huyBtn.Image = global::PBL3.Properties.Resources.baseline_highlight_off_white_24dp;
            this.huyBtn.Location = new System.Drawing.Point(192, 131);
            this.huyBtn.Name = "huyBtn";
            this.huyBtn.Size = new System.Drawing.Size(134, 35);
            this.huyBtn.TabIndex = 72;
            this.huyBtn.Text = "Hủy";
            this.huyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.huyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.huyBtn.UseVisualStyleBackColor = false;
            this.huyBtn.Click += new System.EventHandler(this.huyBtn_Click);
            // 
            // luuBtn
            // 
            this.luuBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.luuBtn.Enabled = false;
            this.luuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.luuBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luuBtn.ForeColor = System.Drawing.Color.White;
            this.luuBtn.Image = global::PBL3.Properties.Resources.baseline_check_circle_outline_white_24dp;
            this.luuBtn.Location = new System.Drawing.Point(19, 131);
            this.luuBtn.Name = "luuBtn";
            this.luuBtn.Size = new System.Drawing.Size(147, 35);
            this.luuBtn.TabIndex = 71;
            this.luuBtn.Text = "Lưu";
            this.luuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.luuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.luuBtn.UseVisualStyleBackColor = false;
            this.luuBtn.Click += new System.EventHandler(this.luuBtn_Click);
            // 
            // txtIDNhap
            // 
            this.txtIDNhap.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtIDNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDNhap.Enabled = false;
            this.txtIDNhap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNhap.Location = new System.Drawing.Point(133, 29);
            this.txtIDNhap.Name = "txtIDNhap";
            this.txtIDNhap.Size = new System.Drawing.Size(130, 21);
            this.txtIDNhap.TabIndex = 70;
            this.txtIDNhap.TextChanged += new System.EventHandler(this.txtIDNhap_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 69;
            this.label4.Text = "ID Đơn hàng nhập";
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbbTenNV.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.Location = new System.Drawing.Point(412, 24);
            this.cbbTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(171, 23);
            this.cbbTenNV.TabIndex = 68;
            // 
            // cbbTenNCC
            // 
            this.cbbTenNCC.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbbTenNCC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenNCC.FormattingEnabled = true;
            this.cbbTenNCC.Location = new System.Drawing.Point(134, 85);
            this.cbbTenNCC.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTenNCC.Name = "cbbTenNCC";
            this.cbbTenNCC.Size = new System.Drawing.Size(129, 23);
            this.cbbTenNCC.TabIndex = 67;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Location = new System.Drawing.Point(412, 92);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(171, 21);
            this.dtpNgayNhap.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 65;
            this.label5.Text = "Ngày nhập kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 64;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 63;
            this.label1.Text = "Tên nhà cung cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lbDonGia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbbSP);
            this.groupBox2.Controls.Add(this.btnXoaSP);
            this.groupBox2.Controls.Add(this.btnThemSP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numUDSL);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox2.Location = new System.Drawing.Point(655, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 199);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SẢN PHẨM";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.Location = new System.Drawing.Point(135, 66);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(0, 15);
            this.lbDonGia.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 70;
            this.label7.Text = "Giá nhập";
            // 
            // cbbSP
            // 
            this.cbbSP.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbbSP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSP.FormattingEnabled = true;
            this.cbbSP.Location = new System.Drawing.Point(138, 32);
            this.cbbSP.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSP.Name = "cbbSP";
            this.cbbSP.Size = new System.Drawing.Size(177, 23);
            this.cbbSP.TabIndex = 69;
            this.cbbSP.SelectedValueChanged += new System.EventHandler(this.cbbSP_SelectedValueChanged);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Image = global::PBL3.Properties.Resources.baseline_delete_white_24dp;
            this.btnXoaSP.Location = new System.Drawing.Point(220, 134);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(95, 32);
            this.btnXoaSP.TabIndex = 68;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemSP.Enabled = false;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Image = global::PBL3.Properties.Resources.baseline_add_circle_outline_white_24dp;
            this.btnThemSP.Location = new System.Drawing.Point(57, 134);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(96, 32);
            this.btnThemSP.TabIndex = 67;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 66;
            this.label6.Text = "Số Lượng";
            // 
            // numUDSL
            // 
            this.numUDSL.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.numUDSL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDSL.Location = new System.Drawing.Point(138, 95);
            this.numUDSL.Margin = new System.Windows.Forms.Padding(2);
            this.numUDSL.Name = "numUDSL";
            this.numUDSL.Size = new System.Drawing.Size(87, 21);
            this.numUDSL.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "Sản phẩm";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::PBL3.Properties.Resources.baseline_refresh_white_24dp;
            this.btnRefresh.Location = new System.Drawing.Point(509, 207);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 43);
            this.btnRefresh.TabIndex = 57;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::PBL3.Properties.Resources.baseline_search_white_24dp;
            this.btnSearch.Location = new System.Drawing.Point(20, 267);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 43);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::PBL3.Properties.Resources.baseline_update_white_24dp;
            this.btnEdit.Location = new System.Drawing.Point(175, 206);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(116, 43);
            this.btnEdit.TabIndex = 45;
            this.btnEdit.Text = "Cập Nhật";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::PBL3.Properties.Resources.baseline_delete_white_24dp;
            this.btnDelete.Location = new System.Drawing.Point(343, 206);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 43);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::PBL3.Properties.Resources.baseline_post_add_white_24dp;
            this.btnAdd.Location = new System.Drawing.Point(20, 207);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 43);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fQLNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 559);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvSP);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ccbSapXep);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvNhap);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fQLNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHẬP KHO";
            ((System.ComponentModel.ISupportInitialize)(this.gvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvSP;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox ccbSapXep;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button huyBtn;
        private System.Windows.Forms.Button luuBtn;
        private System.Windows.Forms.TextBox txtIDNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private System.Windows.Forms.ComboBox cbbTenNCC;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numUDSL;
        private System.Windows.Forms.Label label3;
    }
}
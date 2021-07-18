
namespace PBL3.GUI
{
    partial class fQLBanHang
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtSumPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTongTien = new System.Windows.Forms.Button();
            this.cbbSapXep = new System.Windows.Forms.ComboBox();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.cbbSize = new System.Windows.Forms.ComboBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lsvShoesSelected = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvBanHang = new System.Windows.Forms.DataGridView();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 496);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 81;
            this.label7.Text = "Giảm giá(%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 544);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 80;
            this.label5.Text = "Tổng Tiền";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(731, 493);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(150, 21);
            this.txtGiamGia.TabIndex = 79;
            // 
            // txtSumPrice
            // 
            this.txtSumPrice.Location = new System.Drawing.Point(733, 539);
            this.txtSumPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtSumPrice.Name = "txtSumPrice";
            this.txtSumPrice.Size = new System.Drawing.Size(150, 21);
            this.txtSumPrice.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 77;
            this.label2.Text = "Size Giày";
            // 
            // btnTongTien
            // 
            this.btnTongTien.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTongTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongTien.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongTien.ForeColor = System.Drawing.Color.White;
            this.btnTongTien.Location = new System.Drawing.Point(567, 433);
            this.btnTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.btnTongTien.Name = "btnTongTien";
            this.btnTongTien.Size = new System.Drawing.Size(153, 44);
            this.btnTongTien.TabIndex = 76;
            this.btnTongTien.Text = "Tổng Tiền khi chưa giảm giá";
            this.btnTongTien.UseVisualStyleBackColor = false;
            this.btnTongTien.Click += new System.EventHandler(this.btnTongTien_Click);
            // 
            // cbbSapXep
            // 
            this.cbbSapXep.FormattingEnabled = true;
            this.cbbSapXep.Location = new System.Drawing.Point(429, 28);
            this.cbbSapXep.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSapXep.Name = "cbbSapXep";
            this.cbbSapXep.Size = new System.Drawing.Size(159, 23);
            this.cbbSapXep.TabIndex = 75;
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.ForeColor = System.Drawing.Color.White;
            this.btnSapXep.Image = global::PBL3.Properties.Resources.baseline_sort_white_24dp;
            this.btnSapXep.Location = new System.Drawing.Point(320, 21);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(2);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(93, 34);
            this.btnSapXep.TabIndex = 74;
            this.btnSapXep.Text = "Sắp Xếp";
            this.btnSapXep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSapXep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSapXep.UseVisualStyleBackColor = false;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // cbbSize
            // 
            this.cbbSize.FormattingEnabled = true;
            this.cbbSize.Location = new System.Drawing.Point(150, 71);
            this.cbbSize.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(129, 23);
            this.cbbSize.TabIndex = 73;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Image = global::PBL3.Properties.Resources.baseline_check_circle_outline_white_24dp;
            this.btnCheck.Location = new System.Drawing.Point(882, 19);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 39);
            this.btnCheck.TabIndex = 72;
            this.btnCheck.Text = "Kiểm Tra";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(730, 80);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(76, 15);
            this.labelDate.TabIndex = 71;
            this.labelDate.Text = ".......................";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(601, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 70;
            this.label6.Text = "Ngày lập hóa đơn";
            // 
            // lsvShoesSelected
            // 
            this.lsvShoesSelected.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lsvShoesSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvShoesSelected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader4});
            this.lsvShoesSelected.FullRowSelect = true;
            this.lsvShoesSelected.HideSelection = false;
            this.lsvShoesSelected.Location = new System.Drawing.Point(603, 126);
            this.lsvShoesSelected.Margin = new System.Windows.Forms.Padding(2);
            this.lsvShoesSelected.MultiSelect = false;
            this.lsvShoesSelected.Name = "lsvShoesSelected";
            this.lsvShoesSelected.Size = new System.Drawing.Size(588, 282);
            this.lsvShoesSelected.TabIndex = 69;
            this.lsvShoesSelected.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã giày";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên giày";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá(1 sản phẩm)";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thành tiền";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(150, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(129, 21);
            this.txtSearch.TabIndex = 68;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(733, 447);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(150, 21);
            this.txtTongTien.TabIndex = 67;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::PBL3.Properties.Resources.baseline_add_circle_outline_white_24dp;
            this.btnAdd.Location = new System.Drawing.Point(216, 456);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 57);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvBanHang
            // 
            this.dgvBanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvBanHang.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanHang.Location = new System.Drawing.Point(13, 126);
            this.dgvBanHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBanHang.Name = "dgvBanHang";
            this.dgvBanHang.RowHeadersWidth = 51;
            this.dgvBanHang.RowTemplate.Height = 24;
            this.dgvBanHang.Size = new System.Drawing.Size(575, 282);
            this.dgvBanHang.TabIndex = 61;
            this.dgvBanHang.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvBanHang_MouseDoubleClick);
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(734, 28);
            this.txtSDTKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(129, 21);
            this.txtSDTKH.TabIndex = 59;
            this.txtSDTKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTKH_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(882, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "SĐT Khách Hàng";
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.Location = new System.Drawing.Point(1015, 73);
            this.cbbTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(129, 23);
            this.cbbTenNV.TabIndex = 60;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.ForeColor = System.Drawing.Color.Red;
            this.lbSDT.Location = new System.Drawing.Point(987, 31);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(0, 15);
            this.lbSDT.TabIndex = 82;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::PBL3.Properties.Resources.baseline_search_white_24dp;
            this.btnSearch.Location = new System.Drawing.Point(13, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 34);
            this.btnSearch.TabIndex = 66;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Image = global::PBL3.Properties.Resources.baseline_shopping_cart_white_24dp;
            this.btnThanhToan.Location = new System.Drawing.Point(939, 475);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(205, 70);
            this.btnThanhToan.TabIndex = 65;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Image = global::PBL3.Properties.Resources.baseline_refresh_white_24dp;
            this.btnShow.Location = new System.Drawing.Point(14, 456);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(116, 55);
            this.btnShow.TabIndex = 64;
            this.btnShow.Text = "Làm Mới";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::PBL3.Properties.Resources.baseline_delete_white_24dp;
            this.btnDelete.Location = new System.Drawing.Point(405, 456);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 57);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // fQLBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PBL3.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 586);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.txtSumPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTongTien);
            this.Controls.Add(this.cbbSapXep);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.cbbSize);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lsvShoesSelected);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvBanHang);
            this.Controls.Add(this.txtSDTKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTenNV);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fQLBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ BÁN HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtSumPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTongTien;
        private System.Windows.Forms.ComboBox cbbSapXep;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.ComboBox cbbSize;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lsvShoesSelected;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvBanHang;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private System.Windows.Forms.Label lbSDT;
    }
}

namespace PBL3.GUI
{
    partial class fThongTinSP
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.cbbSapXep = new System.Windows.Forms.ComboBox();
            this.cbbHang = new System.Windows.Forms.ComboBox();
            this.btnHang = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(138, 26);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(112, 21);
            this.txtSearch.TabIndex = 64;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::PBL3.Properties.Resources.baseline_add_circle_outline_white_24dp;
            this.btnAdd.Location = new System.Drawing.Point(803, 106);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 51);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvSP
            // 
            this.dgvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSP.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(28, 77);
            this.dgvSP.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(742, 319);
            this.dgvSP.TabIndex = 60;
            this.dgvSP.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSP_MouseDoubleClick);
            // 
            // cbbSapXep
            // 
            this.cbbSapXep.FormattingEnabled = true;
            this.cbbSapXep.Location = new System.Drawing.Point(378, 24);
            this.cbbSapXep.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSapXep.Name = "cbbSapXep";
            this.cbbSapXep.Size = new System.Drawing.Size(121, 23);
            this.cbbSapXep.TabIndex = 69;
            // 
            // cbbHang
            // 
            this.cbbHang.FormattingEnabled = true;
            this.cbbHang.Location = new System.Drawing.Point(626, 24);
            this.cbbHang.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbbHang.Name = "cbbHang";
            this.cbbHang.Size = new System.Drawing.Size(140, 23);
            this.cbbHang.TabIndex = 72;
            // 
            // btnHang
            // 
            this.btnHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHang.ForeColor = System.Drawing.Color.White;
            this.btnHang.Image = global::PBL3.Properties.Resources.baseline_groups_white_24dp;
            this.btnHang.Location = new System.Drawing.Point(530, 15);
            this.btnHang.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnHang.Name = "btnHang";
            this.btnHang.Size = new System.Drawing.Size(89, 43);
            this.btnHang.TabIndex = 71;
            this.btnHang.Text = "Hãng";
            this.btnHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHang.UseVisualStyleBackColor = false;
            this.btnHang.Click += new System.EventHandler(this.btnHang_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::PBL3.Properties.Resources.baseline_refresh_white_24dp;
            this.btnRefresh.Location = new System.Drawing.Point(803, 15);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 51);
            this.btnRefresh.TabIndex = 70;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSapXep.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.ForeColor = System.Drawing.Color.White;
            this.btnSapXep.Image = global::PBL3.Properties.Resources.baseline_sort_white_24dp;
            this.btnSapXep.Location = new System.Drawing.Point(285, 15);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(2);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(89, 43);
            this.btnSapXep.TabIndex = 68;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSapXep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSapXep.UseVisualStyleBackColor = false;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::PBL3.Properties.Resources.baseline_search_white_24dp;
            this.btnSearch.Location = new System.Drawing.Point(30, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 43);
            this.btnSearch.TabIndex = 65;
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
            this.btnEdit.Location = new System.Drawing.Point(803, 306);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 51);
            this.btnEdit.TabIndex = 63;
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
            this.btnDelete.Location = new System.Drawing.Point(803, 202);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 51);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // fThongTinSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 431);
            this.Controls.Add(this.cbbHang);
            this.Controls.Add(this.btnHang);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbbSapXep);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvSP);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fThongTinSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN SẢN PHẨM";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.ComboBox cbbSapXep;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHang;
        private System.Windows.Forms.ComboBox cbbHang;
    }
}
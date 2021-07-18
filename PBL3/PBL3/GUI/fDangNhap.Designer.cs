
namespace PBL3.GUI
{
    partial class fDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lkbSetMK = new System.Windows.Forms.LinkLabel();
            this.lbWel = new System.Windows.Forms.Label();
            this.picWel = new System.Windows.Forms.PictureBox();
            this.btnDN = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(234, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // txtTenDN
            // 
            this.txtTenDN.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTenDN.Location = new System.Drawing.Point(237, 107);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(250, 21);
            this.txtTenDN.TabIndex = 1;
            // 
            // txtMK
            // 
            this.txtMK.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMK.Location = new System.Drawing.Point(237, 165);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(250, 21);
            this.txtMK.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(234, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // lkbSetMK
            // 
            this.lkbSetMK.AutoSize = true;
            this.lkbSetMK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkbSetMK.Location = new System.Drawing.Point(235, 189);
            this.lkbSetMK.Name = "lkbSetMK";
            this.lkbSetMK.Size = new System.Drawing.Size(102, 15);
            this.lkbSetMK.TabIndex = 9;
            this.lkbSetMK.TabStop = true;
            this.lkbSetMK.Text = "Quên mật khẩu...";
            this.lkbSetMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbSetMK_LinkClicked);
            // 
            // lbWel
            // 
            this.lbWel.AutoSize = true;
            this.lbWel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbWel.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWel.ForeColor = System.Drawing.Color.White;
            this.lbWel.Location = new System.Drawing.Point(12, 63);
            this.lbWel.Name = "lbWel";
            this.lbWel.Size = new System.Drawing.Size(182, 41);
            this.lbWel.TabIndex = 12;
            this.lbWel.Text = "WELLCOME";
            // 
            // picWel
            // 
            this.picWel.Dock = System.Windows.Forms.DockStyle.Left;
            this.picWel.Image = ((System.Drawing.Image)(resources.GetObject("picWel.Image")));
            this.picWel.Location = new System.Drawing.Point(0, 0);
            this.picWel.Name = "picWel";
            this.picWel.Size = new System.Drawing.Size(204, 327);
            this.picWel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWel.TabIndex = 11;
            this.picWel.TabStop = false;
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDN.FlatAppearance.BorderSize = 0;
            this.btnDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.ForeColor = System.Drawing.Color.White;
            this.btnDN.Image = global::PBL3.Properties.Resources.baseline_login_white_24dp;
            this.btnDN.Location = new System.Drawing.Point(384, 215);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(103, 34);
            this.btnDN.TabIndex = 4;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDN.UseCompatibleTextRendering = true;
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(541, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(34, 22);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 327);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbWel);
            this.Controls.Add(this.picWel);
            this.Controls.Add(this.lkbSetMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fDangNhap_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picWel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lkbSetMK;
        private System.Windows.Forms.PictureBox picWel;
        private System.Windows.Forms.Label lbWel;
        private System.Windows.Forms.Button btnCancel;
    }
}

namespace PBL3.GUI
{
    partial class fWellcome
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
            this.components = new System.ComponentModel.Container();
            this.pnProgress = new System.Windows.Forms.Panel();
            this.pnLoad = new System.Windows.Forms.Panel();
            this.tmrRun = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnProgress
            // 
            this.pnProgress.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnProgress.Location = new System.Drawing.Point(0, 352);
            this.pnProgress.Name = "pnProgress";
            this.pnProgress.Size = new System.Drawing.Size(629, 13);
            this.pnProgress.TabIndex = 0;
            // 
            // pnLoad
            // 
            this.pnLoad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLoad.Location = new System.Drawing.Point(0, 352);
            this.pnLoad.Name = "pnLoad";
            this.pnLoad.Size = new System.Drawing.Size(10, 13);
            this.pnLoad.TabIndex = 1;
            // 
            // tmrRun
            // 
            this.tmrRun.Enabled = true;
            this.tmrRun.Interval = 15;
            this.tmrRun.Tick += new System.EventHandler(this.tmrRun_Tick);
            // 
            // fWellcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.quan_ly_ban_giay;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 365);
            this.ControlBox = false;
            this.Controls.Add(this.pnLoad);
            this.Controls.Add(this.pnProgress);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fWellcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fWellcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnProgress;
        private System.Windows.Forms.Panel pnLoad;
        private System.Windows.Forms.Timer tmrRun;
    }
}
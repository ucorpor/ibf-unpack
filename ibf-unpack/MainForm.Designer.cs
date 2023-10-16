namespace ibf_unpack
{
    partial class MainForm
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
            this.pathBtn = new System.Windows.Forms.Button();
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.unpackBtn = new System.Windows.Forms.Button();
            this.renameCb = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.unpackPage = new System.Windows.Forms.TabPage();
            this.makePage = new System.Windows.Forms.TabPage();
            this.makeBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.unpackPage.SuspendLayout();
            this.makePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathBtn
            // 
            this.pathBtn.Location = new System.Drawing.Point(262, 5);
            this.pathBtn.Name = "pathBtn";
            this.pathBtn.Size = new System.Drawing.Size(96, 23);
            this.pathBtn.TabIndex = 0;
            this.pathBtn.Text = "Choose IBF-file...";
            this.pathBtn.UseVisualStyleBackColor = true;
            this.pathBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // pathTxt
            // 
            this.pathTxt.Location = new System.Drawing.Point(6, 5);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(250, 20);
            this.pathTxt.TabIndex = 1;
            // 
            // unpackBtn
            // 
            this.unpackBtn.Location = new System.Drawing.Point(171, 31);
            this.unpackBtn.Name = "unpackBtn";
            this.unpackBtn.Size = new System.Drawing.Size(187, 23);
            this.unpackBtn.TabIndex = 2;
            this.unpackBtn.Text = "Unpack archive";
            this.unpackBtn.UseVisualStyleBackColor = true;
            this.unpackBtn.Click += new System.EventHandler(this.unpackBtn_Click);
            // 
            // renameCb
            // 
            this.renameCb.AutoSize = true;
            this.renameCb.Location = new System.Drawing.Point(6, 35);
            this.renameCb.Name = "renameCb";
            this.renameCb.Size = new System.Drawing.Size(159, 17);
            this.renameCb.TabIndex = 3;
            this.renameCb.Text = "rename IBF-file after unpack";
            this.renameCb.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(196, 104);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(191, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/ucorpor/ibf-unpack";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.unpackPage);
            this.tabControl1.Controls.Add(this.makePage);
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(375, 89);
            this.tabControl1.TabIndex = 5;
            // 
            // unpackPage
            // 
            this.unpackPage.Controls.Add(this.renameCb);
            this.unpackPage.Controls.Add(this.pathBtn);
            this.unpackPage.Controls.Add(this.pathTxt);
            this.unpackPage.Controls.Add(this.unpackBtn);
            this.unpackPage.Location = new System.Drawing.Point(4, 22);
            this.unpackPage.Name = "unpackPage";
            this.unpackPage.Padding = new System.Windows.Forms.Padding(3);
            this.unpackPage.Size = new System.Drawing.Size(367, 63);
            this.unpackPage.TabIndex = 0;
            this.unpackPage.Text = "Unpack";
            this.unpackPage.UseVisualStyleBackColor = true;
            // 
            // makePage
            // 
            this.makePage.Controls.Add(this.makeBtn);
            this.makePage.Location = new System.Drawing.Point(4, 22);
            this.makePage.Name = "makePage";
            this.makePage.Padding = new System.Windows.Forms.Padding(3);
            this.makePage.Size = new System.Drawing.Size(367, 63);
            this.makePage.TabIndex = 1;
            this.makePage.Text = "Make";
            this.makePage.UseVisualStyleBackColor = true;
            // 
            // makeBtn
            // 
            this.makeBtn.Location = new System.Drawing.Point(6, 6);
            this.makeBtn.Name = "makeBtn";
            this.makeBtn.Size = new System.Drawing.Size(355, 51);
            this.makeBtn.TabIndex = 0;
            this.makeBtn.Text = "Make archive...";
            this.makeBtn.UseVisualStyleBackColor = true;
            this.makeBtn.Click += new System.EventHandler(this.makeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 128);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ibf-unpack";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.unpackPage.ResumeLayout(false);
            this.unpackPage.PerformLayout();
            this.makePage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pathBtn;
        private System.Windows.Forms.TextBox pathTxt;
        private System.Windows.Forms.Button unpackBtn;
        private System.Windows.Forms.CheckBox renameCb;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage unpackPage;
        private System.Windows.Forms.TabPage makePage;
        private System.Windows.Forms.Button makeBtn;
    }
}


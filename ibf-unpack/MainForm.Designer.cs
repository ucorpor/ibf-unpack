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
            this.b1Rb = new System.Windows.Forms.RadioButton();
            this.consoleRb = new System.Windows.Forms.RadioButton();
            this.b2Rb = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.unpackPage.SuspendLayout();
            this.makePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathBtn
            // 
            this.pathBtn.Location = new System.Drawing.Point(251, 3);
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
            this.pathTxt.Size = new System.Drawing.Size(231, 20);
            this.pathTxt.TabIndex = 1;
            // 
            // unpackBtn
            // 
            this.unpackBtn.Location = new System.Drawing.Point(165, 55);
            this.unpackBtn.Name = "unpackBtn";
            this.unpackBtn.Size = new System.Drawing.Size(182, 21);
            this.unpackBtn.TabIndex = 2;
            this.unpackBtn.Text = "Unpack archive";
            this.unpackBtn.UseVisualStyleBackColor = true;
            this.unpackBtn.Click += new System.EventHandler(this.unpackBtn_Click);
            // 
            // renameCb
            // 
            this.renameCb.AutoSize = true;
            this.renameCb.Location = new System.Drawing.Point(3, 33);
            this.renameCb.Name = "renameCb";
            this.renameCb.Size = new System.Drawing.Size(159, 17);
            this.renameCb.TabIndex = 3;
            this.renameCb.Text = "rename IBF-file after unpack";
            this.renameCb.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(181, 133);
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
            this.tabControl1.Size = new System.Drawing.Size(361, 118);
            this.tabControl1.TabIndex = 5;
            // 
            // unpackPage
            // 
            this.unpackPage.Controls.Add(this.b2Rb);
            this.unpackPage.Controls.Add(this.consoleRb);
            this.unpackPage.Controls.Add(this.renameCb);
            this.unpackPage.Controls.Add(this.b1Rb);
            this.unpackPage.Controls.Add(this.pathBtn);
            this.unpackPage.Controls.Add(this.pathTxt);
            this.unpackPage.Controls.Add(this.unpackBtn);
            this.unpackPage.Location = new System.Drawing.Point(4, 22);
            this.unpackPage.Name = "unpackPage";
            this.unpackPage.Padding = new System.Windows.Forms.Padding(3);
            this.unpackPage.Size = new System.Drawing.Size(353, 92);
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
            this.makePage.Size = new System.Drawing.Size(353, 92);
            this.makePage.TabIndex = 1;
            this.makePage.Text = "Make";
            this.makePage.UseVisualStyleBackColor = true;
            // 
            // makeBtn
            // 
            this.makeBtn.Location = new System.Drawing.Point(6, 6);
            this.makeBtn.Name = "makeBtn";
            this.makeBtn.Size = new System.Drawing.Size(341, 80);
            this.makeBtn.TabIndex = 0;
            this.makeBtn.Text = "Make archive...\r\n(PC version only)";
            this.makeBtn.UseVisualStyleBackColor = true;
            this.makeBtn.Click += new System.EventHandler(this.makeBtn_Click);
            // 
            // b1Rb
            // 
            this.b1Rb.AutoSize = true;
            this.b1Rb.Checked = true;
            this.b1Rb.Location = new System.Drawing.Point(165, 32);
            this.b1Rb.Name = "b1Rb";
            this.b1Rb.Size = new System.Drawing.Size(76, 17);
            this.b1Rb.TabIndex = 4;
            this.b1Rb.TabStop = true;
            this.b1Rb.Text = "PC version";
            this.b1Rb.UseVisualStyleBackColor = true;
            // 
            // consoleRb
            // 
            this.consoleRb.AutoSize = true;
            this.consoleRb.Location = new System.Drawing.Point(247, 32);
            this.consoleRb.Name = "consoleRb";
            this.consoleRb.Size = new System.Drawing.Size(100, 17);
            this.consoleRb.TabIndex = 5;
            this.consoleRb.Text = "Console version";
            this.consoleRb.UseVisualStyleBackColor = true;
            // 
            // b2Rb
            // 
            this.b2Rb.AutoSize = true;
            this.b2Rb.Location = new System.Drawing.Point(3, 57);
            this.b2Rb.Name = "b2Rb";
            this.b2Rb.Size = new System.Drawing.Size(81, 17);
            this.b2Rb.TabIndex = 6;
            this.b2Rb.Text = "Bioshock 2 ";
            this.b2Rb.UseVisualStyleBackColor = true;
            this.b2Rb.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 155);
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
        private System.Windows.Forms.RadioButton b1Rb;
        private System.Windows.Forms.RadioButton b2Rb;
        private System.Windows.Forms.RadioButton consoleRb;
    }
}


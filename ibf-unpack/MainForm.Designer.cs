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
            this.SuspendLayout();
            // 
            // pathBtn
            // 
            this.pathBtn.Location = new System.Drawing.Point(268, 12);
            this.pathBtn.Name = "pathBtn";
            this.pathBtn.Size = new System.Drawing.Size(96, 23);
            this.pathBtn.TabIndex = 0;
            this.pathBtn.Text = "Choose IBF-file...";
            this.pathBtn.UseVisualStyleBackColor = true;
            this.pathBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // pathTxt
            // 
            this.pathTxt.Location = new System.Drawing.Point(12, 12);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(250, 20);
            this.pathTxt.TabIndex = 1;
            // 
            // unpackBtn
            // 
            this.unpackBtn.Location = new System.Drawing.Point(177, 38);
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
            this.renameCb.Location = new System.Drawing.Point(12, 42);
            this.renameCb.Name = "renameCb";
            this.renameCb.Size = new System.Drawing.Size(159, 17);
            this.renameCb.TabIndex = 3;
            this.renameCb.Text = "rename IBF-file after unpack";
            this.renameCb.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(174, 64);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(191, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/ucorpor/ibf-unpack";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 80);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.renameCb);
            this.Controls.Add(this.unpackBtn);
            this.Controls.Add(this.pathTxt);
            this.Controls.Add(this.pathBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ibf-unpack";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pathBtn;
        private System.Windows.Forms.TextBox pathTxt;
        private System.Windows.Forms.Button unpackBtn;
        private System.Windows.Forms.CheckBox renameCb;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


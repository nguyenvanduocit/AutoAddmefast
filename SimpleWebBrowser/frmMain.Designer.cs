namespace SimpleWebBrowser
{
    partial class frmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnGetPoint = new System.Windows.Forms.Button();
            this.btnOpenLink = new System.Windows.Forms.Button();
            this.btnGetLinkList = new System.Windows.Forms.Button();
            this.btnLoginAddmefast = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.wbAddmefast = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbxAddmefast = new System.Windows.Forms.RichTextBox();
            this.prsAddmefast = new System.Windows.Forms.ProgressBar();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnLoginFacebook = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.wbFacebook = new System.Windows.Forms.WebBrowser();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.prsFacebook = new System.Windows.Forms.ProgressBar();
            this.btnCheckBef = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnUpdateAction = new System.Windows.Forms.Button();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 544);
            this.splitContainer1.SplitterDistance = 36;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1.Controls.Add(this.prsAddmefast);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Panel2.Controls.Add(this.prsFacebook);
            this.splitContainer2.Size = new System.Drawing.Size(1143, 504);
            this.splitContainer2.SplitterDistance = 953;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnUpdateAction);
            this.splitContainer3.Panel1.Controls.Add(this.btnCheckBef);
            this.splitContainer3.Panel1.Controls.Add(this.btnConfirm);
            this.splitContainer3.Panel1.Controls.Add(this.btnGetPoint);
            this.splitContainer3.Panel1.Controls.Add(this.btnOpenLink);
            this.splitContainer3.Panel1.Controls.Add(this.btnGetLinkList);
            this.splitContainer3.Panel1.Controls.Add(this.btnLoginAddmefast);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer3.Size = new System.Drawing.Size(953, 456);
            this.splitContainer3.SplitterDistance = 30;
            this.splitContainer3.TabIndex = 4;
            // 
            // btnGetPoint
            // 
            this.btnGetPoint.Location = new System.Drawing.Point(464, 3);
            this.btnGetPoint.Name = "btnGetPoint";
            this.btnGetPoint.Size = new System.Drawing.Size(110, 25);
            this.btnGetPoint.TabIndex = 7;
            this.btnGetPoint.Text = "Get point";
            this.btnGetPoint.UseVisualStyleBackColor = true;
            this.btnGetPoint.Click += new System.EventHandler(this.btnGetPoint_Click);
            // 
            // btnOpenLink
            // 
            this.btnOpenLink.Location = new System.Drawing.Point(201, 3);
            this.btnOpenLink.Name = "btnOpenLink";
            this.btnOpenLink.Size = new System.Drawing.Size(65, 25);
            this.btnOpenLink.TabIndex = 6;
            this.btnOpenLink.Text = "Open link";
            this.btnOpenLink.UseVisualStyleBackColor = true;
            this.btnOpenLink.Click += new System.EventHandler(this.btnOpenLink_Click);
            // 
            // btnGetLinkList
            // 
            this.btnGetLinkList.Location = new System.Drawing.Point(57, 3);
            this.btnGetLinkList.Name = "btnGetLinkList";
            this.btnGetLinkList.Size = new System.Drawing.Size(65, 25);
            this.btnGetLinkList.TabIndex = 5;
            this.btnGetLinkList.Text = "Get link";
            this.btnGetLinkList.UseVisualStyleBackColor = true;
            this.btnGetLinkList.Click += new System.EventHandler(this.btnGetLinkList_Click);
            // 
            // btnLoginAddmefast
            // 
            this.btnLoginAddmefast.Location = new System.Drawing.Point(3, 3);
            this.btnLoginAddmefast.Name = "btnLoginAddmefast";
            this.btnLoginAddmefast.Size = new System.Drawing.Size(48, 25);
            this.btnLoginAddmefast.TabIndex = 4;
            this.btnLoginAddmefast.Text = "login";
            this.btnLoginAddmefast.UseVisualStyleBackColor = true;
            this.btnLoginAddmefast.Click += new System.EventHandler(this.btnLoginAddmefast_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(953, 422);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.wbAddmefast);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(945, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // wbAddmefast
            // 
            this.wbAddmefast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbAddmefast.Location = new System.Drawing.Point(3, 3);
            this.wbAddmefast.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.wbAddmefast.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbAddmefast.Name = "wbAddmefast";
            this.wbAddmefast.ScriptErrorsSuppressed = true;
            this.wbAddmefast.Size = new System.Drawing.Size(939, 390);
            this.wbAddmefast.TabIndex = 5;
            this.wbAddmefast.Url = new System.Uri("", System.UriKind.Relative);
            this.wbAddmefast.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbAddmefast_DocumentCompleted);
            this.wbAddmefast.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.wbAddmefast_ProgressChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtbxAddmefast);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(422, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtbxAddmefast
            // 
            this.rtbxAddmefast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbxAddmefast.Location = new System.Drawing.Point(3, 3);
            this.rtbxAddmefast.Name = "rtbxAddmefast";
            this.rtbxAddmefast.Size = new System.Drawing.Size(416, 354);
            this.rtbxAddmefast.TabIndex = 5;
            this.rtbxAddmefast.Text = "";
            // 
            // prsAddmefast
            // 
            this.prsAddmefast.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prsAddmefast.Location = new System.Drawing.Point(0, 456);
            this.prsAddmefast.Name = "prsAddmefast";
            this.prsAddmefast.Size = new System.Drawing.Size(953, 48);
            this.prsAddmefast.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prsAddmefast.TabIndex = 2;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.btnLoginFacebook);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer4.Size = new System.Drawing.Size(186, 456);
            this.splitContainer4.SplitterDistance = 29;
            this.splitContainer4.TabIndex = 4;
            // 
            // btnLoginFacebook
            // 
            this.btnLoginFacebook.Location = new System.Drawing.Point(28, 3);
            this.btnLoginFacebook.Name = "btnLoginFacebook";
            this.btnLoginFacebook.Size = new System.Drawing.Size(114, 25);
            this.btnLoginFacebook.TabIndex = 3;
            this.btnLoginFacebook.Text = "login facebook";
            this.btnLoginFacebook.UseVisualStyleBackColor = true;
            this.btnLoginFacebook.Click += new System.EventHandler(this.btnLoginFacebook_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(186, 423);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.wbFacebook);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(178, 397);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // wbFacebook
            // 
            this.wbFacebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbFacebook.Location = new System.Drawing.Point(3, 3);
            this.wbFacebook.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.wbFacebook.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbFacebook.Name = "wbFacebook";
            this.wbFacebook.ScriptErrorsSuppressed = true;
            this.wbFacebook.Size = new System.Drawing.Size(172, 391);
            this.wbFacebook.TabIndex = 1;
            this.wbFacebook.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(412, 361);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // prsFacebook
            // 
            this.prsFacebook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prsFacebook.Location = new System.Drawing.Point(0, 456);
            this.prsFacebook.Name = "prsFacebook";
            this.prsFacebook.Size = new System.Drawing.Size(186, 48);
            this.prsFacebook.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prsFacebook.TabIndex = 3;
            // 
            // btnCheckBef
            // 
            this.btnCheckBef.Location = new System.Drawing.Point(128, 2);
            this.btnCheckBef.Name = "btnCheckBef";
            this.btnCheckBef.Size = new System.Drawing.Size(65, 25);
            this.btnCheckBef.TabIndex = 9;
            this.btnCheckBef.Text = "Check bef";
            this.btnCheckBef.UseVisualStyleBackColor = true;
            this.btnCheckBef.Click += new System.EventHandler(this.btnCheckBef_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(272, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 25);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnUpdateAction
            // 
            this.btnUpdateAction.Location = new System.Drawing.Point(343, 3);
            this.btnUpdateAction.Name = "btnUpdateAction";
            this.btnUpdateAction.Size = new System.Drawing.Size(94, 25);
            this.btnUpdateAction.TabIndex = 10;
            this.btnUpdateAction.Text = "Update action";
            this.btnUpdateAction.UseVisualStyleBackColor = true;
            this.btnUpdateAction.Click += new System.EventHandler(this.btnUpdateAction_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 544);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLoginFacebook;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ProgressBar prsAddmefast;
        private System.Windows.Forms.ProgressBar prsFacebook;
        private System.Windows.Forms.Button btnLoginAddmefast;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button btnGetLinkList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser wbAddmefast;
        private System.Windows.Forms.RichTextBox rtbxAddmefast;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser wbFacebook;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnOpenLink;
        private System.Windows.Forms.Button btnGetPoint;
        private System.Windows.Forms.Button btnCheckBef;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnUpdateAction;
    }
}


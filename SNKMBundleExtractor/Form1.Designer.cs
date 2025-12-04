namespace SNKMBundleExtractor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPatchBundle = new System.Windows.Forms.TextBox();
            this.textBoxDLCBundle = new System.Windows.Forms.TextBox();
            this.textBoxMainBundle = new System.Windows.Forms.TextBox();
            this.labelPatchBundle = new System.Windows.Forms.Label();
            this.labelDLCBundle = new System.Windows.Forms.Label();
            this.labelMainBundle = new System.Windows.Forms.Label();
            this.buttonOpenPListFile = new System.Windows.Forms.Button();
            this.textBoxPListFile = new System.Windows.Forms.TextBox();
            this.labelPListFile = new System.Windows.Forms.Label();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.buttonExtractTo = new System.Windows.Forms.Button();
            this.labelExtractTo = new System.Windows.Forms.Label();
            this.textBoxExtractTo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.parseToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // parseToolStripMenuItem
            // 
            this.parseToolStripMenuItem.Name = "parseToolStripMenuItem";
            this.parseToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.parseToolStripMenuItem.Text = "&Extract";
            this.parseToolStripMenuItem.Click += new System.EventHandler(this.ExtractToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(106, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(104, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPatchBundle);
            this.groupBox1.Controls.Add(this.textBoxDLCBundle);
            this.groupBox1.Controls.Add(this.textBoxMainBundle);
            this.groupBox1.Controls.Add(this.labelPatchBundle);
            this.groupBox1.Controls.Add(this.labelDLCBundle);
            this.groupBox1.Controls.Add(this.labelMainBundle);
            this.groupBox1.Controls.Add(this.buttonOpenPListFile);
            this.groupBox1.Controls.Add(this.textBoxPListFile);
            this.groupBox1.Controls.Add(this.labelPListFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBoxPatchBundle
            // 
            this.textBoxPatchBundle.Location = new System.Drawing.Point(89, 93);
            this.textBoxPatchBundle.Name = "textBoxPatchBundle";
            this.textBoxPatchBundle.Size = new System.Drawing.Size(600, 20);
            this.textBoxPatchBundle.TabIndex = 13;
            // 
            // textBoxDLCBundle
            // 
            this.textBoxDLCBundle.Location = new System.Drawing.Point(89, 65);
            this.textBoxDLCBundle.Name = "textBoxDLCBundle";
            this.textBoxDLCBundle.Size = new System.Drawing.Size(600, 20);
            this.textBoxDLCBundle.TabIndex = 12;
            // 
            // textBoxMainBundle
            // 
            this.textBoxMainBundle.Location = new System.Drawing.Point(89, 39);
            this.textBoxMainBundle.Name = "textBoxMainBundle";
            this.textBoxMainBundle.Size = new System.Drawing.Size(600, 20);
            this.textBoxMainBundle.TabIndex = 11;
            // 
            // labelPatchBundle
            // 
            this.labelPatchBundle.AutoSize = true;
            this.labelPatchBundle.Location = new System.Drawing.Point(6, 96);
            this.labelPatchBundle.Name = "labelPatchBundle";
            this.labelPatchBundle.Size = new System.Drawing.Size(74, 13);
            this.labelPatchBundle.TabIndex = 10;
            this.labelPatchBundle.Text = "Patch Bundle:";
            // 
            // labelDLCBundle
            // 
            this.labelDLCBundle.AutoSize = true;
            this.labelDLCBundle.Location = new System.Drawing.Point(6, 68);
            this.labelDLCBundle.Name = "labelDLCBundle";
            this.labelDLCBundle.Size = new System.Drawing.Size(67, 13);
            this.labelDLCBundle.TabIndex = 9;
            this.labelDLCBundle.Text = "DLC Bundle:";
            // 
            // labelMainBundle
            // 
            this.labelMainBundle.AutoSize = true;
            this.labelMainBundle.Location = new System.Drawing.Point(6, 42);
            this.labelMainBundle.Name = "labelMainBundle";
            this.labelMainBundle.Size = new System.Drawing.Size(69, 13);
            this.labelMainBundle.TabIndex = 8;
            this.labelMainBundle.Text = "Main Bundle:";
            // 
            // buttonOpenPListFile
            // 
            this.buttonOpenPListFile.Location = new System.Drawing.Point(695, 11);
            this.buttonOpenPListFile.Name = "buttonOpenPListFile";
            this.buttonOpenPListFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenPListFile.TabIndex = 4;
            this.buttonOpenPListFile.Text = "&Open";
            this.buttonOpenPListFile.UseVisualStyleBackColor = true;
            this.buttonOpenPListFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // textBoxPListFile
            // 
            this.textBoxPListFile.Location = new System.Drawing.Point(89, 13);
            this.textBoxPListFile.Name = "textBoxPListFile";
            this.textBoxPListFile.Size = new System.Drawing.Size(600, 20);
            this.textBoxPListFile.TabIndex = 1;
            // 
            // labelPListFile
            // 
            this.labelPListFile.AutoSize = true;
            this.labelPListFile.Location = new System.Drawing.Point(6, 16);
            this.labelPListFile.Name = "labelPListFile";
            this.labelPListFile.Size = new System.Drawing.Size(52, 13);
            this.labelPListFile.TabIndex = 0;
            this.labelPListFile.Text = "PList File:";
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(695, 39);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(75, 23);
            this.buttonExtract.TabIndex = 6;
            this.buttonExtract.Text = "&Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.ButtonExtract_Click);
            // 
            // buttonExtractTo
            // 
            this.buttonExtractTo.Location = new System.Drawing.Point(695, 10);
            this.buttonExtractTo.Name = "buttonExtractTo";
            this.buttonExtractTo.Size = new System.Drawing.Size(75, 23);
            this.buttonExtractTo.TabIndex = 5;
            this.buttonExtractTo.Text = "...";
            this.buttonExtractTo.UseVisualStyleBackColor = true;
            this.buttonExtractTo.Click += new System.EventHandler(this.ButtonExtractTo_Click);
            // 
            // labelExtractTo
            // 
            this.labelExtractTo.AutoSize = true;
            this.labelExtractTo.Location = new System.Drawing.Point(6, 15);
            this.labelExtractTo.Name = "labelExtractTo";
            this.labelExtractTo.Size = new System.Drawing.Size(59, 13);
            this.labelExtractTo.TabIndex = 3;
            this.labelExtractTo.Text = "Extract To:";
            // 
            // textBoxExtractTo
            // 
            this.textBoxExtractTo.Location = new System.Drawing.Point(71, 12);
            this.textBoxExtractTo.Name = "textBoxExtractTo";
            this.textBoxExtractTo.Size = new System.Drawing.Size(618, 20);
            this.textBoxExtractTo.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonExtractTo);
            this.groupBox2.Controls.Add(this.buttonExtract);
            this.groupBox2.Controls.Add(this.labelExtractTo);
            this.groupBox2.Controls.Add(this.textBoxExtractTo);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 68);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxLog);
            this.groupBox3.Location = new System.Drawing.Point(12, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 206);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(9, 10);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(761, 190);
            this.textBoxLog.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SNK 40th Anniversary Collection MBundle Extractor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelExtractTo;
        private System.Windows.Forms.TextBox textBoxExtractTo;
        private System.Windows.Forms.TextBox textBoxPListFile;
        private System.Windows.Forms.Label labelPListFile;
        private System.Windows.Forms.Button buttonExtractTo;
        private System.Windows.Forms.Button buttonOpenPListFile;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.ToolStripMenuItem parseToolStripMenuItem;
        private System.Windows.Forms.Label labelPatchBundle;
        private System.Windows.Forms.Label labelDLCBundle;
        private System.Windows.Forms.Label labelMainBundle;
        private System.Windows.Forms.TextBox textBoxPatchBundle;
        private System.Windows.Forms.TextBox textBoxDLCBundle;
        private System.Windows.Forms.TextBox textBoxMainBundle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxLog;
    }
}


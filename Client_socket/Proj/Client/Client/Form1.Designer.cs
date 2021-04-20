namespace Client
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.iptext = new System.Windows.Forms.TextBox();
            this.porttext = new System.Windows.Forms.TextBox();
            this.msgtext = new System.Windows.Forms.TextBox();
            this.outputtext = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.onbut = new System.Windows.Forms.Button();
            this.offbut = new System.Windows.Forms.Button();
            this.comtext = new System.Windows.Forms.TextBox();
            this.com = new System.Windows.Forms.Label();
            this.feedtext = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(688, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // iptext
            // 
            this.iptext.Location = new System.Drawing.Point(133, 54);
            this.iptext.Name = "iptext";
            this.iptext.Size = new System.Drawing.Size(322, 20);
            this.iptext.TabIndex = 1;
            // 
            // porttext
            // 
            this.porttext.Location = new System.Drawing.Point(552, 54);
            this.porttext.Name = "porttext";
            this.porttext.Size = new System.Drawing.Size(109, 20);
            this.porttext.TabIndex = 2;
            // 
            // msgtext
            // 
            this.msgtext.Location = new System.Drawing.Point(133, 95);
            this.msgtext.Name = "msgtext";
            this.msgtext.Size = new System.Drawing.Size(528, 20);
            this.msgtext.TabIndex = 3;
            // 
            // outputtext
            // 
            this.outputtext.ForeColor = System.Drawing.Color.Black;
            this.outputtext.FormattingEnabled = true;
            this.outputtext.Items.AddRange(new object[] {
            "OUTPUT :"});
            this.outputtext.Location = new System.Drawing.Point(23, 189);
            this.outputtext.Name = "outputtext";
            this.outputtext.Size = new System.Drawing.Size(638, 225);
            this.outputtext.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP / Hostname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Modes -";
            // 
            // onbut
            // 
            this.onbut.Location = new System.Drawing.Point(134, 153);
            this.onbut.Name = "onbut";
            this.onbut.Size = new System.Drawing.Size(75, 23);
            this.onbut.TabIndex = 12;
            this.onbut.Text = "ON";
            this.onbut.UseVisualStyleBackColor = true;
            this.onbut.Click += new System.EventHandler(this.onbut_Click);
            // 
            // offbut
            // 
            this.offbut.Location = new System.Drawing.Point(215, 153);
            this.offbut.Name = "offbut";
            this.offbut.Size = new System.Drawing.Size(75, 23);
            this.offbut.TabIndex = 13;
            this.offbut.Text = "OFF";
            this.offbut.UseVisualStyleBackColor = true;
            this.offbut.Click += new System.EventHandler(this.offbut_Click);
            // 
            // comtext
            // 
            this.comtext.Location = new System.Drawing.Point(461, 153);
            this.comtext.Name = "comtext";
            this.comtext.Size = new System.Drawing.Size(200, 20);
            this.comtext.TabIndex = 14;
            // 
            // com
            // 
            this.com.AutoSize = true;
            this.com.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com.Location = new System.Drawing.Point(375, 156);
            this.com.Name = "com";
            this.com.Size = new System.Drawing.Size(80, 17);
            this.com.TabIndex = 15;
            this.com.Text = "Command -";
            // 
            // feedtext
            // 
            this.feedtext.ForeColor = System.Drawing.Color.Black;
            this.feedtext.FormattingEnabled = true;
            this.feedtext.Items.AddRange(new object[] {
            "FEEDBACK :"});
            this.feedtext.Location = new System.Drawing.Point(23, 426);
            this.feedtext.Name = "feedtext";
            this.feedtext.Size = new System.Drawing.Size(638, 160);
            this.feedtext.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 610);
            this.Controls.Add(this.feedtext);
            this.Controls.Add(this.com);
            this.Controls.Add(this.comtext);
            this.Controls.Add(this.offbut);
            this.Controls.Add(this.onbut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputtext);
            this.Controls.Add(this.msgtext);
            this.Controls.Add(this.porttext);
            this.Controls.Add(this.iptext);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ED_Miniproject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TextBox iptext;
        private System.Windows.Forms.TextBox porttext;
        private System.Windows.Forms.TextBox msgtext;
        private System.Windows.Forms.ListBox outputtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button onbut;
        private System.Windows.Forms.Button offbut;
        private System.Windows.Forms.TextBox comtext;
        private System.Windows.Forms.Label com;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ListBox feedtext;
    }
}


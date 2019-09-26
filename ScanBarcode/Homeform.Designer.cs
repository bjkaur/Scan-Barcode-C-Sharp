namespace ScanBarcode
{
    partial class Homeform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homeform));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maxBtn = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.footerLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.helpBtn = new ScanBarcode.RoundButton();
            this.aboutBtn = new ScanBarcode.RoundButton();
            this.getBarcodeform = new ScanBarcode.RoundButton();
            this.create = new ScanBarcode.RoundButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(243, 81);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.maxBtn);
            this.panel2.Controls.Add(this.exitbutton);
            this.panel2.Controls.Add(this.minimizebtn);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(12, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1339, 123);
            this.panel2.TabIndex = 47;
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.BackColor = System.Drawing.Color.White;
            this.maxBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.maxBtn.FlatAppearance.BorderSize = 0;
            this.maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.maxBtn.Location = new System.Drawing.Point(1275, 59);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(26, 39);
            this.maxBtn.TabIndex = 37;
            this.maxBtn.Text = "▯";
            this.maxBtn.UseVisualStyleBackColor = false;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbutton.BackColor = System.Drawing.Color.White;
            this.exitbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.DarkRed;
            this.exitbutton.Location = new System.Drawing.Point(1305, 58);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(26, 39);
            this.exitbutton.TabIndex = 36;
            this.exitbutton.Text = "X";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // minimizebtn
            // 
            this.minimizebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizebtn.BackColor = System.Drawing.Color.White;
            this.minimizebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.minimizebtn.FlatAppearance.BorderSize = 0;
            this.minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizebtn.ForeColor = System.Drawing.Color.DarkRed;
            this.minimizebtn.Location = new System.Drawing.Point(1243, 56);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(26, 39);
            this.minimizebtn.TabIndex = 36;
            this.minimizebtn.Text = "_";
            this.minimizebtn.UseVisualStyleBackColor = false;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.helpBtn);
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.getBarcodeform);
            this.panel1.Controls.Add(this.create);
            this.panel1.Location = new System.Drawing.Point(223, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 512);
            this.panel1.TabIndex = 54;
            // 
            // footerLbl
            // 
            this.footerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footerLbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.footerLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.footerLbl.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.footerLbl.Location = new System.Drawing.Point(14, 19);
            this.footerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.footerLbl.Name = "footerLbl";
            this.footerLbl.Size = new System.Drawing.Size(676, 20);
            this.footerLbl.TabIndex = 12;
            this.footerLbl.Text = "WMG, International Manufacturing Centre, University of Warwick, Coventry, CV4 7AL" +
    ", United Kingdom";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel2.BackgroundImage")));
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1114, 9);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(217, 91);
            this.flowLayoutPanel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Controls.Add(this.footerLbl);
            this.panel3.Location = new System.Drawing.Point(12, 761);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1339, 110);
            this.panel3.TabIndex = 51;
            // 
            // helpBtn
            // 
            this.helpBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.helpBtn.Location = new System.Drawing.Point(711, 3);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(167, 152);
            this.helpBtn.TabIndex = 58;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = true;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aboutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.aboutBtn.Location = new System.Drawing.Point(698, 338);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(167, 152);
            this.aboutBtn.TabIndex = 55;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // getBarcodeform
            // 
            this.getBarcodeform.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getBarcodeform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getBarcodeform.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getBarcodeform.ForeColor = System.Drawing.SystemColors.Highlight;
            this.getBarcodeform.Location = new System.Drawing.Point(33, 3);
            this.getBarcodeform.Name = "getBarcodeform";
            this.getBarcodeform.Size = new System.Drawing.Size(167, 152);
            this.getBarcodeform.TabIndex = 57;
            this.getBarcodeform.Text = "Get Barcode";
            this.getBarcodeform.UseVisualStyleBackColor = true;
            this.getBarcodeform.Click += new System.EventHandler(this.getBarcodeform_Click);
            // 
            // create
            // 
            this.create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.SystemColors.Highlight;
            this.create.Location = new System.Drawing.Point(22, 338);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(167, 152);
            this.create.TabIndex = 56;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Homeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1363, 881);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homeform";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.Homeform_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Homeform_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Homeform_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Homeform_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.Panel panel1;
        private RoundButton helpBtn;
        private RoundButton aboutBtn;
        private RoundButton getBarcodeform;
        private RoundButton create;
        private System.Windows.Forms.Label footerLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
    }
}
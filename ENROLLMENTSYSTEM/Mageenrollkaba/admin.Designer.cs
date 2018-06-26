namespace Mageenrollkaba
{
    partial class admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.label2 = new System.Windows.Forms.Label();
            this.bsba = new System.Windows.Forms.Button();
            this.bshrm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bsit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(947, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADMIN DASHBOARD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bsba
            // 
            this.bsba.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bsba.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bsba.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsba.Location = new System.Drawing.Point(306, 46);
            this.bsba.Name = "bsba";
            this.bsba.Size = new System.Drawing.Size(105, 29);
            this.bsba.TabIndex = 6;
            this.bsba.Text = "BSBA";
            this.bsba.UseVisualStyleBackColor = false;
            this.bsba.Click += new System.EventHandler(this.bsba_Click);
            // 
            // bshrm
            // 
            this.bshrm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bshrm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bshrm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bshrm.Location = new System.Drawing.Point(417, 46);
            this.bshrm.Name = "bshrm";
            this.bshrm.Size = new System.Drawing.Size(103, 29);
            this.bshrm.TabIndex = 7;
            this.bshrm.Text = "BSHRM";
            this.bshrm.UseVisualStyleBackColor = false;
            this.bshrm.Click += new System.EventHandler(this.bshrm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(32, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 540);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-34, -38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(986, 616);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // bsit
            // 
            this.bsit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bsit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bsit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsit.Location = new System.Drawing.Point(528, 46);
            this.bsit.Name = "bsit";
            this.bsit.Size = new System.Drawing.Size(101, 29);
            this.bsit.TabIndex = 8;
            this.bsit.Text = "BSIT";
            this.bsit.UseVisualStyleBackColor = false;
            this.bsit.Click += new System.EventHandler(this.bsit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.bsit);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.bshrm);
            this.groupBox1.Controls.Add(this.bsba);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 675);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "admin";
            this.Size = new System.Drawing.Size(953, 744);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bsba;
        private System.Windows.Forms.Button bshrm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bsit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;



    }
}

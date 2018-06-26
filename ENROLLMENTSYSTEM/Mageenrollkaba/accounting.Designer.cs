namespace Mageenrollkaba
{
    partial class accounting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accounting));
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.DGVPrint = new System.Windows.Forms.DataGridView();
            this.INSERT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.calculate = new System.Windows.Forms.Button();
            this.promo = new System.Windows.Forms.ComboBox();
            this.code = new System.Windows.Forms.ComboBox();
            this.dbsearch = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.ComboBox();
            this.course = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.fees = new System.Windows.Forms.TextBox();
            this.tuition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BROWSE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.NEW = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dsort = new System.Windows.Forms.Button();
            this.asort = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPrint)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Enter Value To Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 36;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(380, 14);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(115, 44);
            this.delete.TabIndex = 35;
            this.delete.Text = "DELETE";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.WhiteSmoke;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(259, 14);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(115, 44);
            this.update.TabIndex = 34;
            this.update.Text = "UPDATE";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // DGVPrint
            // 
            this.DGVPrint.AllowUserToAddRows = false;
            this.DGVPrint.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DGVPrint.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPrint.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPrint.GridColor = System.Drawing.Color.LightGray;
            this.DGVPrint.Location = new System.Drawing.Point(17, 391);
            this.DGVPrint.Name = "DGVPrint";
            this.DGVPrint.RowHeadersVisible = false;
            this.DGVPrint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPrint.Size = new System.Drawing.Size(946, 183);
            this.DGVPrint.TabIndex = 33;
            this.DGVPrint.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGVPrint.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // INSERT
            // 
            this.INSERT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.INSERT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.INSERT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSERT.Location = new System.Drawing.Point(139, 15);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(114, 42);
            this.INSERT.TabIndex = 32;
            this.INSERT.Text = "SAVE";
            this.INSERT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.INSERT.UseVisualStyleBackColor = false;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.BROWSE);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(17, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 311);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.calculate);
            this.groupBox3.Controls.Add(this.promo);
            this.groupBox3.Controls.Add(this.code);
            this.groupBox3.Controls.Add(this.dbsearch);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.sec);
            this.groupBox3.Controls.Add(this.course);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.date);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.id);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.name);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.total);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.payment);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.year);
            this.groupBox3.Controls.Add(this.fees);
            this.groupBox3.Controls.Add(this.tuition);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 296);
            this.groupBox3.TabIndex = 95;
            this.groupBox3.TabStop = false;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(370, 193);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(173, 23);
            this.calculate.TabIndex = 119;
            this.calculate.Text = "CALCULATE";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // promo
            // 
            this.promo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.promo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.promo.FormattingEnabled = true;
            this.promo.Location = new System.Drawing.Point(370, 91);
            this.promo.Name = "promo";
            this.promo.Size = new System.Drawing.Size(173, 21);
            this.promo.TabIndex = 118;
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.code.FormattingEnabled = true;
            this.code.Location = new System.Drawing.Point(370, 63);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(173, 21);
            this.code.TabIndex = 117;
            // 
            // dbsearch
            // 
            this.dbsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbsearch.FormattingEnabled = true;
            this.dbsearch.Items.AddRange(new object[] {
            "BSIT",
            "BSBA",
            "HRM",
            "ACCOUNTING"});
            this.dbsearch.Location = new System.Drawing.Point(483, 269);
            this.dbsearch.Name = "dbsearch";
            this.dbsearch.Size = new System.Drawing.Size(96, 21);
            this.dbsearch.TabIndex = 68;
            this.dbsearch.SelectedIndexChanged += new System.EventHandler(this.dbsearch_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(46, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(339, 46);
            this.label15.TabIndex = 116;
            this.label15.Text = "Student Tuition fees";
            // 
            // sec
            // 
            this.sec.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sec.FormattingEnabled = true;
            this.sec.Location = new System.Drawing.Point(91, 143);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(173, 21);
            this.sec.TabIndex = 115;
            // 
            // course
            // 
            this.course.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course.FormattingEnabled = true;
            this.course.Location = new System.Drawing.Point(91, 115);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(173, 21);
            this.course.TabIndex = 114;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(91, 220);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(173, 20);
            this.date.TabIndex = 113;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(28, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 111;
            this.label11.Text = "Date:";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.id.Location = new System.Drawing.Point(91, 64);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(173, 20);
            this.id.TabIndex = 92;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(316, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 110;
            this.label12.Text = "Total:";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.name.Location = new System.Drawing.Point(91, 90);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(173, 20);
            this.name.TabIndex = 93;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(316, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 109;
            this.label13.Text = "Payment:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Name:";
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.total.Location = new System.Drawing.Point(370, 168);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(173, 20);
            this.total.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(28, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 96;
            this.label3.Text = "Couse:";
            // 
            // payment
            // 
            this.payment.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.payment.Location = new System.Drawing.Point(370, 142);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(173, 20);
            this.payment.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(316, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 106;
            this.label8.Text = "Fees:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(316, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 105;
            this.label9.Text = "Promo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(316, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 104;
            this.label10.Text = "Code:";
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.year.Location = new System.Drawing.Point(91, 168);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(173, 20);
            this.year.TabIndex = 98;
            // 
            // fees
            // 
            this.fees.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fees.Location = new System.Drawing.Point(370, 116);
            this.fees.Name = "fees";
            this.fees.Size = new System.Drawing.Size(173, 20);
            this.fees.TabIndex = 103;
            // 
            // tuition
            // 
            this.tuition.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tuition.Location = new System.Drawing.Point(91, 194);
            this.tuition.Name = "tuition";
            this.tuition.Size = new System.Drawing.Size(173, 20);
            this.tuition.TabIndex = 99;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(28, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Section:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(28, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 101;
            this.label6.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(28, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Tuition:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Red;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(701, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 17);
            this.label14.TabIndex = 94;
            this.label14.Text = "Insert receipt here...\r\n";
            // 
            // BROWSE
            // 
            this.BROWSE.Location = new System.Drawing.Point(844, 5);
            this.BROWSE.Name = "BROWSE";
            this.BROWSE.Size = new System.Drawing.Size(55, 24);
            this.BROWSE.TabIndex = 93;
            this.BROWSE.Text = "Browse";
            this.BROWSE.UseVisualStyleBackColor = true;
            this.BROWSE.Click += new System.EventHandler(this.BROWSE_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(614, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(23, 27);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 72;
            this.pictureBox5.TabStop = false;
            // 
            // NEW
            // 
            this.NEW.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NEW.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEW.Location = new System.Drawing.Point(18, 15);
            this.NEW.Name = "NEW";
            this.NEW.Size = new System.Drawing.Size(115, 42);
            this.NEW.TabIndex = 66;
            this.NEW.Text = "ADD NEW";
            this.NEW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NEW.UseVisualStyleBackColor = false;
            this.NEW.Click += new System.EventHandler(this.NEW_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dsort);
            this.groupBox2.Controls.Add(this.asort);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.INSERT);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.print);
            this.groupBox2.Controls.Add(this.update);
            this.groupBox2.Controls.Add(this.NEW);
            this.groupBox2.Location = new System.Drawing.Point(17, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(946, 60);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dsort
            // 
            this.dsort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dsort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dsort.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsort.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.dsort.Location = new System.Drawing.Point(825, 12);
            this.dsort.Name = "dsort";
            this.dsort.Size = new System.Drawing.Size(115, 44);
            this.dsort.TabIndex = 122;
            this.dsort.Text = "D SORT";
            this.dsort.UseVisualStyleBackColor = false;
            this.dsort.Click += new System.EventHandler(this.dsort_Click);
            // 
            // asort
            // 
            this.asort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.asort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.asort.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asort.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.asort.Location = new System.Drawing.Point(704, 14);
            this.asort.Name = "asort";
            this.asort.Size = new System.Drawing.Size(115, 44);
            this.asort.TabIndex = 121;
            this.asort.Text = "A SORT";
            this.asort.UseVisualStyleBackColor = false;
            this.asort.Click += new System.EventHandler(this.asort_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(148, 19);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(52, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 120;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(259, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 71;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(392, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 70;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(517, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.WhiteSmoke;
            this.print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.print.Location = new System.Drawing.Point(501, 14);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(115, 44);
            this.print.TabIndex = 67;
            this.print.Text = "PRINT";
            this.print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.button2_Click);
            // 
            // accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVPrint);
            this.DoubleBuffered = true;
            this.Name = "accounting";
            this.Size = new System.Drawing.Size(966, 577);
            this.Load += new System.EventHandler(this.accounting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPrint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView DGVPrint;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NEW;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.ComboBox dbsearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BROWSE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox promo;
        private System.Windows.Forms.ComboBox code;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox sec;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox payment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox fees;
        private System.Windows.Forms.TextBox tuition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button dsort;
        private System.Windows.Forms.Button asort;
    }
}

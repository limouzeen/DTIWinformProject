namespace DTIWinformProject
{
    partial class FrmSAURegister
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
            this.mcdRegis = new System.Windows.Forms.MonthCalendar();
            this.lsSubjectRegis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNoRegis = new System.Windows.Forms.TextBox();
            this.tbNameRegis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdFundRegis = new System.Windows.Forms.RadioButton();
            this.rdNormalRegis = new System.Windows.Forms.RadioButton();
            this.btSelectImageRegis = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btSelectSub = new System.Windows.Forms.Button();
            this.btSelectAllSub = new System.Windows.Forms.Button();
            this.btUnSelectSub = new System.Windows.Forms.Button();
            this.btUnSelectAllSub = new System.Windows.Forms.Button();
            this.cbbLevelRegis = new System.Windows.Forms.ComboBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btRegis = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.lsbSubjectedRegis = new System.Windows.Forms.ListBox();
            this.cbConfirmRegis = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbImageRegis = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageRegis)).BeginInit();
            this.SuspendLayout();
            // 
            // mcdRegis
            // 
            this.mcdRegis.Location = new System.Drawing.Point(80, 169);
            this.mcdRegis.Name = "mcdRegis";
            this.mcdRegis.TabIndex = 0;
            // 
            // lsSubjectRegis
            // 
            this.lsSubjectRegis.FormattingEnabled = true;
            this.lsSubjectRegis.ItemHeight = 16;
            this.lsSubjectRegis.Items.AddRange(new object[] {
            "ภาษาไทย",
            "ภาษาอังกฤษ",
            "ภาษาญี่ปุ่น",
            "ภาษาจีน",
            "สังคมศึกษา",
            "คณิตศาสตร์ ",
            "พละศีกษา",
            "ประวัติศาสตร์",
            "คอมพิวเตอร์เบื้องต้น",
            "บัญชีเบื้องต้น",
            "กฏหมายเบื้องต้น",
            "เศรษฐศาสตร์เบื้องต้น",
            "หลักการบริหาร",
            "เคมี",
            "ชีววิทยา"});
            this.lsSubjectRegis.Location = new System.Drawing.Point(81, 473);
            this.lsSubjectRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsSubjectRegis.Name = "lsSubjectRegis";
            this.lsSubjectRegis.Size = new System.Drawing.Size(165, 132);
            this.lsSubjectRegis.TabIndex = 1;
            this.lsSubjectRegis.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(75, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 73);
            this.label1.TabIndex = 10;
            this.label1.Text = "ลงทะเบียนเรียน";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.CausesValidation = false;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(77, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "วันที่ลงทะเบียนเรียน";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "เลขประจำตัวนักเรียน";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbNoRegis
            // 
            this.tbNoRegis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNoRegis.Location = new System.Drawing.Point(424, 169);
            this.tbNoRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNoRegis.Name = "tbNoRegis";
            this.tbNoRegis.Size = new System.Drawing.Size(166, 22);
            this.tbNoRegis.TabIndex = 30;
            // 
            // tbNameRegis
            // 
            this.tbNameRegis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNameRegis.Location = new System.Drawing.Point(424, 247);
            this.tbNameRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNameRegis.Name = "tbNameRegis";
            this.tbNameRegis.Size = new System.Drawing.Size(166, 22);
            this.tbNameRegis.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "ชื่อ-สกุล";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "ประเภทนักเรียน";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rdFundRegis
            // 
            this.rdFundRegis.AutoSize = true;
            this.rdFundRegis.Location = new System.Drawing.Point(524, 335);
            this.rdFundRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdFundRegis.Name = "rdFundRegis";
            this.rdFundRegis.Size = new System.Drawing.Size(67, 20);
            this.rdFundRegis.TabIndex = 35;
            this.rdFundRegis.Text = "กองทุนฯ";
            this.rdFundRegis.UseVisualStyleBackColor = true;
            // 
            // rdNormalRegis
            // 
            this.rdNormalRegis.AutoSize = true;
            this.rdNormalRegis.Checked = true;
            this.rdNormalRegis.Location = new System.Drawing.Point(425, 334);
            this.rdNormalRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNormalRegis.Name = "rdNormalRegis";
            this.rdNormalRegis.Size = new System.Drawing.Size(48, 20);
            this.rdNormalRegis.TabIndex = 34;
            this.rdNormalRegis.TabStop = true;
            this.rdNormalRegis.Text = "ปกติ";
            this.rdNormalRegis.UseVisualStyleBackColor = true;
            // 
            // btSelectImageRegis
            // 
            this.btSelectImageRegis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelectImageRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectImageRegis.Location = new System.Drawing.Point(880, 367);
            this.btSelectImageRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSelectImageRegis.Name = "btSelectImageRegis";
            this.btSelectImageRegis.Size = new System.Drawing.Size(35, 31);
            this.btSelectImageRegis.TabIndex = 36;
            this.btSelectImageRegis.Text = "...";
            this.btSelectImageRegis.UseVisualStyleBackColor = true;
            this.btSelectImageRegis.Click += new System.EventHandler(this.btSelectImageRegis_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 641);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(985, 31);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslbUsername
            // 
            this.tslbUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslbUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslbUsername.Name = "tslbUsername";
            this.tslbUsername.Size = new System.Drawing.Size(54, 22);
            this.tslbUsername.Text = "name?";
            // 
            // tslbDateTime
            // 
            this.tslbDateTime.Name = "tslbDateTime";
            this.tslbDateTime.Size = new System.Drawing.Size(76, 22);
            this.tslbDateTime.Text = "datetime?";
            // 
            // label5
            // 
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "ระดับชั้น";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "รายวิชาที่ลงทะเบียน";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btSelectSub
            // 
            this.btSelectSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btSelectSub.Location = new System.Drawing.Point(275, 473);
            this.btSelectSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSelectSub.Name = "btSelectSub";
            this.btSelectSub.Size = new System.Drawing.Size(75, 30);
            this.btSelectSub.TabIndex = 40;
            this.btSelectSub.Text = ">";
            this.btSelectSub.UseVisualStyleBackColor = true;
            this.btSelectSub.Click += new System.EventHandler(this.btSelectSub_Click);
            // 
            // btSelectAllSub
            // 
            this.btSelectAllSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectAllSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btSelectAllSub.Location = new System.Drawing.Point(275, 508);
            this.btSelectAllSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSelectAllSub.Name = "btSelectAllSub";
            this.btSelectAllSub.Size = new System.Drawing.Size(75, 30);
            this.btSelectAllSub.TabIndex = 41;
            this.btSelectAllSub.Text = ">>";
            this.btSelectAllSub.UseVisualStyleBackColor = true;
            this.btSelectAllSub.Click += new System.EventHandler(this.btSelectAllSub_Click);
            // 
            // btUnSelectSub
            // 
            this.btUnSelectSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUnSelectSub.ForeColor = System.Drawing.Color.Red;
            this.btUnSelectSub.Location = new System.Drawing.Point(275, 545);
            this.btUnSelectSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUnSelectSub.Name = "btUnSelectSub";
            this.btUnSelectSub.Size = new System.Drawing.Size(75, 30);
            this.btUnSelectSub.TabIndex = 42;
            this.btUnSelectSub.Text = "<";
            this.btUnSelectSub.UseVisualStyleBackColor = true;
            this.btUnSelectSub.Click += new System.EventHandler(this.btUnSelectSub_Click);
            // 
            // btUnSelectAllSub
            // 
            this.btUnSelectAllSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUnSelectAllSub.ForeColor = System.Drawing.Color.Red;
            this.btUnSelectAllSub.Location = new System.Drawing.Point(275, 581);
            this.btUnSelectAllSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUnSelectAllSub.Name = "btUnSelectAllSub";
            this.btUnSelectAllSub.Size = new System.Drawing.Size(75, 30);
            this.btUnSelectAllSub.TabIndex = 43;
            this.btUnSelectAllSub.Text = "<<";
            this.btUnSelectAllSub.UseVisualStyleBackColor = true;
            this.btUnSelectAllSub.Click += new System.EventHandler(this.btUnSelectAllSub_Click);
            // 
            // cbbLevelRegis
            // 
            this.cbbLevelRegis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLevelRegis.FormattingEnabled = true;
            this.cbbLevelRegis.Items.AddRange(new object[] {
            "ชั้นมัธยมศึกษาปีที่ 1",
            "ชั้นมัธยมศึกษาปีที่ 2",
            "ชั้นมัธยมศึกษาปีที่ 3",
            "ชั้นมัธยมศึกษาปีที่ 4",
            "ชั้นมัธยมศึกษาปีที่ 5",
            "ชั้นมัธยมศึกษาปีที่ 6"});
            this.cbbLevelRegis.Location = new System.Drawing.Point(81, 400);
            this.cbbLevelRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLevelRegis.Name = "cbbLevelRegis";
            this.cbbLevelRegis.Size = new System.Drawing.Size(217, 24);
            this.cbbLevelRegis.TabIndex = 44;
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btExit.Image = global::DTIWinformProject.Properties.Resources.exit31;
            this.btExit.Location = new System.Drawing.Point(572, 555);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btExit.Size = new System.Drawing.Size(347, 48);
            this.btExit.TabIndex = 48;
            this.btExit.Text = "ปิดโปรแกรม";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btRegis
            // 
            this.btRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btRegis.Image = global::DTIWinformProject.Properties.Resources.add;
            this.btRegis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRegis.Location = new System.Drawing.Point(743, 439);
            this.btRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRegis.Name = "btRegis";
            this.btRegis.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btRegis.Size = new System.Drawing.Size(176, 48);
            this.btRegis.TabIndex = 47;
            this.btRegis.Text = "ลงทะเบียน";
            this.btRegis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRegis.UseVisualStyleBackColor = true;
            this.btRegis.Click += new System.EventHandler(this.btRegis_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btCancel.Location = new System.Drawing.Point(572, 500);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btCancel.Size = new System.Drawing.Size(347, 48);
            this.btCancel.TabIndex = 46;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btMainMenu
            // 
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(781, 34);
            this.btMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(133, 73);
            this.btMainMenu.TabIndex = 11;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // lsbSubjectedRegis
            // 
            this.lsbSubjectedRegis.FormattingEnabled = true;
            this.lsbSubjectedRegis.ItemHeight = 16;
            this.lsbSubjectedRegis.Location = new System.Drawing.Point(379, 473);
            this.lsbSubjectedRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbSubjectedRegis.Name = "lsbSubjectedRegis";
            this.lsbSubjectedRegis.Size = new System.Drawing.Size(165, 132);
            this.lsbSubjectedRegis.TabIndex = 49;
            // 
            // cbConfirmRegis
            // 
            this.cbConfirmRegis.AutoSize = true;
            this.cbConfirmRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConfirmRegis.Location = new System.Drawing.Point(572, 462);
            this.cbConfirmRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbConfirmRegis.Name = "cbConfirmRegis";
            this.cbConfirmRegis.Size = new System.Drawing.Size(144, 22);
            this.cbConfirmRegis.TabIndex = 50;
            this.cbConfirmRegis.Text = "ยืนยันการลงทะเบียน";
            this.cbConfirmRegis.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbImageRegis
            // 
            this.pbImageRegis.Location = new System.Drawing.Point(647, 141);
            this.pbImageRegis.Name = "pbImageRegis";
            this.pbImageRegis.Size = new System.Drawing.Size(216, 257);
            this.pbImageRegis.TabIndex = 51;
            this.pbImageRegis.TabStop = false;
            // 
            // FrmSAURegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 672);
            this.Controls.Add(this.pbImageRegis);
            this.Controls.Add(this.cbConfirmRegis);
            this.Controls.Add(this.lsbSubjectedRegis);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRegis);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.cbbLevelRegis);
            this.Controls.Add(this.btUnSelectAllSub);
            this.Controls.Add(this.btUnSelectSub);
            this.Controls.Add(this.btSelectAllSub);
            this.Controls.Add(this.btSelectSub);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btSelectImageRegis);
            this.Controls.Add(this.rdFundRegis);
            this.Controls.Add(this.rdNormalRegis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNameRegis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNoRegis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mcdRegis);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsSubjectRegis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmSAURegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ลงทะเบียนเรียน - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmSAURegister_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageRegis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcdRegis;
        private System.Windows.Forms.ListBox lsSubjectRegis;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNoRegis;
        private System.Windows.Forms.TextBox tbNameRegis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdFundRegis;
        private System.Windows.Forms.RadioButton rdNormalRegis;
        private System.Windows.Forms.Button btSelectImageRegis;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSelectSub;
        private System.Windows.Forms.Button btSelectAllSub;
        private System.Windows.Forms.Button btUnSelectSub;
        private System.Windows.Forms.Button btUnSelectAllSub;
        private System.Windows.Forms.ComboBox cbbLevelRegis;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btRegis;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ListBox lsbSubjectedRegis;
        private System.Windows.Forms.CheckBox cbConfirmRegis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbImageRegis;
    }
}
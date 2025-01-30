namespace DTIWinformProject
{
    partial class FrmSAUShop
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPen = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCalculate = new System.Windows.Forms.Button();
            this.lbShowTotalPay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPen = new System.Windows.Forms.Label();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.lbPencil = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPencil = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbPencil = new System.Windows.Forms.CheckBox();
            this.lbRubber = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbRubber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbRubber = new System.Windows.Forms.CheckBox();
            this.lbRuler = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbRuler = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbRuler = new System.Windows.Forms.CheckBox();
            this.lbBook = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbBook = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbBook = new System.Windows.Forms.CheckBox();
            this.cbbSale = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "SAU Shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPen
            // 
            this.cbPen.AutoSize = true;
            this.cbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPen.Location = new System.Drawing.Point(63, 141);
            this.cbPen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPen.Name = "cbPen";
            this.cbPen.Size = new System.Drawing.Size(111, 19);
            this.cbPen.TabIndex = 11;
            this.cbPen.Text = "ปากกา 5 บาท/ด้าม";
            this.cbPen.UseVisualStyleBackColor = true;
            this.cbPen.Click += new System.EventHandler(this.cbPen_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 445);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(653, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslbUsername
            // 
            this.tslbUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslbUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslbUsername.Name = "tslbUsername";
            this.tslbUsername.Size = new System.Drawing.Size(43, 22);
            this.tslbUsername.Text = "name?";
            this.tslbUsername.Click += new System.EventHandler(this.tslbUsername_Click);
            // 
            // tslbDateTime
            // 
            this.tslbDateTime.Name = "tslbDateTime";
            this.tslbDateTime.Size = new System.Drawing.Size(59, 22);
            this.tslbDateTime.Text = "datetime?";
            this.tslbDateTime.Click += new System.EventHandler(this.tslbDateTime_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.btCalculate);
            this.groupBox1.Controls.Add(this.lbShowTotalPay);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(46, 351);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(540, 81);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btCancel
            // 
            this.btCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btCancel.Location = new System.Drawing.Point(442, 32);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(85, 32);
            this.btCancel.TabIndex = 34;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCalculate
            // 
            this.btCalculate.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btCalculate.Location = new System.Drawing.Point(346, 32);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(85, 32);
            this.btCalculate.TabIndex = 33;
            this.btCalculate.Text = "คำนวณ";
            this.btCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // lbShowTotalPay
            // 
            this.lbShowTotalPay.BackColor = System.Drawing.Color.Yellow;
            this.lbShowTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowTotalPay.ForeColor = System.Drawing.Color.Red;
            this.lbShowTotalPay.Location = new System.Drawing.Point(124, 27);
            this.lbShowTotalPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbShowTotalPay.Name = "lbShowTotalPay";
            this.lbShowTotalPay.Size = new System.Drawing.Size(165, 38);
            this.lbShowTotalPay.TabIndex = 33;
            this.lbShowTotalPay.Text = "0.00";
            this.lbShowTotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.CausesValidation = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "บาท";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "รวมเป็นเงินทั้งสิ้น";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "รายการสินค้า";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "จำนวน";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "คิดเป็นเงิน";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "ด้าม";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPen
            // 
            this.tbPen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPen.Location = new System.Drawing.Point(209, 141);
            this.tbPen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPen.MaxLength = 3;
            this.tbPen.Name = "tbPen";
            this.tbPen.Size = new System.Drawing.Size(88, 20);
            this.tbPen.TabIndex = 30;
            this.tbPen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbPen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPen_KeyPress);
            this.tbPen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPen_KeyUp);
            // 
            // label6
            // 
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "บาท";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPen
            // 
            this.lbPen.BackColor = System.Drawing.Color.Yellow;
            this.lbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPen.ForeColor = System.Drawing.Color.Red;
            this.lbPen.Location = new System.Drawing.Point(351, 140);
            this.lbPen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPen.Name = "lbPen";
            this.lbPen.Size = new System.Drawing.Size(106, 22);
            this.lbPen.TabIndex = 32;
            this.lbPen.Text = "0.00";
            this.lbPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btMainMenu
            // 
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(527, 30);
            this.btMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(100, 59);
            this.btMainMenu.TabIndex = 10;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // lbPencil
            // 
            this.lbPencil.BackColor = System.Drawing.Color.Yellow;
            this.lbPencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPencil.ForeColor = System.Drawing.Color.Red;
            this.lbPencil.Location = new System.Drawing.Point(351, 173);
            this.lbPencil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPencil.Name = "lbPencil";
            this.lbPencil.Size = new System.Drawing.Size(106, 22);
            this.lbPencil.TabIndex = 37;
            this.lbPencil.Text = "0.00";
            this.lbPencil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.CausesValidation = false;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(430, 174);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 19);
            this.label12.TabIndex = 36;
            this.label12.Text = "บาท";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPencil
            // 
            this.tbPencil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPencil.Location = new System.Drawing.Point(209, 175);
            this.tbPencil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPencil.MaxLength = 3;
            this.tbPencil.Name = "tbPencil";
            this.tbPencil.Size = new System.Drawing.Size(88, 20);
            this.tbPencil.TabIndex = 35;
            this.tbPencil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPencil_KeyPress);
            this.tbPencil.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPencil_KeyUp);
            // 
            // label13
            // 
            this.label13.CausesValidation = false;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(271, 173);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 19);
            this.label13.TabIndex = 34;
            this.label13.Text = "ด้าม";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPencil
            // 
            this.cbPencil.AutoSize = true;
            this.cbPencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPencil.Location = new System.Drawing.Point(63, 174);
            this.cbPencil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPencil.Name = "cbPencil";
            this.cbPencil.Size = new System.Drawing.Size(124, 19);
            this.cbPencil.TabIndex = 33;
            this.cbPencil.Text = "ดินสอ 1.50 บาท/ด้าม";
            this.cbPencil.UseVisualStyleBackColor = true;
            this.cbPencil.Click += new System.EventHandler(this.cbPencil_Click);
            // 
            // lbRubber
            // 
            this.lbRubber.BackColor = System.Drawing.Color.Yellow;
            this.lbRubber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRubber.ForeColor = System.Drawing.Color.Red;
            this.lbRubber.Location = new System.Drawing.Point(351, 205);
            this.lbRubber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRubber.Name = "lbRubber";
            this.lbRubber.Size = new System.Drawing.Size(106, 22);
            this.lbRubber.TabIndex = 42;
            this.lbRubber.Text = "0.00";
            this.lbRubber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.CausesValidation = false;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(430, 206);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 19);
            this.label15.TabIndex = 41;
            this.label15.Text = "บาท";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRubber
            // 
            this.tbRubber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRubber.Location = new System.Drawing.Point(209, 206);
            this.tbRubber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRubber.MaxLength = 3;
            this.tbRubber.Name = "tbRubber";
            this.tbRubber.Size = new System.Drawing.Size(88, 20);
            this.tbRubber.TabIndex = 40;
            this.tbRubber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRubber_KeyPress);
            this.tbRubber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRubber_KeyUp);
            // 
            // label16
            // 
            this.label16.CausesValidation = false;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(271, 205);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 19);
            this.label16.TabIndex = 39;
            this.label16.Text = "ด้าม";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbRubber
            // 
            this.cbRubber.AutoSize = true;
            this.cbRubber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRubber.Location = new System.Drawing.Point(63, 206);
            this.cbRubber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRubber.Name = "cbRubber";
            this.cbRubber.Size = new System.Drawing.Size(129, 19);
            this.cbRubber.TabIndex = 38;
            this.cbRubber.Text = "ยางลบ 2.50 บาท/ก้อน";
            this.cbRubber.UseVisualStyleBackColor = true;
            this.cbRubber.Click += new System.EventHandler(this.cbRubber_Click);
            // 
            // lbRuler
            // 
            this.lbRuler.BackColor = System.Drawing.Color.Yellow;
            this.lbRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuler.ForeColor = System.Drawing.Color.Red;
            this.lbRuler.Location = new System.Drawing.Point(351, 237);
            this.lbRuler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRuler.Name = "lbRuler";
            this.lbRuler.Size = new System.Drawing.Size(106, 22);
            this.lbRuler.TabIndex = 47;
            this.lbRuler.Text = "0.00";
            this.lbRuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.CausesValidation = false;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(430, 238);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 19);
            this.label18.TabIndex = 46;
            this.label18.Text = "บาท";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRuler
            // 
            this.tbRuler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRuler.Location = new System.Drawing.Point(209, 239);
            this.tbRuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRuler.MaxLength = 3;
            this.tbRuler.Name = "tbRuler";
            this.tbRuler.Size = new System.Drawing.Size(88, 20);
            this.tbRuler.TabIndex = 45;
            this.tbRuler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRuler_KeyPress);
            this.tbRuler.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRuler_KeyUp);
            // 
            // label19
            // 
            this.label19.CausesValidation = false;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(271, 237);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 19);
            this.label19.TabIndex = 44;
            this.label19.Text = "อัน";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbRuler
            // 
            this.cbRuler.AutoSize = true;
            this.cbRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRuler.Location = new System.Drawing.Point(63, 238);
            this.cbRuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRuler.Name = "cbRuler";
            this.cbRuler.Size = new System.Drawing.Size(121, 19);
            this.cbRuler.TabIndex = 43;
            this.cbRuler.Text = "ไม้บรรทัด 2 บาท/อัน";
            this.cbRuler.UseVisualStyleBackColor = true;
            this.cbRuler.Click += new System.EventHandler(this.cbRuler_Click);
            // 
            // lbBook
            // 
            this.lbBook.BackColor = System.Drawing.Color.Yellow;
            this.lbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBook.ForeColor = System.Drawing.Color.Red;
            this.lbBook.Location = new System.Drawing.Point(351, 272);
            this.lbBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBook.Name = "lbBook";
            this.lbBook.Size = new System.Drawing.Size(106, 22);
            this.lbBook.TabIndex = 52;
            this.lbBook.Text = "0.00";
            this.lbBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.CausesValidation = false;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(430, 273);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 19);
            this.label21.TabIndex = 51;
            this.label21.Text = "บาท";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBook
            // 
            this.tbBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBook.Location = new System.Drawing.Point(209, 274);
            this.tbBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBook.MaxLength = 3;
            this.tbBook.Name = "tbBook";
            this.tbBook.Size = new System.Drawing.Size(88, 20);
            this.tbBook.TabIndex = 50;
            this.tbBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBook_KeyPress);
            this.tbBook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBook_KeyUp);
            // 
            // label22
            // 
            this.label22.CausesValidation = false;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(271, 272);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 19);
            this.label22.TabIndex = 49;
            this.label22.Text = "เล่ม";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBook
            // 
            this.cbBook.AutoSize = true;
            this.cbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBook.Location = new System.Drawing.Point(63, 273);
            this.cbBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(123, 19);
            this.cbBook.TabIndex = 48;
            this.cbBook.Text = "สมุด 10.25 บาท/เล่ม";
            this.cbBook.UseVisualStyleBackColor = true;
            this.cbBook.Click += new System.EventHandler(this.cbBook_Click);
            // 
            // cbbSale
            // 
            this.cbbSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSale.FormattingEnabled = true;
            this.cbbSale.Items.AddRange(new object[] {
            "ส่วนลด 5%",
            "ส่วนลด 10%",
            "ส่วนลด 15%"});
            this.cbbSale.Location = new System.Drawing.Point(208, 310);
            this.cbbSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbSale.Name = "cbbSale";
            this.cbbSale.Size = new System.Drawing.Size(92, 21);
            this.cbbSale.TabIndex = 53;
            // 
            // label23
            // 
            this.label23.CausesValidation = false;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(88, 310);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 19);
            this.label23.TabIndex = 54;
            this.label23.Text = "ส่วนลด";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSAUShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 470);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cbbSale);
            this.Controls.Add(this.lbBook);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tbBook);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cbBook);
            this.Controls.Add(this.lbRuler);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbRuler);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbRuler);
            this.Controls.Add(this.lbRubber);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbRubber);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbRubber);
            this.Controls.Add(this.lbPencil);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbPencil);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbPencil);
            this.Controls.Add(this.lbPen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cbPen);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmSAUShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSAUShop";
            this.Load += new System.EventHandler(this.FrmSAUShop_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.CheckBox cbPen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbShowTotalPay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label lbPencil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPencil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbPencil;
        private System.Windows.Forms.Label lbRubber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbRubber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbRubber;
        private System.Windows.Forms.Label lbRuler;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbRuler;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox cbRuler;
        private System.Windows.Forms.Label lbBook;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbBook;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox cbBook;
        private System.Windows.Forms.ComboBox cbbSale;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Timer timer1;
    }
}
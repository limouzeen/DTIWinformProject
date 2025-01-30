namespace DTIWinformProject
{
    partial class FrmShapeArea
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdCircleArea = new System.Windows.Forms.RadioButton();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.rdCircleRound = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCircleShow = new System.Windows.Forms.Label();
            this.btCircleCancel = new System.Windows.Forms.Button();
            this.btCircleCal = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdRectArea = new System.Windows.Forms.RadioButton();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.rdRectRound = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbRectShow = new System.Windows.Forms.Label();
            this.btRectCancel = new System.Windows.Forms.Button();
            this.btRectCal = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbSideAngle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rdTriArea = new System.Windows.Forms.RadioButton();
            this.tbBase = new System.Windows.Forms.TextBox();
            this.rdTriRound = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTriShow = new System.Windows.Forms.Label();
            this.btTriCancel = new System.Windows.Forms.Button();
            this.btTriCal = new System.Windows.Forms.Button();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(40, 115);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 324);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rdCircleArea);
            this.tabPage1.Controls.Add(this.tbRadius);
            this.tabPage1.Controls.Add(this.rdCircleRound);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lbCircleShow);
            this.tabPage1.Controls.Add(this.btCircleCancel);
            this.tabPage1.Controls.Add(this.btCircleCal);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(589, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "วงกลม";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rdCircleArea
            // 
            this.rdCircleArea.AutoSize = true;
            this.rdCircleArea.Checked = true;
            this.rdCircleArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCircleArea.Location = new System.Drawing.Point(50, 110);
            this.rdCircleArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdCircleArea.Name = "rdCircleArea";
            this.rdCircleArea.Size = new System.Drawing.Size(100, 22);
            this.rdCircleArea.TabIndex = 33;
            this.rdCircleArea.TabStop = true;
            this.rdCircleArea.Text = "พื้นที่ทรงกลม";
            this.rdCircleArea.UseVisualStyleBackColor = true;
            // 
            // tbRadius
            // 
            this.tbRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRadius.Location = new System.Drawing.Point(50, 66);
            this.tbRadius.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(313, 22);
            this.tbRadius.TabIndex = 40;
            this.tbRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRadius_KeyPress);
            this.tbRadius.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRadius_KeyUp);
            // 
            // rdCircleRound
            // 
            this.rdCircleRound.AutoSize = true;
            this.rdCircleRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCircleRound.Location = new System.Drawing.Point(50, 145);
            this.rdCircleRound.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdCircleRound.Name = "rdCircleRound";
            this.rdCircleRound.Size = new System.Drawing.Size(108, 22);
            this.rdCircleRound.TabIndex = 32;
            this.rdCircleRound.Text = "เส้นรอบวงกลม";
            this.rdCircleRound.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "ป้อนรัศมี";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "ผลลัพธ์";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCircleShow
            // 
            this.lbCircleShow.BackColor = System.Drawing.Color.Yellow;
            this.lbCircleShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCircleShow.ForeColor = System.Drawing.Color.Red;
            this.lbCircleShow.Location = new System.Drawing.Point(51, 228);
            this.lbCircleShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCircleShow.Name = "lbCircleShow";
            this.lbCircleShow.Size = new System.Drawing.Size(307, 35);
            this.lbCircleShow.TabIndex = 37;
            this.lbCircleShow.Text = "0.00";
            this.lbCircleShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCircleCancel
            // 
            this.btCircleCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btCircleCancel.Location = new System.Drawing.Point(412, 158);
            this.btCircleCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCircleCancel.Name = "btCircleCancel";
            this.btCircleCancel.Size = new System.Drawing.Size(97, 43);
            this.btCircleCancel.TabIndex = 36;
            this.btCircleCancel.Text = "ยกเลิก";
            this.btCircleCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCircleCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCircleCancel.UseVisualStyleBackColor = true;
            this.btCircleCancel.Click += new System.EventHandler(this.btCircleCancel_Click);
            // 
            // btCircleCal
            // 
            this.btCircleCal.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btCircleCal.Location = new System.Drawing.Point(412, 99);
            this.btCircleCal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCircleCal.Name = "btCircleCal";
            this.btCircleCal.Size = new System.Drawing.Size(97, 43);
            this.btCircleCal.TabIndex = 35;
            this.btCircleCal.Text = "คำนวณ";
            this.btCircleCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCircleCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCircleCal.UseVisualStyleBackColor = true;
            this.btCircleCal.Click += new System.EventHandler(this.btCircleCal_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbLength);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.rdRectArea);
            this.tabPage2.Controls.Add(this.tbWidth);
            this.tabPage2.Controls.Add(this.rdRectRound);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lbRectShow);
            this.tabPage2.Controls.Add(this.btRectCancel);
            this.tabPage2.Controls.Add(this.btRectCal);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(589, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "สี่เหลี่ยม";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbLength
            // 
            this.tbLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLength.Location = new System.Drawing.Point(245, 67);
            this.tbLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(139, 22);
            this.tbLength.TabIndex = 60;
            this.tbLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLength_KeyPress);
            // 
            // label3
            // 
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "ป้อนยาว";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdRectArea
            // 
            this.rdRectArea.AutoSize = true;
            this.rdRectArea.Checked = true;
            this.rdRectArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRectArea.Location = new System.Drawing.Point(76, 111);
            this.rdRectArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdRectArea.Name = "rdRectArea";
            this.rdRectArea.Size = new System.Drawing.Size(99, 22);
            this.rdRectArea.TabIndex = 52;
            this.rdRectArea.TabStop = true;
            this.rdRectArea.Text = "พื้นที่สี่เหลี่ยม";
            this.rdRectArea.UseVisualStyleBackColor = true;
            // 
            // tbWidth
            // 
            this.tbWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWidth.Location = new System.Drawing.Point(76, 67);
            this.tbWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(139, 22);
            this.tbWidth.TabIndex = 58;
            this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWidth_KeyPress);
            // 
            // rdRectRound
            // 
            this.rdRectRound.AutoSize = true;
            this.rdRectRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRectRound.Location = new System.Drawing.Point(76, 146);
            this.rdRectRound.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdRectRound.Name = "rdRectRound";
            this.rdRectRound.Size = new System.Drawing.Size(116, 22);
            this.rdRectRound.TabIndex = 51;
            this.rdRectRound.Text = "เส้นรอบสี่เหลี่ยม";
            this.rdRectRound.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 57;
            this.label5.Text = "ป้อนกว้าง";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "ผลลัพธ์";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRectShow
            // 
            this.lbRectShow.BackColor = System.Drawing.Color.Yellow;
            this.lbRectShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRectShow.ForeColor = System.Drawing.Color.Red;
            this.lbRectShow.Location = new System.Drawing.Point(77, 229);
            this.lbRectShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRectShow.Name = "lbRectShow";
            this.lbRectShow.Size = new System.Drawing.Size(307, 35);
            this.lbRectShow.TabIndex = 55;
            this.lbRectShow.Text = "0.00";
            this.lbRectShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRectCancel
            // 
            this.btRectCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btRectCancel.Location = new System.Drawing.Point(438, 159);
            this.btRectCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRectCancel.Name = "btRectCancel";
            this.btRectCancel.Size = new System.Drawing.Size(97, 43);
            this.btRectCancel.TabIndex = 54;
            this.btRectCancel.Text = "ยกเลิก";
            this.btRectCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRectCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRectCancel.UseVisualStyleBackColor = true;
            // 
            // btRectCal
            // 
            this.btRectCal.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btRectCal.Location = new System.Drawing.Point(438, 100);
            this.btRectCal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRectCal.Name = "btRectCal";
            this.btRectCal.Size = new System.Drawing.Size(97, 43);
            this.btRectCal.TabIndex = 53;
            this.btRectCal.Text = "คำนวณ";
            this.btRectCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRectCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRectCal.UseVisualStyleBackColor = true;
            this.btRectCal.Click += new System.EventHandler(this.btRectCal_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbSideAngle);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.tbHeight);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.rdTriArea);
            this.tabPage3.Controls.Add(this.tbBase);
            this.tabPage3.Controls.Add(this.rdTriRound);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.lbTriShow);
            this.tabPage3.Controls.Add(this.btTriCancel);
            this.tabPage3.Controls.Add(this.btTriCal);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(589, 298);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "สามเหลี่ยมมุมฉาก";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbSideAngle
            // 
            this.tbSideAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSideAngle.Location = new System.Drawing.Point(403, 67);
            this.tbSideAngle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSideAngle.Name = "tbSideAngle";
            this.tbSideAngle.Size = new System.Drawing.Size(142, 22);
            this.tbSideAngle.TabIndex = 52;
            this.tbSideAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSideAngle_KeyPress);
            // 
            // label13
            // 
            this.label13.CausesValidation = false;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(388, 35);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 19);
            this.label13.TabIndex = 51;
            this.label13.Text = "ป้อนด้านตรงข้ามมุมฉาก";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHeight
            // 
            this.tbHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHeight.Location = new System.Drawing.Point(236, 67);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(142, 22);
            this.tbHeight.TabIndex = 50;
            this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHeight_KeyPress);
            // 
            // label11
            // 
            this.label11.CausesValidation = false;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(219, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 19);
            this.label11.TabIndex = 49;
            this.label11.Text = "ป้อนสูง";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdTriArea
            // 
            this.rdTriArea.AutoSize = true;
            this.rdTriArea.Checked = true;
            this.rdTriArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTriArea.Location = new System.Drawing.Point(76, 111);
            this.rdTriArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdTriArea.Name = "rdTriArea";
            this.rdTriArea.Size = new System.Drawing.Size(114, 22);
            this.rdTriArea.TabIndex = 42;
            this.rdTriArea.TabStop = true;
            this.rdTriArea.Text = "พื้นที่สามเหลี่ยม";
            this.rdTriArea.UseVisualStyleBackColor = true;
            // 
            // tbBase
            // 
            this.tbBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBase.Location = new System.Drawing.Point(69, 67);
            this.tbBase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(142, 22);
            this.tbBase.TabIndex = 48;
            this.tbBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBase_KeyPress);
            // 
            // rdTriRound
            // 
            this.rdTriRound.AutoSize = true;
            this.rdTriRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTriRound.Location = new System.Drawing.Point(76, 146);
            this.rdTriRound.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdTriRound.Name = "rdTriRound";
            this.rdTriRound.Size = new System.Drawing.Size(131, 22);
            this.rdTriRound.TabIndex = 41;
            this.rdTriRound.Text = "เส้นรอบสามเหลี่ยม";
            this.rdTriRound.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 47;
            this.label7.Text = "ป้อนฐาน";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "ผลลัพธ์";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTriShow
            // 
            this.lbTriShow.BackColor = System.Drawing.Color.Yellow;
            this.lbTriShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTriShow.ForeColor = System.Drawing.Color.Red;
            this.lbTriShow.Location = new System.Drawing.Point(77, 229);
            this.lbTriShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTriShow.Name = "lbTriShow";
            this.lbTriShow.Size = new System.Drawing.Size(307, 35);
            this.lbTriShow.TabIndex = 45;
            this.lbTriShow.Text = "0.00";
            this.lbTriShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btTriCancel
            // 
            this.btTriCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btTriCancel.Location = new System.Drawing.Point(438, 170);
            this.btTriCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTriCancel.Name = "btTriCancel";
            this.btTriCancel.Size = new System.Drawing.Size(97, 43);
            this.btTriCancel.TabIndex = 44;
            this.btTriCancel.Text = "ยกเลิก";
            this.btTriCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTriCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTriCancel.UseVisualStyleBackColor = true;
            this.btTriCancel.Click += new System.EventHandler(this.btTriCancel_Click);
            // 
            // btTriCal
            // 
            this.btTriCal.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btTriCal.Location = new System.Drawing.Point(438, 111);
            this.btTriCal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTriCal.Name = "btTriCal";
            this.btTriCal.Size = new System.Drawing.Size(97, 43);
            this.btTriCal.TabIndex = 43;
            this.btTriCal.Text = "คำนวณ";
            this.btTriCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTriCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTriCal.UseVisualStyleBackColor = true;
            this.btTriCal.Click += new System.EventHandler(this.btTriCal_Click);
            // 
            // btMainMenu
            // 
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(537, 36);
            this.btMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(100, 59);
            this.btMainMenu.TabIndex = 12;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 59);
            this.label1.TabIndex = 11;
            this.label1.Text = "คำนวณรูปทรง";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 455);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(675, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslbUsername
            // 
            this.tslbUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslbUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslbUsername.Name = "tslbUsername";
            this.tslbUsername.Size = new System.Drawing.Size(43, 22);
            this.tslbUsername.Text = "name?";
            // 
            // tslbDateTime
            // 
            this.tslbDateTime.Name = "tslbDateTime";
            this.tslbDateTime.Size = new System.Drawing.Size(59, 22);
            this.tslbDateTime.Text = "datetime?";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmShapeArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 480);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmShapeArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ผลการลงทะเบียน - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmShapeArea_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Button btCircleCancel;
        private System.Windows.Forms.Button btCircleCal;
        private System.Windows.Forms.Label lbCircleShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.RadioButton rdCircleArea;
        private System.Windows.Forms.RadioButton rdCircleRound;
        private System.Windows.Forms.RadioButton rdTriArea;
        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.RadioButton rdTriRound;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTriShow;
        private System.Windows.Forms.Button btTriCancel;
        private System.Windows.Forms.Button btTriCal;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdRectArea;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.RadioButton rdRectRound;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbRectShow;
        private System.Windows.Forms.Button btRectCancel;
        private System.Windows.Forms.Button btRectCal;
        private System.Windows.Forms.TextBox tbSideAngle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
    }
}
namespace DTIWinformProject
{
    partial class FrmCalculator
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
            this.btMainMenu = new System.Windows.Forms.Button();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btMultiply = new System.Windows.Forms.Button();
            this.btDevide = new System.Windows.Forms.Button();
            this.btPower = new System.Windows.Forms.Button();
            this.lbShowResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.cbbDecimal = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btMainMenu
            // 
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(590, 39);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(133, 73);
            this.btMainMenu.TabIndex = 10;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // tbNum1
            // 
            this.tbNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNum1.Location = new System.Drawing.Point(214, 147);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(284, 22);
            this.tbNum1.TabIndex = 16;
            this.tbNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum1_KeyPress);
            // 
            // label2
            // 
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "ป้อนตัวเลข";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbNum2
            // 
            this.tbNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNum2.Location = new System.Drawing.Point(214, 194);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(284, 22);
            this.tbNum2.TabIndex = 18;
            this.tbNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum2_KeyPress);
            // 
            // label3
            // 
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "ป้อนตัวเลข";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btPlus
            // 
            this.btPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlus.ForeColor = System.Drawing.Color.Blue;
            this.btPlus.Location = new System.Drawing.Point(65, 253);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(75, 67);
            this.btPlus.TabIndex = 19;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMinus
            // 
            this.btMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinus.ForeColor = System.Drawing.Color.Blue;
            this.btMinus.Location = new System.Drawing.Point(172, 253);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(75, 67);
            this.btMinus.TabIndex = 20;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btMultiply
            // 
            this.btMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiply.ForeColor = System.Drawing.Color.Blue;
            this.btMultiply.Location = new System.Drawing.Point(279, 253);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(75, 67);
            this.btMultiply.TabIndex = 21;
            this.btMultiply.Text = "x";
            this.btMultiply.UseVisualStyleBackColor = true;
            this.btMultiply.Click += new System.EventHandler(this.btMultiply_Click);
            // 
            // btDevide
            // 
            this.btDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDevide.ForeColor = System.Drawing.Color.Blue;
            this.btDevide.Location = new System.Drawing.Point(389, 253);
            this.btDevide.Name = "btDevide";
            this.btDevide.Size = new System.Drawing.Size(75, 67);
            this.btDevide.TabIndex = 22;
            this.btDevide.Text = "÷";
            this.btDevide.UseVisualStyleBackColor = true;
            this.btDevide.Click += new System.EventHandler(this.btDevide_Click);
            // 
            // btPower
            // 
            this.btPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPower.ForeColor = System.Drawing.Color.Blue;
            this.btPower.Location = new System.Drawing.Point(500, 253);
            this.btPower.Name = "btPower";
            this.btPower.Size = new System.Drawing.Size(75, 67);
            this.btPower.TabIndex = 23;
            this.btPower.Text = "^";
            this.btPower.UseVisualStyleBackColor = true;
            this.btPower.Click += new System.EventHandler(this.btPower_Click);
            // 
            // lbShowResult
            // 
            this.lbShowResult.BackColor = System.Drawing.Color.Yellow;
            this.lbShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowResult.ForeColor = System.Drawing.Color.Red;
            this.lbShowResult.Location = new System.Drawing.Point(181, 395);
            this.lbShowResult.Name = "lbShowResult";
            this.lbShowResult.Size = new System.Drawing.Size(353, 73);
            this.lbShowResult.TabIndex = 24;
            this.lbShowResult.Text = "?????";
            this.lbShowResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbShowResult.Click += new System.EventHandler(this.lbShowResult_Click);
            // 
            // label5
            // 
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "ผลลัพธ์";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 487);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslbUsername
            // 
            this.tslbUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslbUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslbUsername.Name = "tslbUsername";
            this.tslbUsername.Size = new System.Drawing.Size(55, 22);
            this.tslbUsername.Text = "name?";
            // 
            // tslbDateTime
            // 
            this.tslbDateTime.Name = "tslbDateTime";
            this.tslbDateTime.Size = new System.Drawing.Size(76, 22);
            this.tslbDateTime.Text = "datetime?";
            // 
            // cbbDecimal
            // 
            this.cbbDecimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDecimal.FormattingEnabled = true;
            this.cbbDecimal.Items.AddRange(new object[] {
            "ทศนิยม 2 ตำแหน่ง",
            "ทศนิยม 4 ตำแหน่ง",
            "ทศนิยม 8 ตำแหน่ง"});
            this.cbbDecimal.Location = new System.Drawing.Point(214, 346);
            this.cbbDecimal.Name = "cbbDecimal";
            this.cbbDecimal.Size = new System.Drawing.Size(284, 24);
            this.cbbDecimal.TabIndex = 27;
            this.cbbDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbDecimal_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.cbbDecimal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbShowResult);
            this.Controls.Add(this.btPower);
            this.Controls.Add(this.btDevide);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอเครื่องคิดเลข -  DTI soft v1.0";
            this.Load += new System.EventHandler(this.FrmCalculator_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.Button btDevide;
        private System.Windows.Forms.Button btPower;
        private System.Windows.Forms.Label lbShowResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.ComboBox cbbDecimal;
        private System.Windows.Forms.Timer timer1;
    }
}
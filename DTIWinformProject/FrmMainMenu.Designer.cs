namespace DTIWinformProject
{
    partial class FrmMainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(72, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "DTI Soft V.1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 552);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(888, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel1.Text = "name?";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(76, 22);
            this.toolStripLabel2.Text = "datetime?";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // button5
            // 
            this.button5.Image = global::DTIWinformProject.Properties.Resources.menu5;
            this.button5.Location = new System.Drawing.Point(77, 342);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 172);
            this.button5.TabIndex = 9;
            this.button5.Text = "Go to DooDung";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = global::DTIWinformProject.Properties.Resources.menu7;
            this.button6.Location = new System.Drawing.Point(277, 342);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 172);
            this.button6.TabIndex = 8;
            this.button6.Text = "Go to Shape Area";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Image = global::DTIWinformProject.Properties.Resources.menu6;
            this.button7.Location = new System.Drawing.Point(476, 342);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(148, 172);
            this.button7.TabIndex = 7;
            this.button7.Text = "Go to Register";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Image = global::DTIWinformProject.Properties.Resources.exitapp;
            this.button8.Location = new System.Drawing.Point(674, 342);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(148, 172);
            this.button8.TabIndex = 6;
            this.button8.Text = "ออกจากระบบ";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Image = global::DTIWinformProject.Properties.Resources.menu1;
            this.button4.Location = new System.Drawing.Point(77, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 172);
            this.button4.TabIndex = 5;
            this.button4.Text = "Go to Welcome";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::DTIWinformProject.Properties.Resources.menu2;
            this.button3.Location = new System.Drawing.Point(277, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 172);
            this.button3.TabIndex = 4;
            this.button3.Text = "Go to Calculator";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::DTIWinformProject.Properties.Resources.menu3;
            this.button2.Location = new System.Drawing.Point(476, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 172);
            this.button2.TabIndex = 3;
            this.button2.Text = "Go to SAU Shop";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::DTIWinformProject.Properties.Resources.menu4;
            this.button1.Location = new System.Drawing.Point(674, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 172);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go to Lotto";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 577);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอหลัก - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}
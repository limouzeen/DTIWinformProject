using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("ต้องการออกจากโปรแกรมหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
            rdStudent.Checked = true;
            tbUsername.Focus();
        }


        private void showWarningMSG(String msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Trim().Length == 0)
            {
                showWarningMSG("ป้อนชื่อผู้ใช้ด้วย");
            }else if (tbPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("ป้อนรหัสผ่านด้วย", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbPassword.Text.Trim().Length < 6)
            {
                MessageBox.Show("ป้อนรหัสผ่าน 6 ตัวขึ้นไป", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //check user login
                if((tbUsername.Text.Trim().ToLower() != "sau" || tbPassword.Text.Trim().ToLower() != "123456789") && (tbUsername.Text.Trim().ToLower() != "dti" || tbPassword.Text.Trim().ToLower() != "987654321"))
                {
                    showWarningMSG("ชื่อผู้ใช้รหัสผ่านไม่ถูกต้อง");
                }else{
                // ชื่อผู้ใช้รหัสผ่านถูกต้องเปิด  FrmMainMenu พร้อมส่งชื่อผู้ใช้ไปแสดงด้วย
                    FrmMainMenu frmMainMenu = new FrmMainMenu();
                    frmMainMenu.Show();

                    Hide();


                }
            }
        }
    }
}

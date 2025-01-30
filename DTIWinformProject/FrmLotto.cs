using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmLotto : Form
    {
        private Random random = new Random();
        public FrmLotto()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmLotto_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " ( " + ShareData.loginType + " ) ";
            timer1.Start();
            rdClose.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();

            Hide();
        }

        private void rdClose_Click(object sender, EventArgs e)
        {
            if (rdClose.Checked == true)
            {
                lbLotto1.Text = "??????";
                lbLotto3Top01.Text = "???";
                lbLotto3Top02.Text = "???";
                lbLotto3Bottom01.Text = "???";
                lbLotto3Bottom02.Text = "???";
                lbLotto2Bottom.Text = "??";

                btLotto1.Enabled = false;
                btLotto3Top.Enabled = false;
                btLotto3Bottom.Enabled = false;
                btLotto2Bottom.Enabled = false;

                dtpLotto.Value = DateTime.Now;
            }
        }

        private void rdOpen_Click(object sender, EventArgs e)
        {
            btLotto1.Enabled = true;
            btLotto3Top.Enabled = true;
            btLotto3Bottom.Enabled = true;
            btLotto2Bottom.Enabled = true;


        }

        private bool IsAllowedDrawDate()
        {
            int day = dtpLotto.Value.Day;
            return (day == 1 || day == 16);
        }

        private string GenerateRandomNumber(int length)
        {
            string result = "";
            for (int i = 0; i < length; i++)
            {
                result += random.Next(0, 10).ToString();
            }
            return result;
        }

        private void btLotto1_Click(object sender, EventArgs e)
        {
            if (IsAllowedDrawDate())
            {
                lbLotto1.Text = GenerateRandomNumber(6);
                btLotto1.Enabled = false;
            }
            else
            {
                ShareData.showWarningMSG("วันที่ต้องเป็นวันที่ 1 หรือ 16 เท่านั้น");
            }
        }

        private void btLotto2Bottom_Click(object sender, EventArgs e)
        {
            if (IsAllowedDrawDate())
            {
                lbLotto2Bottom.Text = GenerateRandomNumber(2);
                btLotto2Bottom.Enabled = false;
            }
            else
            {
                ShareData.showWarningMSG("วันที่ต้องเป็นวันที่ 1 หรือ 16 เท่านั้น");
            }
        }

        private void btLotto3Top_Click(object sender, EventArgs e)
        {
            if (IsAllowedDrawDate())
            {
                lbLotto3Top01.Text = GenerateRandomNumber(3);
                lbLotto3Top02.Text = GenerateRandomNumber(3);
                btLotto3Top.Enabled = false;
            }
            else
            {
                ShareData.showWarningMSG("วันที่ต้องเป็นวันที่ 1 หรือ 16 เท่านั้น");
            }
        }

        private void btLotto3Bottom_Click(object sender, EventArgs e)
        {
            if (IsAllowedDrawDate())
            {
                lbLotto3Bottom01.Text = GenerateRandomNumber(3);
                lbLotto3Bottom02.Text = GenerateRandomNumber(3);
                btLotto3Bottom.Enabled = false;
            }
            else
            {
                ShareData.showWarningMSG("วันที่ต้องเป็นวันที่ 1 หรือ 16 เท่านั้น");
            }
        }
    }
}

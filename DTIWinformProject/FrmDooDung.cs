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
    public partial class FrmDooDung : Form
    {
        public FrmDooDung()
        {
            InitializeComponent();
        }

        private void FrmDooDung_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " ( " + ShareData.loginType + " ) ";
            timer1.Start();
            btNew.PerformClick();
            nudHeight.Maximum = 200;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btNew_Click(object sender, EventArgs e)
        {
            mtbIDcard.Clear();
            tbFullname.Clear();
            dtpBirthDate.Value = DateTime.Now;
            nudWeight.Value = 0;
            nudHeight.Value = 0;

            lbFullname.Text = "xxxxxxxxxx"; 
            lbIDcard.Text = "xxxxxxxxxx";
            lbBirthDate.Text = "xxxxxxxxxx";
            lbAge.Text = "xxxxxxxxxx";
            lbWeight.Text = "xxxxxxxxxx";
            lbHeight.Text = "xxxxxxxxxx";
            lbBMI.Text = "xxxxxxxxxx";

            lbShowResult.Text = "ผลดวง";


        }

        private void btExit_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();

            Hide();
        }


        private string GetBMICategory(double bmi)
        {
            if (bmi < 18.5) return "น้ำหนักน้อย";
            if (bmi < 24.9) return "ปกติ";
            if (bmi < 29.9) return "ท้วม";
            return "อ้วน";
        }

        private string GenerateFortuneByMonth(int month)
        {
            switch (month)
            {
                case 1: return "มกราคม: ปีนี้คุณจะพบกับโอกาสดีๆ ในการงาน!";
                case 2: return "กุมภาพันธ์: ระวังเรื่องการเงิน ใช้จ่ายอย่างรอบคอบ!";
                case 3: return "มีนาคม: ความรักกำลังเข้ามาหาคุณ เตรียมตัวให้พร้อม!";
                case 4: return "เมษายน: มีโชคลาภเข้ามา แต่ต้องใช้สติปัญญา!";
                case 5: return "พฤษภาคม: สุขภาพต้องดูแลให้ดี ระวังเรื่องอาหาร!";
                case 6: return "มิถุนายน: มีโอกาสในการเดินทางไกล!";
                case 7: return "กรกฎาคม: คนใกล้ตัวจะนำข่าวดีมาให้!";
                case 8: return "สิงหาคม: ช่วงนี้เหมาะกับการเริ่มต้นสิ่งใหม่ๆ!";
                case 9: return "กันยายน: โอกาสในธุรกิจกำลังมา อย่าพลาด!";
                case 10: return "ตุลาคม: ชีวิตกำลังจะเปลี่ยนไปในทางที่ดีขึ้น!";
                case 11: return "พฤศจิกายน: ระวังปัญหาเกี่ยวกับสุขภาพ พักผ่อนให้พอ!";
                case 12: return "ธันวาคม: คุณจะได้รับของขวัญที่ไม่คาดคิด!";
                default: return "เกิดข้อผิดพลาด กรุณาลองใหม่!";
            }
        }

        private void btDooDung_Click(object sender, EventArgs e)
        {
            //Validate
            if (mtbIDcard.MaskCompleted == false)
            {
                ShareData.showWarningMSG("กรุณากรอกบัตรประชาชนด้วย");
            }
            else if (tbFullname.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกชื่อ-สกุลด้วย");
            }
            else if (dtpBirthDate.Value.Year >= DateTime.Now.Year)
            {
                ShareData.showWarningMSG("ปีเกิดต้องน้อยกว่าปีปัจจุบัน");
            }
            else if (nudWeight.Value == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกน้ำหนักด้วย");
            }
            else if (nudHeight.Value == 0)
            {
                ShareData.showWarningMSG("กรุณากรอกส่วนสูงด้วย");
            }
            else
            {
                lbIDcard.Text = mtbIDcard.Text;
                lbFullname.Text = tbFullname.Text.Trim();

                CultureInfo cultureInfo = new CultureInfo("th-TH");
                lbBirthDate.Text = dtpBirthDate.Value.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy",cultureInfo);

                int age = DateTime.Now.Year - dtpBirthDate.Value.Year;
                lbAge.Text = age.ToString();

                lbWeight.Text = nudWeight.Value.ToString("0.00");
                lbHeight.Text = nudHeight.Value.ToString("0.00");



                double weight = (double)nudWeight.Value;
                double heightInMeters = (double)nudHeight.Value / 100;

                double bmi = 0;
                if (heightInMeters > 0)
                {
                    bmi = weight / (heightInMeters * heightInMeters);
                }

                lbBMI.Text = bmi.ToString("0.00");


                //ผลดวงดูจากเดือนเกิด
                int month = dtpBirthDate.Value.Month;
                lbShowResult.Text = GenerateFortuneByMonth(month);

            }
        }

        private void tbFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

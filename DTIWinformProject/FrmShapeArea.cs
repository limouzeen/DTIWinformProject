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
    public partial class FrmShapeArea : Form
    {
        public FrmShapeArea()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FrmShapeArea_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " ( " + ShareData.loginType + " ) ";
            timer1.Start();
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

        private void btCircleCal_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbRadius.Text, out double radius) && radius > 0)
            {
                if (rdCircleArea.Checked)
                {
                    double area = Math.PI * Math.Pow(radius, 2);
                    lbCircleShow.Text = area.ToString("0.00");
                }
                else if (rdCircleRound.Checked)
                {
                    double circumference = 2 * Math.PI * radius;
                    lbCircleShow.Text = circumference.ToString("0.00");
                }
                else
                {
                    ShareData.showWarningMSG("กรุณาเลือกการคำนวณ!");
            
                }
            }
            else
            {
                ShareData.showWarningMSG("กรุณากรอกค่ารัศมีให้ถูกต้อง!");
               
            }
        }

        private void tbRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.textBox_KeyPress(sender, e);
        }

        private void tbWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.textBox_KeyPress(sender, e);
        }

        private void tbLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.textBox_KeyPress(sender, e);
        }

        private void tbBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.textBox_KeyPress(sender, e);
        }

        private void tbHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.textBox_KeyPress(sender, e);
        }

        private void tbSideAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.textBox_KeyPress(sender, e);
        }

        private void tbRadius_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void btCircleCancel_Click(object sender, EventArgs e)
        {
            tbRadius.Clear();        
            lbCircleShow.Text = "0.00"; 
            rdCircleArea.Checked = true;  
            rdCircleRound.Checked = false;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            tbWidth.Clear();
            tbLength.Clear();
            lbRectShow.Text = "0.00";
            rdRectArea.Checked = true;
            rdRectRound.Checked = false;

        }

        private void btTriCancel_Click(object sender, EventArgs e)
        {
            tbBase.Clear();
            tbHeight.Clear();
            tbSideAngle.Clear();
            lbTriShow.Text = "0.00";
            rdTriArea.Checked = true;
            rdTriRound.Checked = false;
        }

        private void btRectCal_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbWidth.Text, out double width) && width > 0 &&
        double.TryParse(tbLength.Text, out double height) && height > 0)
            {
                if (rdRectArea.Checked)
                {
                    double area = width * height;
                    lbRectShow.Text = area.ToString("0.00");
                }
                else if (rdRectRound.Checked)
                {
                    double perimeter = 2 * (width + height);
                    lbRectShow.Text = perimeter.ToString("0.00");
                }
                else
                {
                    ShareData.showWarningMSG("กรุณาเลือกการคำนวณ (พื้นที่หรือเส้นรอบสี่เหลี่ยม)!");
                }
            }
            else
            {
                ShareData.showWarningMSG("กรุณากรอกค่าความกว้างและความยาวให้ถูกต้อง!");
            }
        }

        private void btTriCal_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbBase.Text, out double baseLength) && baseLength > 0 &&
       double.TryParse(tbHeight.Text, out double height) && height > 0)
            {
                if (rdTriArea.Checked)
                {
                    double area = 0.5 * baseLength * height;
                    lbTriShow.Text = area.ToString("0.00");
                }
                else if (rdTriRound.Checked)
                {
                    if (double.TryParse(tbSideAngle.Text, out double side) && side > 0)
                    {
                        double perimeter = baseLength + height + side;
                        lbTriShow.Text = perimeter.ToString("0.00");
                    }
                    else
                    {
                        ShareData.showWarningMSG("กรุณากรอกค่าความยาวด้านที่สามให้ถูกต้อง!");
                    }
                }
                else
                {
                    ShareData.showWarningMSG("กรุณาเลือกการคำนวณ (พื้นที่หรือเส้นรอบสามเหลี่ยม)!");
                }
            }
            else
            {
                ShareData.showWarningMSG("กรุณากรอกค่าฐานและความสูงให้ถูกต้อง!");
            }
        }
    }
}

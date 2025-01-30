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
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {


            tslbUsername.Text = ShareData.loginName + " ( " + ShareData.loginType + " ) ";
            timer1.Start();
            cbbDecimal.SelectedIndex = 0;
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

        private void cbbDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void lbShowResult_Click(object sender, EventArgs e)
        {

        }

        private void tbNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.textBox_KeyPress(sender, e);
        }

        private void tbNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.textBox_KeyPress(sender, e);
        }


        //private void validate_textbox (object sender, EventArgs e)
        //{
        //    if(tbNum1.Text.Length == 0 || tbNum2.Text.Length == 0)
        //    {
        //        ShareData.showWarningMSG("ป้อนข้อมูลให้ครบในการคำนวณ");
        //    }
        //    else
        //    {

        //        double num1 = double.Parse(tbNum1.Text);
        //        double num2 = double.Parse(tbNum2.Text);
        //        double result = num1 + num2;
        //        if (cbbDecimal.SelectedIndex == 0)
        //        {
        //            lbShowResult.Text = result.ToString("0.00");
        //        }
        //        else if (cbbDecimal.SelectedIndex == 1)
        //        {
        //            lbShowResult.Text = result.ToString("0.00000");
        //        }
        //        else
        //        {
        //            lbShowResult.Text = result.ToString("0.0000000000");
        //        }

        //    }
        //}

        private void validate_and_calculate(string operation)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(tbNum1.Text) || string.IsNullOrWhiteSpace(tbNum2.Text))
            {
                ShareData.showWarningMSG("ป้อนข้อมูลให้ครบในการคำนวณ");
                return;
            }

            try
            {
                // Parse input values
                double num1 = double.Parse(tbNum1.Text);
                double num2 = double.Parse(tbNum2.Text);

                double result = 0;

                // Perform calculation based on the operation
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            ShareData.showWarningMSG("หารด้วยศูนย์ไม่ได้!");
                            return;
                        }
                        result = num1 / num2;
                        break;
                    case "^":
                        result = Math.Pow(num1, num2); // Perform power calculation
                        break;
                    default:
                        ShareData.showWarningMSG("ไม่รองรับการดำเนินการนี้");
                        return;
                }

                // Format result based on the selected decimal places
                if (cbbDecimal.SelectedIndex == 0)
                {
                    lbShowResult.Text = result.ToString("0.00");
                }
                else if (cbbDecimal.SelectedIndex == 1)
                {
                    lbShowResult.Text = result.ToString("0.00000");
                }
                else
                {
                    lbShowResult.Text = result.ToString("0.0000000000");
                }
            }
            catch (FormatException)
            {
                ShareData.showWarningMSG("กรุณากรอกเฉพาะตัวเลขเท่านั้น");
            }
            catch (Exception ex)
            {
                ShareData.showWarningMSG($"เกิดข้อผิดพลาด: {ex.Message}");
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            validate_and_calculate("+");
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            validate_and_calculate("-");
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            validate_and_calculate("*");
        }

        private void btDevide_Click(object sender, EventArgs e)
        {
            validate_and_calculate("/");
        }

        private void btPower_Click(object sender, EventArgs e)
        {
            validate_and_calculate("^");
        }
    }
}

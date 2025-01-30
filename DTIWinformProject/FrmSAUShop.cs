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
    public partial class FrmSAUShop : Form
    {
        public FrmSAUShop()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmSAUShop_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " ( " + ShareData.loginType + " ) ";
            timer1.Start();
            btCancel.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void tslbUsername_Click(object sender, EventArgs e)
        {

        }

        private void tslbDateTime_Click(object sender, EventArgs e)
        {

        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();

            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            cbPen.Checked = false;
            cbPencil.Checked = false;
            cbRubber.Checked = false;
            cbRuler.Checked = false;
            cbBook.Checked = false;

            tbPen.Clear();
            tbPencil.Clear();
            tbRubber.Clear();
            tbRuler.Clear();
            tbBook.Clear();

            tbPen.Enabled = false;
            tbPencil.Enabled = false;
            tbRubber.Enabled = false;
            tbBook.Enabled = false;
            tbRuler.Enabled = false;

            lbPen.Text = "0.00";
            lbPencil.Text = "0.00";
            lbRubber.Text = "0.00";
            lbRuler.Text = "0.00";
            lbBook.Text = "0.00";

            cbbSale.SelectedIndex = 0;
            lbShowTotalPay.Text = "0.00";
        }


        private void ToggleTextBox(CheckBox checkBox, TextBox textBox, Label label)
        {
            if (checkBox.Checked)
            {
                textBox.Enabled = true;
            }
            else
            {
                textBox.Clear();
                textBox.Enabled = false;
                label.Text = "0.00";
            }
        }

        private void cbPen_Click(object sender, EventArgs e)
        {
            if (cbPen.Checked == true)
            {
                tbPen.Enabled = true;
            }
            else
            {
                tbPen.Clear();
                tbPen.Enabled = false;
                lbPen.Text = "0.00";
            }
        }

        private void cbPencil_Click(object sender, EventArgs e)
        {
            ToggleTextBox(cbPencil, tbPencil, lbPencil);
        }

        private void cbRubber_Click(object sender, EventArgs e)
        {
            ToggleTextBox(cbRubber, tbRubber, lbRubber);

        }

        private void cbRuler_Click(object sender, EventArgs e)
        {
            ToggleTextBox(cbRuler, tbRuler, lbRuler);
        }

        private void cbBook_Click(object sender, EventArgs e)
        {
            ToggleTextBox(cbBook, tbBook, lbBook);
        }



        private void tbPen_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.textBox_KeyPressNum(sender, e);
        }

        private void tbPencil_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.textBox_KeyPressNum(sender, e);
        }

        private void tbRubber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.textBox_KeyPressNum(sender, e);
        }

        private void tbRuler_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.textBox_KeyPressNum(sender, e);
        }

        private void tbBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.textBox_KeyPressNum(sender, e);
        }
        private static void UpdatePriceOnKeyUp(TextBox textBox, Label label, double unitPrice)
        {
            if (textBox.Text.Length > 0)
            {
                if (int.TryParse(textBox.Text, out int quantity))
                {
                    double price = unitPrice * quantity;
                    label.Text = price.ToString("0.00"); // Format with two decimal places
                }
                else
                {
                    label.Text = "0.00"; // Reset if input is invalid
                }
            }
            else
            {
                label.Text = "0.00";
            }
        }

        private void tbPen_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPen.Text.Length > 0) {
                int quantity = int.Parse(tbPen.Text);
                double price = 5 * quantity;
                lbPen.Text = price.ToString();
            }
            else
            {
                lbPen.Text = "0.00";
            }
  
        }

        private void tbPencil_KeyUp(object sender, KeyEventArgs e)
        {
            UpdatePriceOnKeyUp(tbPencil, lbPencil, 1.5);
        }

        private void tbRubber_KeyUp(object sender, KeyEventArgs e)
        {
            UpdatePriceOnKeyUp(tbRubber, lbRubber, 2.5);
        }

        private void tbRuler_KeyUp(object sender, KeyEventArgs e)
        {
            UpdatePriceOnKeyUp(tbRuler, lbRuler, 2);
        }

        private void tbBook_KeyUp(object sender, KeyEventArgs e)
        {
            UpdatePriceOnKeyUp(tbBook, lbBook, 10.25);
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            double totalPay =
                Double.Parse(lbPen.Text) +
                Double.Parse(lbPencil.Text) +
                Double.Parse(lbRubber.Text) +
                Double.Parse(lbRuler.Text) +
                Double.Parse(lbBook.Text);

            // ตรวจสอบเพื่อคำนวณหาราคาสุทธิ แล้วแสดงผล
            if(cbbSale.SelectedIndex == 0)
            {
                totalPay = totalPay - (totalPay * 5 / 100);
            }else if(cbbSale.SelectedIndex == 1)
            {
                totalPay = totalPay - (totalPay *10 /100);
            }else if(cbbSale.SelectedIndex == 2)
            {
                totalPay = totalPay - ( totalPay *15 /100);
            }
            lbShowTotalPay.Text = totalPay.ToString("#,###,###,##0.00");
        }
    }
}

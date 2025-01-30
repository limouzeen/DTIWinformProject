using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinformProject
{
    internal class ShareData
    {

        public static String loginName;
        public static String loginType;


        public static void showWarningMSG(String msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        public static void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // อนุญาตให้กดปุ่มควบคุม เช่น Backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // อนุญาตให้กดตัวเลข (0-9)
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // อนุญาตให้กด '.' แต่ต้องไม่มีจุดซ้ำ
            if (e.KeyChar == '.' && !((sender as TextBox).Text.Contains(".")))
            {
                return;
            }

            // หากไม่ตรงตามเงื่อนไขด้านบน ยกเลิกการพิมพ์
            e.Handled = true;
        }



    }
}

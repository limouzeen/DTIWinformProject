using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; //set time to Thai
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " ( " + ShareData.loginType + " ) ";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.",cultureInfo);
        }

        private void btWelcome_Click(object sender, EventArgs e)
        {
            //FrmMainMenu frmMainMenu = new FrmMainMenu();
            //frmMainMenu.Show();

            //Hide();

            FrmWelcome frmWelcome = new FrmWelcome();
            frmWelcome.Show();

            Hide();
        }

        private void btCalculator_Click(object sender, EventArgs e)
        {
            FrmCalculator frmCalculator = new FrmCalculator();
            frmCalculator.Show();

            Hide();
         }

        private void btSAUShop_Click(object sender, EventArgs e)
        {
            FrmSAUShop frmSAUShop = new FrmSAUShop();
            frmSAUShop.Show();

            Hide();
        }

        private void btLotto_Click(object sender, EventArgs e)
        {
            FrmLotto frmLotto = new FrmLotto();
            frmLotto.Show();


            Hide();
        }

        private void btDooDung_Click(object sender, EventArgs e)
        {
            FrmDooDung frmDooDung = new FrmDooDung();
            frmDooDung.Show();

            Hide();
        }

        private void btShapeArea_Click(object sender, EventArgs e)
        {
            FrmShapeArea frmShapeArea = new FrmShapeArea();
            frmShapeArea.Show();

            Hide();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            FrmSAURegister frmSAURegister = new FrmSAURegister();
            frmSAURegister.Show();

            Hide();
        }

        private void btExitToLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();

            Hide();
        }
    }
}

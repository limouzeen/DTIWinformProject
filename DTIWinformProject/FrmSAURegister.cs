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
    public partial class FrmSAURegister : Form
    {
        public FrmSAURegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmSAURegister_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " ( " + ShareData.loginType + " ) ";
            timer1.Start();

            tbNoRegis.KeyPress += ShareData.textBox_KeyPressNum;
            tbNameRegis.KeyPress += ShareData.ValidateName;
            

            foreach (var item in lsSubjectRegis.Items)
            {
                originalSubjects.Add(item.ToString());
            }

            btCancel.PerformClick();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();

            Hide();
        }
        private List<string> originalSubjects = new List<string>();
        private void btCancel_Click(object sender, EventArgs e)
        {
            tbNameRegis.Clear();
            tbNoRegis.Clear();
            rdNormalRegis.Checked = true;
            mcdRegis.SetDate(DateTime.Now);
            cbConfirmRegis.Checked = false;
            cbbLevelRegis.SelectedIndex = 0;
            lsbSubjectedRegis.ClearSelected();
            lsbSubjectedRegis.Items.Clear();
            pbImageRegis.Image = null;

            lsSubjectRegis.Items.Clear(); // Clear current subjects
            foreach (string subject in originalSubjects)
            {
                lsSubjectRegis.Items.Add(subject); // Restore original subjects
            }


        }

        private void btSelectImageRegis_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "เลือกไฟล์รูปภาพ"; // Set dialog title
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Allow only image file types
            openFileDialog1.Multiselect = false; // Allow only one file selection
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); // Open in Pictures folder

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the image without locking the file
                    using (Image tempImage = Image.FromFile(openFileDialog1.FileName))
                    {
                        pbImageRegis.Image = new Bitmap(tempImage); // Avoids file lock issue
                    }

                    pbImageRegis.SizeMode = PictureBoxSizeMode.StretchImage; // Resize to fit
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการโหลดรูปภาพ: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btSelectSub_Click(object sender, EventArgs e)
        {
            if (lsSubjectRegis.SelectedIndex < 0) // ตรวจสอบว่าได้เลือกวิชาหรือยัง
            {
                ShareData.showWarningMSG("เลือกวิชาที่จะลงทะเบียนด้วย");
            }
            else
            {
                // Get the selected subject
                string selectedSubject = lsSubjectRegis.SelectedItem.ToString();

                // Check if the subject is already added to lsbSubjectedRegis to avoid duplicates
                if (!lsbSubjectedRegis.Items.Contains(selectedSubject))
                {
                    lsbSubjectedRegis.Items.Add(selectedSubject); // Add to lsbSubjectedRegis

                    // Remove the subject from lsSubjectRegis
                    lsSubjectRegis.Items.RemoveAt(lsSubjectRegis.SelectedIndex);
                }
                else
                {
                    ShareData.showWarningMSG("วิชานี้ถูกเลือกไปแล้ว");
                }
            }
        }

        private void btUnSelectSub_Click(object sender, EventArgs e)
        {
            if (lsbSubjectedRegis.SelectedIndex < 0) // ตรวจสอบว่ามีการเลือกวิชาหรือไม่
            {
                ShareData.showWarningMSG("เลือกวิชาที่จะนำออกจากการลงทะเบียนด้วย");
            }
            else
            {
                // Get the selected subject from lsbSubjectedRegis
                string selectedSubject = lsbSubjectedRegis.SelectedItem.ToString();

                // Check if the subject already exists in lsSubjectRegis to avoid duplicates
                if (!lsSubjectRegis.Items.Contains(selectedSubject))
                {
                    lsSubjectRegis.Items.Add(selectedSubject); // Add it back to lsSubjectRegis
                }

                // Remove the subject from lsbSubjectedRegis
                lsbSubjectedRegis.Items.RemoveAt(lsbSubjectedRegis.SelectedIndex);
            }

        }

        private void btSelectAllSub_Click(object sender, EventArgs e)
        {
            if (lsSubjectRegis.Items.Count == 0) // ตรวจสอบว่ามีวิชาให้เลือกหรือไม่
            {
                ShareData.showWarningMSG("ไม่มีวิชาให้เลือก");
                return;
            }

            // Move all subjects from lsSubjectRegis to lsbSubjectedRegis
            for (int i = 0; i < lsSubjectRegis.Items.Count; i++)
            {
                string subject = lsSubjectRegis.Items[i].ToString();

                // Check if subject already exists in lsbSubjectedRegis
                if (!lsbSubjectedRegis.Items.Contains(subject))
                {
                    lsbSubjectedRegis.Items.Add(subject); // Add to lsbSubjectedRegis
                }
            }

            // Clear all subjects from lsSubjectRegis after moving
            lsSubjectRegis.Items.Clear();
        }

        private void btUnSelectAllSub_Click(object sender, EventArgs e)
        {
            if (lsbSubjectedRegis.Items.Count == 0) // ตรวจสอบว่ามีวิชาที่ลงทะเบียนหรือไม่
            {
                ShareData.showWarningMSG("ไม่มีวิชาที่ถูกเลือกไว้");
                return;
            }

            // Move all subjects from lsbSubjectedRegis back to lsSubjectRegis
            for (int i = 0; i < lsbSubjectedRegis.Items.Count; i++)
            {
                string subject = lsbSubjectedRegis.Items[i].ToString();

                // Check if subject already exists in lsSubjectRegis to avoid duplicates
                if (!lsSubjectRegis.Items.Contains(subject))
                {
                    lsSubjectRegis.Items.Add(subject); // Add back to lsSubjectRegis
                }
            }

            // Clear all subjects from lsbSubjectedRegis after moving
            lsbSubjectedRegis.Items.Clear();
        }

        private bool ValidateRegistration()
        {
            if (string.IsNullOrWhiteSpace(tbNoRegis.Text))
            {
                ShareData.showWarningMSG("กรุณากรอกเลขประจำตัวนักเรียน");
                tbNoRegis.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbNameRegis.Text))
            {
                ShareData.showWarningMSG("กรุณากรอกชื่อ-สกุล");
                tbNameRegis.Focus();
                return false;
            }

            if (!rdNormalRegis.Checked && !rdFundRegis.Checked)
            {
                ShareData.showWarningMSG("กรุณาเลือกประเภทนักเรียน");
                return false;
            }

            if (cbbLevelRegis.SelectedIndex == -1)
            {
                ShareData.showWarningMSG("กรุณาเลือกระดับชั้น");
                return false;
            }

            if (lsbSubjectedRegis.Items.Count == 0)
            {
                ShareData.showWarningMSG("กรุณาเลือกรายวิชาที่ต้องการลงทะเบียน");
                return false;
            }
            // ✅ Ensure that students can select up to 7 subjects
            if (lsbSubjectedRegis.Items.Count > 7)
            {
                ShareData.showWarningMSG("ไม่สามารถลงทะเบียนเกิน 7 วิชาได้");
                return false;
            }

            
            // ✅ Check if the user uploaded an image
            if (pbImageRegis.Image == null)
            {
                ShareData.showWarningMSG("กรุณาอัปโหลดรูปภาพก่อนลงทะเบียน");
                return false;
            }
            if (!cbConfirmRegis.Checked)
            {
                ShareData.showWarningMSG("กรุณายืนยันการลงทะเบียน");
                return false;
            }

            return true; // If all checks pass
        }


        private void btRegis_Click(object sender, EventArgs e)
        {

            if (!ValidateRegistration()) return;

            // Create result form instance
            FrmSAURegisterResult frmResult = new FrmSAURegisterResult();

            // Gather registration data
            string studentId = tbNoRegis.Text;
            string studentName = tbNameRegis.Text;
            string date = ShareData.ConvertToThaiDate(mcdRegis.SelectionStart);
            string type = rdNormalRegis.Checked ? "ปกติ" : "กองทุน";
            string level = cbbLevelRegis.SelectedItem?.ToString() ?? "ไม่ระบุ";

            // Gather selected subjects
            StringBuilder subjects = new StringBuilder();
            foreach (var item in lsbSubjectedRegis.Items)
            {
                subjects.AppendLine(item.ToString());
            }

            // Pass data to FrmSAURegisterResult
            frmResult.SetRegisterData(studentId, studentName, date, type, level, subjects.ToString().Trim(), pbImageRegis.Image);

            // Show result form
            frmResult.ShowDialog();

        }
    }
}

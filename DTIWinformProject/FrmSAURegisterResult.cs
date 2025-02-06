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
    public partial class FrmSAURegisterResult : Form
    {
        public FrmSAURegisterResult()
        {
            InitializeComponent();
        }

        private void FrmSAURegisterResult_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetRegisterData(string studentId, string studentName, string date, string type, string level, string subjects, Image studentImage)
        {
            lbNoShow.Text = studentId;
            lbNameShow.Text = studentName;
            lbDateShow.Text = date;
            lbTypeShow.Text = type;
            lbLevelShow.Text = level;
            lbSubjectShow.Text = subjects;

            // Set image if provided
            if (studentImage != null)
            {
                pbImageRgisShow.BackgroundImage = new Bitmap(studentImage);
                pbImageRgisShow.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

    }
}

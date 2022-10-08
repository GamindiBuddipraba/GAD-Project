using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoopFoodCity
{
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AttendanceDataSet.Attendance' table. You can move, or remove it, as needed.
            txt_empid.Focus();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                this.AttendanceTableAdapter.Fill(this.AttendanceDataSet.Attendance, Convert.ToInt32(txt_empid.Text), Convert.ToString(dtpfromdate.Value), Convert.ToString(dtptodate.Value));

                this.reportViewer1.RefreshReport();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Reports rep = new Reports();
                rep.Show();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

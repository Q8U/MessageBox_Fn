using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            BehComponents.MessageBoxFarsi.Show("اطلاعات با موفقیت ثبت شد", "پیام", BehComponents.MessageBoxFarsiButtons.OK, BehComponents.MessageBoxFarsiIcon.Preference);

        }

        private void btn_error_Click(object sender, EventArgs e)
        {
            BehComponents.MessageBoxFarsi.Show("خطا در ثبت اطلاعات", "پیام", BehComponents.MessageBoxFarsiButtons.OK, BehComponents.MessageBoxFarsiIcon.Error);

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            BehComponents.MessageBoxFarsi.Show("اطلاعات با موفقیت ویرایش شد", "پیام", BehComponents.MessageBoxFarsiButtons.OK, BehComponents.MessageBoxFarsiIcon.Information);

        }

        private void btn_q_Click(object sender, EventArgs e)
        {
            if (BehComponents.MessageBoxFarsi.Show("آیا مایل به حذف اطلاعات هستید؟", "پیام", BehComponents.MessageBoxFarsiButtons.YesNo, BehComponents.MessageBoxFarsiIcon.Question)==DialogResult.Yes)
                BehComponents.MessageBoxFarsi.Show("رکورد با موفقیت حذف شد", "پیام", BehComponents.MessageBoxFarsiButtons.OK, BehComponents.MessageBoxFarsiIcon.Delete);

            

        }

        private void btn_warning_Click(object sender, EventArgs e)
        {
            BehComponents.MessageBoxFarsi.Show("حذف رکورد باعث اختلال در برنامه خواهد شد", "پیام", BehComponents.MessageBoxFarsiButtons.OK, BehComponents.MessageBoxFarsiIcon.Warning);

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            BehComponents.MessageBoxFarsi.Show("پردازش اطلاعات متوقف شد", "پیام", BehComponents.MessageBoxFarsiButtons.OK, BehComponents.MessageBoxFarsiIcon.Stop);

        }


    }
}

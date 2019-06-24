using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject.Views.UserControls
{
    public partial class Receipt : UserControl
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void detailslabel_Click(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void monthcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthcomboBox1.Items.AddRange(new object[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" });
        }

        private void confirmButton1_Click(object sender, EventArgs e)
        {
            receiptpanel1.Visible = false;
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            receiptpanel1.Visible = false;
        }

        private void IDlabel_Click(object sender, EventArgs e)
        {

        }

        private void recievelabel_Click(object sender, EventArgs e)
        {

        }

        private void recieveTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            receiptpanel1.Visible = false;

        }

        private void confirmButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
           // receiptpanel1.Visible = false;
        }

        private void CancelButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}

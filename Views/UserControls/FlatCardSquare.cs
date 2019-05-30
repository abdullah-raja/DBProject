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
    public partial class FlatCardSquare : UserControl
    {
        public FlatCardSquare()
        {
            InitializeComponent();
        }

        public void setText(string str)
        {
            
            button1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
